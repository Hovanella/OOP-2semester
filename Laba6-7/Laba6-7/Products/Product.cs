using System;

namespace Laba6_7.Products
{
    internal class Product
    {
        private string _name;
        private AnimalType _animalType;
        private string _animalTypeString;
        private string _FotoUrl;
        private string _description;
        private int _cost;
        private Guid _id;


        public Product(string name, AnimalType animalType, string fotoUrl, string description, int cost)
        {
            Name = name;
            _animalType = animalType;

            switch (_animalType)
            {
                case AnimalType.Cat: AnimalTypeString = "Кот"; break;
                case AnimalType.Dog: AnimalTypeString = "Собака"; break;
                case AnimalType.Tortoise: AnimalTypeString = "Черепаха"; break;
            }

            FotoUrl = fotoUrl;
            Description = description;
            Cost = cost;
            Id = new Guid();
        }

        public string Name { get => _name; set => _name = value; }
        public string FotoUrl { get => _FotoUrl; set => _FotoUrl = value; }
        public string Description { get => _description; set => _description = value; }
        public int Cost { get => _cost; set => _cost = value; }
        public Guid Id { get => _id; set => _id = value; }
        public string AnimalTypeString { get => _animalTypeString; set => _animalTypeString = value; }

        public AnimalType AnimalType
        {
            get => _animalType;
            set => _animalType = value;
        }
    }
}
