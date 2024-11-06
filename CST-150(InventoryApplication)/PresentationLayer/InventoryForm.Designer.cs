namespace CST_150_InventoryApplication_.PresentationLayer
{
    partial class InventoryForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnShowInventory = new Button();
            btnAddItem = new Button();
            btnSortItems = new Button();
            lblListFunkoInventory = new Label();
            selectFileDialog = new OpenFileDialog();
            dataGridViewInventory = new DataGridView();
            btnIncQty = new Button();
            btnRemoveItem = new Button();
            btnDecQty = new Button();
            button1 = new Button();
            txtSearch = new TextBox();
            cmbSortOptions = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInventory).BeginInit();
            SuspendLayout();
            // 
            // btnShowInventory
            // 
            btnShowInventory.BackColor = Color.DarkSlateGray;
            btnShowInventory.Cursor = Cursors.Hand;
            btnShowInventory.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btnShowInventory.FlatAppearance.BorderSize = 3;
            btnShowInventory.FlatAppearance.MouseDownBackColor = Color.DarkSeaGreen;
            btnShowInventory.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            btnShowInventory.FlatStyle = FlatStyle.Flat;
            btnShowInventory.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnShowInventory.ForeColor = SystemColors.ButtonHighlight;
            btnShowInventory.Location = new Point(750, 869);
            btnShowInventory.Name = "btnShowInventory";
            btnShowInventory.Size = new Size(236, 82);
            btnShowInventory.TabIndex = 0;
            btnShowInventory.Text = "Show Inventory";
            btnShowInventory.UseVisualStyleBackColor = false;
            btnShowInventory.Click += btnShowInventory_Click;
            // 
            // btnAddItem
            // 
            btnAddItem.BackColor = Color.DarkSlateGray;
            btnAddItem.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btnAddItem.FlatAppearance.BorderSize = 3;
            btnAddItem.FlatAppearance.MouseDownBackColor = Color.DarkSeaGreen;
            btnAddItem.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            btnAddItem.FlatStyle = FlatStyle.Flat;
            btnAddItem.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAddItem.ForeColor = SystemColors.Control;
            btnAddItem.Location = new Point(1446, 869);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(202, 83);
            btnAddItem.TabIndex = 2;
            btnAddItem.Text = "Add Item";
            btnAddItem.UseVisualStyleBackColor = false;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // btnSortItems
            // 
            btnSortItems.BackColor = Color.DarkSlateGray;
            btnSortItems.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSortItems.ForeColor = SystemColors.Control;
            btnSortItems.Location = new Point(30, 68);
            btnSortItems.Name = "btnSortItems";
            btnSortItems.Size = new Size(172, 63);
            btnSortItems.TabIndex = 4;
            btnSortItems.Text = "Sort Items";
            btnSortItems.UseVisualStyleBackColor = false;
            btnSortItems.Click += btnSortItems_Click;
            // 
            // lblListFunkoInventory
            // 
            lblListFunkoInventory.AutoSize = true;
            lblListFunkoInventory.BackColor = Color.DarkSlateGray;
            lblListFunkoInventory.Font = new Font("Arial Narrow", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblListFunkoInventory.ForeColor = SystemColors.Control;
            lblListFunkoInventory.Location = new Point(677, 78);
            lblListFunkoInventory.Name = "lblListFunkoInventory";
            lblListFunkoInventory.Size = new Size(360, 62);
            lblListFunkoInventory.TabIndex = 6;
            lblListFunkoInventory.Text = "Funko Inventory";
            // 
            // selectFileDialog
            // 
            selectFileDialog.FileName = "Inventory";
            // 
            // dataGridViewInventory
            // 
            dataGridViewInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInventory.Location = new Point(219, 198);
            dataGridViewInventory.Name = "dataGridViewInventory";
            dataGridViewInventory.RowHeadersWidth = 62;
            dataGridViewInventory.Size = new Size(1262, 492);
            dataGridViewInventory.TabIndex = 10;
            dataGridViewInventory.Click += GridView_ClickEventHandler;
            // 
            // btnIncQty
            // 
            btnIncQty.BackColor = Color.DarkSlateGray;
            btnIncQty.Font = new Font("Arial Narrow", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnIncQty.ForeColor = SystemColors.Control;
            btnIncQty.Location = new Point(423, 158);
            btnIncQty.Name = "btnIncQty";
            btnIncQty.Size = new Size(112, 34);
            btnIncQty.TabIndex = 11;
            btnIncQty.Text = "Inc Qty";
            btnIncQty.UseVisualStyleBackColor = false;
            btnIncQty.Click += BtnIncQty_ClickEventHandler;
            // 
            // btnRemoveItem
            // 
            btnRemoveItem.BackColor = Color.DarkSlateGray;
            btnRemoveItem.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btnRemoveItem.FlatAppearance.BorderSize = 3;
            btnRemoveItem.FlatAppearance.MouseDownBackColor = Color.DarkSeaGreen;
            btnRemoveItem.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            btnRemoveItem.FlatStyle = FlatStyle.Flat;
            btnRemoveItem.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnRemoveItem.ForeColor = Color.White;
            btnRemoveItem.Location = new Point(66, 868);
            btnRemoveItem.Name = "btnRemoveItem";
            btnRemoveItem.Size = new Size(197, 83);
            btnRemoveItem.TabIndex = 12;
            btnRemoveItem.Text = "Remove Item";
            btnRemoveItem.UseVisualStyleBackColor = false;
            btnRemoveItem.Click += btnRemoveItem_Click;
            // 
            // btnDecQty
            // 
            btnDecQty.BackColor = Color.DarkSlateGray;
            btnDecQty.Font = new Font("Arial Narrow", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnDecQty.ForeColor = SystemColors.Control;
            btnDecQty.Location = new Point(295, 158);
            btnDecQty.Name = "btnDecQty";
            btnDecQty.Size = new Size(112, 34);
            btnDecQty.TabIndex = 13;
            btnDecQty.Text = "Dec Qty";
            btnDecQty.UseVisualStyleBackColor = false;
            btnDecQty.Click += btnDecQty_ClickEventHandler;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSlateGray;
            button1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(1550, 81);
            button1.Name = "button1";
            button1.Size = new Size(124, 36);
            button1.TabIndex = 15;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnSearch_ClickEvent;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtSearch.ForeColor = SystemColors.ControlText;
            txtSearch.Location = new Point(1332, 81);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(188, 35);
            txtSearch.TabIndex = 16;
            // 
            // cmbSortOptions
            // 
            cmbSortOptions.FormattingEnabled = true;
            cmbSortOptions.Location = new Point(30, 137);
            cmbSortOptions.Name = "cmbSortOptions";
            cmbSortOptions.Size = new Size(172, 33);
            cmbSortOptions.TabIndex = 17;
            // 
            // InventoryForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1709, 989);
            Controls.Add(cmbSortOptions);
            Controls.Add(txtSearch);
            Controls.Add(button1);
            Controls.Add(btnDecQty);
            Controls.Add(btnRemoveItem);
            Controls.Add(btnIncQty);
            Controls.Add(lblListFunkoInventory);
            Controls.Add(btnSortItems);
            Controls.Add(btnAddItem);
            Controls.Add(btnShowInventory);
            Controls.Add(dataGridViewInventory);
            Name = "InventoryForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewInventory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnShowInventory;
        private Button btnAddItem;
        private Button btnSortItems;
        private Label lblListFunkoInventory;
        private OpenFileDialog selectFileDialog;
        private DataGridView dataGridViewInventory;
        private Button btnIncQty;
        private Button btnRemoveItem;
        private Button btnDecQty;
        private Button button1;
        private TextBox txtSearch;
        private ComboBox cmbSortOptions;
    }
}