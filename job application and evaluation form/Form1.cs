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
namespace connection_status
{
    public partial class DataUsage : Form
    {
        public DataUsage()
        {
            InitializeComponent();
        }

        SqlConnection cnd = new SqlConnection("Data Source=ACERS;Initial Catalog=damlaaksu;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {

            if (cnd.State.ToString() == "Closed")
            {
                cnd.Open();
                MessageBox.Show("The connection is opened from now.");
            }
            else
            {

                MessageBox.Show("The connection is already opened from now.");
            }


        }

        private void btnclosed_Click(object sender, EventArgs e)
        {
            try
            {
                cnd.Close();
                MessageBox.Show("The connection is closed from now.");
            }
            catch (Exception)
            {
                MessageBox.Show("The connection is already closed from now.");
            }

        }

        private void btnconnection_Click(object sender, EventArgs e)
        {
            MessageBox.Show("your connection status is " + cnd.State.ToString());

        }


        private void btntab2datagridview_Click(object sender, EventArgs e)
        {
            SqlCommand order = new SqlCommand();
            order.CommandText = "SELECT * FROM APPLICANTS";
            order.Connection = cnd;
            SqlDataAdapter adap = new SqlDataAdapter(order);
            DataTable applicants = new DataTable();
            adap.Fill(applicants);
            dataGridView1.DataSource = applicants;
        }

        private void btntab2listview_Click(object sender, EventArgs e)
        {
            SqlCommand order = new SqlCommand();
            order.CommandText = "SELECT * FROM APPLICANTS";
            order.Connection = cnd;
            SqlDataAdapter adap = new SqlDataAdapter(order);
            DataTable applicants = new DataTable();
            adap.Fill(applicants);
            for (int i = 0; i < applicants.Rows.Count; i++)
            {
                listView1.Items.Add(applicants.Rows[i]["namesurname"].ToString());
                listView1.Items[i].SubItems.Add(applicants.Rows[i]["age"].ToString());
                listView1.Items[i].SubItems.Add(applicants.Rows[i]["graduationdepartment"].ToString());
                listView1.Items[i].SubItems.Add(applicants.Rows[i]["militarystatus"].ToString());
                listView1.Items[i].SubItems.Add(applicants.Rows[i]["englishknowledge"].ToString());
                listView1.Items[i].SubItems.Add(applicants.Rows[i]["csharpknowledge"].ToString());
            }


        }

        private void btnadddata_Click(object sender, EventArgs e)
        {
            SqlCommand order = new SqlCommand("INSERT INTO APPLICANTS (NAMESURNAME,AGE,GRADUATIONDEPARTMENT,MILITARYSTATUS,ENGLISHKNOWLEDGE,CSHARPKNOWLEDGE) VALUES(@NAMESURNAME, @AGE , @GRADUATIONDEPARTMENT,@MILITARYSTATUS,@ENGLISHKNOWLEDGE,@CSHARPKNOWLEDGE)", cnd);

            order.Parameters.AddWithValue("@NAMESURNAME", txtnamesurname.Text);
            order.Parameters.AddWithValue("@AGE", Convert.ToInt32(txtage.Text));
            order.Parameters.AddWithValue("@GRADUATIONDEPARTMENT", txtgraduation.Text);
            order.Parameters.AddWithValue("@MILITARYSTATUS", chkmilitary.Checked);
            order.Parameters.AddWithValue("@ENGLISHKNOWLEDGE", chkenglish.Checked);
            order.Parameters.AddWithValue("@CSHARPKNOWLEDGE", chkcsharp.Checked);
            cnd.Open();
            order.ExecuteNonQuery();
            cnd.Close();
            MessageBox.Show("new data record has been added succesfully");




        }

