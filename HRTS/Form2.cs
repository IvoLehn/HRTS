using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRTS
{
    public partial class FormAnmeldeinfo : Form
    {
        Form1 form1 = new Form1();
        public FormAnmeldeinfo(Form1 f1)
        {
            this.form1 = f1;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.ServerFarmblue1;
            TextBoxUsername.Text = $"Admin-{Environment.UserName.Substring(Environment.UserName.Length - 1, 1).ToUpper()}{Environment.UserName.Substring(0, 1).ToUpper()}";
        }
        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            ButtonLogin.Enabled = false;

            labelWrongPW.Text = string.Empty;

            if (SessionVerwaltung.ADAuthentication("vrg-ol.de", TextBoxUsername.Text, TextBoxPassword.Text))
            {
                form1.username = TextBoxUsername.Text;
                form1.passwort = TextBoxPassword.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("Authentifizierung fehlgeschlagen", "Warnung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                labelWrongPW.Text = "  Falsches PW";
                TextBoxPassword.Text = string.Empty;
                TextBoxPassword.Focus();
            }

            ButtonLogin.Enabled = true;
        }
        private void TextBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ButtonLogin_Click(null, null);
            }
        }
    }
}
