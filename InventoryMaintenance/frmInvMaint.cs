using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryMaintenance
{
    public partial class frmInvMaint : Form
    {
        // Marley Chilenski
        // Stores the list of inventory items.
        private List<InvItem> invItems = null;

        // Marley Chilenski
        // Initializes the Inventory Maintenance form.
        public frmInvMaint()
        {
            InitializeComponent();
        }

        // Marley Chilenski
        // Loads the inventory items from the database class
        // and displays them in the list box.
        private void frmInvMaint_Load(object sender, EventArgs e)
        {
            invItems = InvItemDB.GetItems();
            FillItemListBox();
        }

        // Marley Chilenski
        // Clears the list box and fills it with the inventory items.
        private void FillItemListBox()
        {
            lstItems.Items.Clear();

            foreach (InvItem item in invItems)
            {
                lstItems.Items.Add(item.GetDisplayText());
            }
        }

        // Marley Chilenski
        // Opens the New Item form and adds the new item
        // to the inventory list if the user saves it.
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmNewItem newItemForm = new frmNewItem();

            InvItem newItem = newItemForm.GetNewItem();

            if (newItem != null)
            {
                invItems.Add(newItem);
                InvItemDB.SaveItems(invItems);
                FillItemListBox();
            }
        }

        // Marley Chilenski
        // Confirms deletion of the selected item, removes it
        // from the list, saves the updated list, and refreshes the display.
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = lstItems.SelectedIndex;

            if (i != -1)
            {
                DialogResult result = MessageBox.Show(
                    "Delete the selected item?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    invItems.RemoveAt(i);
                    InvItemDB.SaveItems(invItems);
                    FillItemListBox();
                }
            }
        }

        // Marley Chilenski
        // Closes the Inventory Maintenance form.
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
