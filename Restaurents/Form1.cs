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
        SqlCommand cmd; 
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            using (var con = DataBaseConnection.SqlConnection)
            {

                cmd = new SqlCommand()
                {
                    CommandText = "GetRestaurent",
                    Connection = con,
                    CommandType = CommandType.StoredProcedure

                };

                //SqlParameter param1 = new SqlParameter
                //{
                //    ParameterName = "@Name",
                //    SqlDbType = SqlDbType.VarChar,
                //    Value = txtSearchRegion.Text,
                //    Direction = ParameterDirection.Input

                //};
                //cmd.Parameters.Add(param1);
                con.Open();
               // DataTable dataTable = new DataTable();
                //using (var adapter = new SqlDataAdapter("GetIDWithRestaurent", con))
                //{
                  //  adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    
                    //adapter.SelectCommand.Parameters.Add("Name", SqlDbType.VarChar).Value = txtSearchRegion.Text;

                    //adapter.Fill(dataTable);
                    


                //};

                
                
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lsRegions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void DisplayRestaurents( int id)


        {
            using (var con = DataBaseConnection.SqlConnection)
            {
                
               
                
                // con.Open();
                DataTable dataTable = new DataTable();

                using (var adapter = new SqlDataAdapter("GetResturantByRegionId", con))
                {
                    adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    


                    adapter.SelectCommand.Parameters.Add("@RegionId", SqlDbType.Int).Value = id;

                    adapter.Fill(dataTable);



                    //};







                }
               
                
                
                lsRestaurents.DataSource = dataTable;
            };
        }

        private void lsRegion_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var con = DataBaseConnection.SqlConnection)
            {
              
                DataTable dataTable = new DataTable();
                using (var adapter = new SqlDataAdapter("GetAllRegions", con))
                {
                    adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                    adapter.Fill(dataTable);
                };
                lsRegion.DataSource = dataTable;
            };

        }

        public void lsRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedId = (int)((DataRowView)lsRegion.SelectedItem).Row.ItemArray[0];

            DisplayRestaurents(selectedId);

            

        }

        private void lsRestaurents_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            PopUPForm popUP = new PopUPForm();
            popUP.ShowDialog();
        }
    }
}
