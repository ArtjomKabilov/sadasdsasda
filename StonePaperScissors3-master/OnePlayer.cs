using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StonePaperScissors
{
    public partial class OnePlayer : Form
    {
        //PictureBox pb;
        PictureBox pbt;
        Button bt;
        Button bt2;
        RadioButton rb1;
        RadioButton rb2;
        RadioButton rb3;
        public int numb;
        MainMenu mm;
        Label lb;
        public OnePlayer()
        {
            this.Height = 700;
            this.Width = 1000;
            this.Text = "Kivist paber käärid";
            
            rb1 = new RadioButton();
            rb2 = new RadioButton();
            rb3 = new RadioButton();
            pbt = new PictureBox();
            rb1.Location = new Point(20, 50);
            rb1.Image= Image.FromFile(@"../../images/kamen.png");
            rb1.Size = new Size(200, 200);
            rb2.Location = new Point(20, 250);
            rb2.Image = Image.FromFile(@"../../images/noznitsi.png");
            rb2.Size = new Size(200, 200);
            rb3.Location = new Point(20, 450);
            rb3.Image = Image.FromFile(@"../../images/bumaga.png");
            rb3.Size = new Size(200, 200);
            pbt.Location = new Point(500, 100);
            pbt.ImageLocation = "../../images/Hõiva.png";
            pbt.SizeMode = PictureBoxSizeMode.AutoSize;
            
            this.Controls.Add(rb1);
            this.Controls.Add(rb2);
            this.Controls.Add(rb3);
            this.Controls.Add(pbt);

            bt = new Button();
            bt.Location = new Point(500, 300);
            bt.Size = new Size(100, 50);
            bt.Text = "Alusta";
            this.Controls.Add(bt);
            bt.MouseClick += Bt_MouseClick;

            List<string> list = new List<string>();

            list.Add("kamen.png");
            list.Add("noznitsi.png");
            list.Add("bumaga.png");


            Random rnd = new Random();

            int num = rnd.Next(3);

            bt2 = new Button();
            bt2.Location = new Point(300, 300);
            bt2.Size = new Size(100, 50);
            this.Controls.Add(bt2);
            bt2.MouseClick += Bt2_MouseClick;
            bt2.Text = "Bot liigub";

            mm = new MainMenu();
            MenuItem menuFile = new MenuItem("File");
            menuFile.MenuItems.Add("Exit", new EventHandler(menuFile_Exit_Select));
            menuFile.MenuItems.Add("Back", new EventHandler(menuFile_Back_Select));
            this.Menu = mm;
            mm.MenuItems.Add(menuFile);

            lb = new Label();
            string readText = File.ReadAllText(@"../../name.txt");
            lb.Text = readText;
            lb.Location = new Point(20, 5);
            this.Controls.Add(lb);

        }
        void menuFile_Exit_Select(object sender, System.EventArgs e)
        {

            this.Close();

        }
        void menuFile_Back_Select(object sender, System.EventArgs e)
        {
            Form1 fp = new Form1();
            fp.Show();
            fp.WindowState = FormWindowState.Minimized;
            fp.WindowState = FormWindowState.Normal;
            this.Hide();
        }
    

        public void Bt2_MouseClick(object sender, MouseEventArgs e)
        {
            pbt.SizeMode = PictureBoxSizeMode.AutoSize;
            List<string> lists = new List<string>();

            lists.Add("kamen.png");
            lists.Add("noznitsi.png");
            lists.Add("bumaga.png");
            



            Random rand = new Random();

            numb = rand.Next(3);
            pbt.ImageLocation = ($"../../images/{lists[numb]}");
            bt2.Hide();
            if (rb1.Checked)
            {
                rb2.Hide();
                rb3.Hide();
            }
            else if (rb2.Checked)
            {
                rb1.Hide();
                rb3.Hide();
            }
            else if (rb3.Checked)
            {
                rb2.Hide();
                rb1.Hide();
            }

        }

        public void Bt_MouseClick(object sender, MouseEventArgs e)
        {


            if (rb1.Checked == true && numb == 1  || rb2.Checked == true && numb == 2 || rb3.Checked == true && numb == 0)
            {

                var answer = MessageBox.Show(
                "Ты победил",
                "Сообщение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
                if(answer == DialogResult.Yes)
                {
                    OnePlayer op = new OnePlayer();
                    op.Show();
                    op.WindowState = FormWindowState.Minimized;
                    op.WindowState = FormWindowState.Normal;
                    this.Hide();
                   
                }
                else
                {
                    Form1 fp = new Form1();
                    fp.Show();
                    fp.WindowState = FormWindowState.Minimized;
                    fp.WindowState = FormWindowState.Normal;
                    this.Hide();
                    
                }
                

            }
            else if (rb1.Checked == true && numb == 0 || rb2.Checked == true && numb == 1 || rb3.Checked == true && numb == 2)
            {
                var answer = MessageBox.Show(
                "Ничья",
                "Сообщение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
                if (answer == DialogResult.Yes)
                {
                    OnePlayer op = new OnePlayer();
                    op.Show();
                    op.WindowState = FormWindowState.Minimized;
                    op.WindowState = FormWindowState.Normal;
                    this.Hide();

                }
                else
                {
                    Form1 fp = new Form1();
                    fp.Show();
                    fp.WindowState = FormWindowState.Minimized;
                    fp.WindowState = FormWindowState.Normal;
                    this.Hide();

                }

            }
            else
            {
                var answer = MessageBox.Show(
                "Ты проиграл, бот выиграл",
                "Сообщение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
                if (answer == DialogResult.Yes)
                {
                    OnePlayer op = new OnePlayer();
                    op.Show();
                    op.WindowState = FormWindowState.Minimized;
                    op.WindowState = FormWindowState.Normal;
                    this.Hide();

                }
                else
                {
                    Form1 fp = new Form1();
                    fp.Show();
                    fp.WindowState = FormWindowState.Minimized;
                    fp.WindowState = FormWindowState.Normal;
                    this.Hide();

                }
                
            }     
        }

    }
}
