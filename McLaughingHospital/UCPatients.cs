using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace McLaughingHospital
{
    public partial class UCPatients : UserControl
    {
        public UCPatients()
        {
            InitializeComponent();
        }
        List<Patient> Pat = new List<Patient>();
        BindingSource bs = new BindingSource();
        bool isNumber;
        private void btnSave_Click(object sender, EventArgs e)
        {
            string firstname = txtFirstName.Text;
            string surname = txtSurn.Text;
            string address = txtAddress.Text;
            string county = cboCounty.Text;
            string phone = txtPhone.Text;
            string email = txtEmail.Text;
            try
            {
                int age = int.Parse(txtAge.Text);
                int patNo = int.Parse(txtPatNo.Text);
                Patient p = new Patient(firstname, surname, address, county, age, phone, email, patNo);
                Pat.Add(p);
                MessageBox.Show($"Patient added successfully.");
                txtFirstName.Clear();
                txtAddress.Clear();
                txtAge.Clear();
                txtEmail.Clear();
                txtFirstName.Clear();
                txtAddress.Clear();
                txtAge.Clear();
                txtEmail.Clear();
                txtPhone.Clear();
                txtSurn.Clear();
                txtPatNo.Clear();
            }
            catch
            {
                MessageBox.Show("Please fill in all fields");
            }
            
        }

        private void UCPatients_Load(object sender, EventArgs e)
        {
            cboCounty.DataSource = Enum.GetValues(typeof(Counties));
            
            StyleDGV();
        }


        private void btnExp_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfdExpCSV = new SaveFileDialog();
            string filter = "CSV file (*csv)|*.csv";
            sfdExpCSV.Filter = filter;
            if (sfdExpCSV.ShowDialog(this) == DialogResult.OK)
            {
                foreach (Patient pt in Pat)
                {
                    File.WriteAllText(sfdExpCSV.FileName, pt.ToString());
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dgvPat.Rows.RemoveAt(dgvPat.SelectedRows[0].Index);
        }
        void StyleDGV()
        {
            dgvPat.BorderStyle = BorderStyle.None;
            dgvPat.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvPat.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPat.DefaultCellStyle.SelectionBackColor = Color.BlueViolet;
            dgvPat.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvPat.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvPat.EnableHeadersVisualStyles = false;
            dgvPat.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvPat.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 10);
            dgvPat.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(209, 215, 240);
            dgvPat.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(50, 71, 154);
        }
        void DisplayPatients()
        {
            dgvPat.DataSource = false;
            bs.DataSource = Pat;
            dgvPat.DataSource = bs;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayPatients();
        }

        private void txtPatNo_Validating(object sender, CancelEventArgs e)
        {
            bool cancel = false;
            int x;
            isNumber = int.TryParse(txtPatNo.Text, out x);
            if (isNumber == false || string.IsNullOrEmpty(txtPatNo.Text))
            {
                epPatNo.SetError(txtPatNo, "It should be a number");
                cancel = true;
            }
            e.Cancel = cancel;
        }

        private void txtPatNo_Validated(object sender, EventArgs e)
        {
            epPatNo.Clear();

        }

        private void txtAge_Validating(object sender, CancelEventArgs e)
        {
            bool cancel = false;
            int x;
            isNumber = int.TryParse(txtAge.Text, out x);
            if (isNumber == false || string.IsNullOrEmpty(txtAge.Text))
            {
                epAge.SetError(txtAge, "It should be a number");
                cancel = true;
            }
            e.Cancel = cancel;
        }

        private void txtAge_Validated(object sender, EventArgs e)
        {
            epAge.Clear();
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            bool cancel = false;
            if (isStringNullOrEmpty(txtFirstName.Text))
            {
                epFn.SetError(txtFirstName, "Name must not be blank");
                cancel = true;
            }
            e.Cancel = cancel;
        }

        private void txtFirstName_Validated(object sender, EventArgs e)
        {
            epFn.Clear();
        }

        private void txtSurn_Validating(object sender, CancelEventArgs e)
        {
            bool cancel = false;
            if (isStringNullOrEmpty(txtSurn.Text))
            {
                epSn.SetError(txtSurn, "Surname must not be blank");
                cancel = true;
            }
            e.Cancel = cancel;
        }

        private void txtSurn_Validated(object sender, EventArgs e)
        {
            epSn.Clear();
        }

        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            bool cancel = false;
            if (isStringNullOrEmpty(txtAddress.Text))
            {
                epAddress.SetError(txtAddress, "Address must not be blank");
                cancel = true;
            }
            e.Cancel = cancel;
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            bool cancel = false;
            Regex reg = new Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (!reg.IsMatch(txtEmail.Text) || isStringNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Invalid Email Format! It should be user@domain");
                epEmail.SetError(txtEmail, "Email must not be blank");
                cancel = true;

            }
            e.Cancel = cancel;
        }

        private void txtEmail_Validated(object sender, EventArgs e)
        {
            epEmail.Clear();
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            bool cancel = false;
            if (isStringNullOrEmpty(txtPhone.Text))
            {
                epPhone.SetError(txtPhone, "Phone must not be blank");
                cancel = true;
            }
            e.Cancel = cancel;
        }

        private void txtPhone_Validated(object sender, EventArgs e)
        {
            epPhone.Clear();
        }

        bool isStringNullOrEmpty(string s)
        {
            bool st = String.IsNullOrEmpty(s);
            return st;
        }

        private void txtAddress_Validated(object sender, EventArgs e)
        {
            epAddress.Clear();
        }

        private void dgvPat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainMenu uc= new MainMenu();
            uc.Show();
            this.Hide();
        }
    }
}
