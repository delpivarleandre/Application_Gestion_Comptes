using System;
using System.Windows.Forms;

namespace Application_avec_base_de_donnée
{
    public partial class Code : Form
    {
      

        public Code()
        {
           

            InitializeComponent();
        }
        


        private void buttonVal_Click(object sender, EventArgs e)
        {
            
            
            
            int CodeReponse = Convert.ToInt32(TextBoxReponseCode.Text);
            if (CodeReponse == Connexion.login.GetCode())
            {
                Connexion.stockage.SetCode(1);
                Close();
                
            }
        }
    }
}
