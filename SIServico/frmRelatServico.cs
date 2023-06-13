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
    public partial class frmRelatServico : Form
    {
        public frmRelatServico()
        {
            InitializeComponent();
        }

        private void frmRelatServico_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
