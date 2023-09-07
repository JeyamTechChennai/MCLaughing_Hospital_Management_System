using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace McLaughingHospital
{
    public partial class UCMenu : UserControl
    {
        public UCMenu()
        {
            InitializeComponent();
        }
        
       
        private void btnPat_Click(object sender, EventArgs e)
        {
            UCPatients ucp = new UCPatients();
            this.Hide();
            this.Parent.Controls.Add(ucp);
        }

        private void btnEmp_Click(object sender, EventArgs e)
        {
            UCEmployees uce = new UCEmployees();
            this.Hide();
            this.Parent.Controls.Add(uce);

        }
    }
}
