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
    public partial class AddRestaurentForm : Form
    {
        HomePageForm _form1;
        private Resturant _resturant;
        private Region _region;
        private int _currentRegionId;
        public AddRestaurentForm()
        {
            InitializeComponent();
            _resturant = new Resturant();
            _region = new Region();

            BindBox();
        }

        public AddRestaurentForm(HomePageForm form1) : this()
        {
            _form1 = form1;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        public int BindBox()
        { 
            List<RegionObj> regionList = _region.DisplayRegions();        
            ShowAvailableRegions.DataSource = regionList;
           
            return _currentRegionId=(int)ShowAvailableRegions.SelectedValue;
        }


        private void InsertButton_Click(object sender, EventArgs e)
        {
            ResturantObj resturantObj = new ResturantObj();
            resturantObj.Name = txtResturantName.Text;
            resturantObj.RegionId = _currentRegionId;
            resturantObj.Address = txtAddress.Text;
            resturantObj.Hotline = txtHotline.Text;

            _resturant.Add(resturantObj);

            _form1.InsertResturants(resturantObj.Name);

           

        }

        private void AddRestaurentForm_FormClosing(object sender, FormClosingEventArgs e)
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
