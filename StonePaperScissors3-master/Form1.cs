﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StonePaperScissors
{
    public partial class Form1 : Form
    {
        Button bt, bt2;
        MainMenu mm;
        public Form1()
        {
            this.Height = 600;
            this.Width = 400;
            this.Text = "Kivist paber käärid";

            bt = new Button();
            bt.Location = new Point(140, 170);
            bt.Text = "1 mängija";
            bt.Height = 40;
            bt.Width = 100;
            this.Controls.Add(bt);
            bt.MouseClick += Bt_MouseClick;

            bt2 = new Button();
            bt2.Location = new Point(140, 240);
            bt2.Text = "2 mängijat";
            bt2.Height = 40;
            bt2.Width = 100;
            this.Controls.Add(bt2);
            bt2.MouseClick += Bt2_MouseClick;

            mm = new MainMenu();
            MenuItem menuFile = new MenuItem("File");
            menuFile.MenuItems.Add("Exit", new EventHandler(menuFile_Exit_Select));
            menuFile.MenuItems.Add("Back", new EventHandler(menuFile_Back_Select));
            this.Menu = mm;
            mm.MenuItems.Add(menuFile);

            


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
    

        private void Bt2_MouseClick(object sender, MouseEventArgs e)
        {

            this.Hide();
            name2 na = new name2();
            na.Show();
        }

        private void Bt_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            Name n = new Name();
            n.Show();
           
        }
    }
}
