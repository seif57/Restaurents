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
    public partial class PopUPForm : Form
    {
        Form1 _form1;
        public PopUPForm()
        {
            InitializeComponent();
            BindBox();
        }

        public PopUPForm(Form1 form1)
        {
            _form1 = form1;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        public int BindBox( )
        {
            int id;
            List<Region> RegionsList;
            RegionsList = new List<Region>();

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
                ShowAvailableRegions.DataSource = RegionsList;
            };
                
                return  id = (int)ShowAvailableRegions.SelectedValue;

            

        }

        private void AddRestaurent()


        {
            using (var con = DataBaseConnection.SqlConnection)
            {


                
                DataTable dataTable = new DataTable();

                using (var adapter = new SqlDataAdapter("AddRestaurent", con))
                {

                    adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adapter.SelectCommand.Parameters.Add("@Name", SqlDbType.VarChar).Value = ResName.Text;
                    adapter.SelectCommand.Parameters.Add("@RegionId", SqlDbType.Int).Value = BindBox();
                    adapter.SelectCommand.Parameters.Add("@Address", SqlDbType.VarChar).Value = Addressbox.Text;
                    adapter.SelectCommand.Parameters.Add("@Hotline", SqlDbType.VarChar).Value = Hotlinebox.Text;



                    adapter.Fill(dataTable);

                }



                
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var con = DataBaseConnection.SqlConnection)
            {
                
                    AddRestaurent();
                _form1.UpdateResturants(ResName.Text);
                this.Close();
                this.Dispose();

            };

        }

        
    }
}
