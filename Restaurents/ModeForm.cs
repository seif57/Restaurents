using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Restaurents
{
    public partial class ModeForm : Form
    {

        HomePageForm _form2;
        private Resturant _resturant;
        private Region _region;
        private int _currentresturantId;
        public ModeForm()
        {

            InitializeComponent();
            _resturant = new Resturant();
            _region = new Region();
            BindBox();

        }
        public ModeForm(HomePageForm form1) : this()
        {
            _form2 = form1;
            _currentresturantId = 0;
        }
        public ModeForm(int ResturantID, HomePageForm form1) : this()
        {
            _form2 = form1;
            _currentresturantId = ResturantID;

        }

        private void ModifyForm_Load(object sender, EventArgs e)
        {

            if (_currentresturantId > 0)
            {
                ResturantObj resturantObj = _resturant.GetById(_currentresturantId);
                txtResturantName.Text = resturantObj.Name;
                txtAddress.Text = resturantObj.Address;
                txtHotline.Text = resturantObj.Hotline;

                btnModify.Text = "Update";
                this.Text = "Update [" + txtResturantName.Text + "]";
            }
            else
            {
                btnModify.Text = "Add";
                this.Text = "New Resturant";

            }
        }
        public int BindBox()
        {

            List<RegionObj> regionList = _region.DisplayRegions();
            ShowAvailableRegions.DataSource = regionList;

            return _currentresturantId = (int)ShowAvailableRegions.SelectedValue;
        }

        public bool ValidateFields()
        {

            var controls = new[] { txtResturantName, txtAddress, txtHotline };

            Boolean isValid = true;
            foreach (var control in controls.Where(e => String.IsNullOrWhiteSpace(e.Text)))
            {
                errorProvider1.SetError(control, "Please fill the required field");
                isValid = false;
            }

            return isValid;
        }
        private void ModifyButton_Click(object sender, EventArgs e)
        {
            ResturantObj resturantObj = _resturant.GetById(_currentresturantId);
            bool validateresult = ValidateFields();

            if (btnModify.Text=="Update")
            {
                
                resturantObj.Name = txtResturantName.Text;
                resturantObj.RegionId = (int)ShowAvailableRegions.SelectedValue;
                resturantObj.Address = txtAddress.Text;
                resturantObj.Hotline = txtHotline.Text;

                _resturant.Update(resturantObj);
                _form2.UpdateResturants(txtResturantName.Text);
            }

            else
            {
                resturantObj.Name = txtResturantName.Text;
                resturantObj.RegionId = (int)ShowAvailableRegions.SelectedValue;
                resturantObj.Address = txtAddress.Text;
                resturantObj.Hotline = txtHotline.Text;
                

                if (validateresult==false )
                {
                    MessageBox.Show("Please Enter Missing Fields");
                }
                else
                {
                    _resturant.Add(resturantObj);

                    _form2.InsertResturants(resturantObj.Name);
                } 
            } 
            



        }

        private void ModifyForm_FormClosing(object sender, FormClosingEventArgs e)
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
