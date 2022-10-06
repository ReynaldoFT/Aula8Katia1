using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula8Katia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            List<int> lista = new List<int>() { 10, -2 }; // Vai adicionando conforme vai usando
            string texto = null;                          // e vai inserindo as informações no final

            lista.Add(202); // Adiciona o elemento na lista
            lista.Add(301);

            lista.Insert(2, 54); // O elemento vai ser inserido na posição 2

            //lista.Sort();        // Mostra os elementos em ordem CRESCENTE
            //lista.Reverse();     // Mestra os elementos em ordem DECRESCRENTE

            for(int i = 0; i  < lista.Count; i++) // Compara o valor de "i" com a quantidade de elementos da lista
            {
                texto += lista[i].ToString() + "\n";
            }
            MessageBox.Show(texto);

            lista.Remove(202); // Remove o elemento
            lista.RemoveAt(2); // Remove o elemento na posição "0"

            texto = null;

            for (int i = 0; i < lista.Count; i++) // Compara o valor de "i" com a quantidade de elementos da lista
            {
                texto += lista[i].ToString() + "\n";
            }
            MessageBox.Show(texto);
            


        }
        List<Pet> listpet = new List<Pet>();
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Pet animal = new Pet();
            animal.Animal = txtPet.Text;
            animal.Idade = Convert.ToInt32(txtIdade.Text);
            animal.Especie = cbxEspecie.Text;
            animal.Dono = txtDono.Text;
            listpet.Add(animal);
            limpar();
        }
        private void limpar()
        {
            txtPet.Text = null;
            txtDono.Text = null;
            txtIdade.Text = null;
            cbxEspecie.SelectedIndex = -1;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            int op = 0;
            for(int i = 0; i < listpet.Count; i++)                 // Percorre a lista
            {
                if (txtPet.Text.Equals(listpet[i].Animal))         // Compara Os itens do "Animal"
                {
                    txtDono.Text = listpet[i].Dono;
                    txtIdade.Text = listpet[i].Idade.ToString();
                    cbxEspecie.Text = listpet[i].Especie;
                    op = 1;
                    break;
                }
            }
            if(op == 0)
            {
                MessageBox.Show("Pet não encontrado!");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listpet.Count; i++)                 // Percorre a lista
            {
                if (txtPet.Text.Equals(listpet[i].Animal))         // Compara Os itens do "Animal"
                {
                    listpet.RemoveAt(i);
                }
            }
            limpar();
        }
    }
}
