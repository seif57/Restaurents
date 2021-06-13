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
    public partial class HomePageForm : Form
    {
        private Resturant _resturant;
        private Region _region;
        private int currentRegionId;
        public HomePageForm()
        {
            InitializeComponent();
            _resturant = new Resturant();
            _region = new Region();
        }


        private void DisplayRestaurents(int id)
        {
             
            List<ResturantObj>  ResturantsList = _resturant.GetByRegionId(id);

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = ResturantsList;
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<RegionObj> regionList = _region.DisplayRegions();
            lsRegion.DataSource = regionList;                     
        }
        public void lsRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedRegion = (RegionObj)lsRegion.SelectedItem;
            currentRegionId = selectedRegion.Id;
            lblRegion.Text = selectedRegion.Name;
            DisplayRestaurents(currentRegionId);

          
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string RestaurentID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
               e.RowIndex >= 0)

            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Modify")
                {
                    ModeForm modifyForm = new ModeForm(int.Parse(RestaurentID), this);
                    modifyForm.ShowDialog();
                }


                else if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
                {
                    var resturantName = senderGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                    DialogResult dialogResult = MessageBox.Show("Are you sure u want to delete [" + resturantName + "]", "Confirm", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        int id = int.Parse(RestaurentID);
                        _resturant.Delete(id);
                        dataGridView1.DataSource = _resturant.GetByRegionId(currentRegionId);
                    }
                }

                



                
            }

            
        }

        public void UpdateResturants(string newResturantName)
        {
            dataGridView1.DataSource = _resturant.GetByRegionId(currentRegionId);
            MessageBox.Show(newResturantName + " Update Successfully");
        }
        public void InsertResturants(string newResturantName)
        {
            dataGridView1.DataSource = _resturant.GetByRegionId(currentRegionId);
            MessageBox.Show(newResturantName + " InsertSsuccessful");
        }
        private void button_AddRestaurent(object sender, EventArgs e)
        {
            var popUP = new ModeForm(this);
            popUP.ShowDialog();

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var selectedRegion = (RegionObj)lsRegion.SelectedItem;

            string RestaurentID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            RestaurentDetailsForm form2 = new RestaurentDetailsForm(int.Parse(RestaurentID), selectedRegion.Name, this);
            form2.ShowDialog();

        }

        
    }
}
