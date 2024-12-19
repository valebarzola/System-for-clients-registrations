using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormAppFinal.models;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace FormAppFinal.dao
{
    internal class ClientDao
    {
        //database conexion
        public MySqlConnection Conectar()
        {
            string servidor = "localhost";
            string usuario = "root";
            string password = "";
            string baseDeDatos = "clientesform";

            string cadenaDeConexion = "Database=" + baseDeDatos + ";Data Source=" + servidor + 
                "; User Id=" + usuario + "; Password=" + password + "";
            MySqlConnection conexionDb = new MySqlConnection(cadenaDeConexion);
            conexionDb.Open();
            return conexionDb;
           
        }

        public List<Cliente> ObtenerlistadoDeClientes()
        {
            List<Cliente> lista = new List<Cliente>();
            string consulta = "SELECT * FROM `clientes`";
            MySqlCommand comando = new MySqlCommand(consulta);
            comando.Connection = Conectar();
            MySqlDataReader lectura = comando.ExecuteReader();
            
            while (lectura.Read())
            {   
                Cliente cliente = new Cliente();
                cliente.Id = lectura.GetInt32("id").ToString(); // ToString() and GetInt32 is being used because of datatypes. Oldest version dont need it.  
                cliente.Nombre = lectura.GetString("nombre");
                cliente.Apellido = lectura.GetString("apellido");
                cliente.Telefono = lectura.GetString("telefono");
                cliente.TarjetaDeCredito = lectura.GetString("tarjeta_de_credito");
                lista.Add(cliente);
               
            }
            comando.Connection.Close();
            return lista;
        }

        public void Eliminar(Cliente? cliente)
        {
            string consulta = "DELETE FROM clientes WHERE `clientes`.`id` = "+cliente.Id+"";
            MySqlCommand comando = new MySqlCommand(consulta);
            comando.Connection = Conectar();
            comando.ExecuteNonQuery();
            comando.Connection.Close();
        }

        public void Guardar(Cliente cliente)
        {
            if (cliente.Id == null)
            {
                insert(cliente);
            }
            else
            {
                update(cliente);
            }
       
        }
        private void insert(Cliente cliente)
        {

            string consulta = "INSERT INTO `clientes` (`id`, `nombre`, `apellido`, `telefono`, `tarjeta_de_credito`) " +
                "VALUES (NULL, '" + cliente.Nombre + "', '" + cliente.Apellido + "', '" + cliente.Telefono + "', '" + cliente.TarjetaDeCredito + "');";
            MySqlCommand comando = new MySqlCommand(consulta);
            comando.Connection = Conectar();
            comando.ExecuteNonQuery();
            comando.Connection.Close();
        }
         private void update(Cliente cliente)
        {

            string consulta = "UPDATE `clientes` SET `nombre` = '" + cliente.Nombre + "', `apellido` = '" + cliente.Apellido + "', `telefono` = '" + cliente.Telefono + "', `tarjeta_de_credito` = '" + cliente.TarjetaDeCredito + "' WHERE `clientes`.`id` = " + cliente.Id + ";";
            MySqlCommand comando = new MySqlCommand(consulta);
            comando.Connection = Conectar();
            comando.ExecuteNonQuery();
            comando.Connection.Close();
        }
    }
}
