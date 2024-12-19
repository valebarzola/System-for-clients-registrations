using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormAppFinal.dao;
using FormAppFinal.models;
using MySqlX.XDevAPI;

namespace FormAppFinal
{
    public partial class GestionUsuarios : Form
    {
        public GestionUsuarios()
        {
            InitializeComponent();
        }

        private void GestionUsuarios_Load(object sender, EventArgs e)
        {
            refreshlista();
        }

        private void refreshlista()
        {
            ClientDao baseDeDatos = new ClientDao();
            List<Cliente> listaDb = baseDeDatos.ObtenerlistadoDeClientes();
            ListClients.Items.Clear();
            for (int i = 0; i < listaDb.Count; i++)
            {
                Cliente cliente = listaDb[i];
                ListClients.Items.Add(cliente);

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)

        {
            Cliente cliente = new Cliente();
            cliente.Nombre = txtNombre.Text;
            cliente.Apellido = txtApellido.Text;
            cliente.Telefono = txtTelefono.Text;
            cliente.TarjetaDeCredito = txtTarjeta.Text;


            if (lblId.Text != "") //an lblId empty means new client, anything different is for editing  
            {
                cliente.Id = lblId.Text;
            }

            

            ClientDao baseDeDatos = new ClientDao();
            baseDeDatos.Guardar(cliente);
            refreshlista();
            limpiarlistado();


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)ListClients.SelectedItem;

            ClientDao baseDeDatos = new ClientDao();
            baseDeDatos.Eliminar(cliente);
            refreshlista();




        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)ListClients.SelectedItem;
            txtNombre.Text = cliente.Nombre;
            txtApellido.Text = cliente.Apellido;
            txtTelefono.Text = cliente.Telefono;
            txtTarjeta.Text = cliente.TarjetaDeCredito;
            lblId.Text = cliente.Id;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            limpiarlistado();
        }
        private void limpiarlistado()
        {
            lblId.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTelefono.Text = "";
            txtTarjeta.Text = "";
        }
    }
}
