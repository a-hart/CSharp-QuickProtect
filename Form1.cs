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
        static byte[] defaultEntropy = { 1, 2, 3, 4, 5 };
        byte[] protectedPassword;
        byte[] passwordPlain;
        byte[] extraEntropy;
        bool bCustomEntropy = false;

        public Form1()
        {
            InitializeComponent();
        }
        //Encrypt it
        private void button1_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(string2Encrypt.Text);
            if (EntropyText.Text != String.Empty)
            {
                extraEntropy = Encoding.Unicode.GetBytes(EntropyText.Text);
                protectedPassword = ProtectedData.Protect(bytes, extraEntropy, DataProtectionScope.CurrentUser);
                bCustomEntropy = true;
            }
            else
            {
                protectedPassword = ProtectedData.Protect(bytes, defaultEntropy, DataProtectionScope.CurrentUser);
            }

            EncryptTextBox.Text = Convert.ToBase64String(protectedPassword);
          
        }
        //Decrypt it
        private void button2_Click(object sender, EventArgs e)
        {
            byte[] bytes = Convert.FromBase64String(EncryptTextBox.Text);
            if (bCustomEntropy)
            {
                passwordPlain = ProtectedData.Unprotect(bytes, extraEntropy, DataProtectionScope.CurrentUser);
            }
            else
            {
                passwordPlain = ProtectedData.Unprotect(bytes, defaultEntropy, DataProtectionScope.CurrentUser);
            }
            DecryptTextBox.Text = Encoding.Unicode.GetString(passwordPlain);
        }


    }
}
