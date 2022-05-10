using Laba6_7.Products;
using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Laba6_7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Product> items;

        private readonly List<ObservableCollection<Product>> _mementos = new();
        private int cursor = 0;

        public MainWindow()
        {
            // get project direcry
            string projectDir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;

            //combine projectDir and Cursor.cur
            string cursorPath = Path.Combine(projectDir, "Cursor.cur");

            string iconPath = Path.Combine(projectDir, "icon.png");

            Icon = new BitmapImage((new Uri(iconPath)));
            Cursor = new Cursor(cursorPath);

            InitializeComponent();
            this.items = new ObservableCollection<Product>()
            {
                new Product("Lulu", AnimalType.Cat,
                    @"d:\Education\Semestr4\OOP\MyLabs\Laba6-7\Laba6-7\Products\Animals\AnimalFotos\external-content.duckduckgo.com.jpg",
                    "Классный котик - мягкий животик", 100)
            };

            ProductsDataGrid.ItemsSource = items;
            ShopDataGrid.ItemsSource = items;

            _mementos.Add(new ObservableCollection<Product>(items));

        }

        private void CostSlider_OnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ShopCostTextBlock.Text = "Цена :  " + (int)ShopCostSlider.Value;
        }

        private void RedactorCostSlider_OnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            RedactorCostTextBlock.Text = "Цена :  " + (int)RedactorCostSlider.Value;
        }

        private void OpenExplorerButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter =
                "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (openFileDialog.ShowDialog() == true)
            {
                //set img url to img
                AnimalImage.Source = new BitmapImage(new System.Uri(openFileDialog.FileName));
            }
        }

        private void LoadButton_Click(object sender, RoutedEventArgs e)
        {
            using var reader = new StreamReader(@"../../../Files/Products.json");
            var json = reader.ReadToEnd();

            var serailizedItems = JsonConvert.DeserializeObject<List<Product>>(json);
            foreach (var serailizedItem in serailizedItems)
            {
                items.Add(serailizedItem);
            }

            _mementos.Add(new ObservableCollection<Product>(items));
            cursor++;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            var items = ProductsDataGrid.ItemsSource;
            var serializer = new JsonSerializer();
            using var sw = new StreamWriter(@"../../../Files/Products.json");
            string jsonString = JsonConvert.SerializeObject(items);
            sw.Write(jsonString);

        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = ProductsDataGrid.SelectedItem;
            if (selectedItem != null)
            {
                items.Remove(selectedItem as Product);
            }

            _mementos.Add(new ObservableCollection<Product>(items));
            cursor++;
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = ProductsDataGrid.SelectedItem;
            if (selectedItem == null) return;
            var itemNumberInCollection = items.IndexOf(selectedItem as Product);
            if (itemNumberInCollection == -1) return;

            var type = TypeComboBox.SelectedIndex switch
            {
                0 => AnimalType.Cat,
                1 => AnimalType.Tortoise,
                2 => AnimalType.Dog,
                _ => AnimalType.Cat
            };

            string fotoUrl = AnimalImage.Source != null ? AnimalImage.Source.ToString() : "";

            var ChangedProduct = new Product(NameTextBox.Text, type, fotoUrl, RedactorDescriptionTextBox.Text,
                (int)RedactorCostSlider.Value);

            items.RemoveAt(itemNumberInCollection);
            items.Insert(itemNumberInCollection, ChangedProduct);


            _mementos.Add(new ObservableCollection<Product>(items));
            cursor++;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            var type = TypeComboBox.SelectedIndex switch
            {
                0 => AnimalType.Cat,
                1 => AnimalType.Tortoise,
                2 => AnimalType.Dog,
                _ => AnimalType.Cat
            };

            string fotoUrl = AnimalImage.Source != null ? AnimalImage.Source.ToString() : "";

            var newProduct = new Product(NameTextBox.Text, type, fotoUrl, RedactorDescriptionTextBox.Text,
                (int)RedactorCostSlider.Value);

            items.Add(newProduct);


            _mementos.Add(new ObservableCollection<Product>(items));
            cursor++;
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            var searchingCost = (int)ShopCostSlider.Value;

            AnimalType animalType;
            if (CatRadioButton.IsChecked == true) animalType = AnimalType.Cat;
            else if (TortoiseRadioButton.IsChecked == true) animalType = AnimalType.Tortoise;
            else animalType = AnimalType.Dog;

            var description = ShopDescriptionTextBox.Text;

            var filteredItems = items.Where(x =>
                x.Cost <= searchingCost && x.AnimalType == animalType && x.Description.Contains(description));

            ShopDataGrid.ItemsSource = filteredItems;
        }

        private void LanguageButton_Click(object sender, RoutedEventArgs e)
        {
            var buttonName = (sender as Button).Name;

            var sourceUri = buttonName switch
            {
                "EnglishButton" => new Uri("Resources/Languages/English.xaml", UriKind.Relative),
                "RussianButton" => new Uri("Resources/Languages/Russian.xaml", UriKind.Relative),
                _ => new Uri("Resources/Languages/English.xaml", UriKind.Relative),
            };
            if (Application.Current.Resources.MergedDictionaries.FirstOrDefault(x => x.Source == sourceUri) != null)
            {
                return;
            }

            var newLanguageResource = new ResourceDictionary() { Source = sourceUri };

            var englishLanguageResource = Application.Current.Resources.MergedDictionaries.FirstOrDefault(x =>
                x.Source == new Uri("Resources/Languages/English.xaml", UriKind.Relative));

            var russianLanguageResource = Application.Current.Resources.MergedDictionaries.FirstOrDefault(x =>
                x.Source == new Uri("Resources/Languages/Russian.xaml", UriKind.Relative));

            if (englishLanguageResource != null)
            {
                Application.Current.Resources.MergedDictionaries.Remove(englishLanguageResource);
            }
            else
            {
                if (russianLanguageResource != null)
                    Application.Current.Resources.MergedDictionaries.Remove(russianLanguageResource);
            }

            Application.Current.Resources.MergedDictionaries.Add(newLanguageResource);
        }

        private void ThemeButton_Click(object sender, RoutedEventArgs e)
        {
            var themeButton = (sender as Button);

            if (themeButton.Content.ToString() == "DarkThemeButton")
            {
                themeButton.Content = "LightThemeButton";

                var lightThemeResource = new ResourceDictionary()
                { Source = new Uri("Resources/Style/Themes/LightTheme.xaml", UriKind.Relative) };

                var oldTheme = Application.Current.Resources.MergedDictionaries.FirstOrDefault(x =>
                    x.Source == new Uri("Resources/Style/Themes/DarkTheme.xaml", UriKind.Relative));
                Application.Current.Resources.MergedDictionaries.Remove(oldTheme);


                Application.Current.Resources.MergedDictionaries.Add(lightThemeResource);
            }
            else
            {
                themeButton.Content = "DarkThemeButton";

                var darkThemeResource = new ResourceDictionary()
                { Source = new Uri("Resources/Style/Themes/DarkTheme.xaml", UriKind.Relative) };

                //delete old theme
                var oldTheme = Application.Current.Resources.MergedDictionaries.FirstOrDefault(x =>
                    x.Source == new Uri("Resources/Style/Themes/LightTheme.xaml", UriKind.Relative));
                Application.Current.Resources.MergedDictionaries.Remove(oldTheme);

                Application.Current.Resources.MergedDictionaries.Add(darkThemeResource);
            }
        }

        private void cmdGet_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(colorPicker.Color.ToString());
        }

        private void cmdSet_Click(object sender, RoutedEventArgs e)
        {
            colorPicker.Color = Colors.Beige;
        }

        private void colorPicker_ColorChanged(object sender, RoutedPropertyChangedEventArgs<Color> e)
        {
            if (lblColor != null)
            {
                lblColor.Text = "The new color is " + e.NewValue.ToString();
            }
        }

        private void UndoButton_Click(object sender, ExecutedRoutedEventArgs e)
        {
            if (cursor == 0) return;


            cursor--;
            items = new ObservableCollection<Product>(_mementos[cursor]);
            ProductsDataGrid.ItemsSource = items;
        }


        private void RedoButton_Click(object sender, ExecutedRoutedEventArgs e)
        {
            if (cursor == _mementos.Count - 1) return;

            cursor++;
            items = new ObservableCollection<Product>(_mementos[cursor]);
            ProductsDataGrid.ItemsSource = items;
        }



        private void Control2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            textBlock2.Text = textBlock2.Text + "sender: " + sender.ToString() + " ";
            textBlock2.Text = textBlock2.Text + "source: " + e.Source.ToString() + " ";
            textBlock2.Text += "\n";
        }

        private void Control3_MouseDown(object sender, MouseButtonEventArgs e)
        {
            textBlock3.Text = textBlock3.Text + "sender: " + sender.ToString() + " ";
            textBlock3.Text = textBlock3.Text + "source: " + e.Source.ToString() + " ";        
            textBlock3.Text += "\n";
        }
    }
}