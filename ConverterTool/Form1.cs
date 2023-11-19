using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spire.Doc; //Package relates to .doc & .docx to pdf 
using Spire.Doc.Documents;//Package relates to .doc & .docx to pdf
using System.Security; 

namespace ConverterTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            txtbox_step_2_instructions.Text = "Step 2: " + Environment.NewLine + Environment.NewLine + "Select a file conversion method." + Environment.NewLine + Environment.NewLine + "Then press the 'Perform Conversion' button.";
        }

        //Global variables
        string selectedFilePath;

        private void btn_select_file_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Configuration for openFileDialog

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedFilePath = openFileDialog.FileName; // Assigns the selected file path to the global variable

                    lb_chosen_file.Items.Clear(); // Clear previous entries
                    lb_chosen_file.Items.Add(selectedFilePath); // Add the selected file path to the listbox

                    string fileExtension = Path.GetExtension(selectedFilePath).ToLower();
                    List<string> conversionOptionsList = GetConversionOptions(fileExtension);

                    clb_conversion_options.Items.Clear(); // Clear existing items in the checked list box
                    foreach (string option in conversionOptionsList)
                    {
                        clb_conversion_options.Items.Add(option); // Add options to the checked list box
                    }
                }
            }
        }

        private List<string> GetConversionOptions(string fileExtension)
        {
            var options = new List<string>(); //Declare and initialize a new list of strings called options keyword | var allows compiler to infer variable type | new keyword allocates memory for for a new 'List<string> object

            switch (fileExtension) //this switch statement is where the logic for populating the conversion options list in clb_conversion_options is contained
            {
                //add word to pdf conversion option to options list
                case ".doc":
                case ".docx":
                    options.Add("Word to PDF");
                    break;

                //ADD MORE OPTIONS HERE
            }
            return options; //Function returns string list named options back to foreach statement in btn_select_file_Click that adds string option to the checked list box named clb_conversion_options
        }

        private void btn_convert_Click(object sender, EventArgs e)
        {
            foreach (var item in clb_conversion_options.CheckedItems) //Iterate through the conversion_options list and store selected converson in var item
            {
                string conversionType = item.ToString(); //set string conversionType equal to the stringified var item

                PerformConversion(conversionType); //call the PerformConvert function based on the data stored in string conversionType
            }
        }

        private void PerformConversion(string conversionType)
        {
            switch (conversionType) //this switch statement checks the string stored in conversionType and calls the appropriate conversion function
            {
                //call word to pdf conversion
                case "Word to PDF":
                    ConvertWordToPdf();
                    break;

                //ADD MORE OPTIONS HERE
            }
        }

        private string GetFilePathWithoutExtension(string filePath)
        {
            string directory = Path.GetDirectoryName(filePath);
            string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(filePath);
            return Path.Combine(directory, fileNameWithoutExtension);
        }

        private void ConvertWordToPdf() 
        {
            //parts of this function rely on the Spire.Doc package

            bool conversionSuccess = false;

            try
            {
                string baseFilePath = GetFilePathWithoutExtension(selectedFilePath);
                string pdfFilePath = baseFilePath + ".pdf";
                Document doc = new Document(); //Create new instance of Spire.Doc document class called doc
                doc.LoadFromFile(selectedFilePath); //Load word doc from file specified by wordFilePath, into the doc object

                doc.SaveToFile(pdfFilePath, FileFormat.PDF); //Save the loaded document to a new file in PDF format

                conversionSuccess = true;
            }

            catch (Exception ex)
            {
                conversionSuccess = false;
            }
            conversionStatusMessage(conversionSuccess);
        }

        private void conversionStatusMessage(bool operationStatus)
        {
            if (operationStatus)
            {
                MessageBox.Show("File Converted Successfully!");
            } else
            {
                MessageBox.Show("File Conversion has Failed!");
            }
        }
    }
}
