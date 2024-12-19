namespace FormAppFinal
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GestionUsuarios ventanaGestionClientes = new GestionUsuarios();
            ventanaGestionClientes.ShowDialog();
        }
    }
}
