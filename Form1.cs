using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAtleta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Atleta obj = new Atleta();

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dados obtidos: " + obj.ImprimeDados());
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                obj.Nome = txtnome.Text;
                obj.Idade = int.Parse(txtidade.Text);
                obj.Altura = double.Parse(txtaltura.Text);
                obj.Peso = double.Parse(txtpeso.Text);
                MessageBox.Show("Dados armazenados");
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Erro. \n" + ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
