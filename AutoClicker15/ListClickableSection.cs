using System.Configuration;

namespace AutoClicker15
{
    class ListClickableSection:ConfigurationSection
    {
        private static readonly ConfigurationPropertyCollection properties;
        private static readonly ConfigurationProperty list;

        static ListClickableSection()
        {
            list = new ConfigurationProperty(string.Empty, typeof(ClickableElementCollection), null, ConfigurationPropertyOptions.IsRequired | ConfigurationPropertyOptions.IsDefaultCollection);
            properties = new ConfigurationPropertyCollection { list };
        }

        public ClickableElementCollection Lists
        {
            get { return (ClickableElementCollection)base[list]; }
        }

        public new ClickableElement this[string name]
        {
            get { return Lists[name]; }
        }

        protected override ConfigurationPropertyCollection Properties
        {
            get { return properties; }
        }
    }
}
