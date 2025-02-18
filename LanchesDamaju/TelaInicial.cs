using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanchesDamaju
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void buttonAcesso_Click(object sender, EventArgs e)
        {
            Gerenciamento form = new Gerenciamento();
            form.ShowDialog();
        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {

        }
    }
}
