using System.Text.RegularExpressions;
using System.Windows.Forms;
using static TextboxForPhoneNumbers.CountryCodes;
namespace TextboxForPhoneNumbers
{
    public partial class MainForm : Form
    {
        /*-----NOTES-----
        REGEX Documantation:
        https://learn.microsoft.com/en-us/dotnet/standard/base-types/regular-expression-language-quick-reference

        List of Country Codes and Country Names is taken from(28.01.2023):
        https://gist.github.com/Venoli/685c5bb24ba8170a7b22f46089d77224#file-dictionaryoutput-cs         
        */

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        string phoneNumber;
        string regexNumber;
        string numberWithNoCountryCode;
        string regexNumberWithNoCountryCode;

        string dataText = "";

        public MainForm()
        {
            InitializeComponent();
            this.Size = new Size(549, 525);
            label2.Text = ">";
        }

        //detail panel methods
        private void detailsPanelLabels()
        {
            if (label2.Text == "<")
            {
                originalNumberLabel.Text = "Number: \n" + phoneNumber;
                regexNumberLabel.Text = "Regex Number: \n" + regexNumber;
                numberWithNoCountryCodeLabel.Text = "Number With No Country Code: \n" + numberWithNoCountryCode;
                regexNumberWithNoCountryCodeLabel.Text = "Regex Number With No Country Code: \n" + regexNumberWithNoCountryCode;
            }
        }
        private void panelExpand()
        {
            if (label2.Text == "<")//restricting
            {
                this.Size = new Size(549, 525);
                detailsPanel.Visible = false;
                label2.Text = ">";
                this.CenterToScreen();
            }
            else if (label2.Text == ">")//expanding
            {
                detailsPanel.Visible = true;
                this.Size = new Size(920, 525);
                label2.Text = "<";
                detailsPanelLabels();
                this.CenterToScreen();
            }
        }

        //Validate Phone Number
        private void validateButton_Click(object sender, EventArgs e)
        {
            try
            {
                phoneNumber = $"+{countriesCombobox.SelectedValue.ToString().Trim()} {maskedTextBox1.Text.ToString().Trim()}";
                regexNumberWithNoCountryCode = Regex.Replace(maskedTextBox1.Text.ToString().Trim(), @"[^0-9]+", "");
                numberWithNoCountryCode = maskedTextBox1.Text.ToString().Trim();
                regexNumber = countriesCombobox.SelectedValue.ToString().Trim() + Regex.Replace(phoneNumber, @"[^0-9]+", "");
                if (regexNumberWithNoCountryCode.Length == 10)
                {
                    validOrNotValidLabel.Visible = true;
                    validOrNotValidLabel.Text = "Valid Phone Number!";
                    detailsPanelLabels();
                }
                else
                {
                    MessageBox.Show("Phone Number is wrong.");
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Select Country first!");
            }
        }

        //when textbox is clicked by mouse, move cursor to textbox start.
        private void maskedTextBox1_Click(object sender, EventArgs e)
        {
            if (Regex.Replace(maskedTextBox1.Text.ToString(), @"[^0-9]+", "").Length == 0)
            {
                maskedTextBox1.Select(0, 0);
            }
            else if (Regex.Replace(maskedTextBox1.Text.ToString(), @"[^0-9]+", "").Length != 0)
            {
                maskedTextBox1.SelectAll();
            }
        }

        //Binding CountryCodes to combobox if combobox is empty
        private void countriesCombobox_MouseClick(object sender, MouseEventArgs e)
        {
            if (countriesCombobox.DataSource == null)
            {
                countriesCombobox.DataSource = CountryCodes.countryCodesMapping.ToList();
                countriesCombobox.ValueMember = "Value";
                countriesCombobox.DisplayMember = "Key";
            }
        }

        //combobox info display
        private void countriesCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            infoLabel.Text = "Selected item: \n" + countriesCombobox.SelectedItem.ToString() +
                "\nSelected value: \n" + countriesCombobox.SelectedValue.ToString() +
                "\nSelected text: \n" + countriesCombobox.SelectedText.ToString() +
                "\nSelected index: \n" + countriesCombobox.SelectedIndex.ToString() +
                "\nCombobox text: \n" + countriesCombobox.Text.ToString();
        }

        //Pressing enter key is run validate method and control coppied text
        private void maskedTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                validateButton_Click(sender, e);
            }
            if (e.Control && e.KeyValue == 86 && Regex.Replace(Clipboard.GetText().ToString().Trim(), @"[^0-9]+", "").Length != 10)
            {
                MessageBox.Show("Coppied text is not a phone number!");
            }
        }

        //---data buttons click events---
        //Show data button click event
        private void showDataButton_Click(object sender, EventArgs e)
        {
            if (getDataFromCountryCodes() != "")
            {
                FlexibleMessageBox.Show(dataText);
            }
            else
            {
                MessageBox.Show("Select data items");
            }
            dataText = "";
            ShowDataCheckedListBox.UncheckAllItems();
        }
        //Copy data button click event
        private void copyDataButton_Click(object sender, EventArgs e)
        {
            if (getDataFromCountryCodes() != "")
            {
                Clipboard.SetText(dataText);
                MessageBox.Show("COPIED!");
            }
            else
            {
                MessageBox.Show("Select data items");
            }
            dataText = "";
            ShowDataCheckedListBox.UncheckAllItems();
        }

        //Get data from CountryCodes class
        private string getDataFromCountryCodes()
        {
            if (ShowDataCheckedListBox.CheckedItems.Count == 2)
            {
                foreach (var kvp in CountryCodes.countryCodesMapping)
                {
                    dataText = dataText + $"{kvp.Key}, {kvp.Value}\n";
                }
            }
            else if (ShowDataCheckedListBox.SelectedItems.Contains("Countries"))
            {
                foreach (var kvp in CountryCodes.countryCodesMapping)
                {
                    dataText = dataText + $"{kvp.Key}\n";
                }
            }
            else if (ShowDataCheckedListBox.SelectedItems.Contains("Codes"))
            {
                foreach (var kvp in CountryCodes.countryCodesMapping)
                {
                    dataText = dataText + $"{kvp.Value}\n";
                }
            }
            return dataText;
        }

        //Disable keyboard in combobox
        private void countriesCombobox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Keys.None;
        }

        //---label click events---
        //info label click event
        private void infoLabel_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(infoLabel.Text.ToString().Trim());
            MessageBox.Show("COPIED!");
        }
        //Number labels click events
        private void originalNumberLabel_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(phoneNumber);
            MessageBox.Show("COPIED!");
        }
        private void regexNumberLabel_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(regexNumber);
            MessageBox.Show("COPIED!");
        }
        private void numberWithNoCountryCodeLabel_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(numberWithNoCountryCode);
            MessageBox.Show("COPIED!");
        }
        private void regexNumberWithNoCountryCodeLabel_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(regexNumberWithNoCountryCode);
            MessageBox.Show("COPIED!");
        }

        //Other Events
        private void navigationPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void closeAppButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void aboutPictureBox_Click(object sender, EventArgs e)
        {
            AppExtensions.OpenURL("https://github.com/sametcn99");
        }
        private void aboutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AppExtensions.OpenURL("https://github.com/sametcn99");
        }
        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            panelExpand();
        }
        private void minimizeFormButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void label2_Click(object sender, EventArgs e)
        {
            panelExpand();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            AppExtensions.OpenURL("https://gist.github.com/Venoli/685c5bb24ba8170a7b22f46089d77224#file-dictionaryoutput-cs");
        }
    }
}