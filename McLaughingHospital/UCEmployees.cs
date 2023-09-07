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
    public partial class UCEmployees : UserControl
    {
        public UCEmployees()
        {
            InitializeComponent();
        }
        List<Doctor> Doct = new List<Doctor>();
        List<PartTime> Ptm = new List<PartTime>();
        List<Nurse> Nurs = new List<Nurse>();
        BindingSource bs = new BindingSource();

        bool isNumber;

        private void btnAdd_Click(object sender, EventArgs e)
        {

            string firstname = txtFirstName.Text;
            string surname = txtSurn.Text;
            string address = txtAddress.Text;
            string county = cboCounty.Text;
            string phone = txtPhone.Text;
            string email = txtEmail.Text;
            
            string specialty = cboSpecialty.Text;
           
            string position = "Doctor";
            int age = int.Parse(txtAge.Text);
            int empNo = int.Parse(txtEmpNo.Text);


            if (rdoDoc.Checked)
            {
                position = "Doctor";
                Doctor doc = new Doctor(firstname, surname, address, county, age, phone, email, empNo, position, specialty);
                if (txtSalary == null || txtHours == null)
                {
                    txtSalary.Text = "0";
                    txtHours.Text = "0";
                }
                
                Doct.Add(doc);
                MessageBox.Show($"Doctor added successfully.");
                ClearFields();
              

            }
            else if (rdoNurse.Checked)
            {
                try
                {
                    double salary = double.Parse(txtSalary.Text);
                    position = "Nurse";
                    Nurse nur = new Nurse(firstname, surname, address, county, age, phone, email, empNo, position, salary);
                    Nurs.Add(nur);
                    MessageBox.Show($"Nurse added successfully.");
                    ClearFields();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Salary must no be blank");
                }
               
               
            }
            else if (rdoPT.Checked)
            {
                try
                {
                    int hours = int.Parse(txtHours.Text);
                    position = "Part Time";

                    PartTime pt = new PartTime(firstname, surname, address, county, age, phone, email, empNo, position, hours);
                    Ptm.Add(pt);
                    MessageBox.Show($"Nurse added successfully.");
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Number of hours must no be blank");
                }
            }
        }

        private void UCEmployees_Load(object sender, EventArgs e)
        {
            cboCounty.DataSource = Enum.GetValues(typeof(Counties));
            cboSpecialty.DataSource = Enum.GetValues(typeof(Specialties));
            cboSpecialty.Enabled = true;
            txtHours.Enabled = false;
            txtSalary.Enabled = false;
            lblNH.Enabled = false;
            lblSal.Enabled = false;
            lblSpe.Enabled = true;
            StyleDGV();
        }
        public void DisplayDoctor()
        {
            dgvEmp.DataSource = false;
            bs.DataSource = Doct;
            dgvEmp.DataSource = bs;
        }
        public void DisplayNurse()
        {
            dgvEmp.DataSource = false;
            bs.DataSource = Nurs;
            dgvEmp.DataSource = bs;
        }
        public void DisplayPT()
        {
            dgvEmp.DataSource = false;
            bs.DataSource = Ptm;
            dgvEmp.DataSource = bs;
        }

        private void btnShowDoc_Click(object sender, EventArgs e)
        {
            DisplayDoctor();
            StyleDGV();
        }

        private void btnShowNur_Click(object sender, EventArgs e)
        {
            DisplayNurse();
            StyleDGV();
        }

        private void btnShowPT_Click(object sender, EventArgs e)
        {
            DisplayPT();
            StyleDGV();
        }

        private void btnall_Click(object sender, EventArgs e)
        {
            var hs = new HashSet<Employee>(Doct, new EmpComparer());
            hs.UnionWith(Nurs);
            hs.UnionWith(Ptm);
            var merged = hs.ToList();
            dgvEmp.DataSource = false;
            bs.DataSource = merged;
            dgvEmp.DataSource = bs;
        }

        void ClearFields()
        {
            txtFirstName.Clear();
            txtAddress.Clear();
            txtAge.Clear();
            txtEmail.Clear();
            txtEmpNo.Clear();
            txtHours.Clear();
            txtPhone.Clear();
            txtSalary.Clear();
            txtSurn.Clear();
        }

        private void rdoNurse_CheckedChanged(object sender, EventArgs e)
        {
            txtSalary.Enabled = true;
            cboSpecialty.Enabled = false;
            txtHours.Enabled = false;
            txtHours.BackColor = Color.Gray;
            txtSalary.BackColor = DefaultBackColor;
            cboSpecialty.Enabled = false;
            txtHours.Enabled = false;
            lblNH.Enabled = false;
            lblSal.Enabled = true;
            lblSpe.Enabled = false;

        }

        private void rdoPT_CheckedChanged(object sender, EventArgs e)
        {
            cboSpecialty.Enabled = false;
            txtHours.Enabled = true;
            txtSalary.Enabled = false;
            txtSalary.BackColor = Color.Gray;
            txtHours.BackColor = DefaultBackColor;
            lblNH.Enabled = true;
            lblSal.Enabled = false;
            lblSpe.Enabled = false;
        }

        private void rdoDoc_CheckedChanged(object sender, EventArgs e)
        {
            cboSpecialty.Enabled = true;
            txtHours.Enabled = false;
            txtSalary.Enabled = false;
            txtSalary.BackColor = Color.Gray;
            txtHours.BackColor = Color.Gray;
            lblNH.Enabled = false;
            lblSal.Enabled = false;
            lblSpe.Enabled = true;

        }

        private void btnExp_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfdExpCSV = new SaveFileDialog();
            string filter = "CSV file (*csv)|*.csv";
            sfdExpCSV.Filter = filter;

            if (sfdExpCSV.ShowDialog(this) == DialogResult.OK)
            {
                if (rdoExpDoc.Checked)
                {
                    foreach (Doctor doc in Doct)
                    {
                        File.WriteAllText(sfdExpCSV.FileName, doc.ToString());
                    }
                }
                else if (rdoExpNur.Checked)
                {
                    foreach (Nurse nur in Nurs)
                    {
                        File.WriteAllText(sfdExpCSV.FileName, nur.ToString());

                    }
                }
                else if (rdoExPT.Checked)
                {
                    foreach (PartTime pt in Ptm)
                    {
                        File.WriteAllText(sfdExpCSV.FileName, pt.ToString());
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dgvEmp.Rows.RemoveAt(dgvEmp.SelectedRows[0].Index);
        }

        void StyleDGV()
        {
            dgvEmp.BorderStyle = BorderStyle.None;
            dgvEmp.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvEmp.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvEmp.DefaultCellStyle.SelectionBackColor = Color.CornflowerBlue;
            dgvEmp.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvEmp.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvEmp.EnableHeadersVisualStyles = false;
            dgvEmp.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvEmp.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 10);
            dgvEmp.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(209, 215, 240);
            dgvEmp.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(50, 71, 154);
        }

        private void txtEmpNo_Validating(object sender, CancelEventArgs e)
        {
            bool cancel = false;
            int x;
            isNumber = int.TryParse(txtEmpNo.Text, out x);
            if (isNumber == false || string.IsNullOrEmpty(txtEmpNo.Text))
            {
                epEmpNo.SetError(txtEmpNo, "It should be a number");
                cancel = true;
            }
            e.Cancel = cancel;
        }

        private void txtEmpNo_Validated(object sender, EventArgs e)
        {
            epEmpNo.Clear();
        }

        private void txtSalary_Validating(object sender, CancelEventArgs e)
        {
            bool cancel = false;
            double x;
            isNumber = double.TryParse(txtSalary.Text, out x);
            if (isNumber == false || string.IsNullOrEmpty(txtSalary.Text))
            {
                epSalary.SetError(txtSalary, "It should be a number");
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
               
            } e.Cancel = cancel;
        }

        private void txtSalary_Validated(object sender, EventArgs e)
        {
            epSalary.Clear();
        }

        private void txtAge_Validating(object sender, CancelEventArgs e)
        {
            bool cancel = false;
            int x;
            isNumber = int.TryParse(txtAge.Text, out x);
            if(isNumber == false || string.IsNullOrEmpty(txtAge.Text))
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

        private void txtHours_Validating(object sender, CancelEventArgs e)
        {
            bool cancel = false;
            int x;
            isNumber = int.TryParse(txtHours.Text, out x);
            if (isNumber == false || string.IsNullOrEmpty(txtHours.Text))
            {
                epHours.SetError(txtHours, "It should be a number");
                cancel = true;
            }
            e.Cancel = cancel;
        }

        private void txtHours_Validated(object sender, EventArgs e)
        {
            epHours.Clear();
        }

        bool isStringNullOrEmpty(string s)
        {
            bool st = String.IsNullOrEmpty(s);
            return st;
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

        private void txtAddress_Validated(object sender, EventArgs e)
        {
            epAddress.Clear();
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

        private void txtEmail_Validated(object sender, EventArgs e)
        {
            epEmail.Clear();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainMenu uce = new MainMenu();
            uce.Show();
            this.Hide();
        }
    }
}
