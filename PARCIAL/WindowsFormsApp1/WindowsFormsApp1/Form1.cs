using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(rbMunicipio.Checked) 
            {

                lstMunicipios.Items.Add(txtNombre.Text);

            }
            else 
            {

                lstDepartamentos.Items.Add(txtNombre.Text);

            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            

            if (rbMunicipio.Checked)
            {

                lstMunicipios.Items.Remove(txtNombre.Text);

            }
            else
            {

                lstDepartamentos.Items.Remove(txtNombre.Text);

            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lstDepartamentos.Items.Clear();
            lstMunicipios.Items.Clear();
        }

        private void btnDerecho_Click(object sender, EventArgs e)
        {
            // Itera a través de los elementos seleccionados en lstMunicipios
            foreach (var item in lstMunicipios.SelectedItems)
            {
                // Agrega el elemento seleccionado a lstDepartamentos
                lstDepartamentos.Items.Add(item);
            }

            // Elimina los elementos seleccionados de lstMunicipios
            while (lstMunicipios.SelectedItems.Count > 0)
            {
                lstMunicipios.Items.Remove(lstMunicipios.SelectedItems[0]);
            }
        }

        private void btnIzquierdo_Click(object sender, EventArgs e)
        {
            // Itera a través de los elementos seleccionados en lstMunicipios
            foreach (var item in lstDepartamentos.SelectedItems)
            {
                // Agrega el elemento seleccionado a lstDepartamentos
                lstMunicipios.Items.Add(item);
            }

            //


            // Elimina los elementos seleccionados de lstMunicipios
            while (lstDepartamentos.SelectedItems.Count > 0)
            {
                lstDepartamentos.Items.Remove(lstDepartamentos.SelectedItems[0]);
            }
        }
    }
}
