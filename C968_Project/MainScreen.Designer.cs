namespace C968_Project
{
    partial class MainScreen
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
            this.partsSearchButtonMS = new System.Windows.Forms.Button();
            this.partsAddButtonMS = new System.Windows.Forms.Button();
            this.partsModifyButtonMS = new System.Windows.Forms.Button();
            this.partsDeleteButtonMS = new System.Windows.Forms.Button();
            this.productsDeleteButtonMS = new System.Windows.Forms.Button();
            this.productsModifyButtonMS = new System.Windows.Forms.Button();
            this.productsAddButtonMS = new System.Windows.Forms.Button();
            this.productsSearchButtonMS = new System.Windows.Forms.Button();
            this.mainScreenTitle = new System.Windows.Forms.TextBox();
            this.partsTitleText = new System.Windows.Forms.TextBox();
            this.productsTitleText = new System.Windows.Forms.TextBox();
            this.partsSearchTextBox = new System.Windows.Forms.TextBox();
            this.productsSearchTextBox = new System.Windows.Forms.TextBox();
            this.partsDataGridView = new System.Windows.Forms.DataGridView();
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.exitButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.partsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // partsSearchButtonMS
            // 
            this.partsSearchButtonMS.Location = new System.Drawing.Point(170, 73);
            this.partsSearchButtonMS.Name = "partsSearchButtonMS";
            this.partsSearchButtonMS.Size = new System.Drawing.Size(121, 41);
            this.partsSearchButtonMS.TabIndex = 4;
            this.partsSearchButtonMS.Text = "Search";
            this.partsSearchButtonMS.UseVisualStyleBackColor = true;
            this.partsSearchButtonMS.Click += new System.EventHandler(this.partsSearchButtonMS_Click);
            // 
            // partsAddButtonMS
            // 
            this.partsAddButtonMS.Location = new System.Drawing.Point(161, 503);
            this.partsAddButtonMS.Name = "partsAddButtonMS";
            this.partsAddButtonMS.Size = new System.Drawing.Size(101, 37);
            this.partsAddButtonMS.TabIndex = 7;
            this.partsAddButtonMS.Text = "Add";
            this.partsAddButtonMS.UseVisualStyleBackColor = true;
            this.partsAddButtonMS.Click += new System.EventHandler(this.partsAddButtonMS_Click);
            // 
            // partsModifyButtonMS
            // 
            this.partsModifyButtonMS.Location = new System.Drawing.Point(268, 503);
            this.partsModifyButtonMS.Name = "partsModifyButtonMS";
            this.partsModifyButtonMS.Size = new System.Drawing.Size(101, 37);
            this.partsModifyButtonMS.TabIndex = 8;
            this.partsModifyButtonMS.Text = "Modify";
            this.partsModifyButtonMS.UseVisualStyleBackColor = true;
            this.partsModifyButtonMS.Click += new System.EventHandler(this.partsModifyButtonMS_Click);
            // 
            // partsDeleteButtonMS
            // 
            this.partsDeleteButtonMS.Location = new System.Drawing.Point(375, 503);
            this.partsDeleteButtonMS.Name = "partsDeleteButtonMS";
            this.partsDeleteButtonMS.Size = new System.Drawing.Size(101, 37);
            this.partsDeleteButtonMS.TabIndex = 9;
            this.partsDeleteButtonMS.Text = "Delete";
            this.partsDeleteButtonMS.UseVisualStyleBackColor = true;
            this.partsDeleteButtonMS.Click += new System.EventHandler(this.partsDeleteButtonMS_Click);
            // 
            // productsDeleteButtonMS
            // 
            this.productsDeleteButtonMS.Location = new System.Drawing.Point(993, 503);
            this.productsDeleteButtonMS.Name = "productsDeleteButtonMS";
            this.productsDeleteButtonMS.Size = new System.Drawing.Size(101, 37);
            this.productsDeleteButtonMS.TabIndex = 12;
            this.productsDeleteButtonMS.Text = "Delete";
            this.productsDeleteButtonMS.UseVisualStyleBackColor = true;
            this.productsDeleteButtonMS.Click += new System.EventHandler(this.productsDeleteButtonMS_Click);
            // 
            // productsModifyButtonMS
            // 
            this.productsModifyButtonMS.Location = new System.Drawing.Point(886, 503);
            this.productsModifyButtonMS.Name = "productsModifyButtonMS";
            this.productsModifyButtonMS.Size = new System.Drawing.Size(101, 37);
            this.productsModifyButtonMS.TabIndex = 11;
            this.productsModifyButtonMS.Text = "Modify";
            this.productsModifyButtonMS.UseVisualStyleBackColor = true;
            this.productsModifyButtonMS.Click += new System.EventHandler(this.productsModifyButtonMS_Click);
            // 
            // productsAddButtonMS
            // 
            this.productsAddButtonMS.Location = new System.Drawing.Point(779, 503);
            this.productsAddButtonMS.Name = "productsAddButtonMS";
            this.productsAddButtonMS.Size = new System.Drawing.Size(101, 37);
            this.productsAddButtonMS.TabIndex = 10;
            this.productsAddButtonMS.Text = "Add";
            this.productsAddButtonMS.UseVisualStyleBackColor = true;
            this.productsAddButtonMS.Click += new System.EventHandler(this.productsAddButtonMS_Click);
            // 
            // productsSearchButtonMS
            // 
            this.productsSearchButtonMS.Location = new System.Drawing.Point(801, 77);
            this.productsSearchButtonMS.Name = "productsSearchButtonMS";
            this.productsSearchButtonMS.Size = new System.Drawing.Size(121, 41);
            this.productsSearchButtonMS.TabIndex = 14;
            this.productsSearchButtonMS.Text = "Search";
            this.productsSearchButtonMS.UseVisualStyleBackColor = true;
            this.productsSearchButtonMS.Click += new System.EventHandler(this.productsSearchButtonMS_Click);
            // 
            // mainScreenTitle
            // 
            this.mainScreenTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainScreenTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainScreenTitle.Location = new System.Drawing.Point(374, 12);
            this.mainScreenTitle.Name = "mainScreenTitle";
            this.mainScreenTitle.ReadOnly = true;
            this.mainScreenTitle.Size = new System.Drawing.Size(421, 31);
            this.mainScreenTitle.TabIndex = 16;
            this.mainScreenTitle.Text = "Inventory Management System";
            this.mainScreenTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mainScreenTitle.TextChanged += new System.EventHandler(this.mainScreenTitle_TextChanged);
            // 
            // partsTitleText
            // 
            this.partsTitleText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.partsTitleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsTitleText.Location = new System.Drawing.Point(80, 79);
            this.partsTitleText.Name = "partsTitleText";
            this.partsTitleText.ReadOnly = true;
            this.partsTitleText.Size = new System.Drawing.Size(84, 34);
            this.partsTitleText.TabIndex = 17;
            this.partsTitleText.Text = "Parts";
            this.partsTitleText.TextChanged += new System.EventHandler(this.partsTitleText_TextChanged);
            // 
            // productsTitleText
            // 
            this.productsTitleText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productsTitleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsTitleText.Location = new System.Drawing.Point(661, 79);
            this.productsTitleText.Name = "productsTitleText";
            this.productsTitleText.ReadOnly = true;
            this.productsTitleText.Size = new System.Drawing.Size(134, 34);
            this.productsTitleText.TabIndex = 18;
            this.productsTitleText.Text = "Products";
            this.productsTitleText.TextChanged += new System.EventHandler(this.productsTitleText_TextChanged);
            // 
            // partsSearchTextBox
            // 
            this.partsSearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.partsSearchTextBox.Location = new System.Drawing.Point(297, 79);
            this.partsSearchTextBox.Name = "partsSearchTextBox";
            this.partsSearchTextBox.Size = new System.Drawing.Size(211, 30);
            this.partsSearchTextBox.TabIndex = 20;
            // 
            // productsSearchTextBox
            // 
            this.productsSearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.productsSearchTextBox.Location = new System.Drawing.Point(928, 84);
            this.productsSearchTextBox.Name = "productsSearchTextBox";
            this.productsSearchTextBox.Size = new System.Drawing.Size(211, 30);
            this.productsSearchTextBox.TabIndex = 21;
            this.productsSearchTextBox.TextChanged += new System.EventHandler(this.productsSearchTextBox_TextChanged);
            // 
            // partsDataGridView
            // 
            this.partsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsDataGridView.Location = new System.Drawing.Point(80, 120);
            this.partsDataGridView.Name = "partsDataGridView";
            this.partsDataGridView.RowHeadersVisible = false;
            this.partsDataGridView.RowHeadersWidth = 51;
            this.partsDataGridView.RowTemplate.Height = 24;
            this.partsDataGridView.Size = new System.Drawing.Size(502, 368);
            this.partsDataGridView.TabIndex = 22;
            this.partsDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.myBindingComplete);
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.Location = new System.Drawing.Point(661, 120);
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.RowHeadersVisible = false;
            this.productsDataGridView.RowHeadersWidth = 51;
            this.productsDataGridView.RowTemplate.Height = 24;
            this.productsDataGridView.Size = new System.Drawing.Size(514, 368);
            this.productsDataGridView.TabIndex = 23;
            this.productsDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.myBindingComplete);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(1089, 546);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(101, 37);
            this.exitButton.TabIndex = 24;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 584);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.productsDataGridView);
            this.Controls.Add(this.partsDataGridView);
            this.Controls.Add(this.productsSearchTextBox);
            this.Controls.Add(this.partsSearchTextBox);
            this.Controls.Add(this.productsTitleText);
            this.Controls.Add(this.partsTitleText);
            this.Controls.Add(this.mainScreenTitle);
            this.Controls.Add(this.productsSearchButtonMS);
            this.Controls.Add(this.productsDeleteButtonMS);
            this.Controls.Add(this.productsModifyButtonMS);
            this.Controls.Add(this.productsAddButtonMS);
            this.Controls.Add(this.partsDeleteButtonMS);
            this.Controls.Add(this.partsModifyButtonMS);
            this.Controls.Add(this.partsAddButtonMS);
            this.Controls.Add(this.partsSearchButtonMS);
            this.Name = "MainScreen";
            this.Text = "MainScreen";
            ((System.ComponentModel.ISupportInitialize)(this.partsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button partsSearchButtonMS;
        private System.Windows.Forms.Button partsAddButtonMS;
        private System.Windows.Forms.Button partsModifyButtonMS;
        private System.Windows.Forms.Button partsDeleteButtonMS;
        private System.Windows.Forms.Button productsDeleteButtonMS;
        private System.Windows.Forms.Button productsModifyButtonMS;
        private System.Windows.Forms.Button productsAddButtonMS;
        private System.Windows.Forms.Button productsSearchButtonMS;
        private System.Windows.Forms.TextBox mainScreenTitle;
        private System.Windows.Forms.TextBox partsTitleText;
        private System.Windows.Forms.TextBox productsTitleText;
        private System.Windows.Forms.TextBox partsSearchTextBox;
        private System.Windows.Forms.Button exitButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.DataGridView productsDataGridView;
        public System.Windows.Forms.TextBox productsSearchTextBox;
        public System.Windows.Forms.DataGridView partsDataGridView;
    }
}

