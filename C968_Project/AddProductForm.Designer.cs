namespace C968_Project
{
    partial class AddProductForm
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
            this.addPartCancelButton = new System.Windows.Forms.Button();
            this.addPartSaveButton = new System.Windows.Forms.Button();
            this.minTextBox = new System.Windows.Forms.TextBox();
            this.maxTextBox = new System.Windows.Forms.TextBox();
            this.priceCostTextBox = new System.Windows.Forms.TextBox();
            this.minLabel = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.priceCostLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.inStockTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.addProductText = new System.Windows.Forms.TextBox();
            this.allPartsDataGridView = new System.Windows.Forms.DataGridView();
            this.allPartsLabel = new System.Windows.Forms.Label();
            this.partsAssociatedLabel = new System.Windows.Forms.Label();
            this.partsAssociatedDataGridView = new System.Windows.Forms.DataGridView();
            this.addAssociatedPartButton = new System.Windows.Forms.Button();
            this.deleteAssociatedPartButton = new System.Windows.Forms.Button();
            this.searchAllPartsButton = new System.Windows.Forms.Button();
            this.searchAllPartsTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.allPartsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsAssociatedDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addPartCancelButton
            // 
            this.addPartCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addPartCancelButton.Location = new System.Drawing.Point(814, 556);
            this.addPartCancelButton.Name = "addPartCancelButton";
            this.addPartCancelButton.Size = new System.Drawing.Size(96, 44);
            this.addPartCancelButton.TabIndex = 56;
            this.addPartCancelButton.Text = "Cancel";
            this.addPartCancelButton.UseVisualStyleBackColor = true;
            this.addPartCancelButton.Click += new System.EventHandler(this.addPartCancelButton_Click);
            // 
            // addPartSaveButton
            // 
            this.addPartSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addPartSaveButton.Location = new System.Drawing.Point(682, 556);
            this.addPartSaveButton.Name = "addPartSaveButton";
            this.addPartSaveButton.Size = new System.Drawing.Size(96, 44);
            this.addPartSaveButton.TabIndex = 55;
            this.addPartSaveButton.Text = "Save";
            this.addPartSaveButton.UseVisualStyleBackColor = true;
            this.addPartSaveButton.Click += new System.EventHandler(this.addProductSaveButton_Click);
            // 
            // minTextBox
            // 
            this.minTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.minTextBox.Location = new System.Drawing.Point(337, 278);
            this.minTextBox.Name = "minTextBox";
            this.minTextBox.Size = new System.Drawing.Size(119, 26);
            this.minTextBox.TabIndex = 53;
            this.minTextBox.TextChanged += new System.EventHandler(this.minTextBox_TextChanged);
            // 
            // maxTextBox
            // 
            this.maxTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.maxTextBox.Location = new System.Drawing.Point(138, 278);
            this.maxTextBox.Name = "maxTextBox";
            this.maxTextBox.Size = new System.Drawing.Size(119, 26);
            this.maxTextBox.TabIndex = 52;
            this.maxTextBox.TextChanged += new System.EventHandler(this.maxTextBox_TextChanged);
            // 
            // priceCostTextBox
            // 
            this.priceCostTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.priceCostTextBox.Location = new System.Drawing.Point(138, 233);
            this.priceCostTextBox.Name = "priceCostTextBox";
            this.priceCostTextBox.Size = new System.Drawing.Size(263, 26);
            this.priceCostTextBox.TabIndex = 51;
            this.priceCostTextBox.TextChanged += new System.EventHandler(this.priceCostTextBox_TextChanged);
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.minLabel.Location = new System.Drawing.Point(294, 281);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(36, 20);
            this.minLabel.TabIndex = 49;
            this.minLabel.Text = "Min";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.maxLabel.Location = new System.Drawing.Point(81, 281);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(40, 20);
            this.maxLabel.TabIndex = 48;
            this.maxLabel.Text = "Max";
            // 
            // priceCostLabel
            // 
            this.priceCostLabel.AutoSize = true;
            this.priceCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.priceCostLabel.Location = new System.Drawing.Point(23, 239);
            this.priceCostLabel.Name = "priceCostLabel";
            this.priceCostLabel.Size = new System.Drawing.Size(98, 20);
            this.priceCostLabel.TabIndex = 47;
            this.priceCostLabel.Text = "Price / Cost";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nameTextBox.Location = new System.Drawing.Point(138, 141);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(263, 26);
            this.nameTextBox.TabIndex = 46;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.inventoryLabel.Location = new System.Drawing.Point(45, 189);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(69, 20);
            this.inventoryLabel.TabIndex = 45;
            this.inventoryLabel.Text = "In Stock";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nameLabel.Location = new System.Drawing.Point(68, 141);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(53, 20);
            this.nameLabel.TabIndex = 44;
            this.nameLabel.Text = "Name";
            // 
            // inStockTextBox
            // 
            this.inStockTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.inStockTextBox.Location = new System.Drawing.Point(138, 183);
            this.inStockTextBox.Name = "inStockTextBox";
            this.inStockTextBox.Size = new System.Drawing.Size(263, 26);
            this.inStockTextBox.TabIndex = 43;
            this.inStockTextBox.TextChanged += new System.EventHandler(this.inStockTextBox_TextChanged);
            // 
            // idTextBox
            // 
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.idTextBox.Location = new System.Drawing.Point(138, 92);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(263, 26);
            this.idTextBox.TabIndex = 42;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.idLabel.Location = new System.Drawing.Point(95, 95);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(26, 20);
            this.idLabel.TabIndex = 41;
            this.idLabel.Text = "ID";
            // 
            // addProductText
            // 
            this.addProductText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addProductText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addProductText.Location = new System.Drawing.Point(21, 25);
            this.addProductText.Name = "addProductText";
            this.addProductText.Size = new System.Drawing.Size(130, 23);
            this.addProductText.TabIndex = 38;
            this.addProductText.Text = "Add Product";
            this.addProductText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // allPartsDataGridView
            // 
            this.allPartsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allPartsDataGridView.Location = new System.Drawing.Point(533, 73);
            this.allPartsDataGridView.Name = "allPartsDataGridView";
            this.allPartsDataGridView.RowHeadersVisible = false;
            this.allPartsDataGridView.RowHeadersWidth = 51;
            this.allPartsDataGridView.RowTemplate.Height = 24;
            this.allPartsDataGridView.Size = new System.Drawing.Size(423, 186);
            this.allPartsDataGridView.TabIndex = 57;
            this.allPartsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.allPartsDataGridView_CellContentClick);
            this.allPartsDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.myBindingComplete);
            // 
            // allPartsLabel
            // 
            this.allPartsLabel.AutoSize = true;
            this.allPartsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.allPartsLabel.Location = new System.Drawing.Point(529, 47);
            this.allPartsLabel.Name = "allPartsLabel";
            this.allPartsLabel.Size = new System.Drawing.Size(73, 20);
            this.allPartsLabel.TabIndex = 58;
            this.allPartsLabel.Text = "All Parts";
            // 
            // partsAssociatedLabel
            // 
            this.partsAssociatedLabel.AutoSize = true;
            this.partsAssociatedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.partsAssociatedLabel.Location = new System.Drawing.Point(529, 306);
            this.partsAssociatedLabel.Name = "partsAssociatedLabel";
            this.partsAssociatedLabel.Size = new System.Drawing.Size(276, 20);
            this.partsAssociatedLabel.TabIndex = 59;
            this.partsAssociatedLabel.Text = "Parts Associated With This Product";
            // 
            // partsAssociatedDataGridView
            // 
            this.partsAssociatedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsAssociatedDataGridView.Location = new System.Drawing.Point(533, 329);
            this.partsAssociatedDataGridView.Name = "partsAssociatedDataGridView";
            this.partsAssociatedDataGridView.RowHeadersVisible = false;
            this.partsAssociatedDataGridView.RowHeadersWidth = 51;
            this.partsAssociatedDataGridView.RowTemplate.Height = 24;
            this.partsAssociatedDataGridView.Size = new System.Drawing.Size(423, 171);
            this.partsAssociatedDataGridView.TabIndex = 60;
            this.partsAssociatedDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.myBindingComplete);
            // 
            // addAssociatedPartButton
            // 
            this.addAssociatedPartButton.Location = new System.Drawing.Point(876, 265);
            this.addAssociatedPartButton.Name = "addAssociatedPartButton";
            this.addAssociatedPartButton.Size = new System.Drawing.Size(80, 41);
            this.addAssociatedPartButton.TabIndex = 61;
            this.addAssociatedPartButton.Text = "Add";
            this.addAssociatedPartButton.UseVisualStyleBackColor = true;
            this.addAssociatedPartButton.Click += new System.EventHandler(this.addAssociatedPartButton_Click_1);
            // 
            // deleteAssociatedPartButton
            // 
            this.deleteAssociatedPartButton.Location = new System.Drawing.Point(876, 506);
            this.deleteAssociatedPartButton.Name = "deleteAssociatedPartButton";
            this.deleteAssociatedPartButton.Size = new System.Drawing.Size(80, 41);
            this.deleteAssociatedPartButton.TabIndex = 62;
            this.deleteAssociatedPartButton.Text = "Delete";
            this.deleteAssociatedPartButton.UseVisualStyleBackColor = true;
            this.deleteAssociatedPartButton.Click += new System.EventHandler(this.deleteAssociatedPartButton_Click);
            // 
            // searchAllPartsButton
            // 
            this.searchAllPartsButton.Location = new System.Drawing.Point(622, 36);
            this.searchAllPartsButton.Name = "searchAllPartsButton";
            this.searchAllPartsButton.Size = new System.Drawing.Size(75, 31);
            this.searchAllPartsButton.TabIndex = 63;
            this.searchAllPartsButton.Text = "Search";
            this.searchAllPartsButton.UseVisualStyleBackColor = true;
            this.searchAllPartsButton.Click += new System.EventHandler(this.searchAllPartsButton_Click);
            // 
            // searchAllPartsTextBox
            // 
            this.searchAllPartsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.searchAllPartsTextBox.Location = new System.Drawing.Point(712, 36);
            this.searchAllPartsTextBox.Name = "searchAllPartsTextBox";
            this.searchAllPartsTextBox.Size = new System.Drawing.Size(204, 30);
            this.searchAllPartsTextBox.TabIndex = 64;
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 612);
            this.Controls.Add(this.searchAllPartsTextBox);
            this.Controls.Add(this.searchAllPartsButton);
            this.Controls.Add(this.deleteAssociatedPartButton);
            this.Controls.Add(this.addAssociatedPartButton);
            this.Controls.Add(this.partsAssociatedDataGridView);
            this.Controls.Add(this.partsAssociatedLabel);
            this.Controls.Add(this.allPartsLabel);
            this.Controls.Add(this.allPartsDataGridView);
            this.Controls.Add(this.addPartCancelButton);
            this.Controls.Add(this.addPartSaveButton);
            this.Controls.Add(this.minTextBox);
            this.Controls.Add(this.maxTextBox);
            this.Controls.Add(this.priceCostTextBox);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.priceCostLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.inventoryLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.inStockTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.addProductText);
            this.Name = "AddProductForm";
            this.Text = "AddProductForm";
            ((System.ComponentModel.ISupportInitialize)(this.allPartsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsAssociatedDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addPartCancelButton;
        private System.Windows.Forms.Button addPartSaveButton;
        private System.Windows.Forms.TextBox minTextBox;
        private System.Windows.Forms.TextBox maxTextBox;
        private System.Windows.Forms.TextBox priceCostTextBox;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label priceCostLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox inStockTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox addProductText;
        private System.Windows.Forms.Label allPartsLabel;
        private System.Windows.Forms.Label partsAssociatedLabel;
        private System.Windows.Forms.Button addAssociatedPartButton;
        public System.Windows.Forms.DataGridView allPartsDataGridView;
        public System.Windows.Forms.DataGridView partsAssociatedDataGridView;
        private System.Windows.Forms.Button deleteAssociatedPartButton;
        private System.Windows.Forms.Button searchAllPartsButton;
        private System.Windows.Forms.TextBox searchAllPartsTextBox;
    }
}