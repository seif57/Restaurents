﻿using System;
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
        public PopUPForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void AddRestaurent()


        {
            using (var con = DataBaseConnection.SqlConnection)
            {



                
                DataTable dataTable = new DataTable();

                using (var adapter = new SqlDataAdapter("AddRestaurent", con))
                {

                    adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adapter.SelectCommand.Parameters.Add("@Name", SqlDbType.VarChar).Value = textBox1.Text;
                    adapter.SelectCommand.Parameters.Add("@RegionId", SqlDbType.Int).Value = textBox2.Text;

                    adapter.Fill(dataTable);

                }



                
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var con = DataBaseConnection.SqlConnection)
            {

                DataTable dataTable = new DataTable();
                using (var adapter = new SqlDataAdapter("AddRestaurent", con))
                {
                    AddRestaurent();

                };
                
            };

        }
    }
}