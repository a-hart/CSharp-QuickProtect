using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace PasswordHashTest
{
    public partial class Form1 : Form
    {
        static byte[] s_extraEntropy = { 9, 8, 7, 6, 5, 4, 3 };

        byte[] protectedPassword; 
        public Form1()
        {
            InitializeComponent();
        }
        //Encrypt it
        private void button1_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(string2Encrypt.Text);
            protectedPassword = ProtectedData.Protect(bytes, s_extraEntropy, DataProtectionScope.CurrentUser);
            EncryptTextBox.Text = Convert.ToBase64String(protectedPassword);
          
        }
        //Decrypt it
        private void button2_Click(object sender, EventArgs e)
        {
            byte[] bytes = Convert.FromBase64String(EncryptTextBox.Text);
            byte[] password = ProtectedData.Unprotect(bytes, s_extraEntropy, DataProtectionScope.CurrentUser);
            DecryptTextBox.Text = Encoding.Unicode.GetString(password);
        }


    }
}
