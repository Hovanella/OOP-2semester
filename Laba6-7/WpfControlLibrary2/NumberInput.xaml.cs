using System.Windows;
using System.Windows.Controls;

namespace WpfControlLibrary2
{
    /// <summary>
    /// Interaction logic for NumberInput.xaml
    /// </summary>
    public partial class NumberInput : UserControl
    {
        public NumberInput()
        {
            InitializeComponent();
        }

        private static int _number;

        static NumberInput()
        {
            //register Number property
            NumberProperty = DependencyProperty.Register("Number", typeof(int), typeof(string),
                new FrameworkPropertyMetadata(new PropertyChangedCallback(OnNumberChanged)));
        }

        private static void OnNumberChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            _number = (int)e.NewValue;
        }

        public static DependencyProperty NumberProperty;

        public string Number
        {
            get => (string)GetValue(NumberProperty);
            set => SetValue(NumberProperty, value);
        }

        public static bool IsNumberCorrect(object value)
        {
            return true;
        }
    }
}

