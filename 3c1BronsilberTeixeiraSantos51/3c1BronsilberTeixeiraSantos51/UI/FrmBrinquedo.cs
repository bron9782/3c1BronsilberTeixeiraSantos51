﻿using _3c1BronsilberTeixeiraSantos51.BLL;
using _3c1BronsilberTeixeiraSantos51.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3c1BronsilberTeixeiraSantos51.UI
{
    public partial class FrmBrinquedo : Form
    {
        BrinquedoDLL brinquedoBLL = new BrinquedoDLL();
        BrinquedoDTO brinquedoDTO = new BrinquedoDTO();
        public FrmBrinquedo()
        {
            InitializeComponent();
        }

      

        private void FrmBrinquedo_Load(object sender, EventArgs e)
        {
            dvgBrinquedos.DataSource = brinquedoBLL.Listar();
        }

        private void dvgBrinquedos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dvgBrinquedos.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNome.Text = dvgBrinquedos.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPreco.Text = dvgBrinquedos.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtMarca.Text = dvgBrinquedos.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
    }
}
