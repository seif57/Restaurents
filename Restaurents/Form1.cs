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
    public partial class Form1 : Form
    {

        List<Region> RegionsList;
        public Form1()
        {
            InitializeComponent();
        }


        private void DisplayRestaurents(int id)


        {
            using (var con = DataBaseConnection.SqlConnection)
            {
                                           
                DataTable dataTable = new DataTable();

                using (var adapter = new SqlDataAdapter("GetResturantByRegionId", con))
                {
                    adapter.SelectCommand.CommandType = CommandType.StoredProcedure;                    

                    adapter.SelectCommand.Parameters.Add("@RegionId", SqlDbType.Int).Value = id;

                    adapter.Fill(dataTable);
                }
                                           
                lsRestaurents.DataSource = dataTable;
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RegionsList = new List<Region>();
            DisplayRegions();

        }

        private void DisplayRegions()
        {
            using (var con = DataBaseConnection.SqlConnection)
            {

                DataTable dataTable = new DataTable();
                using (var adapter = new SqlDataAdapter("GetAllRegions", con))
                {
                    adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adapter.Fill(dataTable);
                };

                foreach (DataRow row in dataTable.Rows)
                {
                    Region region = new Region();
                    region.Id = int.Parse(row[0].ToString());
                    region.Name = row[1].ToString();
                    RegionsList.Add(region);
                }
                lsRegion.DataSource = RegionsList;
            };
        }

        public void lsRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedRegion = (Region)lsRegion.SelectedItem;

            DisplayRestaurents(selectedRegion.Id);
        }

        private void lsRestaurents_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            PopUPForm popUP = new PopUPForm(this);

            popUP.ShowDialog();
        }

        public void UpdateResturants(string newResturantName)
        {
            MessageBox.Show(newResturantName + " Inserted Successfully");
        }
    }
}
