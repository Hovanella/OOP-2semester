using System;
using System.Windows.Forms;

namespace Laba1
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }
        
        private void textBoxNumbersOnly_KeyPress(object sender, KeyPressEventArgs e)
        {   
            char currentSymbol = e.KeyChar;

            if (char.IsDigit(currentSymbol) == false && (int)currentSymbol!=8 )
            {
                e.Handled = true;
            }
        }
        
        private void UsersInputsChanged(object sender, EventArgs e)
        {
            if (textBoxAge.Text != "" && textBoxHeight.Text != "" && textBoxWeight.Text != "" && comboBoxStyles.SelectedItem.ToString() != "")
            {
                try
                {
                    int age = int.Parse(textBoxAge.Text);
                    int height = int.Parse(textBoxHeight.Text);
                    int weight = int.Parse(textBoxWeight.Text);
                    var style = comboBoxStyles.SelectedItem.ToString();
                    int stylenumber = 1;
                    switch (style)
                    {
                        case "Мужской":
                            stylenumber = 1;
                            break;
                        case "Женский":
                            stylenumber = 2;
                            break;
                        case "Вертолёт":
                            stylenumber = 3;
                            break;
                    }

                    int result = checked(age + height + (weight / stylenumber));
                    switch (result % 10)
                    {
                        case 0:
                            textBoxDiagnoz.Text = "Идеальный";
                            break;
                        case 6:
                            textBoxDiagnoz.Text = "Ожирение";
                            break;
                        case 9:
                            textBoxDiagnoz.Text = "Наташа";
                            break;
                        default:
                            textBoxDiagnoz.Text = "Почти ожирение";
                            break;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Числа больно велики");
                }
                


            }
        }

        private void HiddenInputsChanged(object sender, EventArgs e)
        {
            if (textBoxAge.Text == "" || textBoxHeight.Text == "" || textBoxWeight.Text == "" || comboBoxStyles.SelectedItem.ToString() == "") return;
            if (textBoxHiddenTime.Text == "" || textBoxHiddenWeight.Text == "") return;
            
            try
            {
                int age = int.Parse(textBoxAge.Text);
                int height = int.Parse(textBoxHeight.Text);
                int weight = int.Parse(textBoxWeight.Text);
                var style = comboBoxStyles.SelectedItem.ToString();
                
               
                var comboBoxTargetsText = comboBoxTargets.Text;
                if(comboBoxTargetsText == "Поддержание веса")
                {
                    textBoxNorma.Text = new Random().Next(1, 100000).ToString();
                }
                else{
                    int HiddenTime = int.Parse(textBoxHiddenTime.Text);
                    int HiddenWeight = int.Parse(textBoxHiddenWeight.Text);

                    if (comboBoxTargetsText == "Увеличение веса")
                    {
                        if (HiddenWeight <= weight)
                            throw new ApplicationException();
                        textBoxNorma.Text = checked((new Random().Next(1, 1000) + (HiddenWeight - weight)) / HiddenTime).ToString();
                    }
                    else
                    {
                        if (HiddenWeight >= weight)
                            throw new ApplicationException();
                        textBoxNorma.Text = checked((new Random().Next(1, 1000) + (weight - HiddenWeight)) / HiddenTime).ToString();
                    }
                }
            }
            catch (ApplicationException)
            {
                MessageBox.Show("Желаемый вес не соотносится с целью");
            }
            catch (Exception)
            {
                MessageBox.Show("Числа больно велики");
            }
        }
        
        private void comboBoxTargets_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var targetText = (sender as ComboBox).Text;
            HiddenInputsChanged(null,null);
            if (targetText == "Поддержание веса")
            {
                if (labelHiddenTime.Visible == false) return;
                labelHiddenTime.Visible = false;
                labelHiddenWeight.Visible = false;
                textBoxHiddenTime.Visible = false;
                textBoxHiddenWeight.Visible = false;
            }
            else
            {
                if (labelHiddenTime.Visible == true) return;
                labelHiddenTime.Visible = true;
                labelHiddenWeight.Visible = true;
                textBoxHiddenTime.Visible = true;
                textBoxHiddenWeight.Visible = true;
            }
            
        }
    }
}