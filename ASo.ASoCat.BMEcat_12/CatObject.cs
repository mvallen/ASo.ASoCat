
using System.Collections.Generic;
//using System.Linq.Expressions;

namespace ASo.ASoCat.BMEcat_12
{
    /// <summary>
    /// CatObject is the base class from which all other catalog classes are derived.
    /// </summary>
    internal class CatObject
    {
        /// <summary>
        /// Object's unique identifier.
        /// </summary>
        // ReSharper disable once NotAccessedField.Local
        private readonly int _identifier;

        /// <summary>
        /// List of CatObject's attributes.
        /// </summary>
        internal List<Attribute> Attributes;

        /// <summary>
        /// The constructor sets CatObject's identifier.
        /// </summary>
        /// <param name="pIdentifier">CatObject's identifier.</param>
        public CatObject(int pIdentifier)
        {
            _identifier = pIdentifier;
        }

        /// <summary>
        /// Read CatObject's data.
        /// </summary>
        public virtual void Read()
        {
            if (!Globals.ObjectReader.HasAttributes) 
                return;
            Attributes = new List<Attribute>();
            for (var x = 0; x < Globals.ObjectReader.AttributeCount - 1; x++)
            {
                Globals.ObjectReader.MoveToAttribute(x);
                var attribute = new Attribute();
                attribute.Name  = Globals.ObjectReader.Name;
                attribute.Value = Globals.ObjectReader.Value;
                Attributes.Add(attribute);
            }
            Globals.ObjectReader.MoveToElement();
        }
    }
}
