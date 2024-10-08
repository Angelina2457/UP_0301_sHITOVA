using PR_7_02._01;
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
    public partial class Form_Novii_sotrudnik : Form
    {
        private SqlConnection connection = null;
        private SqlDataAdapter adapter = null;
        private DataTable table;

        public object dataGridView_sotr { get; private set; }
        public Form_Novii_sotrudnik()
        {
            InitializeComponent();
        }
        public string get_cs()
        {
            return "Data Source=LAPTOK6O5APB7;Initial Catalog=Fluere;Integrated Security=True";
        }
        private void FillDataGridView()
        {
            Form_Sotrudniki form_add_sotr = (Form_Sotrudniki)this.Owner;

            connection = new SqlConnection("Data Source=LAPTOP-K6O5APB7;Initial Catalog=Fluere;Integrated Security=True");
            connection.Open();

            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter = new SqlDataAdapter("(SELECT * FROM Sotrudniki)", connection);
            table = new DataTable();
            adapter.Fill(table);
            form_add_sotr.dataGridView_sotr.DataSource = table;
            this.Close();
        }

        private void button_dobavit_sotrudnika_Click(object sender, EventArgs e)
        {
            Form_Sotrudniki f1 = (Form_Sotrudniki)this.Owner;
            f1.PassID_sotrudnika = tb_id_sotr.Text;
            f1.PassImya = tb_imya.Text;
            f1.PassFamiliya = tb_familiya.Text;
            f1.PassOtchestvo = tb_otch.Text;
            f1.PassNomer_telefona = tb_telefon.Text;
            f1.PassID_dolgnosti = tb_id_dolg.Text;
            f1.PassData_rozhdeniya = tb_data_rozh.Text;
            f1.Show();
            this.Close();

            MessageBox.Show("Вы точно хотите добавить данные в таблицу Сотрудники?", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (!string.IsNullOrEmpty(tb_id_sotr.Text) && !string.IsNullOrWhiteSpace(tb_id_sotr.Text) &&
               !string.IsNullOrEmpty(tb_imya.Text) && !string.IsNullOrWhiteSpace(tb_imya.Text) &&
               !string.IsNullOrEmpty(tb_familiya.Text) && !string.IsNullOrWhiteSpace(tb_familiya.Text) &&
               !string.IsNullOrEmpty(tb_otch.Text) && !string.IsNullOrWhiteSpace(tb_otch.Text) &&
               !string.IsNullOrEmpty(tb_telefon.Text) && !string.IsNullOrWhiteSpace(tb_telefon.Text) &&
               !string.IsNullOrEmpty(tb_id_dolg.Text) && !string.IsNullOrWhiteSpace(tb_id_dolg.Text) &&
               !string.IsNullOrEmpty(tb_data_rozh.Text) && !string.IsNullOrWhiteSpace(tb_data_rozh.Text))              
            {
                using (var connection = new SqlConnection(get_cs()))
                {
                    connection.Open();

                    using (var cmd = new SqlCommand("INSERT INTO [Sotrudniki] (ID_sotrudnika, Imiya, Familiya, Otchestvo, Nomer_telefona, ID_dolgnosti, Data_rozhdeniya) VALUES (@ID_sotrudnika, @Imiya, @Familiya, @Otchestvo, @Nomer_telefona, @ID_dolgnosti, @Data_rozhdeniya)", connection))

                    {
                        cmd.Parameters.AddWithValue("ID_sotrudnika", tb_id_sotr.Text);
                        cmd.Parameters.AddWithValue("Imya", tb_imya.Text);
                        cmd.Parameters.AddWithValue("Familiya", tb_familiya.Text);
                        cmd.Parameters.AddWithValue("Otchestvo", tb_otch.Text);
                        cmd.Parameters.AddWithValue("Nomer_telefona", tb_telefon.Text);
                        cmd.Parameters.AddWithValue("ID_dolgnosti", tb_id_dolg.Text);
                        cmd.Parameters.AddWithValue("Data_rozhdeniya", tb_data_rozh.Text);
                        cmd.ExecuteNonQuery();

                    }
                    connection.Close();
                    tb_id_sotr.Clear();
                    tb_imya.Clear();
                    tb_familiya.Clear();
                    tb_otch.Clear();
                    tb_telefon.Clear();
                    tb_id_dolg.Clear();
                    tb_data_rozh.Clear();
                    FillDataGridView();

                }
            }
            else
            {
                MessageBox.Show("Все поля должны быть заполнены!!!", "Предупреждение");
            }

        }

        private void таблицыToolStripMenuItem_Click(object sender, EventArgs e)
        {
               
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Sotrudniki form1 = new Form_Sotrudniki();
            form1.Show();
            this.Hide();
        }

        private void договорыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Dogovori form2 = new Form_Dogovori();
            form2.Show();
            this.Hide();
        }

        private void составToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Sostav form3 = new Form_Sostav();
            form3.Show();
            this.Hide();
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Klienti form4 = new Form_Klienti();
            form4.Show();
            this.Hide();
        }

        private void предметЗалогаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Predmet_zaloga form6 = new Form_Predmet_zaloga();
            form6.Show();
            this.Hide();
        }

        private void должностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Dolgnosti form7 = new Form_Dolgnosti();
            form7.Show();
            this.Hide();
        }

        private void выходToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_Vhod form8 = new Form_Vhod();
            form8.Show();
            this.Hide();
        }

        private void справкаToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form_spravka sprav = new Form_spravka();
            sprav.Show();
        }
    }
}
