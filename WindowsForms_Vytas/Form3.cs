using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WindowsForms_Vytas
{
    public partial class Form3 : Form
    {
        ListBox lbox1, lbox2;
        Button btn,btnlf,btndel;
        string x;
        int index;
        RichTextBox rtb;
        Label lbl;
        public Form3()
        {
          

            this.Text = "Расписание";
            this.Size = new Size { Height = 800, Width = 800 };
            this.BackColor = Color.FromArgb(227, 176, 75);
            lbox1 = new ListBox();
            lbox1.BackColor = Color.Red;
            lbox1.Items.Add("Понедельник");
            lbox1.Items.Add("Вторник");
            lbox1.Items.Add("Среда");
            lbox1.Items.Add("Четверг");
            lbox1.Items.Add("Пятница");
            lbox1.Items.Add("Суббота");
            lbox1.Items.Add("Воскресение");
            lbox1.Height = 75;
            lbox1.SelectedIndexChanged += new EventHandler(Lbox_SelectedIndexChanged);
            lbl = new Label()
            {
                BackColor = Color.FromArgb(241, 214, 171),
                Width = 500,
                Height = 80,
                Text = "Расписание",
                
            };
            lbox2 = new ListBox();

            lbox2.Height = 75;
            rtb = new RichTextBox();
            btn = new Button();
            btn.Click += Btn_Click;
            btn.Text = "Сохранить";
            btnlf = new Button();
            btnlf.BackColor = Color.Red;
            btnlf.Text = "ad";
            btndel = new Button();
            btndel.Location = new Point(200, 300);
            btndel.BackColor = Color.Red;
            btndel.Text = "delete";
            btndel.Click += Btndel_Click;
            btnlf.Click += Btnlf_Click;
            lbl.Location = new Point(0, 0);
            lbox1.Location = new Point(100, 200);
            lbox2.Location = new Point(400, 200);
            rtb.Location = new Point(100, 20);
            btn.Location = new Point(600, 200);
            btnlf.Location = new Point(100, 300);
            btndel.Location = new Point(200, 300);

            Controls.Add(btn);
            Controls.Add(lbox1);
            Controls.Add(lbox2);
            Controls.Add(rtb);
            Controls.Add(btnlf);
            Controls.Add(btndel);
            Controls.Add(lbl);


        }

        private void Btndel_Click(object sender, EventArgs e)
        {
            var selectedIndices = lbox2.SelectedIndices;
            foreach (int i in selectedIndices)
                lbox2.Items.RemoveAt(i);
        }

        private void Btnlf_Click(object sender, EventArgs e)
        {
                ListBox.SelectedIndexCollection collection = lbox2.SelectedIndices;

                if (collection.Count == 0)
                    index = lbox2.Items.Count;
                else index = collection[0];

                lbox2.Items.Insert(index, rtb.Text);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            if (this.lbox1.SelectedIndex== 0) { 
                StreamWriter vastused1 = new StreamWriter("Esmaspäev.txt");
                foreach (var item in lbox2.Items)
                {
                    vastused1.WriteLine(item.ToString());
                }
                vastused1.Close();
                MessageBox.Show("Programs saved!");
                lbox2.Items.Clear();
            }
            else if (this.lbox1.SelectedIndex == 1)
            {
                StreamWriter vastused2 = new StreamWriter("Teisipäev.txt");
                foreach (var item in lbox2.Items)
                {
                    vastused2.WriteLine(item.ToString());
                }
                vastused2.Close();
                MessageBox.Show("Programs saved!");
                lbox2.Items.Clear();
            }
            else if (this.lbox1.SelectedIndex == 2)
            {
                StreamWriter vastused3 = new StreamWriter("Kolmapäev.txt");
                foreach (var item in lbox2.Items)
                {
                    vastused3.WriteLine(item.ToString());
                }
                vastused3.Close();
                MessageBox.Show("Programs saved!");
                lbox2.Items.Clear();
            }
            else if (this.lbox1.SelectedIndex == 3)
            {
                StreamWriter vastused4 = new StreamWriter("Neljapäev.txt");
                foreach (var item in lbox2.Items)
                {
                    vastused4.WriteLine(item.ToString());
                }
                vastused4.Close();
                MessageBox.Show("Programs saved!");
                lbox2.Items.Clear();
            }
            else if (this.lbox1.SelectedIndex == 4)
            {
                StreamWriter vastused5 = new StreamWriter("Reede.txt");
                foreach (var item in lbox2.Items)
                {
                    vastused5.WriteLine(item.ToString());
                }
                vastused5.Close();
                MessageBox.Show("Programs saved!");
                lbox2.Items.Clear();
            }
            else if (this.lbox1.SelectedIndex == 5)
            {
                StreamWriter vastused6 = new StreamWriter("Laulpäev.txt");
                foreach (var item in lbox2.Items)
                {
                    vastused6.WriteLine(item.ToString());
                }
                vastused6.Close();
                MessageBox.Show("Programs saved!");
                lbox2.Items.Clear();
            }
            else if (this.lbox1.SelectedIndex == 6)
            {
                StreamWriter vastused7 = new StreamWriter("Pühapäev.txt");
                foreach (var item in lbox2.Items)
                {
                    vastused7.WriteLine(item.ToString());
                }
                vastused7.Close();
                MessageBox.Show("Programs saved!");
                lbox2.Items.Clear();
            }
        }

    

        private void Lbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (lbox1.SelectedIndex)
            {
                case (0): lbox2.Items.Clear();esmaspaev();break;
                case (1): lbox2.Items.Clear(); teisipäev();break;
                case (2): lbox2.Items.Clear(); kolmapäev();break;
                case (3): lbox2.Items.Clear(); neljapäev();break;
                case (4): lbox2.Items.Clear(); reede(); break;
                case (5): lbox2.Items.Clear(); laulpäev();break;
                case (6): lbox2.Items.Clear(); pühapäev();break;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private void esmaspaev()
        {
            string pathToFile = "Esmaspäev.txt";
            // Считываем строки в массив
            string[] allLines = File.ReadAllLines(pathToFile, Encoding.GetEncoding(1251));
            // Добавляем каждую строку
            foreach (string line in allLines)
                lbox2.Items.Add(line);
            
        }
        private void teisipäev()
        {
            string pathToFile = "Teisipäev.txt";
            // Считываем строки в массив
            string[] allLines = File.ReadAllLines(pathToFile, Encoding.GetEncoding(1251));
            // Добавляем каждую строку
            foreach (string line in allLines)
                lbox2.Items.Add(line);
        }
        private void kolmapäev()
        {
            string pathToFile = "Kolmapäev.txt";
            // Считываем строки в массив
            string[] allLines = File.ReadAllLines(pathToFile, Encoding.GetEncoding(1251));
            // Добавляем каждую строку
            foreach (string line in allLines)
                lbox2.Items.Add(line);
        }
        private void neljapäev()
        {
            string pathToFile = "Neljapäev.txt";
            // Считываем строки в массив
            string[] allLines = File.ReadAllLines(pathToFile, Encoding.GetEncoding(1251));
            // Добавляем каждую строку
            foreach (string line in allLines)
                lbox2.Items.Add(line);
        }
        private void reede()
        {
            string pathToFile = "Reede.txt";
            // Считываем строки в массив
            string[] allLines = File.ReadAllLines(pathToFile, Encoding.GetEncoding(1251));
            // Добавляем каждую строку
            foreach (string line in allLines)
                lbox2.Items.Add(line);
        }
        private void laulpäev()
        {
            string pathToFile = "Laulpäev.txt";
            // Считываем строки в массив
            string[] allLines = File.ReadAllLines(pathToFile, Encoding.GetEncoding(1251));
            // Добавляем каждую строку
            foreach (string line in allLines)
                lbox2.Items.Add(line);
        }
        private void pühapäev()
        {
            string pathToFile = "Pühapäev.txt";
            // Считываем строки в массив
            string[] allLines = File.ReadAllLines(pathToFile, Encoding.GetEncoding(1251));
            // Добавляем каждую строку
            foreach (string line in allLines)
                lbox2.Items.Add(line);
        }
    }

}
