using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurents
{
    public partial class ModifyMenu : Form
    {

        RestaurentDetailsForm _form1;
        private int _itemId;
        private Resturant _resturant;
        private MenuItem _menuitem;

        public ModifyMenu()
        {

            InitializeComponent();
            _resturant = new Resturant();

            _menuitem = new MenuItem();


        }
        public ModifyMenu(RestaurentDetailsForm form1) : this()
        {
            _form1 = form1;
            _itemId = 0;

        }
        public ModifyMenu(int ItemID, RestaurentDetailsForm form1) : this()
        {
            _form1 = form1;
            _itemId = ItemID;
            

        }

        private void ModifyMenu_Load(object sender, EventArgs e)
        {
            if (_itemId > 0)
            {
                ItemObj item = _menuitem.GetItemInfo(_itemId);
                txtItemName.Text = item.Name;
                txtInfo.Text = item.Info;
                txtPrice.Text = item.Price.ToString();
                

                BtnMode.Text = "Update";
                this.Text = "Update [" + txtItemName.Text + "]";
            }
            else
            {
                BtnMode.Text = "Add";
                this.Text = "New Item";

            }
        }
        public bool ValidateFields()
        {

            var controls = new[] { txtItemName, txtInfo, txtPrice };

            Boolean isValid = true;
            foreach (var control in controls.Where(e => String.IsNullOrWhiteSpace(e.Text)))
            {
                errorProvider1.SetError(control, "Please fill the required field");
                isValid = false;
            }

            return isValid;
        }

        private void BtnMode_Click(object sender, EventArgs e)
        {
            ItemObj item = _menuitem.GetItemInfo(_itemId);
            bool validateresult = ValidateFields();

            if (BtnMode.Text == "Update")
            {

                item.Name = txtItemName.Text;
                item.Price = int.Parse(txtPrice.Text);
                item.Info = txtInfo.Text;
                

                _menuitem.Update(item);
                _form1.UpdateMenu(txtItemName.Text);
            }

            else
            {
                item.Name = txtItemName.Text;
                item.Price = int.Parse(txtPrice.Text);
                item.Info = txtInfo.Text;


                if (validateresult == false)
                {
                    MessageBox.Show("Please Enter Missing Fields");
                }
                else
                {
                    _menuitem.Add(item);

                    _form1.InsertResturants(item.Name);
                }

            } 
        }

        private void ModifyMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure u want to close ?", "Confirm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Dispose();
            }
            else if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
