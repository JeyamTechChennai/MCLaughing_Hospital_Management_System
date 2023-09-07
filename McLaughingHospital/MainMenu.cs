using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace McLaughingHospital
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();

        }
        
        
        
        ManageUC mnguc = new ManageUC();

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            UCMenu ucm = new UCMenu();
            panBtnDetail.Height = btnMainMenu.Height;
            panBtnDetail.Top = btnMainMenu.Top;
            mnguc.DisplayControl(ucm, panelContainer);
            

        }

        private void btnEmp_Click(object sender, EventArgs e)
        {
            UCEmployees uce = new UCEmployees();
            panBtnDetail.Height = btnEmp.Height;
            panBtnDetail.Top = btnEmp.Top;
            mnguc.DisplayControl(uce, panelContainer);

        }

        private void btnPat_Click(object sender, EventArgs e)
        {

            UCPatients ucp = new UCPatients();
            panBtnDetail.Height = btnPat.Height;
            panBtnDetail.Top = btnPat.Top;
            mnguc.DisplayControl(ucp, panelContainer);
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            UCMenu ucm = new UCMenu();
            panBtnDetail.Height = btnMainMenu.Height;
            panBtnDetail.Top = btnMainMenu.Top;
            mnguc.DisplayControl(ucm, panelContainer);

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            panBtnDetail.Height = btnLogout.Height;
            panBtnDetail.Top = btnLogout.Top;
            this.Close();
            f1.Show();
            

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
