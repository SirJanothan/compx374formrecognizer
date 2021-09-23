using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Azure;
using Azure.AI.FormRecognizer;
using Azure.AI.FormRecognizer.Models;
using Azure.AI.FormRecognizer.Training;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;


namespace compx374winform
{
    public partial class Form1 : Form
    {
        private static readonly string endpoint = "https://jonathan-eddy-form-recognizer.cognitiveservices.azure.com/";
        private static readonly string apiKey = "0a4823585ca04c5d991705bc318679b4";
        private static readonly AzureKeyCredential credential = new AzureKeyCredential(apiKey);

        private static string trainingDataUrl = "https://jonathaneddy374.blob.core.windows.net/universityapplication1?sp=rwdl&st=2021-09-13T05:29:51Z&se=2021-11-29T12:29:51Z&spr=https&sv=2020-08-04&sr=c&sig=i5h2ct8CjvQB%2FBe%2BvgA0zTGC5VnuH5ZpaarlJSSteHo%3D";
        private static string formUrl = "https://jonathaneddy374.blob.core.windows.net/universityapplication1/IMG_0914.png?sp=rwd&st=2021-09-13T05:34:26Z&se=2021-11-29T12:34:26Z&spr=https&sv=2020-08-04&sr=b&sig=tkk4kC%2BUks%2Fx1haZX2v3GAXj%2FafTbZ%2BgrAzLjQRDl3g%3D";
        private static string modelId = "f8a363a6-dbfa-4d5e-ad34-9edd04105d75";
        private static string storageAccString = "DefaultEndpointsProtocol=https;AccountName=jonathaneddy374;AccountKey=MtRw600avh4qhcrQqxWL2FSXshnZ2pp4ovcQVkQEvugyxIUhVzJFnNCKf2j7pzk+tWdO9hUmngLw0hllFv4BmQ==;EndpointSuffix=core.windows.net";

        private FormRecognizerClient recognizerClient;
        private FormTrainingClient trainingClient;

        public Form1()
        {
            InitializeComponent();

            recognizerClient = AuthenticateClient();
            trainingClient = AuthenticateTrainingClient();

            Task.WaitAll(LoadContainers());
        }

        private static FormRecognizerClient AuthenticateClient()
        {
            var credential = new AzureKeyCredential(apiKey);
            var client = new FormRecognizerClient(new Uri(endpoint), credential);
            return client;
        }

        static private FormTrainingClient AuthenticateTrainingClient()
        {
            var credential = new AzureKeyCredential(apiKey);
            var client = new FormTrainingClient(new Uri(endpoint), credential);
            return client;
        }

        private static async Task RecognizeContent(FormRecognizerClient recognizerClient)
        {
            var invoiceUri = formUrl;
            FormPageCollection formPages = await recognizerClient
                .StartRecognizeContentFromUri(new Uri(invoiceUri))
                .WaitForCompletionAsync();
            foreach (FormPage page in formPages)
            {
                Console.WriteLine($"Form Page {page.PageNumber} has {page.Lines.Count} lines.");

                for (int i = 0; i < page.Lines.Count; i++)
                {
                    FormLine line = page.Lines[i];
                    Console.WriteLine($"    Line {i} has {line.Words.Count} word{(line.Words.Count > 1 ? "s" : "")}, and text: '{line.Text}'.");
                }

                for (int i = 0; i < page.Tables.Count; i++)
                {
                    FormTable table = page.Tables[i];
                    Console.WriteLine($"Table {i} has {table.RowCount} rows and {table.ColumnCount} columns.");
                    foreach (FormTableCell cell in table.Cells)
                    {
                        Console.WriteLine($"    Cell ({cell.RowIndex}, {cell.ColumnIndex}) contains text: '{cell.Text}'.");
                    }
                }
            }
        }


        private static async Task<String> TrainModel(FormTrainingClient trainingClient, string trainingDataUrl)
        {
            CustomFormModel model = await trainingClient
            .StartTrainingAsync(new Uri(trainingDataUrl), useTrainingLabels: false)
            .WaitForCompletionAsync();

            Console.WriteLine($"Custom Model Info:");
            Console.WriteLine($"    Model Id: {model.ModelId}");
            Console.WriteLine($"    Model Status: {model.Status}");
            Console.WriteLine($"    Training model started on: {model.TrainingStartedOn}");
            Console.WriteLine($"    Training model completed on: {model.TrainingCompletedOn}");
            foreach (CustomFormSubmodel submodel in model.Submodels)
            {
                Console.WriteLine($"Submodel Form Type: {submodel.FormType}");
                foreach (CustomFormModelField field in submodel.Fields.Values)
                {
                    Console.Write($"    FieldName: {field.Name}");
                    if (field.Label != null)
                    {
                        Console.Write($", FieldLabel: {field.Label}");
                    }
                    Console.WriteLine("");
                }
            }
            return model.ModelId;
        }

