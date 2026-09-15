using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System;
using System.Windows.Forms;

namespace InventoryMaintenance
{
    public partial class frmNewItem : Form
    {
        // Marley Chilenski
        // Stores the new InvItem created by the user.
        // It starts as null if the user cancels.
        private InvItem invItem = null;

        // Marley Chilenski
        // Initializes the New Item form.
        public frmNewItem()
        {
            InitializeComponent();
        }

        // Marley Chilenski
        // Displays the New Item form as a dialog box
        // and returns the new InvItem created by the user.
        public InvItem GetNewItem()
        {
            this.ShowDialog();
            return invItem;
        }

        // Marley Chilenski
        // Creates a new InvItem using the values entered
        // in the text boxes and closes the form if valid.
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                int itemNo = Convert.ToInt32(txtItemNo.Text);
                string description = txtDescription.Text;
                decimal price = Convert.ToDecimal(txtPrice.Text);

                invItem = new InvItem(itemNo, description, price);

                this.Close();
            }
        }

        // Marley Chilenski
        // Checks whether all required text boxes contain valid data.
        private bool IsValidData()
        {
            return Validator.IsPresent(txtItemNo) &&
                   Validator.IsInt32(txtItemNo) &&
                   Validator.IsPresent(txtDescription) &&
                   Validator.IsPresent(txtPrice) &&
                   Validator.IsDecimal(txtPrice);
        }

        // Marley Chilenski
        // Closes the form without creating a new item.
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
