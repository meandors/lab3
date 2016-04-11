using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        private SortedDictionary<string, string> polski;
        private SortedDictionary<string, string> angielski;
 
        public Form1()
        {
            InitializeComponent();
            polski = new SortedDictionary<string, string>();
            angielski = new SortedDictionary<string, string>();

            angielski.Add("cat", "dog");
            polski.Add("kot", "cat");
            angielski.Add("dog", "pies");
            polski.Add("pies", "dog");
            angielski.Add("wolf", "wilk");
            polski.Add("wilk", "wolf");

            foreach (var item in polski)
            {
                listBox1.Items.Add(item.Key);
            }
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tbToTranslate.Text = listBox1.Text;
            tbWynik.Text = "";
        }

        private void tbWyszukaj_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (rbPolski.Checked)
            {
                foreach (var item in polski)
                {
                    string word = item.Key;
                    if (word.Contains(tbWyszukaj.Text))
                    {
                        listBox1.Items.Add(word);
                    }
                }
            }
            else
            {
                foreach (var item in angielski)
                {
                    string word = item.Key;
                    if (word.Contains(tbWyszukaj.Text))
                    {
                        listBox1.Items.Add(word);
                    }
                }
            }
        }

        private void rbAngielski_CheckedChanged(object sender, EventArgs e)
        {
            reFillList();
//            listBox1.Items.Clear();
//            tbToTranslate.Text = "";
//            tbWynik.Text = "";
//            tbWyszukaj.Text = "";
//            if (rbPolski.Checked)
//            {
//                foreach (var item in polski)
//                {
//                    listBox1.Items.Add(item.Key);
//                }
//            }
//            else
//            {
//                foreach (var item in angielski)
//                {
//                    listBox1.Items.Add(item.Key);
//                }
//            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tbToTranslate.Text != "")
            {
                if (rbPolski.Checked)
                {
                    if (polski.ContainsKey(tbToTranslate.Text))
                    {
                        tbWynik.Text = polski[tbToTranslate.Text];
                    }
                    else
                    {
                        MessageBox.Show("Brak słowa w lowniku!");
                    }
                }
                else
                {
                    if (angielski.ContainsKey(tbToTranslate.Text))
                    {
                        tbWynik.Text = angielski[tbToTranslate.Text];
                    }
                    else
                    {
                        MessageBox.Show("Brak słowa w lowniku!");
                    }
                
                }
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tbToTranslate.Text == "" || tbWynik.Text == "") return;
            if (rbPolski.Checked)
            {
                if (!polski.ContainsKey(tbToTranslate.Text))
                {
                    polski.Add(tbToTranslate.Text, tbWynik.Text);
                    angielski.Add(tbWynik.Text, tbToTranslate.Text);
                }
                else
                {
                    MessageBox.Show("Słowo juz wystepuje w słowniku!");
                }
            }
            else
            {
                if (!angielski.ContainsKey(tbToTranslate.Text))
                {
                    angielski.Add(tbToTranslate.Text, tbWynik.Text);
                    polski.Add(tbWynik.Text, tbToTranslate.Text);
                }
                else
                {
                    MessageBox.Show("Word already exist in dictionary!");
                }
            }
            tbToTranslate.Text = "";
            tbWynik.Text = "";
            reFillList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tbToTranslate.Text == "") return;
            if (rbPolski.Checked)
            {
                if (polski.ContainsKey(tbToTranslate.Text))
                {
                    angielski.Remove(polski[tbToTranslate.Text]);
                    polski.Remove(tbToTranslate.Text);
                }
            }
            else
            {
                if (angielski.ContainsKey(tbToTranslate.Text))
                {
                    polski.Remove(angielski[tbToTranslate.Text]);
                    angielski.Remove(tbToTranslate.Text);
                }
            }
            tbToTranslate.Text = "";
            tbWynik.Text = "";
            reFillList();
        }

        private void reFillList()
        {
            listBox1.Items.Clear();
            tbToTranslate.Text = "";
            tbWynik.Text = "";
            tbWyszukaj.Text = "";
            if (rbPolski.Checked)
            {
                foreach (var item in polski)
                {
                    listBox1.Items.Add(item.Key);
                }
            }
            else
            {
                foreach (var item in angielski)
                {
                    listBox1.Items.Add(item.Key);
                }
            }
        }
    }
}
