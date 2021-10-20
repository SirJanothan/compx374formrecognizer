using Azure.AI.FormRecognizer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compx374winform
{
    /* RecognizedForm really doesn't seem to like being deserialized so I have to do this
     * Basically just holds the data that we need to from a RecognizedForm so we can serialize it
     * Serializing ends up being a much easier way of outputting raw data than 
     */
    public class LoadedFormData
    {
        //public List<Dictionary<String, String>> formFields;
        //public List<Dictionary<String, String>> tableData;

        public List<Dictionary<String, String>> formFields { get; set; }
        public List<Dictionary<String, String>> tableData { get; set; }

        //public String serializeTestString = "here is a test for serialization";

        public LoadedFormData(RecognizedForm form)
        {
            if(formFields == null)
            {
                formFields = new List<Dictionary<String, String>>();
            }

            //Fields Data
            foreach (FormField field in form.Fields.Values)
            {
                Dictionary<String, String> stringField = new Dictionary<String, String>();
                stringField.Add("Field", field.Name);
                if (field.LabelData != null) { stringField.Add("Label", field.LabelData); }

                FieldValueType fieldType = field.Value.ValueType;

                String value = "";

                //I wish there was a better way to do this but alas
                if(fieldType is FieldValueType.SelectionMark)
                {
                    Console.WriteLine("Selection Mark State is: " + field.Value.AsSelectionMarkState());
                    value = field.Value.AsSelectionMarkState().ToString();
                }
                else if (fieldType is FieldValueType.Dictionary)
                {
                    Console.WriteLine("Unable to store dictionaries currently");
                    value = "Dictionary";

                    //IReadOnlyDictionary<string, FormField> itemFields = field.Value.AsDictionary();
                    //FormField dictionaryField;

                    //String valuesConcat = "";

                    /*foreach (KeyValuePair<string, FormField> dictonaryKeyValPair in itemFields)
                    {
                        FormField dictionaryField = dictonaryKeyValPair.Value;
                        String valueString = dictonaryKeyValPair.Key;

                        if (dictionaryField.Value.ValueType is FieldValueType.Dictionary)
                        {
                            //String valueString = dictionaryField.Name;
                            valueString += ": " + dictionaryField.Value.AsSelectionMarkState().ToString();
                            valueString += ": " + dictionaryField.Confidence;

                            //Console.WriteLine($"    Name: '{itemName}', with confidence {itemNameField.Confidence}");
                        }
                        else
                        {
                            Console.WriteLine("Something wrong with selection marks here");
                            Console.WriteLine("Type: " + dictionaryField.Value.ValueType);
                        }

                        valuesConcat += valueString + ",";
                    }

                    value = valuesConcat;*/
                }
                else if (fieldType is FieldValueType.Date)
                {
                    value = field.Value.AsDate().ToString();
                }
                else if (fieldType is FieldValueType.Float)
                {
                    value = field.Value.AsFloat().ToString();
                }
                else
                {
                    value = "unknown value";
                }
                //else if (fieldType is FieldValueType.String)
                //{
                //    value = field.Value.ToString();
                //    value = field.Value.AsString

                    //try
                    //{
                    //    Console.WriteLine(fieldType.ToString());
                    //    value = field.ValueData.Text.ToString();
                    //    Console.WriteLine("ValueData Text: " + field.ValueData.Text.ToString());
                    //}
                    //catch (Exception ex) { }
                //}

                //if(fieldType is SelectionMark)
                //{
                //    SelectionMarkState state = field.Value.AsSelectionMarkState();
                //    Console.WriteLine("Selection Mark State is: " + state);
                    //value = field.Value.AsSelectionMarkState;
                //}

                //Console.WriteLine("Field type is: " + field.Value.ValueType);
                //Console.WriteLine("Maybe the field data?: " + field.Value.ToString());

                stringField.Add("Value", value + "");
                stringField.Add("Confidence:", field.Confidence + "");

                formFields.Add(stringField);
            }

            if(tableData == null)
            {
                tableData = new List<Dictionary<String, String>>();
            }

            //Tables data
            foreach (FormPage page in form.Pages)
            {
                for (int i = 0; i < page.Tables.Count; i++)
                {
                    FormTable table = page.Tables[i];
                    int rows = table.RowCount;
                    int columns = table.ColumnCount;

                    //list of cells?
                    //Console.WriteLine($"Table {i} has {table.RowCount} rows and {table.ColumnCount} columns.");
                    foreach (FormTableCell cell in table.Cells)
                    {
                        Dictionary<String, String> tableField = new Dictionary<string, string>();

                        Console.WriteLine("Text" + cell.Text + "");

                        tableField.Add("ColumnIndex", cell.ColumnIndex + "");
                        tableField.Add("RowIndex", cell.RowIndex + "");
                        tableField.Add("IsHeader", cell.IsHeader + "");
                        tableField.Add("Text", cell.Text + "");

                        tableData.Add(tableField);

                        //Console.WriteLine($"    Cell ({cell.RowIndex}, {cell.ColumnIndex}) contains {(cell.IsHeader ? "header" : "text")}: '{cell.Text}'");
                    }
                }
            }
        }

        public LoadedFormData(List<Dictionary<String, String>> _formFields, List<Dictionary<String, String>> _tableData)
        {
            formFields = _formFields;
            tableData = _tableData;
        }

        public void printFieldContents()
        {
            foreach (Dictionary<String,String> field in formFields)
            {
                foreach (KeyValuePair<String,String> val in field){
                    Console.WriteLine(val.Key + ": " + val.Value);
                }
            }
        }
    }
}
