namespace C968_Project
{
    partial class AddPartForm
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
            this.addPartText = new System.Windows.Forms.TextBox();
            this.inHouseRadioButton = new System.Windows.Forms.RadioButton();
            this.outSourcedRadioButton = new System.Windows.Forms.RadioButton();
            this.idLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.inStockTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.priceCostLabel = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.machineOrCompanyLabel = new System.Windows.Forms.Label();
            this.priceCostTextBox = new System.Windows.Forms.TextBox();
            this.maxTextBox = new System.Windows.Forms.TextBox();
            this.minTextBox = new System.Windows.Forms.TextBox();
            this.machineOrCompanyTextBox = new System.Windows.Forms.TextBox();
            this.addPartSaveButton = new System.Windows.Forms.Button();
            this.addPartCancelButton = new System.Windows.Forms.Button();
            this.radiButtonsGroupBox = new System.Windows.Forms.GroupBox();
            this.radiButtonsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // addPartText
            // 
            this.addPartText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addPartText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartText.Location = new System.Drawing.Point(27, 28);
            this.addPartText.Name = "addPartText";
            this.addPartText.Size = new System.Drawing.Size(100, 19);
            this.addPartText.TabIndex = 0;
            this.addPartText.Text = "Add Part";
            this.addPartText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inHouseRadioButton
            // 
            this.inHouseRadioButton.AutoSize = true;
            this.inHouseRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.inHouseRadioButton.Location = new System.Drawing.Point(30, 29);
            this.inHouseRadioButton.Name = "inHouseRadioButton";
            this.inHouseRadioButton.Size = new System.Drawing.Size(98, 24);
            this.inHouseRadioButton.TabIndex = 1;
            this.inHouseRadioButton.TabStop = true;
            this.inHouseRadioButton.Text = "In-House";
            this.inHouseRadioButton.UseVisualStyleBackColor = true;
            this.inHouseRadioButton.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // outSourcedRadioButton
            // 
            this.outSourcedRadioButton.AutoSize = true;
            this.outSourcedRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.outSourcedRadioButton.Location = new System.Drawing.Point(185, 29);
            this.outSourcedRadioButton.Name = "outSourcedRadioButton";
            this.outSourcedRadioButton.Size = new System.Drawing.Size(117, 24);
            this.outSourcedRadioButton.TabIndex = 2;
            this.outSourcedRadioButton.TabStop = true;
            this.outSourcedRadioButton.Text = "Outsourced";
            this.outSourcedRadioButton.UseVisualStyleBackColor = true;
            this.outSourcedRadioButton.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.idLabel.Location = new System.Drawing.Point(129, 99);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(26, 20);
            this.idLabel.TabIndex = 3;
            this.idLabel.Text = "ID";
            // 
            // idTextBox
            // 
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.idTextBox.Location = new System.Drawing.Point(172, 96);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(263, 26);
            this.idTextBox.TabIndex = 4;
            // 
            // inStockTextBox
            // 
            this.inStockTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.inStockTextBox.Location = new System.Drawing.Point(172, 187);
            this.inStockTextBox.Name = "inStockTextBox";
            this.inStockTextBox.Size = new System.Drawing.Size(263, 26);
            this.inStockTextBox.TabIndex = 5;
            this.inStockTextBox.TextChanged += new System.EventHandler(this.inStockTextBox_TextChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nameLabel.Location = new System.Drawing.Point(102, 145);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(53, 20);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "Name";
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.inventoryLabel.Location = new System.Drawing.Point(79, 193);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(69, 20);
            this.inventoryLabel.TabIndex = 7;
            this.inventoryLabel.Text = "In Stock";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nameTextBox.Location = new System.Drawing.Point(172, 145);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(263, 26);
            this.nameTextBox.TabIndex = 8;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // priceCostLabel
            // 
            this.priceCostLabel.AutoSize = true;
            this.priceCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.priceCostLabel.Location = new System.Drawing.Point(57, 243);
            this.priceCostLabel.Name = "priceCostLabel";
            this.priceCostLabel.Size = new System.Drawing.Size(98, 20);
            this.priceCostLabel.TabIndex = 9;
            this.priceCostLabel.Text = "Price / Cost";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.maxLabel.Location = new System.Drawing.Point(115, 285);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(40, 20);
            this.maxLabel.TabIndex = 10;
            this.maxLabel.Text = "Max";
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.minLabel.Location = new System.Drawing.Point(328, 285);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(36, 20);
            this.minLabel.TabIndex = 11;
            this.minLabel.Text = "Min";
            // 
            // machineOrCompanyLabel
            // 
            this.machineOrCompanyLabel.AutoSize = true;
            this.machineOrCompanyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.machineOrCompanyLabel.Location = new System.Drawing.Point(61, 333);
            this.machineOrCompanyLabel.Name = "machineOrCompanyLabel";
            this.machineOrCompanyLabel.Size = new System.Drawing.Size(94, 20);
            this.machineOrCompanyLabel.TabIndex = 12;
            this.machineOrCompanyLabel.Text = "Machine ID";
            // 
            // priceCostTextBox
            // 
            this.priceCostTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.priceCostTextBox.Location = new System.Drawing.Point(172, 237);
            this.priceCostTextBox.Name = "priceCostTextBox";
            this.priceCostTextBox.Size = new System.Drawing.Size(263, 26);
            this.priceCostTextBox.TabIndex = 13;
            this.priceCostTextBox.TextChanged += new System.EventHandler(this.priceCostTextBox_TextChanged);
            // 
            // maxTextBox
            // 
            this.maxTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.maxTextBox.Location = new System.Drawing.Point(172, 282);
            this.maxTextBox.Name = "maxTextBox";
            this.maxTextBox.Size = new System.Drawing.Size(119, 26);
            this.maxTextBox.TabIndex = 14;
            this.maxTextBox.TextChanged += new System.EventHandler(this.maxTextBox_TextChanged);
            // 
            // minTextBox
            // 
            this.minTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.minTextBox.Location = new System.Drawing.Point(371, 282);
            this.minTextBox.Name = "minTextBox";
            this.minTextBox.Size = new System.Drawing.Size(119, 26);
            this.minTextBox.TabIndex = 15;
            this.minTextBox.TextChanged += new System.EventHandler(this.minTextBox_TextChanged);
            // 
            // machineOrCompanyTextBox
            // 
            this.machineOrCompanyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.machineOrCompanyTextBox.Location = new System.Drawing.Point(172, 333);
            this.machineOrCompanyTextBox.Name = "machineOrCompanyTextBox";
            this.machineOrCompanyTextBox.Size = new System.Drawing.Size(263, 26);
            this.machineOrCompanyTextBox.TabIndex = 16;
            this.machineOrCompanyTextBox.TextChanged += new System.EventHandler(this.machineOrCompanyTextBox_TextChanged);
            // 
            // addPartSaveButton
            // 
            this.addPartSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addPartSaveButton.Location = new System.Drawing.Point(339, 374);
            this.addPartSaveButton.Name = "addPartSaveButton";
            this.addPartSaveButton.Size = new System.Drawing.Size(96, 44);
            this.addPartSaveButton.TabIndex = 17;
            this.addPartSaveButton.Text = "Save";
            this.addPartSaveButton.UseVisualStyleBackColor = true;
            this.addPartSaveButton.Click += new System.EventHandler(this.addPartSaveButton_Click);
            // 
            // addPartCancelButton
            // 
            this.addPartCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addPartCancelButton.Location = new System.Drawing.Point(458, 374);
            this.addPartCancelButton.Name = "addPartCancelButton";
            this.addPartCancelButton.Size = new System.Drawing.Size(96, 44);
            this.addPartCancelButton.TabIndex = 18;
            this.addPartCancelButton.Text = "Cancel";
            this.addPartCancelButton.UseVisualStyleBackColor = true;
            this.addPartCancelButton.Click += new System.EventHandler(this.addPartCancelButton_Click);
            // 
            // radiButtonsGroupBox
            // 
            this.radiButtonsGroupBox.Controls.Add(this.inHouseRadioButton);
            this.radiButtonsGroupBox.Controls.Add(this.outSourcedRadioButton);
            this.radiButtonsGroupBox.Location = new System.Drawing.Point(155, -2);
            this.radiButtonsGroupBox.Name = "radiButtonsGroupBox";
            this.radiButtonsGroupBox.Size = new System.Drawing.Size(316, 79);
            this.radiButtonsGroupBox.TabIndex = 19;
            this.radiButtonsGroupBox.TabStop = false;
            // 
            // AddPartForm
            // 
            this.ClientSize = new System.Drawing.Size(611, 420);
            this.Controls.Add(this.radiButtonsGroupBox);
            this.Controls.Add(this.addPartCancelButton);
            this.Controls.Add(this.addPartSaveButton);
            this.Controls.Add(this.machineOrCompanyTextBox);
            this.Controls.Add(this.minTextBox);
            this.Controls.Add(this.maxTextBox);
            this.Controls.Add(this.priceCostTextBox);
            this.Controls.Add(this.machineOrCompanyLabel);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.priceCostLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.inventoryLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.inStockTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.addPartText);
            this.Name = "AddPartForm";
            this.Text = "AddPartForm";
            this.radiButtonsGroupBox.ResumeLayout(false);
            this.radiButtonsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox addPartText;
        private System.Windows.Forms.RadioButton inHouseRadioButton;
        private System.Windows.Forms.RadioButton outSourcedRadioButton;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox inStockTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label priceCostLabel;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label machineOrCompanyLabel;
        private System.Windows.Forms.TextBox priceCostTextBox;
        private System.Windows.Forms.TextBox maxTextBox;
        private System.Windows.Forms.TextBox minTextBox;
        private System.Windows.Forms.TextBox machineOrCompanyTextBox;
        private System.Windows.Forms.Button addPartSaveButton;
        private System.Windows.Forms.Button addPartCancelButton;
        private System.Windows.Forms.GroupBox radiButtonsGroupBox;
    }
}