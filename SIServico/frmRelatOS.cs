using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIServico
{
    public partial class frmRelatOS : Form
    {
        public frmRelatOS()
        {
            InitializeComponent();
        }

        private void frmRelatOS_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
