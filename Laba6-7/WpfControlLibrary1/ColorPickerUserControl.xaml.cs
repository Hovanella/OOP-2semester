using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace WpfControlLibrary1
{
    public partial class ColorPickerUserControl : UserControl
    {
        public ColorPickerUserControl()
        {
            InitializeComponent();
        }

        private Color? _previousColor;


        // Проверка возможности запуска команды.
        private static void UndoCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            ColorPickerUserControl colorPicker = (ColorPickerUserControl)sender;
            e.CanExecute = colorPicker._previousColor.HasValue;
        }

        private static void UndoCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            // Возвращаем старое значение цвета.
            ColorPickerUserControl colorPicker = (ColorPickerUserControl)sender;
            colorPicker.Color = (Color)colorPicker._previousColor;
        }

        // Конструктор для регистрации свойств зависимостей.
        static ColorPickerUserControl()
        {
            ColorProperty = DependencyProperty.Register("Color", typeof(Color),
                typeof(ColorPickerUserControl),
                new FrameworkPropertyMetadata(Colors.Black, OnColorChangedCallback));


            var metadata = new FrameworkPropertyMetadata(OnColorRGBChangedCallback)
            {
                
            };
            RedProperty = DependencyProperty.Register("Red", typeof(byte),
                typeof(ColorPickerUserControl),
                metadata, IsColorPickerValid);


            GreenProperty = DependencyProperty.Register("Green", typeof(byte),
                typeof(ColorPickerUserControl),
                new FrameworkPropertyMetadata(OnColorRGBChangedCallback));

            BlueProperty = DependencyProperty.Register("Blue", typeof(byte),
                typeof(ColorPickerUserControl),
                new FrameworkPropertyMetadata(OnColorRGBChangedCallback));

            CommandManager.RegisterClassCommandBinding(typeof(ColorPickerUserControl),
                new CommandBinding(ApplicationCommands.Undo,
                    UndoCommand_Executed, UndoCommand_CanExecute));
        }

       

        private static bool IsColorPickerValid(object value)
        {
            var color = (byte)value;
            return color == 0 || color == 255 || color > 100;
        }


        #region Обертки для свойств зависимостей

        public static DependencyProperty ColorProperty;
        public static DependencyProperty RedProperty;
        public static DependencyProperty GreenProperty;
        public static DependencyProperty BlueProperty;

        public Color Color
        {
            get => (Color)GetValue(ColorProperty);
            set => SetValue(ColorProperty, value);
        }

        public byte Red
        {
            get { return (byte)GetValue(RedProperty); }
            set { SetValue(RedProperty, value); }
        }

        public byte Green
        {
            get => (byte)GetValue(GreenProperty);
            set => SetValue(GreenProperty, value);
        }

        public byte Blue
        {
            get { return (byte)GetValue(BlueProperty); }
            set => SetValue(BlueProperty, value);
        }

        #endregion


        private static void OnColorChangedCallback(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            ColorPickerUserControl colorPicker = (ColorPickerUserControl)sender;

            Color oldColor = (Color)e.OldValue;
            Color newColor = (Color)e.NewValue;
            colorPicker.Red = newColor.R;
            colorPicker.Green = newColor.G;
            colorPicker.Blue = newColor.B;


            colorPicker._previousColor = oldColor;
            colorPicker.OnColorChanged(oldColor, newColor);
        }

        private static void OnColorRGBChangedCallback(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            ColorPickerUserControl colorPicker = (ColorPickerUserControl)sender;
            Color color = colorPicker.Color;

            // Определяем свойство, из-за которого этот метод сработал.
            if (e.Property == RedProperty)
            {
                color.R = (byte)e.NewValue;
            }
            else if (e.Property == GreenProperty)
            {
                color.G = (byte)e.NewValue;
            }
            else if (e.Property == BlueProperty)
            {
                color.B = (byte)e.NewValue;
            }

            colorPicker.Color = color;
        }


        public static readonly RoutedEvent ColorChangedEvent =
            EventManager.RegisterRoutedEvent("ColorChanged", RoutingStrategy.Bubble,
                typeof(RoutedPropertyChangedEventHandler<Color>), typeof(ColorPickerUserControl));

        public event RoutedPropertyChangedEventHandler<Color> ColorChanged
        {
            add => AddHandler(ColorChangedEvent, value);
            remove => RemoveHandler(ColorChangedEvent, value);
        }

        private void OnColorChanged(Color oldValue, Color newValue)
        {
            RoutedPropertyChangedEventArgs<Color> args = new RoutedPropertyChangedEventArgs<Color>(oldValue, newValue);
            args.RoutedEvent = ColorPickerUserControl.ColorChangedEvent;
            RaiseEvent(args);
        }
    }
}