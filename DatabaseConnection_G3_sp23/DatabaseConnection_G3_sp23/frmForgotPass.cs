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
        public string resetCode = "";
        public frmForgotPass()
        {
            InitializeComponent();
        }

        private void frmForgotPass_Load(object sender, EventArgs e)
        {

        }

        private void btnSendCode_Click(object sender, EventArgs e)
        {
            string email = tbxEmail.Text;
            DatabaseConnection database = new DatabaseConnection();

            foreach (clsUser user in database.userList)
            {
                if (tbxEmail.Text == user.email){
                    try
                    {
                        resetCode = GenerateResetCode();

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
        }


        private static string GenerateResetCode()
        {
            string code = "example";
            return code;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (tbxEnterCode.Text.Equals(resetCode))
            {

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}
