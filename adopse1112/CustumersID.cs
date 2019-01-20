using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace adopse1112
{
    public partial class CustumersID : Form
    {
        public CustumersID()
        {
            InitializeComponent();
            ComboBoxCustomers();
        }

        private void CustumersID_Load(object sender, EventArgs e)
        {
            
        }

        private void ComboBoxCustomers()
        {

            string strSQL = "SELECT * FROM Customers ";

            try
            {

                using (OleDbConnection cnn = new OleDbConnection(Properties.Settings.Default.NorthwindConnectionString))
                {
                    using (OleDbCommand cmd = new OleDbCommand(strSQL, cnn))
                    {
                        cnn.Open();

                        using (OleDbDataReader dr = cmd.ExecuteReader())
                        {

                            while (dr.Read())
                            {
                                comboBox1.Items.Add(string.Format("{0} ", dr["CustomerID"]));
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string strSQL = "SELECT * FROM Customers where CustomerID='" + comboBox1.Text + "';";

            string id;
            try
            {

                using (OleDbConnection cnn = new OleDbConnection(Properties.Settings.Default.NorthwindConnectionString))
                {
                    using (OleDbCommand cmd = new OleDbCommand(strSQL, cnn))
                    {
                        cnn.Open();

                        using (OleDbDataReader dr = cmd.ExecuteReader())
                        {

                            while (dr.Read())
                            {
                                id = Convert.ToString(dr["CompanyName"]);
                                label1.Text = "" + id;
                                label1.Show();
                                
                            }
                        }
                    } 
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
