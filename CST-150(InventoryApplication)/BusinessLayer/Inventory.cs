/*
 * Aiden Vargas
 * CST-150 milestone 7
 * 11/3/2024
 */
using CST_150_InventoryApplication_.Models;
using System;
using System.Collections.Generic;
using System.Formats.Tar;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace CST_150_InventoryApplication_.BusinessLayer
{
    internal class Inventory
    {

        // Store the list of inventory items
        private List<InvItem> invItems;

        public Inventory()
        {
            invItems = new List<InvItem>(); // Initialize the list
        }
        // The purpose of this class is to read the text file into a List
        // Then pass the list to the FrmInventory.cs.
        /// <summary>
        ///  Read the inventory text file and return a list of InvItems class
        /// </summary>
        public List<InvItem> ReadInventory(List<InvItem> invItems)
        {
            // Location of the text file to open
            string dirLoc = Application.StartupPath + "\\Data\\Inventory.txt";

            try
            {
                // Open the file and read each line
                foreach (string line in File.ReadLines(dirLoc, Encoding.UTF8))
                {
                    // Trim whitespace and split each line by comma
                    string[] rowData = line.Trim().Split(',');

                    // Validate the correct number of fields for each item (5 fields)
                    if (rowData.Length == 8)
                    {
                        try
                        {
                            // Parse and trim each field accordingly
                            string description = rowData[0].Trim();
                            int qty = int.Parse(rowData[1].Trim());
                            decimal price = decimal.Parse(rowData[2].Trim());
                            string condition = rowData[3].Trim();
                            DateTime releaseDate = DateTime.Parse(rowData[4].Trim()); // Parse release date as DateTime
                            string series = rowData[5].Trim();
                            string signedAutograph = rowData[6].Trim();
                            string type = rowData[7].Trim();

                            // Add to the list
                            invItems.Add(new InvItem(description, qty, price, condition, releaseDate, series, signedAutograph, type));
                        }
                        catch (FormatException ex)
                        {
                            MessageBox.Show($"Error parsing line: '{line}'.\nDetails: {ex.Message}");
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Invalid format in line: '{line}'");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading file: {ex.Message}");
            }
            return invItems;
        }

        // Method to increment the quantity value of an item
        public List<InvItem> IncQtyValue(List<InvItem> invItems, int selectedRowIndex)
        {
            int updatedQty = ++invItems[selectedRowIndex].Qty;
            invItems[selectedRowIndex].Qty = updatedQty;
            return invItems;
        }

        // Method to remove selected item from the list
        public List<InvItem> RemoveSelectedItem(List<InvItem> invItems, int selectedRowIndex)
        {
            if (selectedRowIndex >= 0 && selectedRowIndex < invItems.Count)
            {
                invItems.RemoveAt(selectedRowIndex); // Remove item from list
            }
            return invItems;
        }

        // Method to add a new item to the list
        public List<InvItem> AddNewItem(List<InvItem> invItems, InvItem newItem)
        {
            if (newItem != null)
            {
                invItems.Add(newItem); // Add new item to list
            }
            return invItems;
        }

        /// <summary>
        /// Search the item in the main Inventory List and return the New Search List
        /// </summary>
        /// <param name="invItems"></param>
        // Writes the current inventory list to the file
        public void WriteInventoryToFile(List<InvItem> invItems)
        {
            string dirLoc = Application.StartupPath + "\\Data\\Inventory.txt";

            try
            {
                // Open a StreamWriter to overwrite the file with the updated inventory list
                using (StreamWriter writer = new StreamWriter(dirLoc, false))
                {
                    // Write each item in the inventory to a new line in the file
                    foreach (var item in invItems)
                    {
                        writer.WriteLine($"{item.Description},{item.Qty},{item.Price},{item.Condition},{item.ReleaseDate:MM/dd/yyyy},{item.Series},{item.SignedAutograph},{item.Type}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error writing to file: {ex.Message}");
            }
        }

        public List<InvItem> SearchItem(List<InvItem> invItems, List<InvItem> invSearch, string searchCriteria)
        {
            // Make sure the invSearch List is cleared before we start.
            invSearch.Clear();
            // Now Iterate over the main inventory and see if can find
            // any matches to the search criteria
            foreach (InvItem item in invItems)
            {
                if (item.Type.ToLower().Contains(searchCriteria.ToLower()) ||
        item.Qty.ToString().Contains(searchCriteria) ||
        item.SignedAutograph.ToString().Contains(searchCriteria) ||
        item.Series.ToString().Contains(searchCriteria) ||
        item.Price.ToString().Contains(searchCriteria) ||
        item.Description.ToLower().Contains(searchCriteria.ToLower()) ||
        item.Condition.ToLower().Contains(searchCriteria.ToLower()))
                {
                    // If an item was found add it to the list
                    invSearch.Add(item);
                }
            }
            // Return the end results of the search
            return invSearch;
        }

        // Load items from a text file
        public void LoadItemsFromFile(string filePath)
        {
            try
            {
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    var parts = line.Split(',');
                    if (parts.Length == 8)
                    {
                        // Parse the line into an InvItem
                        var item = new InvItem(
                            parts[0], // Description
                            int.Parse(parts[1]), // Quantity
                            decimal.Parse(parts[2]), // Price
                            parts[3], // Condition
                            DateTime.Parse(parts[4]), // ReleaseDate
                            parts[5], // Series
                            parts[6], // SignedAutograph
                            parts[7]  // Type
                        );
                        invItems.Add(item); // Add item to the list
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any errors during file reading
                Console.WriteLine("Error loading items: " + ex.Message);
            }
        }

        

    }
}


