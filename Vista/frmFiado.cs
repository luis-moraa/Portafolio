﻿using Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmFiado : Form
    {
        int _numeroBoleta = 0;
        public frmFiado()
        {
            InitializeComponent();
            CargarGrillaVentasFiadas();
            CargarComboboxCliente();
            CargarGrillaAbono();
        }
        private void CargarGrillaVentasFiadas()
        {
            Boleta boleta = new Boleta();
            grdVentaFiadas.DataSource = boleta.ListarPorMedioPago(4);
        }
        private void CargarGrillaAbono()
        {
            Abono abono = new Abono();
            grdAbono.DataSource = abono.Listar();
        }
        private void CargarComboboxCliente()
        {
            Controlador.Cliente cliente = new Controlador.Cliente();
            cmbCliente.DisplayMember = "Nombre";
            cmbCliente.ValueMember = "Run";
            cmbCliente.DataSource = cliente.ListarCombobox();
        }

        private void cmbCliente_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedValue != null)
            {
                Boleta boleta = new Boleta();
                grdVentaFiadas.DataSource = boleta.ListarPorClienteFiados((int)cmbCliente.SelectedValue);
            }
        }

        private void grdVentaFiadas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            _numeroBoleta = int.Parse(grdVentaFiadas.Rows[rowIndex].Cells[0].Value.ToString());
            MostrarDeuda(_numeroBoleta);
        }

        public bool MostrarDeuda(int numeroBoleta)
        {
            Boleta boleta = new Boleta();
            boleta = boleta.ObtenerBoleta(numeroBoleta);
            if (boleta != null)
            {
                txtRunCliente.Text = boleta.Cliente.Run.ToString();
                txtDeuda.Text = boleta.Valor.ToString();
                return true;
            }
            else
            {
                return false;
            }
        }

        private void rdbDeudaTotal_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDeudaTotal.Checked)
            {
                txtMontoAbono.Enabled = false;
                txtMontoAbono.Text = txtDeuda.Text;
            }
        }

        private void rdbDeudaParcial_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDeudaParcial.Checked)
            {
                txtMontoAbono.Enabled = true;
            }
        }

        public void AgregarAbono()
        {
            if (int.Parse(txtMontoAbono.Text) > 0)
            {
                DateTime fechaAbono = DateTime.Now.Date;
                int montoAbono = int.Parse(txtMontoAbono.Text);

                Abono abono = new Abono(fechaAbono, montoAbono);
                if (abono.AgregarAbono())
                {
                    int idAbono = abono.ObtenerIdMaximoAbono();

                    Boleta boleta = new Boleta();
                    boleta = boleta.ObtenerBoleta(_numeroBoleta);
                    DateTime fechaDetalleAbono = DateTime.Now.Date;
                    DateTime fechaLimite = boleta.FechaCreacion.AddMonths(1);
                    DetalleAbono detalleAbono = new DetalleAbono(boleta, abono, fechaDetalleAbono, abono.ValorAbono, fechaLimite);
                    if (detalleAbono != null)
                    {
                        MessageBox.Show("Abono N°" + idAbono + " agregado.");
                    }
                }
            }
            _numeroBoleta = 0;
        }

        private void btnAgregarAbono_Click(object sender, EventArgs e)
        {
            AgregarAbono();
            CargarGrillaVentasFiadas();
            txtMontoAbono.Clear();
        }
    }
}
