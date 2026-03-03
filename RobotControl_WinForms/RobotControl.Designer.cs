namespace RobotControl_WinForms
{
    partial class RobotControl
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lb_Werkzeugkasten = new ListBox();
            num_Platzwahl = new NumericUpDown();
            cbx_WerkzeugAuswahl = new ComboBox();
            bt_RoboBestuecken = new Button();
            bt_WerkzeugEntfernen = new Button();
            label1 = new Label();
            label2 = new Label();
            cbx_NeuesWerkzeug = new ComboBox();
            label3 = new Label();
            cbx_BohrerGroesse = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            bt_Holen = new Button();
            derVerschleisser = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)num_Platzwahl).BeginInit();
            SuspendLayout();
            // 
            // lb_Werkzeugkasten
            // 
            lb_Werkzeugkasten.BackColor = SystemColors.ControlLightLight;
            lb_Werkzeugkasten.Font = new Font("Segoe UI", 12F);
            lb_Werkzeugkasten.FormattingEnabled = true;
            lb_Werkzeugkasten.Location = new Point(12, 181);
            lb_Werkzeugkasten.Name = "lb_Werkzeugkasten";
            lb_Werkzeugkasten.Size = new Size(676, 284);
            lb_Werkzeugkasten.TabIndex = 0;
            // 
            // num_Platzwahl
            // 
            num_Platzwahl.Location = new Point(11, 43);
            num_Platzwahl.Name = "num_Platzwahl";
            num_Platzwahl.ReadOnly = true;
            num_Platzwahl.Size = new Size(117, 27);
            num_Platzwahl.TabIndex = 1;
            num_Platzwahl.TextAlign = HorizontalAlignment.Center;
            // 
            // cbx_WerkzeugAuswahl
            // 
            cbx_WerkzeugAuswahl.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_WerkzeugAuswahl.FormattingEnabled = true;
            cbx_WerkzeugAuswahl.Location = new Point(134, 43);
            cbx_WerkzeugAuswahl.Name = "cbx_WerkzeugAuswahl";
            cbx_WerkzeugAuswahl.Size = new Size(308, 28);
            cbx_WerkzeugAuswahl.Sorted = true;
            cbx_WerkzeugAuswahl.TabIndex = 2;
            // 
            // bt_RoboBestuecken
            // 
            bt_RoboBestuecken.Location = new Point(11, 139);
            bt_RoboBestuecken.Name = "bt_RoboBestuecken";
            bt_RoboBestuecken.Size = new Size(307, 29);
            bt_RoboBestuecken.TabIndex = 3;
            bt_RoboBestuecken.Text = "Roboter bestücken";
            bt_RoboBestuecken.UseVisualStyleBackColor = true;
            bt_RoboBestuecken.Click += Bt_RoboBestuecken_Click;
            // 
            // bt_WerkzeugEntfernen
            // 
            bt_WerkzeugEntfernen.Location = new Point(324, 139);
            bt_WerkzeugEntfernen.Name = "bt_WerkzeugEntfernen";
            bt_WerkzeugEntfernen.Size = new Size(307, 29);
            bt_WerkzeugEntfernen.TabIndex = 4;
            bt_WerkzeugEntfernen.Text = "Werkzeug entfernen";
            bt_WerkzeugEntfernen.UseVisualStyleBackColor = true;
            bt_WerkzeugEntfernen.Click += Bt_WerkzeugEntfernen_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(134, 20);
            label1.Name = "label1";
            label1.Size = new Size(165, 20);
            label1.TabIndex = 5;
            label1.Text = "Vorhandene Werkzeuge";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 20);
            label2.Name = "label2";
            label2.Size = new Size(117, 20);
            label2.TabIndex = 6;
            label2.Text = "Platz auswählen:";
            // 
            // cbx_NeuesWerkzeug
            // 
            cbx_NeuesWerkzeug.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_NeuesWerkzeug.FormattingEnabled = true;
            cbx_NeuesWerkzeug.Location = new Point(316, 97);
            cbx_NeuesWerkzeug.Name = "cbx_NeuesWerkzeug";
            cbx_NeuesWerkzeug.Size = new Size(170, 28);
            cbx_NeuesWerkzeug.TabIndex = 7;
            cbx_NeuesWerkzeug.SelectedIndexChanged += Cbx_NeuesWerkzeug_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(316, 74);
            label3.Name = "label3";
            label3.Size = new Size(126, 20);
            label3.TabIndex = 8;
            label3.Text = "Neues Werkzeug :";
            // 
            // cbx_BohrerGroesse
            // 
            cbx_BohrerGroesse.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_BohrerGroesse.FormattingEnabled = true;
            cbx_BohrerGroesse.Location = new Point(492, 97);
            cbx_BohrerGroesse.Name = "cbx_BohrerGroesse";
            cbx_BohrerGroesse.Size = new Size(49, 28);
            cbx_BohrerGroesse.TabIndex = 9;
            cbx_BohrerGroesse.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(492, 74);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 10;
            label4.Text = "Größe";
            label4.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(547, 105);
            label5.Name = "label5";
            label5.Size = new Size(35, 20);
            label5.TabIndex = 11;
            label5.Text = "mm";
            label5.Visible = false;
            // 
            // bt_Holen
            // 
            bt_Holen.Location = new Point(588, 96);
            bt_Holen.Name = "bt_Holen";
            bt_Holen.Size = new Size(94, 29);
            bt_Holen.TabIndex = 12;
            bt_Holen.Text = "Holen";
            bt_Holen.UseVisualStyleBackColor = true;
            bt_Holen.Click += Bt_Holen_Click;
            // 
            // derVerschleisser
            // 
            derVerschleisser.Enabled = true;
            derVerschleisser.Tick += timer1_Tick;
            // 
            // RobotControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(701, 479);
            Controls.Add(bt_Holen);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(cbx_BohrerGroesse);
            Controls.Add(label3);
            Controls.Add(cbx_NeuesWerkzeug);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(bt_WerkzeugEntfernen);
            Controls.Add(bt_RoboBestuecken);
            Controls.Add(cbx_WerkzeugAuswahl);
            Controls.Add(num_Platzwahl);
            Controls.Add(lb_Werkzeugkasten);
            Name = "RobotControl";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Robot Control";
            ((System.ComponentModel.ISupportInitialize)num_Platzwahl).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lb_Werkzeugkasten;
        private NumericUpDown num_Platzwahl;
        private ComboBox cbx_WerkzeugAuswahl;
        private Button bt_RoboBestuecken;
        private Button bt_WerkzeugEntfernen;
        private Label label1;
        private Label label2;
        private ComboBox cbx_NeuesWerkzeug;
        private Label label3;
        private ComboBox cbx_BohrerGroesse;
        private Label label4;
        private Label label5;
        private Button bt_Holen;
        private System.Windows.Forms.Timer derVerschleisser;
    }
}