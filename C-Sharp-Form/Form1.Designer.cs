namespace C_Sharp_Form
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblInvalidCredentials = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.LblUsername = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.LblSucessfulConnect = new System.Windows.Forms.Label();
            this.LblMatch = new System.Windows.Forms.Label();
            this.PannelLogin = new System.Windows.Forms.Panel();
            this.PannelDashboard = new System.Windows.Forms.Panel();
            this.LblMatchedUsername = new System.Windows.Forms.Label();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.PannelChangePassword = new System.Windows.Forms.Panel();
            this.LblUnknownError = new System.Windows.Forms.Label();
            this.LblPasswordsDifferent = new System.Windows.Forms.Label();
            this.btnReturnToDashboard = new System.Windows.Forms.Button();
            this.btnSubmitNewPassword = new System.Windows.Forms.Button();
            this.LblNewPassword2 = new System.Windows.Forms.Label();
            this.LblNewPassword1 = new System.Windows.Forms.Label();
            this.LblOriginalPassword = new System.Windows.Forms.Label();
            this.LblOriginalUsername = new System.Windows.Forms.Label();
            this.txtNewPassword2 = new System.Windows.Forms.TextBox();
            this.txtNewPassword1 = new System.Windows.Forms.TextBox();
            this.txtOriginalPassword = new System.Windows.Forms.TextBox();
            this.txtNewPasswordUsername = new System.Windows.Forms.TextBox();
            this.LblChooseNewPassword = new System.Windows.Forms.Label();
            this.LblInvalidOgUernameOrPassword = new System.Windows.Forms.Label();
            this.PannelLogin.SuspendLayout();
            this.PannelDashboard.SuspendLayout();
            this.PannelChangePassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblInvalidCredentials
            // 
            this.LblInvalidCredentials.AutoSize = true;
            this.LblInvalidCredentials.ForeColor = System.Drawing.Color.Crimson;
            this.LblInvalidCredentials.Location = new System.Drawing.Point(96, 44);
            this.LblInvalidCredentials.Name = "LblInvalidCredentials";
            this.LblInvalidCredentials.Size = new System.Drawing.Size(115, 13);
            this.LblInvalidCredentials.TabIndex = 0;
            this.LblInvalidCredentials.Text = "Invalid user credentials";
            this.LblInvalidCredentials.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(103, 76);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 1;
            // 
            // LblUsername
            // 
            this.LblUsername.AutoSize = true;
            this.LblUsername.Location = new System.Drawing.Point(30, 79);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(58, 13);
            this.LblUsername.TabIndex = 2;
            this.LblUsername.Text = "Username:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(103, 118);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Password:";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(103, 165);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 24);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // LblSucessfulConnect
            // 
            this.LblSucessfulConnect.AutoSize = true;
            this.LblSucessfulConnect.ForeColor = System.Drawing.Color.Crimson;
            this.LblSucessfulConnect.Location = new System.Drawing.Point(86, 21);
            this.LblSucessfulConnect.Name = "LblSucessfulConnect";
            this.LblSucessfulConnect.Size = new System.Drawing.Size(130, 13);
            this.LblSucessfulConnect.TabIndex = 6;
            this.LblSucessfulConnect.Text = "Unable to reach database";
            // 
            // LblMatch
            // 
            this.LblMatch.AutoSize = true;
            this.LblMatch.ForeColor = System.Drawing.Color.DarkGreen;
            this.LblMatch.Location = new System.Drawing.Point(106, 216);
            this.LblMatch.Name = "LblMatch";
            this.LblMatch.Size = new System.Drawing.Size(95, 13);
            this.LblMatch.TabIndex = 7;
            this.LblMatch.Text = "Credentials Match!";
            // 
            // PannelLogin
            // 
            this.PannelLogin.Controls.Add(this.LblMatch);
            this.PannelLogin.Controls.Add(this.LblSucessfulConnect);
            this.PannelLogin.Controls.Add(this.btnLogin);
            this.PannelLogin.Controls.Add(this.label1);
            this.PannelLogin.Controls.Add(this.txtPassword);
            this.PannelLogin.Controls.Add(this.LblUsername);
            this.PannelLogin.Controls.Add(this.txtUsername);
            this.PannelLogin.Controls.Add(this.LblInvalidCredentials);
            this.PannelLogin.Location = new System.Drawing.Point(23, 12);
            this.PannelLogin.Name = "PannelLogin";
            this.PannelLogin.Size = new System.Drawing.Size(297, 237);
            this.PannelLogin.TabIndex = 8;
            // 
            // PannelDashboard
            // 
            this.PannelDashboard.Controls.Add(this.LblMatchedUsername);
            this.PannelDashboard.Controls.Add(this.btnChangePassword);
            this.PannelDashboard.Controls.Add(this.btnLogout);
            this.PannelDashboard.Location = new System.Drawing.Point(10, 12);
            this.PannelDashboard.Name = "PannelDashboard";
            this.PannelDashboard.Size = new System.Drawing.Size(324, 243);
            this.PannelDashboard.TabIndex = 9;
            // 
            // LblMatchedUsername
            // 
            this.LblMatchedUsername.AutoSize = true;
            this.LblMatchedUsername.Location = new System.Drawing.Point(16, 16);
            this.LblMatchedUsername.Name = "LblMatchedUsername";
            this.LblMatchedUsername.Size = new System.Drawing.Size(55, 13);
            this.LblMatchedUsername.TabIndex = 3;
            this.LblMatchedUsername.Text = "Username";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(102, 79);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(108, 33);
            this.btnChangePassword.TabIndex = 1;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(102, 118);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(108, 32);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // PannelChangePassword
            // 
            this.PannelChangePassword.Controls.Add(this.LblUnknownError);
            this.PannelChangePassword.Controls.Add(this.LblPasswordsDifferent);
            this.PannelChangePassword.Controls.Add(this.btnReturnToDashboard);
            this.PannelChangePassword.Controls.Add(this.btnSubmitNewPassword);
            this.PannelChangePassword.Controls.Add(this.LblNewPassword2);
            this.PannelChangePassword.Controls.Add(this.LblNewPassword1);
            this.PannelChangePassword.Controls.Add(this.LblOriginalPassword);
            this.PannelChangePassword.Controls.Add(this.LblOriginalUsername);
            this.PannelChangePassword.Controls.Add(this.txtNewPassword2);
            this.PannelChangePassword.Controls.Add(this.txtNewPassword1);
            this.PannelChangePassword.Controls.Add(this.txtOriginalPassword);
            this.PannelChangePassword.Controls.Add(this.txtNewPasswordUsername);
            this.PannelChangePassword.Controls.Add(this.LblChooseNewPassword);
            this.PannelChangePassword.Controls.Add(this.LblInvalidOgUernameOrPassword);
            this.PannelChangePassword.Location = new System.Drawing.Point(10, 12);
            this.PannelChangePassword.Name = "PannelChangePassword";
            this.PannelChangePassword.Size = new System.Drawing.Size(324, 240);
            this.PannelChangePassword.TabIndex = 4;
            // 
            // LblUnknownError
            // 
            this.LblUnknownError.AutoSize = true;
            this.LblUnknownError.ForeColor = System.Drawing.Color.Crimson;
            this.LblUnknownError.Location = new System.Drawing.Point(130, 220);
            this.LblUnknownError.Name = "LblUnknownError";
            this.LblUnknownError.Size = new System.Drawing.Size(127, 13);
            this.LblUnknownError.TabIndex = 14;
            this.LblUnknownError.Text = "An unkown error occured";
            // 
            // LblPasswordsDifferent
            // 
            this.LblPasswordsDifferent.AutoSize = true;
            this.LblPasswordsDifferent.ForeColor = System.Drawing.Color.Crimson;
            this.LblPasswordsDifferent.Location = new System.Drawing.Point(119, 12);
            this.LblPasswordsDifferent.Name = "LblPasswordsDifferent";
            this.LblPasswordsDifferent.Size = new System.Drawing.Size(147, 13);
            this.LblPasswordsDifferent.TabIndex = 11;
            this.LblPasswordsDifferent.Text = "New passwords do not match";
            // 
            // btnReturnToDashboard
            // 
            this.btnReturnToDashboard.Location = new System.Drawing.Point(13, 209);
            this.btnReturnToDashboard.Name = "btnReturnToDashboard";
            this.btnReturnToDashboard.Size = new System.Drawing.Size(57, 20);
            this.btnReturnToDashboard.TabIndex = 9;
            this.btnReturnToDashboard.Text = "Cancel";
            this.btnReturnToDashboard.UseVisualStyleBackColor = true;
            this.btnReturnToDashboard.Click += new System.EventHandler(this.btnReturnToDashboard_Click);
            // 
            // btnSubmitNewPassword
            // 
            this.btnSubmitNewPassword.Location = new System.Drawing.Point(141, 194);
            this.btnSubmitNewPassword.Name = "btnSubmitNewPassword";
            this.btnSubmitNewPassword.Size = new System.Drawing.Size(107, 23);
            this.btnSubmitNewPassword.TabIndex = 8;
            this.btnSubmitNewPassword.Text = "Change";
            this.btnSubmitNewPassword.UseVisualStyleBackColor = true;
            this.btnSubmitNewPassword.Click += new System.EventHandler(this.btnSubmitNewPassword_Click);
            // 
            // LblNewPassword2
            // 
            this.LblNewPassword2.AutoSize = true;
            this.LblNewPassword2.Location = new System.Drawing.Point(16, 160);
            this.LblNewPassword2.Name = "LblNewPassword2";
            this.LblNewPassword2.Size = new System.Drawing.Size(109, 13);
            this.LblNewPassword2.TabIndex = 7;
            this.LblNewPassword2.Text = "New password again:";
            // 
            // LblNewPassword1
            // 
            this.LblNewPassword1.AutoSize = true;
            this.LblNewPassword1.Location = new System.Drawing.Point(45, 119);
            this.LblNewPassword1.Name = "LblNewPassword1";
            this.LblNewPassword1.Size = new System.Drawing.Size(80, 13);
            this.LblNewPassword1.TabIndex = 6;
            this.LblNewPassword1.Text = "New password:";
            // 
            // LblOriginalPassword
            // 
            this.LblOriginalPassword.AutoSize = true;
            this.LblOriginalPassword.Location = new System.Drawing.Point(32, 78);
            this.LblOriginalPassword.Name = "LblOriginalPassword";
            this.LblOriginalPassword.Size = new System.Drawing.Size(93, 13);
            this.LblOriginalPassword.TabIndex = 5;
            this.LblOriginalPassword.Text = "Original password:";
            // 
            // LblOriginalUsername
            // 
            this.LblOriginalUsername.AutoSize = true;
            this.LblOriginalUsername.Location = new System.Drawing.Point(67, 37);
            this.LblOriginalUsername.Name = "LblOriginalUsername";
            this.LblOriginalUsername.Size = new System.Drawing.Size(58, 13);
            this.LblOriginalUsername.TabIndex = 4;
            this.LblOriginalUsername.Text = "Username:";
            // 
            // txtNewPassword2
            // 
            this.txtNewPassword2.Location = new System.Drawing.Point(142, 156);
            this.txtNewPassword2.Name = "txtNewPassword2";
            this.txtNewPassword2.PasswordChar = '*';
            this.txtNewPassword2.Size = new System.Drawing.Size(106, 20);
            this.txtNewPassword2.TabIndex = 3;
            // 
            // txtNewPassword1
            // 
            this.txtNewPassword1.Location = new System.Drawing.Point(141, 115);
            this.txtNewPassword1.Name = "txtNewPassword1";
            this.txtNewPassword1.PasswordChar = '*';
            this.txtNewPassword1.Size = new System.Drawing.Size(108, 20);
            this.txtNewPassword1.TabIndex = 2;
            // 
            // txtOriginalPassword
            // 
            this.txtOriginalPassword.Location = new System.Drawing.Point(141, 74);
            this.txtOriginalPassword.Name = "txtOriginalPassword";
            this.txtOriginalPassword.PasswordChar = '*';
            this.txtOriginalPassword.Size = new System.Drawing.Size(108, 20);
            this.txtOriginalPassword.TabIndex = 1;
            // 
            // txtNewPasswordUsername
            // 
            this.txtNewPasswordUsername.Location = new System.Drawing.Point(141, 33);
            this.txtNewPasswordUsername.Name = "txtNewPasswordUsername";
            this.txtNewPasswordUsername.Size = new System.Drawing.Size(109, 20);
            this.txtNewPasswordUsername.TabIndex = 0;
            // 
            // LblChooseNewPassword
            // 
            this.LblChooseNewPassword.AutoSize = true;
            this.LblChooseNewPassword.ForeColor = System.Drawing.Color.Crimson;
            this.LblChooseNewPassword.Location = new System.Drawing.Point(115, 12);
            this.LblChooseNewPassword.Name = "LblChooseNewPassword";
            this.LblChooseNewPassword.Size = new System.Drawing.Size(157, 13);
            this.LblChooseNewPassword.TabIndex = 12;
            this.LblChooseNewPassword.Text = "Please choose a new password";
            // 
            // LblInvalidOgUernameOrPassword
            // 
            this.LblInvalidOgUernameOrPassword.AutoSize = true;
            this.LblInvalidOgUernameOrPassword.ForeColor = System.Drawing.Color.Crimson;
            this.LblInvalidOgUernameOrPassword.Location = new System.Drawing.Point(102, 12);
            this.LblInvalidOgUernameOrPassword.Name = "LblInvalidOgUernameOrPassword";
            this.LblInvalidOgUernameOrPassword.Size = new System.Drawing.Size(183, 13);
            this.LblInvalidOgUernameOrPassword.TabIndex = 13;
            this.LblInvalidOgUernameOrPassword.Text = "Invalid original username or password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 261);
            this.Controls.Add(this.PannelChangePassword);
            this.Controls.Add(this.PannelDashboard);
            this.Controls.Add(this.PannelLogin);
            this.Name = "Form1";
            this.Text = "Database User Login";
            this.PannelLogin.ResumeLayout(false);
            this.PannelLogin.PerformLayout();
            this.PannelDashboard.ResumeLayout(false);
            this.PannelDashboard.PerformLayout();
            this.PannelChangePassword.ResumeLayout(false);
            this.PannelChangePassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblInvalidCredentials;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label LblSucessfulConnect;
        private System.Windows.Forms.Label LblMatch;
        private System.Windows.Forms.Panel PannelLogin;
        private System.Windows.Forms.Panel PannelDashboard;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Label LblMatchedUsername;
        private System.Windows.Forms.Panel PannelChangePassword;
        private System.Windows.Forms.Label LblNewPassword2;
        private System.Windows.Forms.Label LblNewPassword1;
        private System.Windows.Forms.Label LblOriginalPassword;
        private System.Windows.Forms.Label LblOriginalUsername;
        private System.Windows.Forms.TextBox txtNewPassword2;
        private System.Windows.Forms.TextBox txtNewPassword1;
        private System.Windows.Forms.TextBox txtOriginalPassword;
        private System.Windows.Forms.TextBox txtNewPasswordUsername;
        private System.Windows.Forms.Button btnSubmitNewPassword;
        private System.Windows.Forms.Button btnReturnToDashboard;
        private System.Windows.Forms.Label LblPasswordsDifferent;
        private System.Windows.Forms.Label LblChooseNewPassword;
        private System.Windows.Forms.Label LblInvalidOgUernameOrPassword;
        private System.Windows.Forms.Label LblUnknownError;
    }
}