        private static async Task<String> TrainModelWithLabels(FormTrainingClient trainingClient, string trainingDataUrl)
        {
            CustomFormModel model = await trainingClient
            .StartTrainingAsync(new Uri(trainingDataUrl), useTrainingLabels: true)
            .WaitForCompletionAsync();
            Console.WriteLine($"Custom Model Info:");
            Console.WriteLine($"    Model Id: {model.ModelId}");
            Console.WriteLine($"    Model Status: {model.Status}");
            Console.WriteLine($"    Training model started on: {model.TrainingStartedOn}");
            Console.WriteLine($"    Training model completed on: {model.TrainingCompletedOn}");
            foreach (CustomFormSubmodel submodel in model.Submodels)
            {
                Console.WriteLine($"Submodel Form Type: {submodel.FormType}");
                foreach (CustomFormModelField field in submodel.Fields.Values)
                {
                    Console.Write($"    FieldName: {field.Name}");
                    if (field.Label != null)
                    {
                        Console.Write($", FieldLabel: {field.Label}");
                    }
                    Console.WriteLine("");
                }
            }
            return model.ModelId;
        }

        // Analyze PDF form data
        private static async Task AnalyzePdfForm(FormRecognizerClient recognizerClient, String modelId, string formUrl)
        {
            RecognizedFormCollection forms = await recognizerClient
            .StartRecognizeCustomFormsFromUri(modelId, new Uri(formUrl))
            .WaitForCompletionAsync();
            foreach (RecognizedForm form in forms)
            {
                Console.WriteLine($"Form of type: {form.FormType}");
                foreach (FormField field in form.Fields.Values)
                {
                    Console.WriteLine($"Field '{field.Name}: ");

                    if (field.LabelData != null)
                    {
                        Console.WriteLine($"    Label: '{field.LabelData.Text}");
                    }

                    Console.WriteLine($"    Value: '{field.ValueData.Text}");
                    Console.WriteLine($"    Confidence: '{field.Confidence}");
                }
                Console.WriteLine("Table data:");
                foreach (FormPage page in form.Pages)
                {
                    for (int i = 0; i < page.Tables.Count; i++)
                    {
                        FormTable table = page.Tables[i];
                        Console.WriteLine($"Table {i} has {table.RowCount} rows and {table.ColumnCount} columns.");
                        foreach (FormTableCell cell in table.Cells)
                        {
                            Console.WriteLine($"    Cell ({cell.RowIndex}, {cell.ColumnIndex}) contains {(cell.IsHeader ? "header" : "text")}: '{cell.Text}'");
                        }
                    }
                }
            }
        }
        private static async Task AnalyzePdfForm(FormRecognizerClient recognizerClient, String modelId, FileStream filestream)
        {
            RecognizedFormCollection forms = await recognizerClient
            .StartRecognizeCustomForms(modelId, filestream)
            .WaitForCompletionAsync();
            foreach (RecognizedForm form in forms)
            {
                Console.WriteLine($"Form of type: {form.FormType}");
                foreach (FormField field in form.Fields.Values)
                {
                    Console.WriteLine($"Field '{field.Name}: ");

                    if (field.LabelData != null)
                    {
                        Console.WriteLine($"    Label: '{field.LabelData.Text}");
                    }

                    Console.WriteLine($"    Value: '{field.ValueData.Text}");
                    Console.WriteLine($"    Confidence: '{field.Confidence}");
                }
                Console.WriteLine("Table data:");
                foreach (FormPage page in form.Pages)
                {
                    for (int i = 0; i < page.Tables.Count; i++)
                    {
                        FormTable table = page.Tables[i];
                        Console.WriteLine($"Table {i} has {table.RowCount} rows and {table.ColumnCount} columns.");
                        foreach (FormTableCell cell in table.Cells)
                        {
                            Console.WriteLine($"    Cell ({cell.RowIndex}, {cell.ColumnIndex}) contains {(cell.IsHeader ? "header" : "text")}: '{cell.Text}'");
                        }
                    }
                }
            }
        }
        private async Task LoadContainers()
        {
            BlobServiceClient blobServiceClient = new BlobServiceClient(storageAccString);
            var segmentSize = 10;
            var containers = blobServiceClient.GetBlobContainersAsync();
            listBoxContainers.Items.Clear();
            try
            {
                // Call the listing operation and enumerate the result segment.
                var resultSegment =
                    blobServiceClient.GetBlobContainers(BlobContainerTraits.Metadata, null, default)
                    .AsPages(default, segmentSize);
                foreach (Azure.Page<BlobContainerItem> containerPage in resultSegment)
                {
                    foreach (BlobContainerItem containerItem in containerPage.Values)
                    {
                        listBoxContainers.Items.Add(containerItem.Name);
                        Console.WriteLine("Container name: {0}", containerItem.Name);
                    }

                    Console.WriteLine();
                }
            }
            catch (RequestFailedException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
                throw;
            }
        }

