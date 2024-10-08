using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_7_02._01
{
    public partial class Form_Vhod : Form
    {
        public Form_Vhod()
        {
            InitializeComponent();
        }

               private void button_vhod_Click(object sender, EventArgs e)
        {
            string login = tb_login.Text;
            string password = tb_parol.Text;

            // Подключение к базе данных
            string connectionString = "Data Source=LAPTOP-K6O5APB7;Initial Catalog=Fluere;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT rol FROM [Sotrudniki] WHERE login = @Login AND parol = @Parol";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Login", login);
                command.Parameters.AddWithValue("@Parol", password);

                string role = (string)command.ExecuteScalar();

                if (role == "Администратор")
                {
                    Form_Sotrudniki adminForm = new Form_Sotrudniki();
                    adminForm.Show();
                }
                else if (role == "Сотрудник")
                {
                    Form_Dogovori userForm = new Form_Dogovori();
                    userForm.Show();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль");
                }
            }
        }

        private void Form_Vhod_Load(object sender, EventArgs e)
        {

        }
    }
}

