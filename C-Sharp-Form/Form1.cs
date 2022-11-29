using Devart.Data.PostgreSql;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace C_Sharp_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PannelDashboard.Visible = false;
            PannelLogin.Visible = true;

            LblInvalidCredentials.Visible = false;
            LblSucessfulConnect.Visible = false;
            LblMatch.Visible = false;

            PannelChangePassword.Visible = false;
            LblChooseNewPassword.Visible = false;
            LblPasswordsDifferent.Visible = false;
            LblInvalidOgUernameOrPassword.Visible = false;
            LblUnknownError.Visible = false;
        }

        String UsernameMatch;
        String PasswordMatch;

        private void btnLogin_Click(object sender, EventArgs e) //String ReadUsername, String ReadPassword)
        {
            string connetionString;
            NpgsqlConnection cnn;
            connetionString = @"Host=db.bit.io,5432;Username=Bmonky13;Password=v2_3uK8C_jArJzeSymZ9haEmzqwgLusg;Database=Bmonky13.Classified";
            cnn = new NpgsqlConnection(connetionString);

            string txtUsernameValue = txtUsername.Text;
            string txtPasswordValue = txtPassword.Text;

            LblInvalidCredentials.Visible = false;
            LblSucessfulConnect.Visible = false;
            LblMatch.Visible = false;

            try
            {
                cnn.Open();
            }
            catch (NpgsqlException)
            {
                LblSucessfulConnect.Visible = true;
            }


            using (NpgsqlConnection newcnn = new NpgsqlConnection(connetionString))
            {
                string readerString = "SELECT * FROM logininfo";
                NpgsqlCommand command = new NpgsqlCommand(readerString, newcnn);

                try
                {
                    newcnn.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine("userid: {0}, username: {1}, password: {2}", reader.GetInt32(0), reader.GetString(1), reader.GetString(2));


                            if (txtUsernameValue == reader.GetString(1) && txtPasswordValue == reader.GetString(2)) //Equals
                            {
                                PannelLogin.Visible = false;
                                PannelDashboard.Visible = true;
                                LblMatch.Visible = true;
                                Console.WriteLine("Match!");
                                UsernameMatch = reader.GetString(1);
                                PasswordMatch = reader.GetString(2);
                                LblMatchedUsername.Text = UsernameMatch;
                                break;
                            }

                        }
                        if (LblMatch.Visible == false)
                        {
                            LblInvalidCredentials.Visible = true;
                        }
                    }
                }
                catch (NpgsqlException)
                {
                    LblSucessfulConnect.Visible = true;
                }

            }
            cnn.Close();

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LblInvalidCredentials.Visible = false;
            LblSucessfulConnect.Visible = false;
            LblMatch.Visible = false;

            txtUsername.Text = String.Empty;
            txtPassword.Text = String.Empty;

            PannelLogin.Visible = true;
            PannelDashboard.Visible = false;

        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            PannelDashboard.Visible = false;
            PannelChangePassword.Visible = true;
        }

        private void btnReturnToDashboard_Click(object sender, EventArgs e)
        {
            PannelDashboard.Visible = true;
            PannelChangePassword.Visible = false;

            txtOriginalPassword.Text = String.Empty;
            txtNewPasswordUsername.Text = String.Empty;
            txtNewPassword1.Text = String.Empty;
            txtNewPassword2.Text = String.Empty;

            LblUnknownError.Visible = false;
        }

        void ModifyPassword(NpgsqlConnection connection)
        {
            string connetionString;
            NpgsqlConnection cnn;
            connetionString = @"Host=db.bit.io,5432;Username=Bmonky13;Password=v2_3uK8C_jArJzeSymZ9haEmzqwgLusg;Database=Bmonky13.Classified";
            cnn = new NpgsqlConnection(connetionString);

            
            String CommandText = "UPDATE logininfo SET password=" + txtNewPassword2.Text + "WHERE username=" + txtNewPasswordUsername.Text;
            NpgsqlCommand command = new NpgsqlCommand(CommandText, cnn);
            /*command.CommandText = "INSERT INTO logininfo (username, password), VALUES (@username, @password)";

            string sqlStatement = "INSERT INTO logininfo (userid, username, password) VALUES (@id, @username, @password)";
            

            command.Parameters.AddWithValue("@username", txtNewPasswordUsername.Text);
            command.Parameters.AddWithValue("@password", txtNewPassword2.Text);*/

                cnn.Open();
                command.ExecuteNonQuery();
                cnn.Close();

            /*// return value of ExecuteNonQuery (i) is the number of rows affected by the command
            int i = command.ExecuteNonQuery();
            Console.WriteLine(Environment.NewLine + "Rows in DEPT updated: {0}", i + Environment.NewLine);*/
        }
        private void btnSubmitNewPassword_Click(object sender, EventArgs e)
        {
            LblPasswordsDifferent.Visible = false;
            LblChooseNewPassword.Visible = false;
            LblInvalidOgUernameOrPassword.Visible = false;

            string connetionString;
            NpgsqlConnection cnn;
            connetionString = @"Host=db.bit.io,5432;Username=Bmonky13;Password=v2_3uK8C_jArJzeSymZ9haEmzqwgLusg;Database=Bmonky13.Classified";
            cnn = new NpgsqlConnection(connetionString);

            try
            {
                cnn.Open();
            }
            catch (NpgsqlException)
            {
                LblSucessfulConnect.Visible = true;
            }
            cnn.Close();

            if (txtOriginalPassword.Text == txtNewPassword1.Text && txtNewPassword1.Text.Length != 0)
            {
                LblChooseNewPassword.Visible = true;
            }

            if ((UsernameMatch == txtNewPasswordUsername.Text) && (PasswordMatch == txtOriginalPassword.Text))
            {
                if (txtNewPassword1.Text == txtNewPassword2.Text)
                {
                    string sqlStatement = "UPDATE logininfo SET password = @password WHERE username = @username";
                    using (NpgsqlConnection newcnn = new NpgsqlConnection(connetionString))
                    {
                        NpgsqlCommand cmd = new NpgsqlCommand(sqlStatement, newcnn);

                        cmd.Parameters.Add("@username", NpgsqlTypes.NpgsqlDbType.Varchar, 255).Value = txtNewPasswordUsername.Text;
                        cmd.Parameters.Add("@password", NpgsqlTypes.NpgsqlDbType.Varchar, 255).Value = txtNewPassword2.Text;

                        try
                        {
                            newcnn.Open();
                            NpgsqlDataReader reader = cmd.ExecuteReader();
                            newcnn.Close();
                        }
                        catch (NpgsqlException)
                        {
                            LblUnknownError.Visible = true;
                        }
                    }
                }
                else
                {
                    LblPasswordsDifferent.Visible = true;
                }    
            }
            else
            {
                //invalid original username or password
                LblInvalidOgUernameOrPassword.Visible = true;
            }

            using (NpgsqlConnection newcnn = new NpgsqlConnection(connetionString))
            {
                string readerString = "SELECT * FROM logininfo";
                NpgsqlCommand command = new NpgsqlCommand(readerString, newcnn);

                try
                {
                    newcnn.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine("userid: {0}, username: {1}, password: {2}", reader.GetInt32(0), reader.GetString(1), reader.GetString(2));

                            if (txtNewPasswordUsername.Text == reader.GetString(1) && txtNewPassword1.Text == reader.GetString(2)) //Equals
                            {
                                PannelChangePassword.Visible = false;
                                PannelDashboard.Visible = true;

                                Console.WriteLine("Password Sucessfully changed!");

                                break;
                            }
                        }
                        if (PannelDashboard.Visible == false)
                        {
                            LblUnknownError.Visible = true;
                        }
                    }
                }
                catch (NpgsqlException)
                {
                    LblSucessfulConnect.Visible = true;
                }
            }
        }
    }
}

        