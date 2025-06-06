﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool gracz1 = true;
        int ruch = 0;

        private void btnRestartuj_Click(object sender, EventArgs e)
        {
            Restartuj();
            WynikO.Text = "0";
            WynikX.Text = "0";
            lblKto.Text = "O";
            gracz1 = true;
        }

        private void Restartuj()
        {
            ruch = 0;
            Button[] all = new Button[9];
            all[0] = btn1;
            all[1] = btn2;
            all[2] = btn3;
            all[3] = btn4;
            all[4] = btn5;
            all[5] = btn6;
            all[6] = btn7;
            all[7] = btn8;
            all[8] = btn9;
            foreach (Button b in all)
            {
                b.Text = "";
                b.Enabled = true;
            }
        }
        private void Sprawdz()
        {
            if (btn1.Text != "" && btn1.Text == btn2.Text && btn2.Text == btn3.Text)
            {
                wygrana();
            }
            else if (btn4.Text != "" && btn4.Text == btn5.Text && btn5.Text == btn6.Text)
            {
                wygrana();
            }
            else if (btn7.Text != "" && btn7.Text == btn8.Text && btn8.Text == btn9.Text)
            {
                wygrana();
            }
            else if (btn1.Text != "" && btn1.Text == btn4.Text && btn4.Text == btn7.Text)
            {
                wygrana();
            }
            else if (btn2.Text != "" && btn2.Text == btn5.Text && btn5.Text == btn8.Text)
            {
                wygrana();
            }
            else if (btn3.Text != "" && btn3.Text == btn6.Text && btn6.Text == btn9.Text)
            {
                wygrana();
            }
            else if (btn1.Text != "" && btn1.Text == btn5.Text && btn5.Text == btn9.Text)
            {
                wygrana();
            }
            else if (btn3.Text != "" && btn3.Text == btn5.Text && btn5.Text == btn7.Text)
            {
                wygrana();
            }
            else if(ruch ==9)
            {
                MessageBox.Show("Remis", "koniec gry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Restartuj();
            }
        }

        private void wygrana()
        {
            MessageBox.Show("Wygrywa gracz:" + (gracz1 ? "O" : "X"), "koniec gry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (gracz1)
                WynikO.Text = (int.Parse(WynikO.Text) + 1).ToString();
            else
                WynikX.Text = (int.Parse(WynikX.Text) + 1).ToString();
            Restartuj();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if(ruch>=5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            lblKto.Text = gracz1 ? "O" : "X";
        }


        private void btn2_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            lblKto.Text = gracz1 ? "O" : "X";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            lblKto.Text = gracz1 ? "O" : "X";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            lblKto.Text = gracz1 ? "O" : "X";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            lblKto.Text = gracz1 ? "O" : "X";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            lblKto.Text = gracz1 ? "O" : "X";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            lblKto.Text = gracz1 ? "O" : "X";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            lblKto.Text = gracz1 ? "O" : "X";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            lblKto.Text = gracz1 ? "O" : "X";
        }
    }
}
