/*
 * Aiden Vargas
 * CST-150 milestone 7
 * 11/3/2024
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST_150_InventoryApplication_.Models
{


    public class InvItem
    {
        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="description"></param>
        /// <param name="qty"></param>
        /// <param name="price"></param>
        /// <param name="condition"></param>
        /// <param name="releaseDate"></param>
        public InvItem(string description, int qty, decimal price, string condition, DateTime releaseDate, string series, string signedAutograph, string type)
        {
            Description = description;
            Qty = qty;
            Price = price;
            Condition = condition;
            ReleaseDate = releaseDate; // Store release date as DateTime
            Series = series;
            SignedAutograph = signedAutograph;
            Type = type;

        }

        // Properties
        public string Description { get; set; }
        public int Qty { get; set; }
        public decimal Price { get; set; }
        public string Condition { get; set; }
        public DateTime ReleaseDate { get; set; } // Updated to DateTime
        public string Series { get; set; } // New property
        public string SignedAutograph { get; set; } // New property
        public string Type { get; set; } // New property
    }
}





