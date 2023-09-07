using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace McLaughingHospital
{
    class ManageUC
    {
        public void DisplayControl(Control uc, Panel pnl)
        {
            pnl.Controls.Clear();
            uc.BringToFront();
            //uc.Focus();
            pnl.Controls.Add(uc);
        }
    }
}


//08a03mm
