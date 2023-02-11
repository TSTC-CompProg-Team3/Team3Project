using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace DatabaseConnection_G3_sp23
{
    public partial class frmForgotPass : Form
    {
        
        DatabaseConnection database = new DatabaseConnection();
        //Creates random number object -CS
        private static Random random = new Random();

        public frmForgotPass()
        {
            InitializeComponent();
        }

        private void frmForgotPass_Load(object sender, EventArgs e)
        {
            //Gets info from database -CS
            database.OpenDatabase();
            database.UserInfo();
        }

        //sends code to email and stores in database -CS
        private void btnSendCode_Click(object sender, EventArgs e)
        {
            string email = tbxEmail.Text;
            

            foreach (clsUser user in database.userList)
            {
                if (tbxEmail.Text == user.email){
                    try
                    {
                        string resetCode = "";
                        resetCode = GenerateResetCode(6);

                        database.StoreResetCodeInDatabase(email, resetCode);

                        MailMessage message = new MailMessage("noreply@example.com", email);
                        message.Subject = "Password Reset Code";
                        message.Body = $"Your password reset code is: {resetCode}";

                        SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                        smtp.Credentials = new NetworkCredential("tstccompprogteam3@gmail.com", "ibhkovptxxlrtndr");
                        smtp.EnableSsl = true;
                        smtp.Port = 587;
                        smtp.Send(message);

                        MessageBox.Show("Password reset code sent to email.");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while sending the reset code: " + ex.Message);


                    }

                    
                }
            }
            //clears userlist and get the info from database - a better implementation is possible -CS
            database.userList.Clear();
            database.UserInfo();
        }

        //generates the random reset code -CS
        private static string GenerateResetCode(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        //resets the password if the reset code is correct and the password fields match -CS
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            foreach  (clsUser user in database.userList)
            {
                if (tbxEnterCode.Text.Equals(user.resetCode) && tbxNewPassword.Text.Equals(tbxConfirmPassword.Text))
                {
                    MessageBox.Show("Password has been changed", "Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    database.ResetPassword(tbxConfirmPassword.Text, user.resetCode);
                    this.Close();
                }
            }

            if (!tbxNewPassword.Text.Equals(tbxConfirmPassword.Text))
            {
                MessageBox.Show("Please enter a valid password", "Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmForgotPass_FormClosing(object sender, FormClosingEventArgs e)
        {
            database.CloseDatabase();
        }
    }


}
