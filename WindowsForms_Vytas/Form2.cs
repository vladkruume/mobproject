using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace WindowsForms_Vytas
{
    public partial class Form2 : Form
    {
        Label lbl;
        Button btn,btnlr;
        Panel panel;
        TreeView treeView;
        TreeNode treeNode;
        CheckBox checkBox1, checkBox2, checkBox3;
        RadioButton rb1,rb2,rb3,rb1f,rb2f,rb3f,rb1ff, rb2ff, rb3ff;
        PictureBox pbox1,pbox2;
        ListBox lbox;
        RichTextBox rtbox;

        public int m = 10;
        

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public Form2()
        {


            //InitializeComponent();
            this.Text = "Форма с разными элементами управления";
            this.Size = new Size { Height = 800, Width = 800 };

            treeView = new TreeView();
            treeView.BackColor = Color.Chocolate;
            treeView.Dock = DockStyle.Left;
            treeView.Width = 150;

            treeNode = new TreeNode("Элемент управления");
            treeNode.Expand();
            treeNode.Nodes.Add(new TreeNode("Label Надпись"));
            treeNode.Nodes.Add(new TreeNode("Button Кнопка"));
            treeNode.Nodes.Add(new TreeNode("CheckBox Флажок"));
            treeNode.Nodes.Add(new TreeNode("Radio Переключатель"));
            treeNode.Nodes.Add(new TreeNode("TabControl Вкладки"));
            treeNode.Nodes.Add(new TreeNode("ListBox-список"));
            treeNode.Nodes.Add(new TreeNode("RichTextBox-текст"));
            treeNode.Nodes.Add(new TreeNode("Clear Очистить"));
            treeView.Nodes.Add(treeNode);
            treeView.AfterSelect += TreeView_AfterSelect;
            Controls.Add(treeView);

            panel = new Panel();
            panel.Dock = DockStyle.Right;
            panel.BorderStyle = BorderStyle.Fixed3D;
            panel.Width = this.Width - treeView.Width;
            panel.Height = this.Height;
            panel.BackColor = Color.BurlyWood;
            Controls.Add(panel);

            lbl = new Label
            {
                Text = "Это метка.\nВторая строка метки",
                ForeColor = Color.Black,
            };



            btn = new Button
            {
                Text = "Жмякай",
                ForeColor = Color.Black,
                BackColor = Color.Chocolate,
                FlatStyle = FlatStyle.Flat,
                Width = 100
            };

            btn.FlatAppearance.BorderColor = Color.Red;
            btn.FlatAppearance.BorderSize = 1;
            btn.Click += (sender, e) =>
            {
                Application.Exit();
            };




            checkBox1 = new CheckBox
            {
                Text = "Синий",
            };
            checkBox1.Click += Cveta;
            checkBox2 = new CheckBox
            {
                Text = "Красный",
            };
            checkBox2.Click += Cveta;
            checkBox3 = new CheckBox
            {
                Text = "Желтый",
                Height = 100,
                Image = global::WindowsForms_Vytas.Properties.Resources.check
            };
            checkBox3.Click += Cveta;

        }

        private void Cveta(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                panel.BackColor = Color.Blue;
            }
            else if (checkBox2.Checked)
            {
                panel.BackColor = Color.Red;
            }
            else if (checkBox3.Checked)
            {
                panel.BackColor = Color.Yellow;
            }

            else if (checkBox1.Checked && checkBox2.Checked)
            {
                panel.BackColor = Color.Purple;
            }
            else if (checkBox1.Checked && checkBox3.Checked)
            {
                panel.BackColor = Color.Green;
            }
            else if (checkBox2.Checked && checkBox3.Checked)
            {
                panel.BackColor = Color.Orange;
            }
        }

        private void TreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text == "Label Надпись")
            {
                lbl.Width = lbl.Text.Length * 10;
                lbl.Height = 20 * 5;
                lbl.Font = new Font("Arial", 20);

                lbl.Location = new Point(panel.Width / 2 - lbl.Text.Length * 5, m);
                panel.Controls.Add(lbl);
            }
            else if (e.Node.Text == "Button Кнопка")
            {
                btn.Location = new Point(15, lbl.Height + 3 + m);
                panel.Controls.Add(btn);
            }
            else if (e.Node.Text == "CheckBox Флажок")
            {

                checkBox1.Location = new Point(15, lbl.Height + 27 + m);
                checkBox2.Location = new Point(15, lbl.Height + 47 + m);
                checkBox3.Location = new Point(15, lbl.Height + 67 + m);

                panel.Controls.Add(checkBox1);
                panel.Controls.Add(checkBox2);
                panel.Controls.Add(checkBox3);


            }
            else if (e.Node.Text == "TabControl Вкладки")
            {
                //создание вкладок
                TabControl tc = new TabControl(); //создание
                tc.Size = new Size(500, 400); //размер окна вкладок
                tc.Location = new Point(20, 330); //местоположение
                //создание страниц
                TabPage tp1 = new TabPage("Собака");//создание страницы 
                TabPage tp2 = new TabPage("Будка");//создание страницы 

                pbox1 = new PictureBox();//создание окна для картинок
                pbox1.Image = new Bitmap("..//..//images//937782.jpg"); //добавление изображения
                pbox1.Size = new Size(400, 300);//размер
                pbox1.SizeMode = PictureBoxSizeMode.StretchImage;//выравнивание фоток

                pbox2 = new PictureBox();//создание окна для картинок
                pbox2.Image = new Bitmap("..//..//images//1.jpg");//добавление изображения
                pbox2.Size = new Size(400, 300);//размер
                pbox2.SizeMode = PictureBoxSizeMode.StretchImage;//выравнивание фоток

                rb1f = new RadioButton();
                rb1f.Text = "Первая собака";
                rb1f.Location = new Point(400, 20);
                rb1f.Click += Rb1f_Click;
                rb2f = new RadioButton();
                rb2f.Text = "Вторая собака";
                rb2f.Location = new Point(400, 40);
                rb2f.Click += Rb2f_Click;

                rb3f = new RadioButton();
                rb3f.Text = "Третья собака";
                rb3f.Location = new Point(400, 60);
                rb3f.Click += Rb3f_Click;

                rb1ff = new RadioButton();
                rb1ff.Text = "Первая будка";
                rb1ff.Location = new Point(400, 20);
                rb1ff.Click += Rb1ff_Click;

                rb2ff = new RadioButton();
                rb2ff.Text = "Вторая будка";
                rb2ff.Location = new Point(400, 40);
                rb2ff.Click += Rb2ff_Click;

                rb3ff = new RadioButton();
                rb3ff.Text = "Третья будка";
                rb3ff.Location = new Point(400, 60);
                rb3ff.Click += Rb3ff_Click;

                //добавление елементов на страницы
                tp1.Controls.Add(pbox1);
                tp1.Controls.Add(rb1f);
                tp1.Controls.Add(rb2f);
                tp1.Controls.Add(rb3f);

                tp2.Controls.Add(pbox2);
                tp2.Controls.Add(rb1ff);
                tp2.Controls.Add(rb2ff);
                tp2.Controls.Add(rb3ff);

                //добавление страниц в вкладки
                tc.TabPages.Add(tp1);
                tc.TabPages.Add(tp2);
                //добавление вкладок на панель
                panel.Controls.Add(tc);
            }
            else if (e.Node.Text == "Radio Переключатель")
            {
                rb1 = new RadioButton();
                rb1.Text = "Красный";
                rb1.Location = new Point(20, m * 2 + 223);


                rb2 = new RadioButton();
                rb2.Text = "Зеленый";
                rb2.Location = new Point(20, m * 2 + 243);

                rb3 = new RadioButton();
                rb3.Text = "Синий";
                rb3.Location = new Point(20, m * 2 + 263);

                panel.Controls.Add(rb1);
                panel.Controls.Add(rb2);
                panel.Controls.Add(rb3);
                rb1.Click += Rb1_Click;
                rb2.Click += Rb2_Click;
                rb3.Click += Rb3_Click;
            }
            else if (e.Node.Text == "ListBox-список")
            {
                lbox = new ListBox();

                lbox.Items.Add("Красный");
                lbox.Items.Add("Зеленый");
                lbox.Items.Add("Синий");
                lbox.Items.Add("Желтый");
                lbox.Items.Add("Фиолетовый");
                lbox.Location = new Point(200, 200);
                lbox.Height = 75;
                panel.Controls.Add(lbox);
                lbox.SelectedIndexChanged += new EventHandler(Lbox_SelectedIndexChanged);
            }
            else if (e.Node.Text == "RichTextBox-текст")
            {
                rtbox = new RichTextBox();
                btnlr = new Button();
                btnlr.Click += Btnlr_Click;
                rtbox.LoadFile("TextFile1.txt",RichTextBoxStreamType.PlainText);
                rtbox.WordWrap = true;
                rtbox.BorderStyle = BorderStyle.Fixed3D;
                rtbox.BackColor = Color.WhiteSmoke;
                rtbox.Size = new Size(100,100);
                rtbox.Location= new Point(200, 300);
                rtbox.DoubleClick += Rtbox_DoubleClick;
                panel.Controls.Add(rtbox);
                panel.Controls.Add(btnlr);
            }
            else
            {
                panel.Controls.Clear();
            }
        }

        private void Rtbox_DoubleClick(object sender, EventArgs e)
        {
            File.WriteAllText(@"TextFile1.txt",rtbox.Text,Encoding.UTF8);
        }

        private void Btnlr_Click(object sender, EventArgs e)
        {
            rtbox.Clear();
            for (int i = 0; i < lbox.Items.Count; i++)
            {
                rtbox.Text = rtbox.Text + " " + lbox.Items[i];
            }
        }

        private void Lbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (lbox.SelectedIndex)
            {
                case (0): treeView.BackColor = Color.Red; break;
                case (1): treeView.BackColor = Color.Green; break;
                case (2): treeView.BackColor = Color.Blue; break;
                case (3): treeView.BackColor = Color.Yellow; break;
                case (4): treeView.BackColor = Color.Purple; break;
            }
        }

        

        private void Rb3ff_Click(object sender, EventArgs e)
        {
            pbox2.Image = new Bitmap("..//..//images//1.jpg");
        }

        private void Rb2ff_Click(object sender, EventArgs e)
        {
            pbox2.Image = new Bitmap("..//..//images//budka2.jpg");
        }

        private void Rb1ff_Click(object sender, EventArgs e)
        {
            pbox2.Image = new Bitmap("..//..//images//budka3.jpg");
        }

        private void Rb3f_Click(object sender, EventArgs e)
        {
            pbox1.Image = new Bitmap("..//..//images//937782.jpg");
        }

        private void Rb2f_Click(object sender, EventArgs e)
        {
            pbox1.Image = new Bitmap("..//..//images//sobaka2.jpg");
        }

        private void Rb1f_Click(object sender, EventArgs e)
        {
            pbox1.Image = new Bitmap("..//..//images//sobaka3.jpg");
        }

        private void Rb3_Click(object sender, EventArgs e)
        {
            panel.BackColor = Color.Blue;
        }

        private void Rb2_Click(object sender, EventArgs e)
        {
            panel.BackColor = Color.Green;
        }

        private void Rb1_Click(object sender, EventArgs e)
        {
            panel.BackColor = Color.Red;
        }

    }
}
