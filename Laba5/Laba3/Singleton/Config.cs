using System;
using System.Drawing;

namespace Laba2.Singleton
{
    public sealed class Config
    {
        private static readonly Lazy<Config> _instance = new Lazy<Config>(() => new Config(Color.Pink));


        private Config(Color color)
        {
            Color = color;
        }

        public static Config Instance
        {
            get { return _instance.Value; }
        }

        public Color Color { get; private set; }
    }
}