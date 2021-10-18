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
        // recogniserEndpoint = "https://jonathan-eddy-form-recognizer.cognitiveservices.azure.com/";
        // subscriptionKey = "0a4823585ca04c5d991705bc318679b4";
        // storageAccString = "DefaultEndpointsProtocol=https;AccountName=jonathaneddy374;AccountKey=MtRw600avh4qhcrQqxWL2FSXshnZ2pp4ovcQVkQEvugyxIUhVzJFnNCKf2j7pzk+tWdO9hUmngLw0hllFv4BmQ==;EndpointSuffix=core.windows.net";
        
        private static string recogniserEndpoint;
        private static string subscriptionKey;
        private static string storageAccString;

        private static string modelId = "f8a363a6-dbfa-4d5e-ad34-9edd04105d75";

        public Form2 apiKeysForm;

        private FormRecognizerClient recognizerClient;
        private FormTrainingClient trainingClient;
        private BlobContainerClient selectedContainerClient;

        public Form1()
        {
            InitializeComponent();


            loadSettings();

            if (recogniserEndpoint == null || recogniserEndpoint == "" || subscriptionKey == null || subscriptionKey == "")
            {
                MessageBox.Show("Please set the azure subscription key and recogniser endpoint");

                openApiKeys();
                return;
            }
            recognizerClient = AuthenticateClient();
            trainingClient = AuthenticateTrainingClient();

            LoadContainers();
            LoadModels();
        }

        public void loadSettings()
        {
            recogniserEndpoint = Properties.Settings.Default["recogniserEndpoint"].ToString(); ;
            subscriptionKey = Properties.Settings.Default["subscriptionKey"].ToString(); ;
            storageAccString = Properties.Settings.Default["storageAccString"].ToString(); ;
        }

        private static FormRecognizerClient AuthenticateClient()
        {
            var credential = new AzureKeyCredential(subscriptionKey);
            var client = new FormRecognizerClient(new Uri(recogniserEndpoint), credential);
            return client;
        }

        static private FormTrainingClient AuthenticateTrainingClient()
        {
            var credential = new AzureKeyCredential(subscriptionKey);
            var client = new FormTrainingClient(new Uri(recogniserEndpoint), credential);
            return client;
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
        private void LoadModels()
        {
            AccountProperties accountProperties = trainingClient.GetAccountProperties();
            Console.WriteLine($"Account has {accountProperties.CustomModelCount} models.");
            Console.WriteLine($"It can have at most {accountProperties.CustomModelLimit} models.");
            labelModelCount.Text = $"{accountProperties.CustomModelCount}/{accountProperties.CustomModelLimit}";
            Pageable<CustomFormModelInfo> models = trainingClient.GetCustomModels();
            listBoxModels.Items.Clear();
            foreach (CustomFormModelInfo modelInfo in models)
            {
                listBoxModels.Items.Add(modelInfo.ModelId.PadRight(40) + modelInfo.TrainingStartedOn);
                Console.WriteLine($"Custom Model Info:");
                Console.WriteLine($"    Model Id: {modelInfo.ModelId}");
                Console.WriteLine($"    Model Status: {modelInfo.Status}");
                Console.WriteLine($"    Training model started on: {modelInfo.TrainingStartedOn}");
                Console.WriteLine($"    Training model completed on: {modelInfo.TrainingCompletedOn}");
            }
        }
        private void LoadContainers()
        {
            Console.WriteLine(storageAccString);
            if (storageAccString == null || storageAccString == "")
            {
                MessageBox.Show("Set the storage account string in the api keys window");
                return;
            }
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
        private async Task uploadBlob()
        {
            if (selectedContainerClient != null)
            {
                var fileDialog = new OpenFileDialog();


                // var containers = await blobServiceClient.GetBlobContainersAsync();

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    var localFilePath = fileDialog.FileName;
                    var fileName = fileDialog.SafeFileName;

                    // Get a reference to a blob
                    BlobClient blobClient = selectedContainerClient.GetBlobClient(fileName);

                    Console.WriteLine("Uploading to Blob storage as blob:\n\t {0}\n", blobClient.Uri);

                    // Upload data from the local file
                    await blobClient.UploadAsync(localFilePath, true);
                }
            }
            
        }

        //Does the same thing as AnlyzePdfForm but also outputs json files
        //Pdfs are retrieved from 
        private static async Task AnalyzePdfForm_andOutput(FormRecognizerClient recognizerClient, String modelId, string formUrl)
        {
            RecognizedFormCollection forms = await recognizerClient
            .StartRecognizeCustomFormsFromUri(modelId, new Uri(formUrl))
            .WaitForCompletionAsync();

            FormInputOutput.saveForms(forms);
        }

        //Overloading method for taking in files from local source
        private static async Task AnalyzePdfForm_andOutput(FormRecognizerClient recognizerClient, String modelId, FileStream filestream)
        {
            RecognizedFormCollection forms = await recognizerClient
            .StartRecognizeCustomForms(modelId, filestream)
            .WaitForCompletionAsync();

            FormInputOutput.saveForms(forms);
        }


        private async void ButtonNewContainer_Click(object sender, EventArgs e)
        {
            var name = textBoxContainerName.Text;
            await CreateStorageContainer(name);
        }

        private async void ListBoxContainers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxContainers.SelectedIndex != -1)
            {
                buttonUploadFile.Enabled = true;
                selectedContainerClient = new BlobContainerClient(storageAccString, listBoxContainers.SelectedItem.ToString());
                await ListBlobsFlatListing(selectedContainerClient);
            }

        }
        private async Task ListBlobsFlatListing(BlobContainerClient blobContainerClient)
        {
            try
            {
                // Call the listing operation and return pages of the specified size.
                var resultSegment = blobContainerClient.GetBlobs()
                    .AsPages(default);
                listBoxBlobs.Items.Clear();
                // Enumerate the blobs returned for each page.
                foreach (Azure.Page<BlobItem> blobPage in resultSegment)
                {
                    foreach (BlobItem blobItem in blobPage.Values)
                    {
                        listBoxBlobs.Items.Add(blobItem.Name);
                    }
                }
            }
            catch (RequestFailedException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
                throw;
            }
        }

        private async void ButtonUploadFile_Click(object sender, EventArgs e)
        {
            await uploadBlob();
        }

        private async void ButtonAnalyze_Click(object sender, EventArgs e)
        {
            try
            {
                var fileDialog = new OpenFileDialog();
                fileDialog.Multiselect = true;
                fileDialog.Filter = "Compatable Image Files(*.PDF;*.JPG;*.PNG)|*.PDF;*.JPG;*.PNG|PDF Files(*.PDF)|*.PDF|JPEG Files(*.JPG)|*.JPG|PNG Files(*.PNG)|*.PNG";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Asyncronously analyze the selected forms
                    List<Task> tasks = new List<Task>();
                    foreach (string file in fileDialog.FileNames)
                    {
                        Console.WriteLine("Processing " + file);
                        using (FileStream fs = File.OpenRead(file))
                        {
                            tasks.Add(AnalyzePdfForm_andOutput(recognizerClient, modelId, fs));
                        }
                    }
                    await Task.WhenAll(tasks);
                }
            } catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async void selectLocalFiles()
        {

            var fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in fileDialog.FileNames)
                {
                    using (FileStream fs = File.OpenRead(file))
                    {
                        await AnalyzePdfForm_andOutput(recognizerClient, modelId, fs);
                    }
                }

            }
        }

        private void ListBoxModels_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxModels.SelectedIndex != -1)
            {
                buttonAnalyze.Enabled = true;
                buttonDeleteModel.Enabled = true;
                modelId = listBoxModels.SelectedItem.ToString().Split(' ')[0];
                Console.WriteLine(modelId);
            }
        }

        private async void ButtonDeleteModel_Click(object sender, EventArgs e)
        {
            await trainingClient.DeleteModelAsync(modelId = listBoxModels.SelectedItem.ToString().Split(' ')[0]);
            LoadModels();
        }

        private void ApiKeysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openApiKeys();
        }
        private void openApiKeys()
        {

            if (apiKeysForm == null)
            {
                apiKeysForm = new Form2(this);
                apiKeysForm.Show();
            }
            else
            {
                apiKeysForm.Focus();
            }
        }
    }
}
