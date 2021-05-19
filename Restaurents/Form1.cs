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
            listView.Clear();
            using (var con = DataBaseConnection.SqlConnection)
            {

                DataTable dataTable = new DataTable();
                listView.View = View.Details;

                using (var adapter = new SqlDataAdapter("GetResturantByRegionId2", con))
                {
                    adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                    adapter.SelectCommand.Parameters.Add("@RegionId", SqlDbType.Int).Value = id;

                    adapter.Fill(dataTable);
                }




                for (int i = 0; i < dataTable.Rows.Count; i++)
                {

                    DataRow dr = dataTable.Rows[i];

                    ListViewItem listItem = new ListViewItem(dr["Name"].ToString());
                    listItem.SubItems.Add(dr["RegionId"].ToString());
                    listItem.SubItems.Add(dr["Address"].ToString());
                    listItem.SubItems.Add(dr["Hotline"].ToString());
                    listView.Items.Add(listItem);

                }
                listView.Columns.Add("Name");
                listView.Columns.Add("RegionId");
                listView.Columns.Add("Address");
                listView.Columns.Add("Hotline");
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


        public void UpdateResturants(string newResturantName)
        {
            MessageBox.Show(newResturantName + " Inserted Successfully");
        }

        private void button_AddRestaurent(object sender, EventArgs e)
        {
            PopUPForm popUP = new PopUPForm();
            popUP.ShowDialog();
        }
    }
}