        private void DataUsage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'damlaaksuDataSet.applicants' table. You can move, or remove it, as needed.
            this.applicantsTableAdapter.Fill(this.damlaaksuDataSet.applicants);
            SqlCommand order = new SqlCommand();
            order.CommandText = "SELECT * FROM APPLICANTS";
            order.Connection = cnd;
            SqlDataAdapter adap = new SqlDataAdapter(order);
            DataTable applicants = new DataTable();
            adap.Fill(applicants);
            for (int i = 0; i < applicants.Rows.Count; i++)
            {
                listView2.Items.Add(applicants.Rows[i]["namesurname"].ToString());
                listView2.Items[i].SubItems.Add(applicants.Rows[i]["age"].ToString());
                listView2.Items[i].SubItems.Add(applicants.Rows[i]["graduationdepartment"].ToString());
                listView2.Items[i].SubItems.Add(applicants.Rows[i]["militarystatus"].ToString());
                listView2.Items[i].SubItems.Add(applicants.Rows[i]["englishknowledge"].ToString());
                listView2.Items[i].SubItems.Add(applicants.Rows[i]["csharpknowledge"].ToString());
            }
        }

        private void btndatadelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand order = new SqlCommand("DELETE FROM APPLICANTS WHERE GRADUATIONDEPARTMENT=@GRADUATIONDEPARTMENT", cnd);
                order.Parameters.AddWithValue("@GRADUATIONDEPARTMENT", Convert.ToString(listView2.SelectedItems[0].SubItems[2].Text));
                cnd.Open();
                order.ExecuteNonQuery();
                cnd.Close();
                MessageBox.Show("the selected data record has been deleted.");
            }
            catch (Exception)
            {
                MessageBox.Show("there is no selected data");
            }

            listView2.Items.Clear();

            SqlCommand order2 = new SqlCommand();
            order2.CommandText = "SELECT * FROM APPLICANTS";
            order2.Connection = cnd;
            SqlDataAdapter adap = new SqlDataAdapter(order2);
            DataTable applicants = new DataTable();
            adap.Fill(applicants);
            for (int i = 0; i < applicants.Rows.Count; i++)
            {
                listView2.Items.Add(applicants.Rows[i]["namesurname"].ToString());
                listView2.Items[i].SubItems.Add(applicants.Rows[i]["age"].ToString());
                listView2.Items[i].SubItems.Add(applicants.Rows[i]["graduationdepartment"].ToString());
                listView2.Items[i].SubItems.Add(applicants.Rows[i]["militarystatus"].ToString());
                listView2.Items[i].SubItems.Add(applicants.Rows[i]["englishknowledge"].ToString());
                listView2.Items[i].SubItems.Add(applicants.Rows[i]["csharpknowledge"].ToString());

            }
        }

        int stdage;
        string stdmilitary;
        string stdenglish;
        string stdcsharp;

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                stdage = Convert.ToInt32(listView2.SelectedItems[0].SubItems[1].Text);
                txtname.Text = listView2.SelectedItems[0].Text;
                txtagee.Text = listView2.SelectedItems[0].SubItems[1].Text;
                txtgraduationdep.Text = listView2.SelectedItems[0].SubItems[2].Text;
                stdmilitary = listView2.SelectedItems[0].SubItems[3].Text;
                stdenglish = listView2.SelectedItems[0].SubItems[4].Text;
                stdcsharp = listView2.SelectedItems[0].SubItems[5].Text;

                if (listView2.SelectedItems[0].SubItems[3].Text == "True")
                {
                    chkmilitaryyy.Checked = true;
                    //MessageBox.Show(listView2.SelectedItems[0].SubItems[3].Text);

                }

                if (listView2.SelectedItems[0].SubItems[3].Text == "False")
                {

                    chkmilitaryyy.Checked = false;
                    //MessageBox.Show(listView2.SelectedItems[0].SubItems[3].Text);
                }

                if (listView2.SelectedItems[0].SubItems[4].Text == "True")
                {
                    chkengg.Checked = true;
                    //MessageBox.Show(listView2.SelectedItems[0].SubItems[4].Text);

                }

                if (listView2.SelectedItems[0].SubItems[4].Text == "False")
                {
                    chkengg.Checked = false;
                    //MessageBox.Show(listView2.SelectedItems[0].SubItems[4].Text);

                }

                if (listView2.SelectedItems[0].SubItems[5].Text == "True")
                {
                    //MessageBox.Show(listView2.SelectedItems[0].SubItems[5].Text);
                    chkcsharppp.Checked = true;
                }

                else
                {
                    chkcsharppp.Checked = false;
                    //MessageBox.Show(listView2.SelectedItems[0].SubItems[5].Text);

                }

            }


            catch (Exception)
            {

                MessageBox.Show("there is a data selection");
            }

        }
        int stdagee;
        private void btndataupdate_Click(object sender, EventArgs e)
        {
            stdagee = Convert.ToInt32(listView2.SelectedItems[0].SubItems[1].Text);
            SqlCommand order = new SqlCommand("UPDATE APPLICANTS SET NAMESURNAME= @NAMESURNAME , AGE=@AGE , GRADUATIONDEPARTMENT=@GRADUATIONDEPARTMENT , MILITARYSTATUS=@MILITARYSTATUS , ENGLISHKNOWLEDGE=@ENGLISHKNOWLEDGE , CSHARPKNOWLEDGE=@CSHARPKNOWLEDGE WHERE NAMESURNAME=@NAMESURNAME", cnd);
            order.Parameters.AddWithValue("@NAMESURNAME", txtname.Text);
            order.Parameters.AddWithValue("@AGE", Convert.ToInt32(txtagee.Text));
            order.Parameters.AddWithValue("@GRADUATIONDEPARTMENT", txtgraduationdep.Text);
            order.Parameters.AddWithValue("@MILITARYSTATUS", chkmilitaryyy.Checked);
            order.Parameters.AddWithValue("@ENGLISHKNOWLEDGE", chkengg.Checked);
            order.Parameters.AddWithValue("@CSHARPKNOWLEDGE", chkcsharppp.Checked);
            cnd.Open();
            order.ExecuteNonQuery();
            cnd.Close();
            MessageBox.Show("The current data record has been updated succesfully");


            listView2.Items.Clear();
            SqlCommand order2 = new SqlCommand();
            order2.CommandText = "SELECT * FROM APPLICANTS";
            order2.Connection = cnd;
            SqlDataAdapter adap = new SqlDataAdapter(order2);
            DataTable applicants = new DataTable();
            adap.Fill(applicants);
            for (int i = 0; i < applicants.Rows.Count; i++)
            {
                listView2.Items.Add(applicants.Rows[i]["namesurname"].ToString());
                listView2.Items[i].SubItems.Add(applicants.Rows[i]["age"].ToString());
                listView2.Items[i].SubItems.Add(applicants.Rows[i]["graduationdepartment"].ToString());
                listView2.Items[i].SubItems.Add(applicants.Rows[i]["militarystatus"].ToString());
                listView2.Items[i].SubItems.Add(applicants.Rows[i]["englishknowledge"].ToString());
                listView2.Items[i].SubItems.Add(applicants.Rows[i]["csharpknowledge"].ToString());

            }
        }

        private void btnviewevaluate_Click(object sender, EventArgs e)
        {


            SqlCommand order = new SqlCommand();
            order.CommandText = "SELECT * FROM APPLICANTS WHERE AGE <= 30 and(GRADUATIONDEPARTMENT = 'computer engineering' or GRADUATIONDEPARTMENT = 'software engineering') and MILITARYSTATUS = 'True' and ENGLISHKNOWLEDGE = 'True' and CSHARPKNOWLEDGE = 'True'";

            order.Connection = cnd;
            SqlDataAdapter adap = new SqlDataAdapter(order);
            DataTable applicants = new DataTable();
            adap.Fill(applicants);
            dataevaluation.DataSource = applicants;
            

        }

        
    }
}
