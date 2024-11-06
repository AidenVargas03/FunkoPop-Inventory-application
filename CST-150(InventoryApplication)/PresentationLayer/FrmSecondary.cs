/*
 * Aiden Vargas
 * CST-150 Milestone 7
 * 11/3/2024
 */
using CST_150_InventoryApplication_.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_150_InventoryApplication_.PresentationLayer
{
    public partial class FrmSecondary : Form
    {
        // Class level List
        List<InvItem> mySearch = new List<InvItem>();

        /// <summary>
        ///  When the form is loaded populate the grid
        /// </summary>
        /// <param name="invSearch"></param>
        public FrmSecondary(List<InvItem> invSearch)
        {
            InitializeComponent();

            this.mySearch = invSearch;
        }

        /// <summary>
        /// When the form is loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmLoad_EventHandler(object sender, EventArgs e)
        {
            if (mySearch != null && mySearch.Count > 0)
            {
                gvSearchResults.DataSource = mySearch;
            }
            else
            {
                MessageBox.Show("No Search results to display.");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();  // Closes the form and returns to the main form
        }
    }
}
