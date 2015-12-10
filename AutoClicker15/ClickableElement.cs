using System.Configuration;

namespace AutoClicker15
{
    class ClickableElement:ConfigurationElement
    {
        private static readonly ConfigurationPropertyCollection properties;
        private static readonly ConfigurationProperty name;
        private static readonly ConfigurationProperty posX;
        private static readonly ConfigurationProperty posY;
        private static readonly ConfigurationProperty width;
        private static readonly ConfigurationProperty height;

        static ClickableElement()
        {
            name = new ConfigurationProperty("name", typeof(string), null, ConfigurationPropertyOptions.IsKey);
            posX = new ConfigurationProperty("posX", typeof(int), null, ConfigurationPropertyOptions.IsRequired);
            posY = new ConfigurationProperty("posX", typeof(int), null, ConfigurationPropertyOptions.IsRequired);
            width = new ConfigurationProperty("posX", typeof(int), null, ConfigurationPropertyOptions.None);
            height = new ConfigurationProperty("posX", typeof(int), null, ConfigurationPropertyOptions.None);
        }

        public string Name
        {
            get { return (string)this["name"];}
            set { this["name"] = value; }
        }

        public int PosX
        {
            get { return (int)this["posX"]; }
            set { this["posX"] = value; }
        }

        public int PosY
        {
            get { return (int)this["posY"]; }
            set { this["posY"] = value; }
        }

        public int Width
        {
            get { return (int)this["width"]; }
            set { this["width"] = value; }
        }

        public int Height
        {
            get { return (int)this["height"]; }
            set { this["height"] = value; }
        }

        protected override ConfigurationPropertyCollection Properties
        {
            get { return properties; }
        }
    }
}
