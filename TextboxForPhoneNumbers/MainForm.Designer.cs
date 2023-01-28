namespace TextboxForPhoneNumbers
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.countriesCombobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.validateButton = new System.Windows.Forms.Button();
            this.originalNumberLabel = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.navigationPanel = new System.Windows.Forms.Panel();
            this.minimizeFormButton = new System.Windows.Forms.Button();
            this.closeAppButton = new System.Windows.Forms.Button();
            this.regexNumberLabel = new System.Windows.Forms.Label();
            this.showDataButton = new System.Windows.Forms.Button();
            this.ShowDataCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.copyDataButton = new System.Windows.Forms.Button();
            this.aboutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.aboutPictureBox = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.numberWithNoCountryCodeLabel = new System.Windows.Forms.Label();
            this.regexNumberWithNoCountryCodeLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.validOrNotValidLabel = new System.Windows.Forms.Label();
            this.detailsPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.navigationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aboutPictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.detailsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // countriesCombobox
            // 
            this.countriesCombobox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.countriesCombobox.FormattingEnabled = true;
            this.countriesCombobox.Location = new System.Drawing.Point(88, 59);
            this.countriesCombobox.Margin = new System.Windows.Forms.Padding(10);
            this.countriesCombobox.Name = "countriesCombobox";
            this.countriesCombobox.Size = new System.Drawing.Size(226, 28);
            this.countriesCombobox.TabIndex = 1;
            this.countriesCombobox.SelectedIndexChanged += new System.EventHandler(this.countriesCombobox_SelectedIndexChanged);
            this.countriesCombobox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.countriesCombobox_KeyPress);
            this.countriesCombobox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.countriesCombobox_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Country:";
            // 
            // validateButton
            // 
            this.validateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.validateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.validateButton.Location = new System.Drawing.Point(381, 103);
            this.validateButton.Name = "validateButton";
            this.validateButton.Size = new System.Drawing.Size(89, 49);
            this.validateButton.TabIndex = 3;
            this.validateButton.Text = "VALIDATE";
            this.validateButton.UseVisualStyleBackColor = true;
            this.validateButton.Click += new System.EventHandler(this.validateButton_Click);
            // 
            // originalNumberLabel
            // 
            this.originalNumberLabel.AutoSize = true;
            this.originalNumberLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.originalNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.originalNumberLabel.Location = new System.Drawing.Point(3, 211);
            this.originalNumberLabel.Margin = new System.Windows.Forms.Padding(15);
            this.originalNumberLabel.Name = "originalNumberLabel";
            this.originalNumberLabel.Size = new System.Drawing.Size(66, 20);
            this.originalNumberLabel.TabIndex = 4;
            this.originalNumberLabel.Text = "Number:";
            this.toolTip1.SetToolTip(this.originalNumberLabel, "Click for copy");
            this.originalNumberLabel.Click += new System.EventHandler(this.originalNumberLabel_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maskedTextBox1.Location = new System.Drawing.Point(327, 59);
            this.maskedTextBox1.Mask = "(999) 000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(143, 27);
            this.maskedTextBox1.TabIndex = 5;
            this.maskedTextBox1.Click += new System.EventHandler(this.maskedTextBox1_Click);
            this.maskedTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maskedTextBox1_KeyDown);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.infoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.infoLabel.Location = new System.Drawing.Point(3, 3);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(115, 200);
            this.infoLabel.TabIndex = 6;
            this.infoLabel.Text = "Selected item:\r\n\r\nSelected value:\r\n\r\nSelected text: \r\n\r\nSelected index:\r\n\r\nCombob" +
    "ox text:\r\n\r\n";
            this.toolTip1.SetToolTip(this.infoLabel, "Click for copy");
            this.infoLabel.Click += new System.EventHandler(this.infoLabel_Click);
            // 
            // navigationPanel
            // 
            this.navigationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.navigationPanel.Controls.Add(this.minimizeFormButton);
            this.navigationPanel.Controls.Add(this.closeAppButton);
            this.navigationPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigationPanel.Location = new System.Drawing.Point(0, 0);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.Size = new System.Drawing.Size(920, 50);
            this.navigationPanel.TabIndex = 8;
            this.navigationPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.navigationPanel_MouseDown);
            // 
            // minimizeFormButton
            // 
            this.minimizeFormButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimizeFormButton.FlatAppearance.BorderSize = 0;
            this.minimizeFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeFormButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.minimizeFormButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.minimizeFormButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.minimizeFormButton.Location = new System.Drawing.Point(820, 0);
            this.minimizeFormButton.Name = "minimizeFormButton";
            this.minimizeFormButton.Size = new System.Drawing.Size(50, 50);
            this.minimizeFormButton.TabIndex = 1;
            this.minimizeFormButton.Text = "_";
            this.minimizeFormButton.UseVisualStyleBackColor = true;
            this.minimizeFormButton.Click += new System.EventHandler(this.minimizeFormButton_Click);
            // 
            // closeAppButton
            // 
            this.closeAppButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeAppButton.FlatAppearance.BorderSize = 0;
            this.closeAppButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeAppButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.closeAppButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.closeAppButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.closeAppButton.Location = new System.Drawing.Point(870, 0);
            this.closeAppButton.Name = "closeAppButton";
            this.closeAppButton.Size = new System.Drawing.Size(50, 50);
            this.closeAppButton.TabIndex = 0;
            this.closeAppButton.Text = "X";
            this.closeAppButton.UseVisualStyleBackColor = true;
            this.closeAppButton.Click += new System.EventHandler(this.closeAppButton_Click);
            // 
            // regexNumberLabel
            // 
            this.regexNumberLabel.AutoSize = true;
            this.regexNumberLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.regexNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.regexNumberLabel.Location = new System.Drawing.Point(3, 261);
            this.regexNumberLabel.Margin = new System.Windows.Forms.Padding(15);
            this.regexNumberLabel.Name = "regexNumberLabel";
            this.regexNumberLabel.Size = new System.Drawing.Size(111, 20);
            this.regexNumberLabel.TabIndex = 9;
            this.regexNumberLabel.Text = "Regex Number:";
            this.toolTip1.SetToolTip(this.regexNumberLabel, "Click for copy");
            this.regexNumberLabel.Click += new System.EventHandler(this.regexNumberLabel_Click);
            // 
            // showDataButton
            // 
            this.showDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showDataButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.showDataButton.Location = new System.Drawing.Point(12, 257);
            this.showDataButton.Name = "showDataButton";
            this.showDataButton.Size = new System.Drawing.Size(89, 49);
            this.showDataButton.TabIndex = 10;
            this.showDataButton.Text = "SHOW DATA";
            this.showDataButton.UseVisualStyleBackColor = true;
            this.showDataButton.Click += new System.EventHandler(this.showDataButton_Click);
            // 
            // ShowDataCheckedListBox
            // 
            this.ShowDataCheckedListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ShowDataCheckedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ShowDataCheckedListBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ShowDataCheckedListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ShowDataCheckedListBox.FormattingEnabled = true;
            this.ShowDataCheckedListBox.Items.AddRange(new object[] {
            "Countries",
            "Codes"});
            this.ShowDataCheckedListBox.Location = new System.Drawing.Point(12, 207);
            this.ShowDataCheckedListBox.Name = "ShowDataCheckedListBox";
            this.ShowDataCheckedListBox.Size = new System.Drawing.Size(105, 44);
            this.ShowDataCheckedListBox.TabIndex = 11;
            // 
            // copyDataButton
            // 
            this.copyDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyDataButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.copyDataButton.Location = new System.Drawing.Point(107, 257);
            this.copyDataButton.Name = "copyDataButton";
            this.copyDataButton.Size = new System.Drawing.Size(89, 49);
            this.copyDataButton.TabIndex = 12;
            this.copyDataButton.Text = "COPY DATA";
            this.copyDataButton.UseVisualStyleBackColor = true;
            this.copyDataButton.Click += new System.EventHandler(this.copyDataButton_Click);
            // 
            // aboutLinkLabel
            // 
            this.aboutLinkLabel.AutoSize = true;
            this.aboutLinkLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aboutLinkLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aboutLinkLabel.LinkColor = System.Drawing.Color.White;
            this.aboutLinkLabel.Location = new System.Drawing.Point(2, 470);
            this.aboutLinkLabel.Name = "aboutLinkLabel";
            this.aboutLinkLabel.Size = new System.Drawing.Size(150, 19);
            this.aboutLinkLabel.TabIndex = 3;
            this.aboutLinkLabel.TabStop = true;
            this.aboutLinkLabel.Text = "github.com/sametcn99";
            this.aboutLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.aboutLinkLabel_LinkClicked);
            // 
            // aboutPictureBox
            // 
            this.aboutPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aboutPictureBox.Image = global::TextboxForPhoneNumbers.Properties.Resources.github_mark_white;
            this.aboutPictureBox.Location = new System.Drawing.Point(26, 367);
            this.aboutPictureBox.Name = "aboutPictureBox";
            this.aboutPictureBox.Size = new System.Drawing.Size(100, 100);
            this.aboutPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.aboutPictureBox.TabIndex = 2;
            this.aboutPictureBox.TabStop = false;
            this.aboutPictureBox.Click += new System.EventHandler(this.aboutPictureBox_Click);
            // 
            // numberWithNoCountryCodeLabel
            // 
            this.numberWithNoCountryCodeLabel.AutoSize = true;
            this.numberWithNoCountryCodeLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numberWithNoCountryCodeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.numberWithNoCountryCodeLabel.Location = new System.Drawing.Point(3, 311);
            this.numberWithNoCountryCodeLabel.Margin = new System.Windows.Forms.Padding(15);
            this.numberWithNoCountryCodeLabel.Name = "numberWithNoCountryCodeLabel";
            this.numberWithNoCountryCodeLabel.Size = new System.Drawing.Size(219, 20);
            this.numberWithNoCountryCodeLabel.TabIndex = 14;
            this.numberWithNoCountryCodeLabel.Text = "Number With No Country Code:";
            this.toolTip1.SetToolTip(this.numberWithNoCountryCodeLabel, "Click for copy");
            this.numberWithNoCountryCodeLabel.Click += new System.EventHandler(this.numberWithNoCountryCodeLabel_Click);
            // 
            // regexNumberWithNoCountryCodeLabel
            // 
            this.regexNumberWithNoCountryCodeLabel.AutoSize = true;
            this.regexNumberWithNoCountryCodeLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.regexNumberWithNoCountryCodeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.regexNumberWithNoCountryCodeLabel.Location = new System.Drawing.Point(3, 361);
            this.regexNumberWithNoCountryCodeLabel.Margin = new System.Windows.Forms.Padding(15);
            this.regexNumberWithNoCountryCodeLabel.Name = "regexNumberWithNoCountryCodeLabel";
            this.regexNumberWithNoCountryCodeLabel.Size = new System.Drawing.Size(268, 20);
            this.regexNumberWithNoCountryCodeLabel.TabIndex = 15;
            this.regexNumberWithNoCountryCodeLabel.Text = "Regex  Number With No Country Code:";
            this.toolTip1.SetToolTip(this.regexNumberWithNoCountryCodeLabel, "Click for copy");
            this.regexNumberWithNoCountryCodeLabel.Click += new System.EventHandler(this.regexNumberWithNoCountryCodeLabel_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(862, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(58, 475);
            this.panel2.TabIndex = 16;
            this.toolTip1.SetToolTip(this.panel2, "Details Panel");
            this.panel2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label2.Location = new System.Drawing.Point(10, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "<";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // validOrNotValidLabel
            // 
            this.validOrNotValidLabel.AutoSize = true;
            this.validOrNotValidLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.validOrNotValidLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.validOrNotValidLabel.Location = new System.Drawing.Point(12, 132);
            this.validOrNotValidLabel.Name = "validOrNotValidLabel";
            this.validOrNotValidLabel.Size = new System.Drawing.Size(126, 20);
            this.validOrNotValidLabel.TabIndex = 17;
            this.validOrNotValidLabel.Text = "Valid or Not Valid";
            this.validOrNotValidLabel.Visible = false;
            // 
            // detailsPanel
            // 
            this.detailsPanel.Controls.Add(this.infoLabel);
            this.detailsPanel.Controls.Add(this.originalNumberLabel);
            this.detailsPanel.Controls.Add(this.regexNumberLabel);
            this.detailsPanel.Controls.Add(this.numberWithNoCountryCodeLabel);
            this.detailsPanel.Controls.Add(this.regexNumberWithNoCountryCodeLabel);
            this.detailsPanel.Location = new System.Drawing.Point(477, 56);
            this.detailsPanel.Name = "detailsPanel";
            this.detailsPanel.Size = new System.Drawing.Size(379, 427);
            this.detailsPanel.TabIndex = 18;
            this.detailsPanel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label3.Location = new System.Drawing.Point(0, 495);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(413, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "List of Country Codes and Country Names is taken from(28.01.2023):\r\nhttps://gist." +
    "github.com/Venoli/685c5bb24ba8170a7b22f46089d77224#file-dictionaryoutput-cs \r\n";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(920, 525);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.detailsPanel);
            this.Controls.Add(this.validOrNotValidLabel);
            this.Controls.Add(this.aboutLinkLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.aboutPictureBox);
            this.Controls.Add(this.copyDataButton);
            this.Controls.Add(this.ShowDataCheckedListBox);
            this.Controls.Add(this.showDataButton);
            this.Controls.Add(this.navigationPanel);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.validateButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.countriesCombobox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TextboxForPhoneNumber";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.navigationPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aboutPictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.detailsPanel.ResumeLayout(false);
            this.detailsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComboBox countriesCombobox;
        private Label label1;
        private Button validateButton;
        private Label originalNumberLabel;
        private MaskedTextBox maskedTextBox1;
        private Label infoLabel;
        private Panel navigationPanel;
        private Button closeAppButton;
        private Label regexNumberLabel;
        private Button showDataButton;
        private CheckedListBox ShowDataCheckedListBox;
        private Button copyDataButton;
        private LinkLabel aboutLinkLabel;
        private PictureBox aboutPictureBox;
        private ToolTip toolTip1;
        private Label numberWithNoCountryCodeLabel;
        private Label regexNumberWithNoCountryCodeLabel;
        private Panel panel2;
        private Label label2;
        private Label validOrNotValidLabel;
        private Panel detailsPanel;
        private Button minimizeFormButton;
        private Label label3;
    }
}