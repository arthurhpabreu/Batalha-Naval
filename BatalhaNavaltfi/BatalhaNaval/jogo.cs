using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatalhaNaval
{
    public partial class jogo : Form
    {
        int conttotaloceano = 8;
        int cont1oceano = 1;
        int cont2oceano = 2;
        int cont3oceano = 3;
        int cont4oceano = 2;

        bool confirmar = true, Portaavioes = false, tanque = false, torpedeiro = false, submarino = false;

        private int dimensao;
        public int[,] mapa;
        public int[,] mapa2;
        Jogador pessoa1 = new Jogador();
        Jogador pessoa2 = new Jogador();
        private PictureBox[,] oceano, oceano2;
        public bool Vertical, Horizontal;
        public jogo()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            pessoa1.Nome = textBox1.Text;
        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            pessoa2.Nome = textBox2.Text;
        }


        private void jogo_Load(object sender, EventArgs e)
        {
            groupBox1.Hide();
            button4.Hide();
            button3.Hide();
            label4.Hide();
            label5.Hide();
        }

        private void jogo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja fechar o Batalha naval?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            menu menu = new menu();
            menu.Show();
            Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Portaavioes = true;
            tanque = false;
            torpedeiro = false;
            submarino = false;
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void horizontal_Click(object sender, EventArgs e)
        {
            Horizontal = true;
            Vertical = false;
            horizontal.BackColor = Color.Red;
            vertical.BackColor = Color.LightGray;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dimensao; i++)
            {
                for (int j = 0; j < dimensao; j++)
                {
                    oceano[i, j].BackColor = Color.Cyan;
                }
            }
            cont1oceano = 1;
            radioButton1.Enabled = true;
            confirmar = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < dimensao; i++)
            {
                for (int j = 0; j < dimensao; j++)
                {
                    oceano2[i, j].BackColor = Color.Cyan;
                }
            }
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            dimensao = 7;
        }
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            dimensao = 8;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            dimensao = 9;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            dimensao = 10;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            dimensao = 11;
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            dimensao = 12;
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            dimensao = 13;
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            dimensao = 14;
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            dimensao = 15;
        }

        private void maskedTextBox1_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int x;
            int y;
            if (Portaavioes == true)
            {
                if (cont1oceano == 0)
                {
                    radioButton1.Enabled = false;
                }

                else if (Horizontal == true)
                {
                    x = int.Parse(maskedTextBox1.Text);
                    y = int.Parse(maskedTextBox2.Text);
                    if (oceano[x, y].BackColor == Color.Cyan && oceano[(x + 1), y].BackColor == Color.Cyan && oceano[(x + 2), y].BackColor == Color.Cyan && oceano[(x + 3), y].BackColor == Color.Cyan && oceano[(x + 4), y].BackColor == Color.Cyan)
                        try
                        {
                            oceano[x, y].BackColor = Color.Black;
                            oceano[(x + 1), y].BackColor = Color.Black;
                            oceano[(x + 2), y].BackColor = Color.Black;
                            oceano[(x + 3), y].BackColor = Color.Black;
                            oceano[(x + 4), y].BackColor = Color.Black;
                            cont1oceano--;

                        }
                        catch
                        {
                            try
                            {

                                oceano[x, y].BackColor = Color.Cyan;
                                oceano[(x + 1), y].BackColor = Color.Cyan;
                                oceano[(x + 2), y].BackColor = Color.Cyan;
                                oceano[(x + 3), y].BackColor = Color.Cyan;
                                oceano[(x + 4), y].BackColor = Color.Cyan;
                                cont1oceano++;
                            }
                            catch
                            {
                                MessageBox.Show("LUGAR INVALIDO", "ERRO");
                            }
                        }
                }
                else if (Vertical == true)
                {
                    x = int.Parse(maskedTextBox1.Text);
                    y = int.Parse(maskedTextBox2.Text);
                    if (oceano[x, y].BackColor == Color.Cyan && oceano[x, (y + 1)].BackColor == Color.Cyan && oceano[x, (y + 2)].BackColor == Color.Cyan && oceano[x, (y + 3)].BackColor == Color.Cyan && oceano[x, (y + 4)].BackColor == Color.Cyan)
                        try
                        {
                            oceano[x, y].BackColor = Color.Black;
                            oceano[x, (y + 1)].BackColor = Color.Black;
                            oceano[x, (y + 2)].BackColor = Color.Black;
                            oceano[x, (y + 3)].BackColor = Color.Black;
                            oceano[x, (y + 4)].BackColor = Color.Black;
                            cont1oceano--;
                        }
                        catch
                        {
                            try
                            {

                                oceano[x, y].BackColor = Color.Black;
                                oceano[x, (y + 1)].BackColor = Color.Cyan;
                                oceano[x, (y + 2)].BackColor = Color.Cyan;
                                oceano[x, (y + 3)].BackColor = Color.Cyan;
                                oceano[x, (y + 4)].BackColor = Color.Cyan;
                            }
                            catch
                            {
                                MessageBox.Show("LUGAR INVALIDO", "ERRO");
                            }
                        }
                }
            }
            if(tanque == true)
            {
                if (cont2oceano == 0)
                {
                    radioButton1.Enabled = false;
                }
                else if (Horizontal == true)
                {
                    x = int.Parse(maskedTextBox1.Text);
                    y = int.Parse(maskedTextBox2.Text);
                    if (oceano[x, y].BackColor == Color.Cyan && oceano[(x + 1), y].BackColor == Color.Cyan && oceano[(x + 2), y].BackColor == Color.Cyan && oceano[(x + 3), y].BackColor == Color.Cyan)
                        try
                        {
                            oceano[x, y].BackColor = Color.Orange;
                            oceano[(x + 1), y].BackColor = Color.Orange;
                            oceano[(x + 2), y].BackColor = Color.Orange;
                            oceano[(x + 3), y].BackColor = Color.Orange;
                            cont2oceano--;
                        }
                        catch
                        {
                            try
                            {

                                oceano[x, y].BackColor = Color.Cyan;
                                oceano[(x + 1), y].BackColor = Color.Cyan;
                                oceano[(x + 2), y].BackColor = Color.Cyan;
                                oceano[(x + 3), y].BackColor = Color.Cyan;
                                cont2oceano++;
                            }
                            catch
                            {
                                MessageBox.Show("LUGAR INVALIDO", "ERRO");
                            }
                        }
                }
                else if (Vertical == true)
                {
                    x = int.Parse(maskedTextBox1.Text);
                    y = int.Parse(maskedTextBox2.Text);
                    if (oceano[x, y].BackColor == Color.Cyan && oceano[x, (y + 1)].BackColor == Color.Cyan && oceano[x, (y + 2)].BackColor == Color.Cyan && oceano[x, (y + 3)].BackColor == Color.Cyan)
                        try
                        {
                            oceano[x, y].BackColor = Color.Orange;
                            oceano[x, (y + 1)].BackColor = Color.Orange;
                            oceano[x, (y + 2)].BackColor = Color.Orange;
                            oceano[x, (y + 3)].BackColor = Color.Orange;
                            cont2oceano--;
                        }
                        catch
                        {
                            try
                            {

                                oceano[x, y].BackColor = Color.Cyan;
                                oceano[x, (y + 1)].BackColor = Color.Cyan;
                                oceano[x, (y + 2)].BackColor = Color.Cyan;
                                oceano[x, (y + 3)].BackColor = Color.Cyan;
                                cont2oceano++;

                            }
                            catch
                            {
                                MessageBox.Show("LUGAR INVALIDO", "ERRO");
                            }
                        }
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Portaavioes = false;
            tanque = true;
            torpedeiro = false;
            submarino = false;
        }

        private void jogo_MouseClick(object sender, MouseEventArgs e)
        {
        }
        private void vertical_Click(object sender, EventArgs e)
        {
            Vertical = true;
            Horizontal = false;
            vertical.BackColor = Color.Red;
            horizontal.BackColor = Color.LightGray;

        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (!(dimensao == 7 || dimensao == 8 || dimensao == 9 || dimensao == 10 || dimensao == 11 || dimensao == 12 || dimensao == 13 || dimensao == 14 || dimensao == 15 || dimensao == 16 ))
            {
                MessageBox.Show("Valor nao suportado o jogo iniciará com o tamanho padrao de 10x10", "ERRO");
                dimensao = 10;
            }

            if ((textBox1.Text == "" || textBox2.Text == ""))
            {
                MessageBox.Show("COLOQUE OS NOMES!", "ERRO");
            }
            else
            {
                label4.Show();
                label5.Show();
                button3.Show();
                button4.Show();
                groupBox1.Show();
                label4.Text = "JOGADOR 1: "+ pessoa1.Nome;
                label5.Text = "JOGADOR 2: "+ pessoa2.Nome;

                oceano = new PictureBox[dimensao, dimensao];
                oceano2 = new PictureBox[dimensao, dimensao];

                for (int i = 0; i < dimensao; i++)
                {
                    for (int j = 0; j < dimensao; j++)
                    {
                        oceano[i, j] = new PictureBox();
                        oceano[i, j].Size = new Size(31, 31);
                        oceano[i, j].Location = new Point(50 + i * 31, 52 + j * 31);
                        oceano[i, j].BackColor = Color.Cyan;
                        oceano[i, j].BorderStyle = BorderStyle.FixedSingle;
                        oceano[i, j].Name = "oceano_" + i + "_" + j;
                        this.Controls.Add(oceano[i, j]);
                    }
                }
                for (int i = 0; i < dimensao; i++)
                {
                    for (int j = 0; j < dimensao; j++)
                    {
                        oceano2[i, j] = new PictureBox();
                        oceano2[i, j].Size = new Size(31, 31);
                        oceano2[i, j].Location = new Point(700 + i * 31, 52 + j * 31);
                        oceano2[i, j].BackColor = Color.Cyan;
                        oceano2[i, j].BorderStyle = BorderStyle.FixedSingle;
                        this.Controls.Add(oceano2[i, j]);
                    }
                }

                button1.Hide();
               
                label1.Hide();
                label2.Hide();
                textBox1.Hide();
                label3.Hide();
                textBox2.Hide();
                button2.Hide();
                radioButton9.Hide();
                radioButton5.Hide();
                radioButton6.Hide();
                radioButton7.Hide();
                radioButton8.Hide();
                radioButton9.Hide();
                radioButton10.Hide();
                radioButton11.Hide();
                radioButton12.Hide();
                radioButton13.Hide();

                // criar mapa
                mapa = new int[dimensao, dimensao];
                mapa2 = new int[dimensao, dimensao];

                for (int i = 0; i < dimensao; i++)
                {
                    for (int j = 0; j < dimensao; j++)
                    {
                        mapa[i, j] = 0;

                    }
                }
                for (int i = 0; i < dimensao; i++)
                {
                    for (int j = 0; j < dimensao; j++)
                    {
                        mapa2[i, j] = 0;

                    }
                }

                int[,] mapa_auxiliar = new int[dimensao, dimensao];

                for (int i = 0; i < dimensao; i++)
                {
                    for (int j = 0; j < dimensao; j++)
                    {
                        mapa_auxiliar[i, j] = 0;
                    }
                }
            }
        }
    }
}



            