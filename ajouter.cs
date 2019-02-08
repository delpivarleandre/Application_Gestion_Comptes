using System;
using System.Windows.Forms;

namespace Appli
{
    public partial class ajouter : Form
    {
        public ajouter()
        {
            InitializeComponent();
        }

        private void ajouter_Load(object sender, EventArgs e)
        {

        }

        private void validationadd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Maintenance");
            Close();
        }

    }
}  
