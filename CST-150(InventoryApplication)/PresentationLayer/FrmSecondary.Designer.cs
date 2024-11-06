namespace CST_150_InventoryApplication_.PresentationLayer
{
    partial class FrmSecondary
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gvSearchResults = new DataGridView();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)gvSearchResults).BeginInit();
            SuspendLayout();
            // 
            // gvSearchResults
            // 
            gvSearchResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvSearchResults.Location = new Point(117, 165);
            gvSearchResults.Name = "gvSearchResults";
            gvSearchResults.RowHeadersWidth = 62;
            gvSearchResults.Size = new Size(1271, 308);
            gvSearchResults.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(117, 479);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 34);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // FrmSecondary
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1501, 698);
            Controls.Add(btnClose);
            Controls.Add(gvSearchResults);
            Name = "FrmSecondary";
            Text = "FrmSecondary";
            Load += FrmLoad_EventHandler;
            ((System.ComponentModel.ISupportInitialize)gvSearchResults).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gvSearchResults;
        private Button btnClose;
    }
}