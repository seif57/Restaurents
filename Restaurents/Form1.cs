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
            List<Resturant> ResturantsList;
            ResturantsList = new List<Resturant>();

            using (var con = DataBaseConnection.SqlConnection)
            {

                DataTable dataTable = new DataTable();


                using (var adapter = new SqlDataAdapter("GetResturantByRegionId2", con))
                {
                    adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                    adapter.SelectCommand.Parameters.Add("@RegionId", SqlDbType.Int).Value = id;

                    adapter.Fill(dataTable);
                }


                foreach (DataRow row in dataTable.Rows)
                {
                    Resturant restaurent = new Resturant();
                    restaurent.Id = int.Parse(row[0].ToString());
                    restaurent.Name = row[1].ToString();
                    restaurent.RegionId = int.Parse(row[2].ToString());
                    restaurent.Address = row[3].ToString();
                    restaurent.Hotline = row[4].ToString();

                    ResturantsList.Add(restaurent);

                }


                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = ResturantsList;







            };

        }
        public void DeleteRestaurent(int id)
        {
            using (var con = DataBaseConnection.SqlConnection)
            {


                using (var adapter = new SqlDataAdapter("DeleteRestaurent", con))
                {
                    adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                    adapter.SelectCommand.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                    con.Open();
                    adapter.SelectCommand.ExecuteNonQuery();
                    con.Close();

                }
            }

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
        private void ModifyRestaurent(int id)
        {
            ModifyForm modifyForm = new ModifyForm(id, this);
            modifyForm.ShowDialog();

        }

        public void lsRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedRegion = (Region)lsRegion.SelectedItem;

            DisplayRestaurents(selectedRegion.Id);
            

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
                    ModifyRestaurent(int.Parse(RestaurentID));

                }


                else if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
                {
                    var resturantName = senderGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                    DialogResult dialogResult = MessageBox.Show("Confirm", "Are you sure u want to delete" + resturantName, MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {

                        DeleteRestaurent(int.Parse(RestaurentID));


                    }
                }

                
            }

            
        }


        public void UpdateResturants(string newResturantName)
        {
            MessageBox.Show(newResturantName + " Inserted Successfully");
        }
        public void ModifyResturants(string newResturantName)
        {
            MessageBox.Show(newResturantName + " Is Modified successfully");
        }

        private void button_AddRestaurent(object sender, EventArgs e)
        {
            PopUPForm popUP = new PopUPForm(this);
            popUP.ShowDialog();
        }
    }
}
