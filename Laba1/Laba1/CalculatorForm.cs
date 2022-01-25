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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            textBoxMemory.Text = textBoxResult.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sign = (sender as ComboBox).Text;
            textBoxOperationSign.Text = sign;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxEquals.Text = "";
            textBoxMemory.Text = "";
            textBoxResult.Text = "";
            textBoxFirstValue.Text = "";
            textBoxSecondValue.Text = "";
            textBoxOperationSign.Text = "";
            comboBox1.Text = "";
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            if (textBoxFirstValue.Text != "" && textBoxSecondValue.Text != "" && textBoxOperationSign.Text != "")
            {
                textBoxEquals.Text = "=";

                int firstValue;
                int secondValue;
                if (int.TryParse(textBoxFirstValue.Text, out firstValue) == false ||
                    int.TryParse(textBoxSecondValue.Text, out secondValue) == false)
                    return;
                
                char sign = textBoxOperationSign.Text[0];
                var result = 0;
                
                try
                {
                    switch (sign)
                    {
                        case '+':
                            result = checked(firstValue + secondValue);
                            break;
                        case '-':
                            result = checked(firstValue - secondValue);
                            break;
                        case '*':
                            result = checked(firstValue * secondValue);
                            break;
                        case '/':
                            result = checked (firstValue / secondValue);
                            break;
                        case '^':
                            result = checked((int)Math.Pow(firstValue, secondValue));
                            break;
                    }
                }
                catch (OverflowException)
                {
                    textBoxResult.Text = "Overflow";
                    return;
                }

                textBoxResult.Text = result.ToString();
            }
        }
    }
}