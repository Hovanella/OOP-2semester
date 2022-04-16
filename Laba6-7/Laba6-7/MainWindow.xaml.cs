using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using Laba6_7.Products;
using Microsoft.Win32;
using Newtonsoft.Json;

namespace Laba6_7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ObservableCollection<Product> items;

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

            //bind CustomCommand to button
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
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
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

            var ChangedProduct = new Product(NameTextBox.Text, type, fotoUrl, RedactorDescriptionTextBox.Text, (int)RedactorCostSlider.Value);

            items.RemoveAt(itemNumberInCollection);
            items.Insert(itemNumberInCollection, ChangedProduct);
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

            var newProduct = new Product(NameTextBox.Text, type, fotoUrl, RedactorDescriptionTextBox.Text, (int)RedactorCostSlider.Value);

            items.Add(newProduct);
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            var searchingCost = (int)ShopCostSlider.Value;

            AnimalType animalType;
            if (CatRadioButton.IsChecked == true) animalType = AnimalType.Cat;
            else if (TortoiseRadioButton.IsChecked == true) animalType = AnimalType.Tortoise;
            else animalType = AnimalType.Dog;

            var description = ShopDescriptionTextBox.Text;

            var filteredItems = items.Where(x => x.Cost <= searchingCost && x.AnimalType == animalType && x.Description.Contains(description));

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

            var englishLanguageResource = Application.Current.Resources.MergedDictionaries.FirstOrDefault(x => x.Source == new Uri("Resources/Languages/English.xaml", UriKind.Relative));

            var russianLanguageResource = Application.Current.Resources.MergedDictionaries.FirstOrDefault(x => x.Source == new Uri("Resources/Languages/Russian.xaml", UriKind.Relative));

            if (englishLanguageResource != null)
            {
                Application.Current.Resources.MergedDictionaries.Remove(englishLanguageResource);
            }
            else
            {
                if (russianLanguageResource != null) Application.Current.Resources.MergedDictionaries.Remove(russianLanguageResource);
            }

            Application.Current.Resources.MergedDictionaries.Add(newLanguageResource);
        }
    }
}