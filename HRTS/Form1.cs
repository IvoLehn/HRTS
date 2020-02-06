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
    public partial class Form1 : Form
    {
        public string username = string.Empty;
        public string passwort = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.ServerFarmblue1;

            DataGridViewServer.Rows.Add(false, "VRGSRV81");
            DataGridViewServer.Rows.Add(false, "VRGSRV82");
            DataGridViewServer.Rows.Add(false, "VRGSRV83");
            DataGridViewServer.Rows.Add(false, "VRGSRV84");
            DataGridViewServer.Rows.Add(false, "VRGSRV85");
            DataGridViewServer.Rows.Add(false, "VRGSRV86");
            DataGridViewServer.Rows.Add(false, "VRGSRV87");
            DataGridViewServer.Rows.Add(false, "VRGSRV88");
        }


        private void ButtonSuchenServer_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            foreach (DataGridViewRow row in DataGridViewServer.Rows)
            {
                row.Visible = true;
            }

            foreach (DataGridViewRow row in DataGridViewServer.Rows)
            {
                if (!row.Cells[1].Value.ToString().ToLower().Contains(TextBoxSucheServer.Text.ToLower()))
                {
                    DataGridViewServer.Rows[row.Index].Visible = false;
                }
            }

            Cursor.Current = Cursors.Default;
        }
        private void ButtonSuchenBenutzer_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            DataGridViewBenutzer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            foreach (DataGridViewRow row in DataGridViewBenutzer.Rows)
            {
                row.Visible = true;
            }

            foreach (DataGridViewRow row in DataGridViewBenutzer.Rows)
            {
                if (!row.Cells[2].Value.ToString().ToLower().Contains(textBoxSucheBenutzer.Text.ToLower()))
                {
                    DataGridViewBenutzer.Rows[row.Index].Visible = false;
                }
            }

            DataGridViewBenutzer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            Cursor.Current = Cursors.Default;
        }
        private void ButtonBenutzerLaden_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            DataGridViewBenutzer.Rows.Clear();

            List<string> serverListe = new List<string>();

            foreach (DataGridViewRow row in DataGridViewServer.Rows)
            {
                if ((bool)row.Cells[0].Value == true && row.Visible)
                {
                    serverListe.Add(row.Cells[1].Value.ToString());
                }
            }

            List<List<string>> liste = SessionVerwaltung.QUser(serverListe);

            foreach (List<string> linie in liste)
            {
                if (linie[1].Trim() != "BENUTZERNAME")
                {
                    if (linie[2].Trim().StartsWith("rdp"))
                    {
                        DataGridViewBenutzer.Rows.Add(false, linie[0], linie[1], linie[3], linie[4]);
                    }
                    else
                    {
                        DataGridViewBenutzer.Rows.Add(false, linie[0], linie[1], linie[2], linie[3]);
                    }
                }
            }

            Cursor.Current = Cursors.Default;
        }
        private void ButtonVerbinden_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            List<string> serverListe = new List<string>();

            foreach (DataGridViewRow row in DataGridViewServer.Rows)
            {
                if ((bool)row.Cells[0].Value == true && row.Visible)
                {
                    serverListe.Add(row.Cells[1].Value.ToString());
                }
            }

            if(!string.IsNullOrEmpty(username))
            {
                SessionVerwaltung.CreateCMDKey(serverListe, username, passwort);
            }

            SessionVerwaltung.Mstsc(serverListe);

            Cursor.Current = Cursors.Default;
        }
        private void ButtonBenutzerAbmelden_Click(object sender, EventArgs e)
        {
            List<List<string>> Users = new List<List<string>>();

            foreach (DataGridViewRow row in DataGridViewBenutzer.Rows)
            {
                if ((bool)row.Cells[0].Value == true && row.Visible)
                {
                    Users.Add(new List<string> { row.Cells[1].Value.ToString(), row.Cells[3].Value.ToString(), row.Cells[2].Value.ToString() });
                }
            }

            if (Users.Count > 0)
            {
                if (MessageBox.Show($"Wirklich {Users.Count} Benutzer abmelden?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    SessionVerwaltung.LogOffUser(Users);
                }
            }
        }

        private void textBoxSucheBenutzer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ButtonSuchenBenutzer_Click(null, null);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void TextBoxSucheServer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ButtonSuchenServer_Click(null, null);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }


        private void anmeldeinformationenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAnmeldeinfo formAnmeldeinfo = new FormAnmeldeinfo(this);
            formAnmeldeinfo.ShowDialog();
        }

        private void ButtonSitzungSpiegeln_Click(object sender, EventArgs e)
        {
            List<List<string>> Users = new List<List<string>>();

            foreach (DataGridViewRow row in DataGridViewBenutzer.Rows)
            {
                if ((bool)row.Cells[0].Value == true && row.Visible)
                {
                    Users.Add(new List<string> { row.Cells[1].Value.ToString(), row.Cells[3].Value.ToString(), row.Cells[2].Value.ToString() });
                }
            }

            if (Users.Count > 0)
            {
                if (MessageBox.Show($"Wirklich {Users.Count} Sitzungen spiegeln?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    SessionVerwaltung.ShadowSession(Users);
                }
            }
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
