using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.Json;
using System.Text.Json.Serialization;
using Azure;
using Azure.AI.FormRecognizer;
using Azure.AI.FormRecognizer.Models;
using Azure.AI.FormRecognizer.Training;
using System.IO;

namespace compx374winform
{
    public static class FormInputOutput
    {
        private static String defaultFilePath = "\\FormJsonOutput"; //default file saving and loading location, mainly for testing
        private static String formRunsSubfolders = "\\FormRun_";

        //takes in all the forms in a form collection (when Analyzing Forms) and outputs serialized json files for all the forms
        public static void saveForms(RecognizedFormCollection forms)
        {
            try
            {
                // Try to create the directory.
                DirectoryInfo di = Directory.CreateDirectory(defaultFilePath);
                DirectoryInfo sub_di = Directory.CreateDirectory(defaultFilePath + formRunsSubfolders + forms.ToString()); //not a great file naming system but it works for now

                foreach(RecognizedForm form in forms)
                {
                    String filePath = sub_di.FullName + form.GetHashCode() + ".json";
                    serializeFormData(form,filePath);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
        }

        //just does the same thing as saveForms but a single form instead of a collection
        public static void saveForm(RecognizedForm form)
        {
            try
            {
                // Try to create the directory.
                DirectoryInfo di = Directory.CreateDirectory(defaultFilePath); //should just do nothing if the folder already exists but I will watch this to make sure it behaves as it says it should
                String filePath = di.FullName + form.GetHashCode() + ".json";
                serializeFormData(form, filePath);
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
        }

        public static void serializeFormData(LoadedFormData formData, String filePath)
        {
            using (StreamWriter sw = File.CreateText(filePath))
            {
                string jsonString = JsonSerializer.Serialize(formData);
                sw.Write(jsonString);
            }
        }

        public static void serializeFormData(RecognizedForm form, String filePath)
        {
            serializeFormData(new LoadedFormData(form), filePath);
        }

        public static LoadedFormData deserializeFormData(String filePath)
        {
            try
            {
                using (StreamReader sr = File.OpenText(filePath))
                {
                    String jsonString = sr.ReadToEnd();
                    return JsonSerializer.Deserialize<LoadedFormData>(jsonString);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("bad file path: " + e);
                return null;
            }
        }

        //deserialization doesn't appear to work on RecognisedForm for whatever reason
        public static RecognizedForm deserializeTest(RecognizedForm form, String filePath)
        {
            //still doesn't work even when I feed the serailized string directly back in, weird
            try
            {
                string jsonString = JsonSerializer.Serialize(form);

                //return JsonSerializer.Deserialize<RecognizedForm>(jsonString);
                return JsonSerializer.Deserialize<RecognizedForm>(jsonString);
            }
            catch (Exception e)
            {
                Console.WriteLine("bad file path: " + e);
                return null;
            }
        }

        

        //just writes form data to a text file
        //not using this anymore since I remembered serialization is a thing and is just better than this in every way
        public static void writeAnalyzedForm(RecognizedForm form, String filePath)
        {
            LoadedFormData convertedForm = new LoadedFormData(form);

            using (StreamWriter sw = File.CreateText(filePath))
            {
                sw.WriteLine("Fields");
                foreach (Dictionary<String, String> field in convertedForm.formFields)
                {
                    String line = "";
                    line += "Field:" + field["Field"] + ",";
                    line += "Label:" + field["Label"] + ",";
                    line += "Value:" + field["Value"] + ",";
                    line += "Confidence:" + field["Confidence"] + ",";
                    sw.WriteLine(line);
                }

                sw.WriteLine("Tables");
                foreach (Dictionary<String, String> table in convertedForm.tableData)
                {
                    String line = "";
                    line += "ColumnIndex:" + table["ColumnIndex"] + ",";
                    line += "RowIndex:" + table["RowIndex"] + ",";
                    line += "IsHeader:" + table["IsHeader"] + ",";
                    line += "Text:" + table["Text"] + ",";
                    sw.WriteLine(line);
                }
            }
        }

        //does nothing atm and probably won't be needed at all but it *should* read in raw text data of some LoadedFormData and put it into a LoadedFormData instance
        //won't bother to implement the rest unless it's actually needed
        public static String readInFormText(String filePath)
        {
            try
            {
                System.IO.StreamReader reader = File.OpenText(filePath);
                reader.ReadLine(); //read off header from file

                return "";

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return "Failed read-in of Form Data";
            }
        }

        //won't be used (for now at least)
        //Serializes a 
        public static void serializeAnalyzedForm(RecognizedForm form, String filePath)
        {
            string jsonString = JsonSerializer.Serialize(form);

            string path = @"e:/jsonTestFolder/json_Test_Output.json";

            using (StreamWriter sw = File.CreateText(path))
            {
                sw.Write(jsonString);
            }
        }
    }
}
