﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoFinalHerramientasDeProgramacion2
{
    public partial class frm_Principal : Form
    {
        public frm_Principal()
        {
            InitializeComponent();
        }

        private void btn_CerrarSesion_Click(object sender, EventArgs e)
        {
            frm_InicioApp Inicio = new frm_InicioApp();
            Inicio.Show();
            Hide();
        }

        private void btn_Entregas_Click(object sender, EventArgs e)
        {
            frm_Entrega Ent = new frm_Entrega();
            Ent.Show();
            Hide();
        }

        private void btn_Inventario_Click(object sender, EventArgs e)
        {
            frm_Inventario Inv = new frm_Inventario();
            Inv.Show();
            Hide();
        }

        private void btn_ListaUsuarios_Click(object sender, EventArgs e)
        {
            frm_ListaUsuarios LU = new frm_ListaUsuarios();
            LU.Show();
            Hide();
        }
    }
}
