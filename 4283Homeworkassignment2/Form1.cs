using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//This using statement is for connecting to sql
using System.Data.SqlClient;

namespace _4283Homeworkassignment2
{
    public partial class Form1 : Form
    {
        //////////////////////////////////////////////////
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader datareader;
        //string connectionstring = "Data Source=essql1.walton.uark.edu;Initial Catalog=smnolan;User ID=smnolan;password=GohogsUA1";
        string connectionstring = "Data Source=essql1.walton.uark.edu;Initial Catalog=smnolan;User ID=smnolan;trusted_connection=True";
        //////////////////////////////////////////////////
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'smnolanDataSet.Campaign' table. You can move, or remove it, as needed.
            this.campaignTableAdapter.Fill(this.smnolanDataSet.Campaign);
            //////////////////////////////////////////////////
            //connection is a variable that gets me to sql  server
            connection = new SqlConnection(connectionstring);
            connection.Open();
            string sql = "SELECT Character_Name FROM Character2";
            command = new SqlCommand(sql,connection);
            datareader = command.ExecuteReader();
            while(datareader.Read())
            {
                cbocharname.Items.Add(datareader[0].ToString());
            }
            connection.Close();
            datareader.Close();
            command.Dispose();
            //////////////////////////////////////////////////
        }

        private void cbocharname_SelectedIndexChanged(object sender, EventArgs e)
        {
            //////////////////////////////////////////////////
            if (cbocharname.SelectedIndex > -1)
            {
                lstquestname.Items.Clear();
                connection = new SqlConnection(connectionstring);
                connection.Open();
                string sql = "SELECT Quest_Name FROM Quests2";
                command = new SqlCommand(sql, connection);
                datareader = command.ExecuteReader();
                while (datareader.Read())
                {
                    lstquestname.Items.Add(datareader[0].ToString());
                }
                connection.Close();
                datareader.Close();
                command.Dispose();


                connection.Open();
                sql = "SELECT Character_ID, Class, Hit_Points, Player_Name FROM character2 WHERE Character_Name = '" + cbocharname.SelectedItem.ToString() + "'";
                command = new SqlCommand(sql, connection);
                datareader = command.ExecuteReader();
                while (datareader.Read())
                {
                    txtcharid.Text = datareader[0].ToString();
                    txtclass.Text = datareader[1].ToString();
                    txthp.Text = datareader[2].ToString();
                    txtplayername.Text = datareader[3].ToString();
                }
                connection.Close();
                datareader.Close();
                command.Dispose();
            }
            else
            {

            }
            //////////////////////////////////////////////////
        }

        private void lstquestname_SelectedIndexChanged(object sender, EventArgs e)
        {
            //////////////////////////////////////////////////
            connection = new SqlConnection(connectionstring);
            connection.Open();
            string sql = "SELECT * FROM campaign WHERE Character_Id = '" + txtcharid.Text + "'";

            var da = new SqlDataAdapter(sql, connection);
            var ds = new DataSet();
            da.Fill(ds);

            dgvcampaign.DataSource = ds.Tables[0];

            connection.Close();
            datareader.Close();
            command.Dispose();


            connection.Open();
            sql = "SELECT Quest_ID, Difficulty, Quest_Type, NPC, Reward FROM Quests2 WHERE Quest_Name = '" + lstquestname.SelectedItem.ToString() + "'";
            command = new SqlCommand(sql, connection);
            datareader = command.ExecuteReader();
            while (datareader.Read())
            {
                txtqid.Text = datareader[0].ToString();
                txtdiff.Text = datareader[1].ToString();
                txtquesttype.Text = datareader[2].ToString();
                txtnpc.Text = datareader[3].ToString();
                txtreward.Text = datareader[4].ToString();
            }
            connection.Close();
            datareader.Close();
            command.Dispose();
            //////////////////////////////////////////////////
        }

