namespace InventoryMaintenance
{
    partial class frmNewItem
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
            label1 = new Label();
            txtItemNo = new TextBox();
            label2 = new Label();
            txtDescription = new TextBox();
            label3 = new Label();
            txtPrice = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            cboSizeOrManufacturer = new ComboBox();
            lblSizeOrManufacturer = new Label();
            rdoPlant = new RadioButton();
            rdoSupply = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 49);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Item no:";
            // 
            // txtItemNo
            // 
            txtItemNo.Location = new Point(108, 47);
            txtItemNo.Margin = new Padding(2);
            txtItemNo.Name = "txtItemNo";
            txtItemNo.Size = new Size(106, 23);
            txtItemNo.TabIndex = 3;
            txtItemNo.Tag = "Item no";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 78);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 2;
            label2.Text = "Description:";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(108, 76);
            txtDescription.Margin = new Padding(2);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(190, 23);
            txtDescription.TabIndex = 5;
            txtDescription.Tag = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 138);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 4;
            label3.Text = "Price:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(108, 136);
            txtPrice.Margin = new Padding(2);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(106, 23);
            txtPrice.TabIndex = 9;
            txtPrice.Tag = "Price";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(108, 180);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(78, 25);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(219, 180);
            btnCancel.Margin = new Padding(2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(78, 25);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // cboSizeOrManufacturer
            // 
            cboSizeOrManufacturer.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSizeOrManufacturer.FormattingEnabled = true;
            cboSizeOrManufacturer.Location = new Point(108, 106);
            cboSizeOrManufacturer.Margin = new Padding(2);
            cboSizeOrManufacturer.Name = "cboSizeOrManufacturer";
            cboSizeOrManufacturer.Size = new Size(129, 23);
            cboSizeOrManufacturer.TabIndex = 7;
            // 
            // lblSizeOrManufacturer
            // 
            lblSizeOrManufacturer.AutoSize = true;
            lblSizeOrManufacturer.Location = new Point(18, 107);
            lblSizeOrManufacturer.Margin = new Padding(2, 0, 2, 0);
            lblSizeOrManufacturer.Name = "lblSizeOrManufacturer";
            lblSizeOrManufacturer.Size = new Size(30, 15);
            lblSizeOrManufacturer.TabIndex = 9;
            lblSizeOrManufacturer.Text = "Size:";
            // 
            // rdoPlant
            // 
            rdoPlant.AutoSize = true;
            rdoPlant.Checked = true;
            rdoPlant.Location = new Point(108, 14);
            rdoPlant.Margin = new Padding(2);
            rdoPlant.Name = "rdoPlant";
            rdoPlant.Size = new Size(52, 19);
            rdoPlant.TabIndex = 0;
            rdoPlant.TabStop = true;
            rdoPlant.Text = "Plant";
            rdoPlant.UseVisualStyleBackColor = true;
            rdoPlant.CheckedChanged += rdoPlant_CheckedChanged;
            // 
            // rdoSupply
            // 
            rdoSupply.AutoSize = true;
            rdoSupply.Location = new Point(192, 14);
            rdoSupply.Margin = new Padding(2);
            rdoSupply.Name = "rdoSupply";
            rdoSupply.Size = new Size(61, 19);
            rdoSupply.TabIndex = 1;
            rdoSupply.TabStop = true;
            rdoSupply.Text = "Supply";
            rdoSupply.UseVisualStyleBackColor = true;
            rdoSupply.CheckedChanged += rdoSupply_CheckedChanged;
            // 
            // frmNewItem
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(317, 217);
            ControlBox = false;
            Controls.Add(rdoSupply);
            Controls.Add(rdoPlant);
            Controls.Add(lblSizeOrManufacturer);
            Controls.Add(cboSizeOrManufacturer);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtPrice);
            Controls.Add(label3);
            Controls.Add(txtDescription);
            Controls.Add(label2);
            Controls.Add(txtItemNo);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmNewItem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New Inventory Item";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtItemNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cboSizeOrManufacturer;
        private System.Windows.Forms.Label lblSizeOrManufacturer;
        private System.Windows.Forms.RadioButton rdoPlant;
        private System.Windows.Forms.RadioButton rdoSupply;
    }
}