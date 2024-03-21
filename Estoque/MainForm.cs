using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estoque
{
    public partial class MainForm : Form
    {

        private CadastroRepository _cadastroRepository = new CadastroRepository();
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bsPeople.ApplyChanges();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            bsPeople.DataSource = _cadastroRepository.GetAll();

            bsPeople.SuspendChanges();
        }

        
    }
}
