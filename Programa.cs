﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaMetroFrameWork
{
    public partial class Programa : MetroFramework.Forms.MetroForm
    {
        public Programa()
        {
            InitializeComponent();
        }

        private void Programa_Load(object sender, EventArgs e)
        {

        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            double pro;
            double cost;
            bool esMedicamento = chkesMedicamento.Checked;
            double res;
            double sub;
            double iva;

            pro = double.Parse(Precio.Text);
            cost = double.Parse(Numero.Text);

            sub = pro * cost;

            if (esMedicamento)
            {
                iva = 0;
                res = sub + iva;
            }
            else
            {
                iva = sub * 0.16;
                res = sub + iva;
            }
            MessageBox.Show("El total de tus productos es: " + res);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}