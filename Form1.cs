using System;
using System.Windows.Forms;
using  MySql.Data.MySqlClient;

namespace FormularioComBD
{
    public partial class sla : Form
    {
        public sla()
        {
            InitializeComponent();
        }           

        private void botao_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("Server = 127.0.0.1; Uid = root; Pwd = usbw; Database = projeto");
            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("INSERT INTO formulario(nome, telefone, rua, rua2, cidade, associado, telefone2, estado) VALUES (@nome, @telefone, @rua, @rua2, @cidade, @associado, @telefone2, @estado);");
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@nome", nome.Text);
                cmd.Parameters.AddWithValue("@telefone", telefone.Text);
                cmd.Parameters.AddWithValue("@rua", rua.Text);
                cmd.Parameters.AddWithValue("@rua2", rua2.Text);
                cmd.Parameters.AddWithValue("@cidade", cidade.Text);
                cmd.Parameters.AddWithValue("@associado", associado.Text);
                cmd.Parameters.AddWithValue("@telefone2", telefone2.Text);
                cmd.Parameters.AddWithValue("@estado",estado.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
