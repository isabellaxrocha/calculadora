using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CALCULADORA_1CD_V_0_1
{
    public partial class fm_Ajuda : Form
    {
        public fm_Ajuda()
        {
            InitializeComponent();
        }

        private void bt_fechar_ajuda_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fm_Ajuda_Load(object sender, EventArgs e)
        {
            this.ActiveControl = bt_fechar_ajuda;
        }
    }
}
