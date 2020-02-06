namespace HRTS
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonSitzungSpiegeln = new System.Windows.Forms.Button();
            this.ButtonVerbinden = new System.Windows.Forms.Button();
            this.ButtonBenutzerLaden = new System.Windows.Forms.Button();
            this.ButtonBenutzerAbmelden = new System.Windows.Forms.Button();
            this.GroupBoxServer = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.DataGridViewServer = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonSuchenServer = new System.Windows.Forms.Button();
            this.TextBoxSucheServer = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.GroupBoxBenutzer = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonSuchenBenutzer = new System.Windows.Forms.Button();
            this.textBoxSucheBenutzer = new System.Windows.Forms.TextBox();
            this.labelSuchen = new System.Windows.Forms.Label();
            this.DataGridViewBenutzer = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnServer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemVerbindung = new System.Windows.Forms.ToolStripMenuItem();
            this.anmeldeinformationenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel4.SuspendLayout();
            this.GroupBoxServer.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewServer)).BeginInit();
            this.GroupBoxBenutzer.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewBenutzer)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel4.Controls.Add(this.ButtonSitzungSpiegeln, 3, 1);
            this.tableLayoutPanel4.Controls.Add(this.ButtonVerbinden, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.ButtonBenutzerLaden, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.ButtonBenutzerAbmelden, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.GroupBoxServer, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.GroupBoxBenutzer, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 27);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(794, 431);
            this.tableLayoutPanel4.TabIndex = 26;
            // 
            // ButtonSitzungSpiegeln
            // 
            this.ButtonSitzungSpiegeln.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ButtonSitzungSpiegeln.Location = new System.Drawing.Point(692, 218);
            this.ButtonSitzungSpiegeln.Name = "ButtonSitzungSpiegeln";
            this.ButtonSitzungSpiegeln.Size = new System.Drawing.Size(93, 54);
            this.ButtonSitzungSpiegeln.TabIndex = 28;
            this.ButtonSitzungSpiegeln.Text = "Sitzung spiegeln";
            this.ButtonSitzungSpiegeln.UseVisualStyleBackColor = true;
            this.ButtonSitzungSpiegeln.Click += new System.EventHandler(this.ButtonSitzungSpiegeln_Click);
            // 
            // ButtonVerbinden
            // 
            this.ButtonVerbinden.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ButtonVerbinden.Location = new System.Drawing.Point(178, 218);
            this.ButtonVerbinden.Name = "ButtonVerbinden";
            this.ButtonVerbinden.Size = new System.Drawing.Size(93, 54);
            this.ButtonVerbinden.TabIndex = 27;
            this.ButtonVerbinden.Text = "Verbinden";
            this.ButtonVerbinden.UseVisualStyleBackColor = true;
            this.ButtonVerbinden.Click += new System.EventHandler(this.ButtonVerbinden_Click);
            // 
            // ButtonBenutzerLaden
            // 
            this.ButtonBenutzerLaden.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ButtonBenutzerLaden.Location = new System.Drawing.Point(178, 158);
            this.ButtonBenutzerLaden.Name = "ButtonBenutzerLaden";
            this.ButtonBenutzerLaden.Size = new System.Drawing.Size(93, 54);
            this.ButtonBenutzerLaden.TabIndex = 20;
            this.ButtonBenutzerLaden.Text = "Benutzer laden";
            this.ButtonBenutzerLaden.UseVisualStyleBackColor = true;
            this.ButtonBenutzerLaden.Click += new System.EventHandler(this.ButtonBenutzerLaden_Click);
            // 
            // ButtonBenutzerAbmelden
            // 
            this.ButtonBenutzerAbmelden.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ButtonBenutzerAbmelden.Location = new System.Drawing.Point(692, 158);
            this.ButtonBenutzerAbmelden.Name = "ButtonBenutzerAbmelden";
            this.ButtonBenutzerAbmelden.Size = new System.Drawing.Size(93, 54);
            this.ButtonBenutzerAbmelden.TabIndex = 23;
            this.ButtonBenutzerAbmelden.Text = "Benutzer abmelden";
            this.ButtonBenutzerAbmelden.UseVisualStyleBackColor = true;
            this.ButtonBenutzerAbmelden.Click += new System.EventHandler(this.ButtonBenutzerAbmelden_Click);
            // 
            // GroupBoxServer
            // 
            this.GroupBoxServer.Controls.Add(this.tableLayoutPanel2);
            this.GroupBoxServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBoxServer.Location = new System.Drawing.Point(3, 3);
            this.GroupBoxServer.Name = "GroupBoxServer";
            this.tableLayoutPanel4.SetRowSpan(this.GroupBoxServer, 2);
            this.GroupBoxServer.Size = new System.Drawing.Size(169, 425);
            this.GroupBoxServer.TabIndex = 26;
            this.GroupBoxServer.TabStop = false;
            this.GroupBoxServer.Text = "Server";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.DataGridViewServer, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.ButtonSuchenServer, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.TextBoxSucheServer, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(163, 406);
            this.tableLayoutPanel2.TabIndex = 28;
            // 
            // DataGridViewServer
            // 
            this.DataGridViewServer.AllowUserToAddRows = false;
            this.DataGridViewServer.AllowUserToDeleteRows = false;
            this.DataGridViewServer.AllowUserToResizeColumns = false;
            this.DataGridViewServer.AllowUserToResizeRows = false;
            this.DataGridViewServer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridViewServer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewServer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn1});
            this.tableLayoutPanel2.SetColumnSpan(this.DataGridViewServer, 3);
            this.DataGridViewServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewServer.Location = new System.Drawing.Point(2, 28);
            this.DataGridViewServer.Margin = new System.Windows.Forms.Padding(2);
            this.DataGridViewServer.Name = "DataGridViewServer";
            this.DataGridViewServer.RowHeadersVisible = false;
            this.DataGridViewServer.RowHeadersWidth = 51;
            this.DataGridViewServer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridViewServer.RowTemplate.Height = 24;
            this.DataGridViewServer.Size = new System.Drawing.Size(159, 376);
            this.DataGridViewServer.TabIndex = 21;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Servername";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ButtonSuchenServer
            // 
            this.ButtonSuchenServer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ButtonSuchenServer.Location = new System.Drawing.Point(114, 3);
            this.ButtonSuchenServer.Name = "ButtonSuchenServer";
            this.ButtonSuchenServer.Size = new System.Drawing.Size(46, 20);
            this.ButtonSuchenServer.TabIndex = 25;
            this.ButtonSuchenServer.Text = "Suche";
            this.ButtonSuchenServer.UseVisualStyleBackColor = true;
            this.ButtonSuchenServer.Click += new System.EventHandler(this.ButtonSuchenServer_Click);
            // 
            // TextBoxSucheServer
            // 
            this.TextBoxSucheServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxSucheServer.Location = new System.Drawing.Point(56, 3);
            this.TextBoxSucheServer.Name = "TextBoxSucheServer";
            this.TextBoxSucheServer.Size = new System.Drawing.Size(52, 20);
            this.TextBoxSucheServer.TabIndex = 24;
            this.TextBoxSucheServer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxSucheServer_KeyDown);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Suchen:";
            // 
            // GroupBoxBenutzer
            // 
            this.GroupBoxBenutzer.Controls.Add(this.tableLayoutPanel5);
            this.GroupBoxBenutzer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBoxBenutzer.Location = new System.Drawing.Point(278, 3);
            this.GroupBoxBenutzer.Name = "GroupBoxBenutzer";
            this.tableLayoutPanel4.SetRowSpan(this.GroupBoxBenutzer, 2);
            this.GroupBoxBenutzer.Size = new System.Drawing.Size(403, 425);
            this.GroupBoxBenutzer.TabIndex = 25;
            this.GroupBoxBenutzer.TabStop = false;
            this.GroupBoxBenutzer.Text = "Benutzer";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.Controls.Add(this.ButtonSuchenBenutzer, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.textBoxSucheBenutzer, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.labelSuchen, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.DataGridViewBenutzer, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(397, 406);
            this.tableLayoutPanel5.TabIndex = 27;
            // 
            // ButtonSuchenBenutzer
            // 
            this.ButtonSuchenBenutzer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ButtonSuchenBenutzer.Location = new System.Drawing.Point(319, 3);
            this.ButtonSuchenBenutzer.Name = "ButtonSuchenBenutzer";
            this.ButtonSuchenBenutzer.Size = new System.Drawing.Size(75, 20);
            this.ButtonSuchenBenutzer.TabIndex = 25;
            this.ButtonSuchenBenutzer.Text = "Suche";
            this.ButtonSuchenBenutzer.UseVisualStyleBackColor = true;
            this.ButtonSuchenBenutzer.Click += new System.EventHandler(this.ButtonSuchenBenutzer_Click);
            // 
            // textBoxSucheBenutzer
            // 
            this.textBoxSucheBenutzer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSucheBenutzer.Location = new System.Drawing.Point(56, 3);
            this.textBoxSucheBenutzer.Name = "textBoxSucheBenutzer";
            this.textBoxSucheBenutzer.Size = new System.Drawing.Size(257, 20);
            this.textBoxSucheBenutzer.TabIndex = 24;
            this.textBoxSucheBenutzer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSucheBenutzer_KeyDown);
            // 
            // labelSuchen
            // 
            this.labelSuchen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSuchen.AutoSize = true;
            this.labelSuchen.Location = new System.Drawing.Point(3, 6);
            this.labelSuchen.Name = "labelSuchen";
            this.labelSuchen.Size = new System.Drawing.Size(47, 13);
            this.labelSuchen.TabIndex = 23;
            this.labelSuchen.Text = "Suchen:";
            // 
            // DataGridViewBenutzer
            // 
            this.DataGridViewBenutzer.AllowUserToAddRows = false;
            this.DataGridViewBenutzer.AllowUserToDeleteRows = false;
            this.DataGridViewBenutzer.AllowUserToResizeColumns = false;
            this.DataGridViewBenutzer.AllowUserToResizeRows = false;
            this.DataGridViewBenutzer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridViewBenutzer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewBenutzer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn2,
            this.ColumnServer,
            this.dataGridViewTextBoxColumn2,
            this.ColumnID,
            this.ColumnStatus});
            this.tableLayoutPanel5.SetColumnSpan(this.DataGridViewBenutzer, 3);
            this.DataGridViewBenutzer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewBenutzer.Location = new System.Drawing.Point(2, 28);
            this.DataGridViewBenutzer.Margin = new System.Windows.Forms.Padding(2);
            this.DataGridViewBenutzer.Name = "DataGridViewBenutzer";
            this.DataGridViewBenutzer.RowHeadersVisible = false;
            this.DataGridViewBenutzer.RowHeadersWidth = 51;
            this.DataGridViewBenutzer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridViewBenutzer.RowTemplate.Height = 24;
            this.DataGridViewBenutzer.Size = new System.Drawing.Size(393, 376);
            this.DataGridViewBenutzer.TabIndex = 22;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.HeaderText = "";
            this.dataGridViewCheckBoxColumn2.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.Width = 6;
            // 
            // ColumnServer
            // 
            this.ColumnServer.HeaderText = "Server";
            this.ColumnServer.Name = "ColumnServer";
            this.ColumnServer.Width = 63;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Benutzername";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.Width = 43;
            // 
            // ColumnStatus
            // 
            this.ColumnStatus.HeaderText = "Status";
            this.ColumnStatus.Name = "ColumnStatus";
            this.ColumnStatus.Width = 62;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemVerbindung});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItemVerbindung
            // 
            this.ToolStripMenuItemVerbindung.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anmeldeinformationenToolStripMenuItem,
            this.beendenToolStripMenuItem});
            this.ToolStripMenuItemVerbindung.Name = "ToolStripMenuItemVerbindung";
            this.ToolStripMenuItemVerbindung.Size = new System.Drawing.Size(80, 20);
            this.ToolStripMenuItemVerbindung.Text = "Verbindung";
            // 
            // anmeldeinformationenToolStripMenuItem
            // 
            this.anmeldeinformationenToolStripMenuItem.Name = "anmeldeinformationenToolStripMenuItem";
            this.anmeldeinformationenToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.anmeldeinformationenToolStripMenuItem.Text = "Anmeldeinformationen";
            this.anmeldeinformationenToolStripMenuItem.Click += new System.EventHandler(this.anmeldeinformationenToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 461);
            this.tableLayoutPanel1.TabIndex = 29;
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "VRG-HR-TS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.GroupBoxServer.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewServer)).EndInit();
            this.GroupBoxBenutzer.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewBenutzer)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button ButtonVerbinden;
        private System.Windows.Forms.Button ButtonBenutzerLaden;
        private System.Windows.Forms.Button ButtonBenutzerAbmelden;
        private System.Windows.Forms.GroupBox GroupBoxServer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView DataGridViewServer;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button ButtonSuchenServer;
        private System.Windows.Forms.TextBox TextBoxSucheServer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox GroupBoxBenutzer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button ButtonSuchenBenutzer;
        private System.Windows.Forms.TextBox textBoxSucheBenutzer;
        private System.Windows.Forms.Label labelSuchen;
        private System.Windows.Forms.DataGridView DataGridViewBenutzer;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnServer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStatus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemVerbindung;
        private System.Windows.Forms.ToolStripMenuItem anmeldeinformationenToolStripMenuItem;
        private System.Windows.Forms.Button ButtonSitzungSpiegeln;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
    }
}

