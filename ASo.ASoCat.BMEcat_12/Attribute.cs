namespace ASo.ASoCat.BMEcat_12
{
    class Attribute
    {
        /// <summary>
        /// Attribute's name.
        /// </summary>
        private string _name;

        /// <summary>
        /// Attribute's value.
        /// </summary>
        private string _value;

        /// <summary>
        /// Attribute's name.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// Attribute's value.
        /// </summary>
        public string Value
        {
            get { return _value; }
            set { _value = value; }
        }
    }
}
