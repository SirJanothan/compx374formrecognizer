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
        public List<Dictionary<String, String>> formFields;
        public List<Dictionary<String, String>> tableData;

        public LoadedFormData(RecognizedForm form)
        {
            //Fields Data
            foreach (FormField field in form.Fields.Values)
            {
                Dictionary<String, String> stringField = new Dictionary<String, String>();
                stringField.Add("Field", field.Name);
                if (field.LabelData != null) { stringField.Add("Label", field.LabelData); }
                stringField.Add("Value", field.Value + "");
                stringField.Add("Confidence:", field.Confidence + "");

                formFields.Add(stringField);
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
    }
}
