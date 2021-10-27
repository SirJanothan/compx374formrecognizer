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
     */
    public class LoadedFormData
    {
        public List<Dictionary<String, String>> formFields { get; set; }
        public List<Dictionary<String, String>> tableData { get; set; }

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

                try
                {
                    //I wish there was a better way to do this but alas
                    if (fieldType is FieldValueType.SelectionMark)
                    {
                        //Console.WriteLine("Selection Mark State is: " + field.Value.AsSelectionMarkState());
                        value = field.Value.AsSelectionMarkState().ToString();
                    }
                    else if (fieldType is FieldValueType.Dictionary)
                    {
                        value = "dictionary";

                        IReadOnlyDictionary<string, FormField> dictionaryValue = field.Value.AsDictionary();

                        foreach (KeyValuePair<string, FormField> keyValPair in dictionaryValue)
                        {
                            FormField row = keyValPair.Value;
                            FieldValueType rowType = row.Value.ValueType;
                            //Console.WriteLine("Key: " + keyValPair.Key + ", Value: " + rowType);

                            if (rowType is FieldValueType.Dictionary)
                            {
                                IReadOnlyDictionary<string, FormField> subDictionaryValue = row.Value.AsDictionary();

                                foreach (KeyValuePair<string, FormField> subKVP in subDictionaryValue)
                                {
                                    FormField tableSubField = subKVP.Value;
                                    FieldValueType tableSubFieldType = tableSubField.Value.ValueType;
                                    //Console.WriteLine("SubKey: " + subKVP.Key + ", SubValueType: " + tableSubFieldType);
                                    String tableVal = "";

                                    try
                                    {
                                        if (tableSubFieldType is FieldValueType.SelectionMark)
                                        {
                                            //Console.WriteLine("Sub:SelectionMarkValue?: " + tableSubField.Value.AsSelectionMarkState().ToString());
                                            tableVal = tableSubField.Value.AsSelectionMarkState().ToString();
                                        }
                                        else if (tableSubFieldType is FieldValueType.String)
                                        {
                                            //Console.WriteLine("Sub:String?: " + tableSubField.Value.AsString());
                                            tableVal = tableSubField.Value.AsString();
                                        }
                                        else
                                        {
                                            tableVal = "value from unkown/unhandled type";
                                            //Console.WriteLine("Unhandled type: " + tableSubFieldType.ToString());
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        tableVal = "unknown/unhandled type (from program error)";
                                        Console.WriteLine("An error occured when attempting to parse the type of a form field when loading the form data (Dictionary Second Level/Columns): " + ex.ToString());
                                    }

                                    //For now I am just adding all the values from a table into the general list of key value pairs (formFields)
                                    //I ran out of time to implement a better way of doing this that preserved the table structure, the the data is still there with it's row/column index noted as it's 'Field'

                                    Dictionary<String, String> stringSubField = new Dictionary<String, String>();

                                    stringSubField.Add("Field", (row.Name + ":" + tableSubField.Name));
                                    if (tableSubField.LabelData != null) { stringSubField.Add("Label", field.LabelData); }
                                    stringSubField.Add("Value", tableVal + "");
                                    stringSubField.Add("Confidence:", tableSubField.Confidence + "");

                                    formFields.Add(stringSubField);
                                }
                            }
                            else if (rowType is FieldValueType.SelectionMark)
                            {
                                Console.WriteLine("SelectionMarkValue?: " + row.Value.AsSelectionMarkState().ToString());
                                Console.WriteLine("This shouldn't show up in the console");
                                //dicVal = subField.Value.AsSelectionMarkState().ToString();
                            }
                            else
                            {
                                Console.WriteLine("Type?: " + rowType.ToString());
                                Console.WriteLine("This shouldn't show up in the console");
                            }
                        }
                    }
                    else if (fieldType is FieldValueType.Date)
                    {
                        value = field.Value.AsDate().ToString();
                    }
                    else if (fieldType is FieldValueType.Float)
                    {
                        value = field.Value.AsFloat().ToString();
                    }
                    else if (fieldType is FieldValueType.String)
                    {
                        try //I've run into some cases where a string is returned as null for some reason, so best to handle it gracefully even if no value is found
                        {
                            value = field.Value.AsString();
                        }
                        catch (Exception ex) { value = "faulty string returned by form recognizer model"; }
                    }
                    else
                    {
                        value = "value from unkown/unhandled type";
                    }
                }
                catch (Exception ex)
                {
                    value = "unknown/unhandled type (from program error)";
                    Console.WriteLine("An error occured when attempting to parse the type of a form field when loading the form data (Top Level Form Field): " + ex.ToString());
                }

                stringField.Add("Value", value + "");
                stringField.Add("Confidence:", field.Confidence + "");

                formFields.Add(stringField);
            }

            //This is data that is automatically extracted from the form
            //Not related to labelled data, it's just something that azure does for you, but is ultimately sort of useless since it's not great at picking up what's a table and what's not
            //I've commented it out for now, however if anyone feels the need to use it again it's there

            //if (tableData == null)
            //{
            //    tableData = new List<Dictionary<String, String>>();
            //}

            /*foreach (FormPage page in form.Pages)
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

                        FormElement[] cellFieldEls = cell.FieldElements.ToArray();
                        Console.WriteLine(cellFieldEls.Count());
                        Console.WriteLine(cell.FieldElements.Count());

                        Console.WriteLine("Text" + cell.Text + "");
                        Console.WriteLine("Cell Type: " + cell.GetType());

                        foreach (FormElement el in cellFieldEls)
                        {
                            Console.WriteLine("Table Debug: " + el.ToString());
                        }

                        Console.WriteLine("Testing cell info: " + cell.FieldElements.ToArray());

                        tableField.Add("Data", cell.Text + "");
                        tableField.Add("ColumnIndex", cell.ColumnIndex + "");
                        tableField.Add("RowIndex", cell.RowIndex + "");
                        tableField.Add("IsHeader", cell.IsHeader + "");
                        tableField.Add("Text", cell.Text + "");
                        Console.WriteLine("Row: " + cell.RowIndex + ", Column: " + cell.ColumnIndex + ", Text: " + cell.Text);

                        tableData.Add(tableField);

                        Console.WriteLine($"    Cell ({cell.RowIndex}, {cell.ColumnIndex}) contains {(cell.IsHeader ? "header" : "text")}: '{cell.Text}'");
                    }
                }
            }*/
        }

        public LoadedFormData(List<Dictionary<String, String>> _formFields, List<Dictionary<String, String>> _tableData)
        {
            formFields = _formFields;
            tableData = _tableData;
        }

        //debugging method
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
