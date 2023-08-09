using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleVendas.Model
{
    public class Metodos
    {
        public void limparCampos(Form Tela)
        {
            foreach (Control ctrMain in Tela.Controls)  //percorrer os controles e limpar 
            {
                foreach (Control ctr1 in ctrMain.Controls)
                {
                    if (ctr1 is TabPage)    // se tiver controles no tabpage e percorra dentro 
                    {
                        foreach (Control ctr2 in ctr1.Controls)
                        {
                            if (ctr2 is TextBox)
                            {
                                (ctr2 as TextBox).Text = string.Empty; //limpar os campos  txt
                            }
                            if (ctr2 is MaskedTextBox)
                            {
                                (ctr2 as MaskedTextBox).Text = string.Empty; //limpar  masked
                            }
                            if (ctr2 is ComboBox)
                            {
                                (ctr2 as ComboBox).Text = string.Empty; //limpar  comboBox
                            }
                        }

                    }
                }
            }
        }
    }
}
