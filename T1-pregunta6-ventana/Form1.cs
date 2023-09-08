﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T1_pregunta6_ventana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float monto = float.Parse(txtb1.Text);

            if (monto > 1000)
            {
                float dsct = monto * 0.2f;
                float montot = monto - dsct;
                lbl.Text = montot + " soles";
            }
            else if (monto > 500 && monto <= 1000)
            {
                float dsct = monto * 0.1f;
                float montot = monto - dsct;
                lbl.Text = montot + " soles";
            }
            else
            {
                lbl.Text =  monto + " soles";
            }

        }
    }
}
