using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {


        }


        private void Btncadastrar_Click(object sender, EventArgs e)
        {
           
            Cadastro pokecadastro = new Cadastro();
            
            pokecadastro.pokenome = txtNome.Text;
            pokecadastro.pokebola = cbpokebola.Text;
            pokecadastro.hp = Convert.ToInt32(txthp.Text);
            pokecadastro.atk = Convert.ToInt32(txtatck.Text);
            pokecadastro.data = Convert.ToDateTime(dtpcap.Text);

            if(pokecadastro.cadastrar() == true)
            {
                MessageBox.Show("Pokemon codastrado na Pokedex");
                dataGridView3.Rows.Add(txtNome.Text, txthp.Text, txtatck.Text, dtpcap.Text, cbpokebola.Text);
            }
            else
            {
                MessageBox.Show("Erro no cadastro");
            }
            
        }

        private void DataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = new DataGridView();
        }
    }
}
