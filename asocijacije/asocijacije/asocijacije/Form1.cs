using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace asocijacije
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.Text = "razredni staresina";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = "opravdani";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "razredna";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = "srpski";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Marina")
            {
                MessageBox.Show("Tacno uneta kolona A!");
                button1.Text = "razredna";
                button2.Text = "srpski";
                button3.Text = "brizna";
                button4.Text = "korektna";
            }
            else
            {
                MessageBox.Show("Netacan unos!");
                textBox1.Clear();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = "neopravdani";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = "regulisani";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text = "neregulisani";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "izostanci")
            {
                MessageBox.Show("Tacno uneta kolona B!");
                button5.Text = "opravdani";
                button6.Text = "neopravdani";
                button7.Text = "regulisani";
                button8.Text = "neregulisani";
            }
            else
            {
                MessageBox.Show("Netacan odgovor!");
                textBox2.Clear();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.Text = "ucenici";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.Text = "predsednik";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Text = "delegat";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "odeljenje")
            {
                MessageBox.Show("Tacno uneta kolona C!");
                button9.Text = "delegat";
                button10.Text = "predsednik";
                button11.Text = "ucenici";
                button12.Text = "razredni staresina";
            }
            else
            {
                MessageBox.Show("Netacan odgovor!");
                textBox3.Clear();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button16.Text = "Martinovic Ivan";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button15.Text = "Milankovic Nikola";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button14.Text = "Popovic Dusan";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button13.Text = "Duska Cicic";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "djaci")
            {
                MessageBox.Show("Tacno uneta kolona D!");
                button13.Text = "Duska Cicic";
                button14.Text = "Popovic Dusan";
                button15.Text = "Milankovic Nikola";
                button16.Text = "Martinovic Ivan";
            }
            else
            {
                MessageBox.Show("Netacan odgovor!");
                textBox4.Clear();
        }
    }

        private void button21_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "IV4")
            {
                MessageBox.Show("Bravo, resili ste asocijaciju!");
                button1.Text = "razredna";
                button2.Text = "srpski";
                button3.Text = "brizna";
                button4.Text = "korektna";
                button5.Text = "opravdani";
                button6.Text = "neopravdani";
                button7.Text = "regulisani";
                button8.Text = "neregulisani";
                button9.Text = "delegat";
                button10.Text = "predsednik";
                button11.Text = "ucenici";
                button12.Text = "razredni staresina";
                button13.Text = "Duska Cicic";
                button14.Text = "Popovic Dusan";
                button15.Text = "Milankovic Nikola";
                button16.Text = "Martinovic Ivan";
                textBox1.Text = "Marina";
                textBox2.Text = "izostanci";
                textBox3.Text = "odeljenje";
                textBox4.Text = "djaci";
            }
            else {
                MessageBox.Show("Pogresan unos,pokusaj ponovo!");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = "brizna";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = "korektna";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}