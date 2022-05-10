using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfCustomControlLibrary
{
    /// <summary>
    /// Follow steps 1a or 1b and then 2 to use this custom control in a XAML file.
    ///
    /// Step 1a) Using this custom control in a XAML file that exists in the current project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:WpfCustomControlLibrary"
    ///
    ///
    /// Step 1b) Using this custom control in a XAML file that exists in a different project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:WpfCustomControlLibrary;assembly=WpfCustomControlLibrary"
    ///
    /// You will also need to add a project reference from the project where the XAML file lives
    /// to this project and Rebuild to avoid compilation errors:
    ///
    ///     Right click on the target project in the Solution Explorer and
    ///     "Add Reference"->"Projects"->[Select this project]
    ///
    ///
    /// Step 2)
    /// Go ahead and use your control in the XAML file.
    ///
    ///     <MyNamespace:CustomControl1/>
    ///
    /// </summary>
    /// 
    [TemplatePart(Name = Calculator.ElemenetOperand1TextBox, Type = typeof(TextBox))]
    [TemplatePart(Name = Calculator.ElemenetOperand2TextBox, Type = typeof(TextBox))]
    [TemplatePart(Name = Calculator.ElemenetResultTextBox, Type = typeof(TextBox))]
    [TemplatePart(Name = Calculator.ElemenetButtonSum, Type = typeof(Button))]
    public class Calculator : Control
    {
        private const string ElemenetOperand1TextBox = "PART_Operand1";
        private const string ElemenetOperand2TextBox = "PART_Operand2";
        private const string ElemenetResultTextBox = "PART_Result";
        private const string ElemenetButtonSum = "PART_ButtonSum";

        static Calculator()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Calculator), new FrameworkPropertyMetadata(typeof(Calculator)));
        }

        private TextBox _operand1TextBox;
        private TextBox _operand2TextBox;
        private TextBox _resultTextBox;
        private Button _buttonSum;

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            _operand1TextBox = GetTemplateChild(ElemenetOperand1TextBox) as TextBox;
            _operand2TextBox = GetTemplateChild(ElemenetOperand2TextBox) as TextBox;
            _resultTextBox = GetTemplateChild(ElemenetResultTextBox) as TextBox;
            _buttonSum = GetTemplateChild(ElemenetButtonSum) as Button;
            
            if (_buttonSum != null)
            {
                _buttonSum.Click += new RoutedEventHandler(buttonSum_Click);
            }
        }

        void buttonSum_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int a, b;
                a = Convert.ToInt32(_operand1TextBox.Text);
                b = Convert.ToInt32(_operand2TextBox.Text);
                _resultTextBox.Text = (a + b).ToString();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
    }
}
