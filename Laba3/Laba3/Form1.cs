using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Laba2.BookFile;
using Newtonsoft.Json;

namespace Laba2
{
    public partial class Form1 : Form
    {
        private readonly AuthorsForm _authorsForm = new AuthorsForm();
        private readonly PublishingHouseForm _publishingHouseForm = new PublishingHouseForm();
        private readonly SearchForm _searchForm = new SearchForm();

        public Form1()
        {
            InitializeComponent();
            _publishingHouseForm.Hide();
            _authorsForm.Hide();
            _searchForm.Hide();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (_publishingHouseForm.CurrentPublishingHouse == null || _authorsForm.CurrentAuthorsList == null) return;
            if (Controls.OfType<RadioButton>().Any(r => r.Checked) == false) return;
            if (textBoxName.Text == "" || textBoxSize.Text == "" || textBoxNumberOfPages.Text == "" || textBoxUDC.Text == "") return;

            var name = "";
            var size = 0;
            var numberOfPages = 0;
            var udc = "";
            var format = Format.FB2;
            int year = DateTime.Now.Year;

            try
            {
                name = textBoxName.Text;
                size = int.Parse(textBoxSize.Text);
                numberOfPages = int.Parse(textBoxNumberOfPages.Text);
                udc = textBoxUDC.Text;
                year = dateTimePickerYear.Value.Year;

                var checkedRadioButton = Controls.OfType<RadioButton>().First(r => r.Checked);
                switch (checkedRadioButton.Name)
                {
                    case "radioButtonFormatHTML":
                        format = Format.HTML;
                        break;
                    case "radioButtonFormatPDF":
                        format = Format.PDF;
                        break;
                    case "radioButtonFormatTXT":
                        format = Format.TXT;
                        break;
                    case "radioButtonFormatFB2":
                        format = Format.FB2;
                        break;
                    case "radioButtonFormatEPUB":
                        format = Format.EPUB;
                        break;
                }
            }
            catch (OverflowException)
            {
                MessageBox.Show("Числа великоваты");
                return;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return;
            }

            var publishingHouse = _publishingHouseForm.CurrentPublishingHouse;
            var authorsList = new List<Author>(_authorsForm.CurrentAuthorsList);
            var bookFile = new BookFile.BookFile(format, size, name, udc, numberOfPages, publishingHouse, year, authorsList);
            
            var results = new List<ValidationResult>();
            var context = new ValidationContext(bookFile);
            if ( Validator.TryValidateObject(bookFile, context, results, true) == false )
            {
                var errorString = new StringBuilder();
                
                foreach (var validationResult in results)
                {
                    errorString.Append(validationResult.ErrorMessage + "\n");
                }
                MessageBox.Show(errorString.ToString()); 
                return;
            }
            
            listBoxBase.Items.Add(bookFile);

            _authorsForm.Clear();
            _publishingHouseForm.Clear();
        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            _publishingHouseForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _authorsForm.Show();
        }


        private void listBoxBase_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxAuthors.Text = "";
            textBoxPublishingHouse.Text = "";

            var selectedBookFile = ((ListBox)sender).SelectedItem as BookFile.BookFile;

            if (selectedBookFile == null) return;
            textBoxPublishingHouse.Text = selectedBookFile.PublishingHouse.ToString();

            foreach (var author in selectedBookFile.Authors) textBoxAuthors.Text += author + Environment.NewLine;
        }

        private void textBoxDigitsOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8) return;
            e.Handled = true;
        }


        private void buttonLoadFromFile_Click(object sender, EventArgs e)
        {
            var BookFilesList = new List<BookFile.BookFile>();
            using (var reader = new StreamReader(@"../../Json/DB.json"))
            {
                BookFilesList = JsonConvert.DeserializeObject<List<BookFile.BookFile>>(reader.ReadToEnd());
            }

            foreach (var bookFile in BookFilesList) listBoxBase.Items.Add(bookFile);
        }

        private void buttonSaveInFile_Click(object sender, EventArgs e)
        {
            var BookFilesList = (from object item in listBoxBase.Items select item as BookFile.BookFile).ToList();

            using (var reader = new StreamWriter(@"d:\Образование\Semestr4\OOP\MyLabs\Laba2\Laba2\Json\DB.json"))
            {
                string jsonString = JsonConvert.SerializeObject(BookFilesList);
                reader.Write(jsonString);
            }
        }

        private void поискToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _searchForm.Show();
            _searchForm.GetBookFilesFromBaseListbox(listBoxBase.Items);
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Author : HTA , version : 6.9");
        }

        private void поНазваниюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sortedBookFiles = listBoxBase.Items.OfType<BookFile.BookFile>().OrderBy(x => x.Name).ToList();
            listBoxBase.Items.Clear();
            
            foreach (var sortedBookFile in sortedBookFiles)
            {
                listBoxBase.Items.Add(sortedBookFile);
            }
        }

        private void датеЗагрузкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sortedBookFiles = listBoxBase.Items.OfType<BookFile.BookFile>().OrderBy(x => x.Year).ToList();
            listBoxBase.Items.Clear();
            
            foreach (var sortedBookFile in sortedBookFiles)
            {
                listBoxBase.Items.Add(sortedBookFile);
            }
        }

        private void панельИнструментовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip1.Visible = toolStrip1.Visible == false;
        }

        private void toolStripButtonClearBase_Click(object sender, EventArgs e)
        {
            listBoxBase.Items.Clear();
        }
    }
    }
