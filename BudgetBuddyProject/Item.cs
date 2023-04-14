using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Financial_Assisstance
{
    [Serializable]
    public class Item
    {
        /*
         * This represents the items to appear in options
         */

        /// <summary>
        /// Desciptive name of the item
        /// </summary>
        [JsonRequired]
        private string name;

        /// <summary>
        /// cost of the item
        /// </summary>
        [JsonRequired]
        private double cost;

        /// <summary>
        /// Quantity of the product.
        /// For computations of total cost outside the class.
        /// The object's cost will remain unaffected and will represent the cost of 1 qty.
        /// </summary>
        [JsonRequired]
        private int quantity;

        /// <summary>
        /// The Date to when the item is bought.
        /// </summary>
        [JsonRequired]
        public DateTime DateBought { get; private set; } //* public methods/attrib = pascal case, private = camel

        // properties
        [JsonIgnore]
        public string Name
        {
            get => this.name;
            set => this.name = value;
        }

        [JsonIgnore]
        public double Cost
        {
            get => this.cost;
            set => this.cost = value;
        }

        [JsonIgnore]
        public int Quantity
        {
            get => this.quantity;
            set => this.quantity = value;
        }

        /// <summary>
        /// keywords used for filtering
        /// </summary>
        [JsonRequired]
        private HashSet<string> tags;

        /// <summary>
        /// constructor for the item class
        /// </summary>
        /// <param name="name">name of the item</param>
        /// <param name="cost">cost of the item (1qty)</param>
        /// <param name="quantity">quantity of the item</param>
        public Item(string name, double cost, int quantity)
        {
            this.name = name;
            this.cost = cost;
            this.quantity = quantity;
            this.tags = new HashSet<string>();
            this.DateBought = DateTime.Now;
        }

        /// <summary>
        /// adds a tag, which is a keyword used for filtering
        /// </summary>
        /// <param name="tag">a keyword associated with the item</param>
        public void AddTag(string tag)
        {
            this.tags.Add(tag);
        }

        /// <summary>
        /// removes a tag, which is a keyword used for filtering
        /// </summary>
        /// <param name="tag">a keyword associated with the item</param>
        public void RemoveTag(string tag)
        {
            this.tags.Remove(tag);
        }

        /// <summary>
        /// Creates a new List<string> object from the tags list property.
        /// Ensures that callers of the Tags method cannot modify the contents of the tags list property directly, but only access it in a read-only manner.
        /// </summary>
        /// <returns></returns>
        public IReadOnlyList<string> Tags()
        {
            return this.tags.ToList().AsReadOnly();
        }

        public override string ToString()
        {
            return $"{this.name}\nTotal Cost: {this.cost * this.quantity}\n\tP{this.cost} x {this.quantity}qty\nTags: {string.Join(", ", this.tags)}";
        }
    }
}
