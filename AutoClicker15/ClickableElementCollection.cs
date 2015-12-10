using System.Configuration;

namespace AutoClicker15
{
    class ClickableElementCollection : ConfigurationElementCollection
    {
        public override ConfigurationElementCollectionType CollectionType
        {
            get { return ConfigurationElementCollectionType.BasicMap; }
        }

        protected override string ElementName
        {
            get{ return "Clickable"; }
        }

        protected override ConfigurationPropertyCollection Properties
        {
            get { return new ConfigurationPropertyCollection(); }
        }

        public ClickableElement this[int index]
        {
            get { return (ClickableElement)BaseGet(index); }
            set
            {
                if(BaseGet(index)!=null)
                {
                    BaseRemoveAt(index);
                }
                BaseAdd(index, value);
            }
        }

        public new ClickableElement this[string name]
        {
            get { return (ClickableElement)BaseGet(name); }
        }

        public void Add(ClickableElement item)
        {
            BaseAdd(item);
        }

        public void Remove(ClickableElement item)
        {
            BaseRemove(item);
        }

        public void RemoveAt(int index)
        {
            BaseRemoveAt(index);
        }

        public void Clear()
        {
            BaseClear();
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new ClickableElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((ClickableElement)element).Name;
        }
    }
}
