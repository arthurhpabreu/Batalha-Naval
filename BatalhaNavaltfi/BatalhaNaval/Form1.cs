using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace BatalhaNaval
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            jogo jogar = new jogo();
            jogar.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lerranking();
        }
        public void lerranking()
        {
            StreamReader arquivo = new StreamReader(@"C:\Users\arthu\OneDrive\Documentos\Visual Studio 2015\Projects\BatalhaNaval\BatalhaNaval\Ranking.txt");
            string texto = "";
            ArrayList vet = new ArrayList();
            String linha = "";
            while (!arquivo.EndOfStream)
            {
                linha = arquivo.ReadLine();
                vet.Add(linha);
            }
            foreach (string element in vet)
            {
                texto = texto + (element + "\n");
            }
            MessageBox.Show(texto, "Ranking");
            arquivo.Close();
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja fechar o Batalha naval?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    }


