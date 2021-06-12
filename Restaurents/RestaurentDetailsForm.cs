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
    public partial class RestaurentDetailsForm : Form
    {
        private Resturant _resturant;
        private int _restaurentId;
        private string _regionName;
        private MenuItem _menuitem;


        public RestaurentDetailsForm()
        {
            InitializeComponent();
            _resturant = new Resturant();

        }
        public RestaurentDetailsForm(int ResturantID,string RegionName,  HomePageForm form1) : this()
        {

            _restaurentId = ResturantID;
            _regionName = RegionName;
            _menuitem = new MenuItem();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ResturantObj resturantObj = _resturant.GetById(_restaurentId);
            lblResturantName.Text = resturantObj.Name;
            lblRegionName.Text = _regionName;
            lblAddressinfo.Text = resturantObj.Address;
            lblHotlineinfo.Text = resturantObj.Hotline;
            List<ItemObj> itemObjsList = _menuitem.GetMenuById(_restaurentId);
            dataGridMenu.AutoGenerateColumns = false;
            dataGridMenu.DataSource = itemObjsList;

        }

        private void RestaurentDetailsForm_FormClosing(object sender, FormClosingEventArgs e)
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
