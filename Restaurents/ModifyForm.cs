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
       
        Form1 _form2;
        Resturant _resturantObj;
        int Globalid ;
        public ModifyForm()
        {
          
            InitializeComponent();
            
        }
        public ModifyForm(int ResturantID, Form1 form1) : this() 
        {
            _resturantObj = new Resturant();
            _form2 = form1;
            Globalid = ResturantID;
        }

        private void ModifyForm_Load(object sender, EventArgs e)
        {
            BindBox();
            
            using (var con = DataBaseConnection.SqlConnection) 
            {
                DataTable dataTable = new DataTable();
                using (var adapter = new SqlDataAdapter("GetRestaurent", con))
                {

                    adapter.SelectCommand.Parameters.Add("@ID", SqlDbType.Int).Value = Globalid;
                    adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adapter.Fill(dataTable);
                }
                foreach (DataRow row in dataTable.Rows)
                {

                    _resturantObj.Id = int.Parse(row[0].ToString());
                    _resturantObj.Name = row[1].ToString();
                    _resturantObj.RegionId = int.Parse(row[2].ToString());
                    _resturantObj.Address = row[3].ToString();
                    _resturantObj.Hotline = row[4].ToString();


                }
                ResName.Text = _resturantObj.Name;
                Addressbox.Text = _resturantObj.Address;
                Hotlinebox.Text = _resturantObj.Hotline;

            }

        }
        public void BindBox()
        {
            
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
                    Region region = new Region
                    {
                        Id = int.Parse(row[0].ToString()),
                        Name = row[1].ToString()
                    };
                    RegionsList.Add(region);
                }
                ShowAvailableRegions.DataSource = RegionsList;
            };

           



        }

        private void ModifyRestaurent(Resturant resturant) 
        {
          
            using (var con = DataBaseConnection.SqlConnection)
            {
                DataTable dataTable = new DataTable();

                resturant.RegionId = (int)ShowAvailableRegions.SelectedValue;


                using (var adapter = new SqlDataAdapter("ModifyRestaurent", con))
                {

                    adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    
                    adapter.SelectCommand.Parameters.Add("@ID", SqlDbType.Int).Value =_resturantObj.Id ;
                    adapter.SelectCommand.Parameters.Add("@Name", SqlDbType.VarChar).Value =ResName.Text;
                    adapter.SelectCommand.Parameters.Add("@RegionId", SqlDbType.Int).Value =resturant.RegionId ;
                    adapter.SelectCommand.Parameters.Add("@Address", SqlDbType.VarChar).Value = Addressbox.Text;
                    adapter.SelectCommand.Parameters.Add("@Hotline", SqlDbType.VarChar).Value = Hotlinebox.Text;
                    con.Open();
                    adapter.SelectCommand.ExecuteNonQuery();
                    con.Close();

                }

                



            };


        }

        private void ModifyButton_Click(object sender, EventArgs e)
        {
           

                ModifyRestaurent(_resturantObj);
                _form2.ModifyResturants(ResName.Text);
                this.Close();
                this.Dispose();

            
        }
    }
}
