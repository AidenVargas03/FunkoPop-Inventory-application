/*
 * Aiden Vargas
 * CST-150 Milestone 7
 * 11/3/2024
 */
using CST_150_InventoryApplication_.BusinessLayer;
using CST_150_InventoryApplication_.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_150_InventoryApplication_.PresentationLayer
{


    public partial class InventoryForm : Form
    {
        // Create the class level object
        // This is called an inventory reference variable
        // This is our master inventory object that MUST
        // always contain the most update-to-date inventory
        List<InvItem> invItems = new List<InvItem>();
        // List that will hhold all items found for search
        List<InvItem> invSearch = new List<InvItem>();

        // Properties
        private int SelectedGridIndex { get; set; }

        public InventoryForm()
        {
            InitializeComponent();
            // Assuming dataGridViewInventory is your DataGridView's name
            dataGridViewInventory.CellValueChanged += DataGridViewInventory_CellValueChanged;

            // Set to not visible until the show inventory button is clicked
            dataGridViewInventory.Visible = false;
            btnIncQty.Visible = false;
            btnDecQty.Visible = false;

            cmbSortOptions.Items.Add("Name A-Z");
            cmbSortOptions.Items.Add("Name Z-A");
            cmbSortOptions.Items.Add("Lowest Price");
            cmbSortOptions.Items.Add("Highest Price");



        }


        /// <summary>
        /// dataGrid view, update the text file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridViewInventory_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Update the text file with the latest inventory data
            UpdateInventoryFile();
        }

        private void UpdateInventoryFile()
        {
            string filePath = "inventory.txt"; // Specify the path to your file

            using (StreamWriter writer = new StreamWriter(filePath, false))
            {
                foreach (var item in invItems)
                {
                    // Customize the line format as needed; here’s an example format:
                    writer.WriteLine($"{item.Description},{item.Qty},{item.Price},{item.Condition},{item.ReleaseDate}");
                }
            }
        }
        /// <summary>
        /// Populate the grid when the form loads
        /// use this event handler to "Bind a DataGrid
        /// control to List of Objects.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowInventory_Click(object sender, EventArgs e)
        {
            // Isntant the business class and get all the inventory items
            // from the text file.
            Inventory readInv = new Inventory();
            invItems = readInv.ReadInventory(invItems);

            // After the list has been populated, set the DataSource Property
            // of the DataGrid control to the list.
            dataGridViewInventory.DataSource = null;
            dataGridViewInventory.DataSource = invItems;

            // What if we do not like the names in the header of the GridView?
            // Let's iterate through the header one column at a time
            // and change the header names.
            foreach (DataGridViewColumn column in dataGridViewInventory.Columns)
            {
                // Switch to change header text
                // column.Index starts at 0 - end count.
                switch (column.Index)
                {
                    case 0:
                        column.HeaderText = "Description";
                        break;
                    case 1:
                        column.HeaderText = "Quantity";
                        column.DefaultCellStyle.Format = "N0";
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        break;
                    case 2:
                        column.HeaderText = "Price";
                        column.DefaultCellStyle.Format = "C2"; // Currency format with 2 decimal places
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        break;
                    case 3:
                        column.HeaderText = "Condition";
                        break;
                    case 4:
                        column.HeaderText = "Release Date";
                        column.DefaultCellStyle.Format = "MM/dd/yyyy";
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case 5:
                        column.HeaderText = "Series";
                        break;
                    case 6:
                        column.HeaderText = "Sign AutoGraphed";
                        break;
                    case 7:
                        column.HeaderText = "Type";
                        break;
                    default:
                        // Show a message indicating something did not work correctly.
                        MessageBox.Show("Invalid column was trying to be accessed!");
                        // C# requires a closing break
                        break;
                }
            }

            dataGridViewInventory.Visible = true;
            btnIncQty.Visible = true;
            btnDecQty.Visible = true;
        }
        /// <summary>
        /// Event Handler to manage click events of data Grid View
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridView_ClickEventHandler(object sender, EventArgs e)
        {
            // Get the selected row
            SelectedGridIndex = dataGridViewInventory.CurrentRow.Index;
            // Now we also know the index into the List to get all our info
        }

        /// <summary>
        /// Event Handler to manage button to increament quantity
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnIncQty_ClickEventHandler(object sender, EventArgs e)
        {
            // Make sure the logic is not in the presentation layer so
            // inc qty in Inventory class.
            // Instatiate the inventory class so we can use the inc qty method
            Inventory incQty = new Inventory();
            // Invoke this method to inc qty and get the master List back
            invItems = incQty.IncQtyValue(invItems, SelectedGridIndex);
            // Since the List contains the master Inventory
            // refresh the data in the DataGridView
            // SInce we have already bound the List to the Data Grid View
            dataGridViewInventory.Refresh();
            dataGridViewInventory.DataSource = null;
            dataGridViewInventory.DataSource = invItems;

            // Write the updated inventory back to the text file
            incQty.WriteInventoryToFile(invItems);
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            // Instantiate Inventory class and remove selected item
            Inventory inventory = new Inventory();
            invItems = inventory.RemoveSelectedItem(invItems, SelectedGridIndex);

            // Update DataGridView
            dataGridViewInventory.DataSource = null;
            dataGridViewInventory.DataSource = invItems;

            // Write updated list to file
            inventory.WriteInventoryToFile(invItems);
        }

        private void btnDecQty_ClickEventHandler(object sender, EventArgs e)
        {
            Inventory DecQty = new Inventory();
            if (SelectedGridIndex >= 0 && invItems[SelectedGridIndex].Qty > 0)
            {
                invItems[SelectedGridIndex].Qty--;
                dataGridViewInventory.Refresh();
                dataGridViewInventory.DataSource = null;
                dataGridViewInventory.DataSource = invItems;
            }

            // Write the updated inventory back to the text file
            DecQty.WriteInventoryToFile(invItems);
        }

        /// <summary>
        /// Event Handler for the add item button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            // Create a new item object with sample data or prompt user for input
            InvItem newItem = new InvItem(
                "New Item",     // Description
                1,              // Quantity
                0.0m,           // Price
                "New",          // Condition
                DateTime.Today,  // Release Date
                "Series Name",  // Series (new field)
                "No",   // Signed Autograph (new field)
                "Type"          // Type (new field)
            );

            // Add the new item to the inventory list
            invItems.Add(newItem);

            // Re-bind the updated list to the DataGridView
            var updatedSource = new BindingList<InvItem>(invItems);
            dataGridViewInventory.DataSource = updatedSource;

            // Refresh the grid to ensure display updates
            dataGridViewInventory.Refresh();

            // Write the updated inventory to the text file
            Inventory inventory = new Inventory();
            inventory.WriteInventoryToFile(invItems);
        }

        /// <summary>
        /// Search Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_ClickEvent(object sender, EventArgs e)
        {
            // Our goal is to read from the textbox and search the
            // list in the Type Column for a match. If there is
            // match or multiple matches then we show the match(s)
            // in the gridview on the secondary form.
            string searchFor = txtSearch.Text;
            // Since the searching is logic - we need to do this
            // in the business Layer.
            Inventory businessLayer = new Inventory();
            // Search for the match and put results in the search list
            invSearch = businessLayer.SearchItem(invItems, invSearch, searchFor);
            // Send this invSearch over to the secondary form to be displayed.
            // Check if any items were found
            if (invSearch.Count > 0)
            {
                // Pass the search results to FrmSecondary and show it
                FrmSecondary secondaryForm = new FrmSecondary(invSearch);
                secondaryForm.ShowDialog(); // Open as modal
            }
            else
            {
                MessageBox.Show("No matching items found.");
            }
        }

        /// <summary>
        ///  For reading the inventory
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public List<InvItem> ReadInventoryFromFile(string filePath)

        {
            List<InvItem> items = new List<InvItem>();


            // Read all lines from the file
            var lines = File.ReadAllLines(filePath);

            foreach (var line in lines)
            {
                var parts = line.Split(',');

                if (parts.Length == 8) // Ensure that all parts are present
                {
                    items.Add(new InvItem(
                        parts[0],                                  // Description
                        int.Parse(parts[1]),                      // Quantity
                        decimal.Parse(parts[2]),                  // Price
                        parts[3],                                  // Condition
                        DateTime.Parse(parts[4]),                 // Release Date
                        parts[5],                                  // Series
                        parts[6],                                  // Signed Autograph
                        parts[7]                                   // Type
                    ));
                }
            }
            return items;
        }

        /// <summary>
        ///  For sorting items event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSortItems_Click(object sender, EventArgs e)
        {
            if (cmbSortOptions.SelectedItem == null)
            {
                MessageBox.Show("Please select a sort option.");
                return;
            }

            string sortOption = cmbSortOptions.SelectedItem.ToString();

            // Sort based on the selected option using invItems
            switch (sortOption)
            {
                case "Name A-Z":
                    invItems = invItems.OrderBy(i => i.Description).ToList();
                    break;
                case "Name Z-A":
                    invItems = invItems.OrderByDescending(i => i.Description).ToList();
                    break;
                case "Lowest Price":
                    invItems = invItems.OrderBy(i => i.Price).ToList();
                    break;
                case "Highest Price":
                    invItems = invItems.OrderByDescending(i => i.Price).ToList();
                    break;
                default:
                    MessageBox.Show("Invalid sort option.");
                    return;
            }

            // Update DataGridView
            dataGridViewInventory.DataSource = null; // Clear previous binding
            dataGridViewInventory.DataSource = invItems; // Bind sorted data
        }


    }

}