        private void dgvcampaign_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //////////////////////////////////////////////////
            txtstatus.Text = dgvcampaign.CurrentRow.Cells[3].Value.ToString();
            txtdesc.Text = dgvcampaign.CurrentRow.Cells[4].Value.ToString();
            txtadate.Text = dgvcampaign.CurrentRow.Cells[5].Value.ToString();
            //////////////////////////////////////////////////
        }

        private void btncinsert_Click(object sender, EventArgs e)
        {
            //////////////////////////////////////////////////
            connection = new SqlConnection(connectionstring);
            connection.Open();
            string sql = "INSERT INTO Character2 VALUES (@CName, @Class, @HP, @PName)";
            int answer;
            command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@CName",txtnewchar.Text);
            command.Parameters.AddWithValue("@Class", txtclass.Text);
            command.Parameters.AddWithValue("@HP", txthp.Text);
            command.Parameters.AddWithValue("@PName", txtplayername.Text);

            answer = command.ExecuteNonQuery();

            connection.Close();
            command.Dispose();
            MessageBox.Show("Successfully entered in " + answer + " rows");
            //////////////////////////////////////////////////
        }

        private void btncupdate_Click(object sender, EventArgs e)
        {
            //////////////////////////////////////////////////
            try
            {
                connection = new SqlConnection(connectionstring);
                connection.Open();
                string sql = "UPDATE Character2 SET Character_Name=@CName, Class=@Class, Hit_Points=@HP, Player_Name=@PName WHERE Character_ID=@CID";
                int answer;
                command = new SqlCommand(sql, connection);

                command.Parameters.AddWithValue("@CName", cbocharname.SelectedItem.ToString());
                command.Parameters.AddWithValue("@Class", txtclass.Text);
                command.Parameters.AddWithValue("@HP", txthp.Text);
                command.Parameters.AddWithValue("@PName", txtplayername.Text);
                command.Parameters.AddWithValue("@CID", txtcharid.Text);

                answer = command.ExecuteNonQuery();

                connection.Close();
                command.Dispose();
                MessageBox.Show("Successfully updated in " + answer + " rows");
            }catch (Exception ex)
            {
                MessageBox.Show("Error! please fix this issue: " + ex);
            }
            //////////////////////////////////////////////////
        }

        private void btncdelete_Click(object sender, EventArgs e)
        {
            //////////////////////////////////////////////////
            connection = new SqlConnection(connectionstring);
            connection.Open();
            string sql = "DELETE FROM Character2 WHERE Character_ID=@CID";
            int answer;
            command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@CID", txtcharid.Text);

            answer = command.ExecuteNonQuery();

            connection.Close();
            command.Dispose();
            MessageBox.Show("Successfully Deleted " + answer + " rows");
            //////////////////////////////////////////////////
        }

        private void btnqinsert_Click(object sender, EventArgs e)
        {
            //////////////////////////////////////////////////
            connection = new SqlConnection(connectionstring);
            connection.Open();
            string sql = "INSERT INTO Quests2 VALUES (@diff, @QName, @Type, @NPC, @Reward)";
            int answer;
            command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@diff", txtdiff.Text);
            command.Parameters.AddWithValue("@QName", txtnewquest.Text);
            command.Parameters.AddWithValue("@Type", txtquesttype.Text);
            command.Parameters.AddWithValue("@NPC", txtnpc.Text);
            command.Parameters.AddWithValue("@Reward", txtreward.Text);

            answer = command.ExecuteNonQuery();

            connection.Close();
            command.Dispose();
            MessageBox.Show("Successfully entered in " + answer + " rows");
            //////////////////////////////////////////////////
        }

        private void btnqupdate_Click(object sender, EventArgs e)
        {
            //////////////////////////////////////////////////
            connection = new SqlConnection(connectionstring);
            connection.Open();
            string sql = "UPDATE Quests2 SET Difficulty=@diff, Quest_Name=@QName, Quest_Type=@Type, NPC=@NPC, Reward=@Reward WHERE Quest_ID=@QID";
            int answer;
            command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@diff", txtdiff.Text);
            command.Parameters.AddWithValue("@QName", lstquestname.SelectedItem.ToString());
            command.Parameters.AddWithValue("@Type", txtquesttype.Text);
            command.Parameters.AddWithValue("@NPC", txtnpc.Text);
            command.Parameters.AddWithValue("@Reward", txtreward.Text);
            command.Parameters.AddWithValue("@QID", txtqid.Text);

            answer = command.ExecuteNonQuery();

            connection.Close();
            command.Dispose();
            MessageBox.Show("Successfully Modified in " + answer + " rows");
            //////////////////////////////////////////////////
        }

        private void btnqdelete_Click(object sender, EventArgs e)
        {
            //////////////////////////////////////////////////
            connection = new SqlConnection(connectionstring);
            connection.Open();
            string sql = "DELETE FROM Quests2 WHERE Quest_ID=@QID";
            int answer;
            command = new SqlCommand(sql, connection);

            
            command.Parameters.AddWithValue("@QID", txtqid.Text);

            answer = command.ExecuteNonQuery();

            connection.Close();
            command.Dispose();
            MessageBox.Show("Successfully Deleted in " + answer + " rows");
            //////////////////////////////////////////////////
        }

        private void btnainsert_Click(object sender, EventArgs e)
        {
            //////////////////////////////////////////////////
            connection = new SqlConnection(connectionstring);
            connection.Open();
            string sql = "INSERT INTO Campaign VALUES (@CID, @QID, @Status, @Desc, @ADate)";
            int answer;
            command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@CID", txtcharid.Text);
            command.Parameters.AddWithValue("@QID", txtqid.Text);
            command.Parameters.AddWithValue("@Status", txtstatus.Text);
            command.Parameters.AddWithValue("@Desc", txtdesc.Text);
            command.Parameters.AddWithValue("@ADate", txtadate.Text);

            answer = command.ExecuteNonQuery();

            connection.Close();
            command.Dispose();
            MessageBox.Show("Successfully entered in " + answer + " rows");
            //////////////////////////////////////////////////
        }

        private void btnaupdate_Click(object sender, EventArgs e)
        {
            //////////////////////////////////////////////////
            connection = new SqlConnection(connectionstring);
            connection.Open();
            string sql = "UPDATE Campaign SET Status=@Status, Description=@Desc, Accept_Date=@ADate WHERE Campaign_ID=@CAID";
            int answer;
            command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@CAID", dgvcampaign.CurrentRow.Cells[0].Value.ToString());
            command.Parameters.AddWithValue("@Status", txtstatus.Text);
            command.Parameters.AddWithValue("@Desc", txtdesc.Text);
            command.Parameters.AddWithValue("@ADate", txtadate.Text);

            answer = command.ExecuteNonQuery();

            connection.Close();
            command.Dispose();
            MessageBox.Show("Successfully entered in " + answer + " rows");
            //////////////////////////////////////////////////
        }

        private void btnadelete_Click(object sender, EventArgs e)
        {
            //////////////////////////////////////////////////
            connection = new SqlConnection(connectionstring);
            connection.Open();
            string sql = "DELETE FROM Campaign WHERE Campaign_ID=@CAID";
            int answer;
            command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@CAID", dgvcampaign.CurrentRow.Cells[0].Value.ToString());
            
            answer = command.ExecuteNonQuery();

            connection.Close();
            command.Dispose();
            MessageBox.Show("Successfully entered in " + answer + " rows");
            //////////////////////////////////////////////////
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            //////////////////////////////////////////////////
            cbocharname.SelectedIndex = -1;
            lstquestname.Items.Clear();
            dgvcampaign.DataSource = null;
            txtcharid.Text = "";
            //////////////////////////////////////////////////
        }

        private void txtclass_TextChanged(object sender, EventArgs e)
        {
            "SELECT * FROM table WHERE CLASS LIKE "
        }

       
    }
}