        private static async Task<BlobContainerClient> CreateStorageContainer(string name)
        {

            // Create a BlobServiceClient object which will be used to create a container client
            BlobServiceClient blobServiceClient = new BlobServiceClient(storageAccString);

            //Create a unique name for the container
            string containerName = name + Guid.NewGuid().ToString();

            // Create the container and return a container client object
            return await blobServiceClient.CreateBlobContainerAsync(containerName);

        }
        private static async Task uploadBlob()
        {

            //var fileDialog = new OpenFileDialog();


            //// var containers = await blobServiceClient.GetBlobContainersAsync();

            //if (fileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    var localFilePath = fileDialog.FileName;
            //    var fileName = fileDialog.SafeFileName;

            //    // Get a reference to a blob
            //    BlobClient blobClient = containerClient.GetBlobClient(fileName);

            //    Console.WriteLine("Uploading to Blob storage as blob:\n\t {0}\n", blobClient.Uri);

            //    // Upload data from the local file
            //    await blobClient.UploadAsync(localFilePath, true);
            //}
        }

        private static async Task ManageModels(FormTrainingClient trainingClient, string trainingFileUrl)
        {
            // Check number of models in the FormRecognizer account, 
            // and the maximum number of models that can be stored.
            AccountProperties accountProperties = trainingClient.GetAccountProperties();
            Console.WriteLine($"Account has {accountProperties.CustomModelCount} models.");
            Console.WriteLine($"It can have at most {accountProperties.CustomModelLimit} models.");
            Pageable<CustomFormModelInfo> models = trainingClient.GetCustomModels();

            foreach (CustomFormModelInfo modelInfo in models)
            {
                Console.WriteLine($"Custom Model Info:");
                Console.WriteLine($"    Model Id: {modelInfo.ModelId}");
                Console.WriteLine($"    Model Status: {modelInfo.Status}");
                Console.WriteLine($"    Training model started on: {modelInfo.TrainingStartedOn}");
                Console.WriteLine($"    Training model completed on: {modelInfo.TrainingCompletedOn}");
            }


            // Create a new model to store in the account
            CustomFormModel model = await trainingClient.StartTrainingAsync(
                new Uri(trainingFileUrl), useTrainingLabels: false).WaitForCompletionAsync();

            // Get the model that was just created
            CustomFormModel modelCopy = trainingClient.GetCustomModel(model.ModelId);

            Console.WriteLine($"Custom Model {modelCopy.ModelId} recognizes the following form types:");

            foreach (CustomFormSubmodel submodel in modelCopy.Submodels)
            {
                Console.WriteLine($"Submodel Form Type: {submodel.FormType}");
                foreach (CustomFormModelField field in submodel.Fields.Values)
                {
                    Console.Write($"    FieldName: {field.Name}");
                    if (field.Label != null)
                    {
                        Console.Write($", FieldLabel: {field.Label}");
                    }
                    Console.WriteLine("");
                }
            }

            // Delete the model from the account.
            trainingClient.DeleteModel(model.ModelId);
        }

        private void FolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine("OK");
            }
        }

        private void FormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fileDialog = new OpenFileDialog();

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = File.OpenRead(fileDialog.FileName);
                var analyzeForm = AnalyzePdfForm(recognizerClient, modelId, fs);
            }
        }

        private void ModelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var trainModel = TrainModel(trainingClient, trainingDataUrl);
            //Task.WaitAll(trainModel);
        }

        private void ModelWithLabelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var trainModelWithLabels = TrainModelWithLabels(trainingClient, trainingDataUrl);
            //Task.WaitAll(trainModel);
        }
        private void RecogniseContentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var recognizeContent = RecognizeContent(recognizerClient);
            //Task.WaitAll(recognizeContent);
        }

        private void AnalyzeFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var analyzeForm = AnalyzePdfForm(recognizerClient, modelId, formUrl);
            //Task.WaitAll(analyzeForm);
        }

        private void ManageModelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var manageModels = ManageModels(trainingClient, trainingDataUrl);
            //Task.WaitAll(manageModels);
        }

        private async void CreateNewContainerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await CreateStorageContainer("testname");
        }

        private async void ButtonNewContainer_Click(object sender, EventArgs e)
        {
            var name = textBoxContainerName.Text;
            await CreateStorageContainer(name);
        }
    }
}
