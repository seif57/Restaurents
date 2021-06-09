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
    public partial class ModifyForm : Form
    {
       
        HomePageForm _form2;
        private Resturant _resturant;
        private Region _region;
        private int _currentresturantId;
        public ModifyForm()
        {
          
            InitializeComponent();
            _resturant = new Resturant();
            _region = new Region();
             BindBox();

        }
        public ModifyForm(int ResturantID, HomePageForm form1) : this() 
        {
            _form2 = form1;
            _currentresturantId = ResturantID;

        }

        private void ModifyForm_Load(object sender, EventArgs e)
        {

            ResturantObj resturantObj = _resturant.GetById(_currentresturantId);
            txtResturantName.Text = resturantObj.Name;
            txtAddress.Text = resturantObj.Address;
            txtHotline.Text = resturantObj.Hotline;

        }
        public int BindBox()
        {

            List<RegionObj> regionList = _region.DisplayRegions();
            ShowAvailableRegions.DataSource = regionList;

            return _currentresturantId = (int)ShowAvailableRegions.SelectedValue;
        }

        private void ModifyButton_Click(object sender, EventArgs e)
        {
            ResturantObj resturantObj = _resturant.GetById(_currentresturantId); ;
            resturantObj.Name = txtResturantName.Text;
            resturantObj.RegionId = (int)ShowAvailableRegions.SelectedValue; ;
            resturantObj.Address = txtAddress.Text;
            resturantObj.Hotline = txtHotline.Text;

            _resturant.Update(resturantObj);
            _form2.UpdateResturants(txtResturantName.Text);


            
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
