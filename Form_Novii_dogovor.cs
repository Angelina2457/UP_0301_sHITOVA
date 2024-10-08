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
    public partial class Form_Novii_dogovor : Form
    {
        private SqlConnection connection = null;
        private SqlDataAdapter adapter = null;
        private DataTable table;

        public object dataGridView_dogovor { get; private set; }
        public Form_Novii_dogovor()
        {
            InitializeComponent();
        }
        public string get_cs()
        {
            return "Data Source=LAPTOK6O5APB7;Initial Catalog=Fluere1;Integrated Security=True";
        }
                
        private void FillDataGridView()
        {
            Form_Dogovori form_add_dogovor = (Form_Dogovori)this.Owner;

            connection = new SqlConnection("Data Source=LAPTOP-K6O5APB7;Initial Catalog=Fluere1;Integrated Security=True");
            connection.Open();

            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter = new SqlDataAdapter("(SELECT * FROM Dogovori)", connection);
            table = new DataTable();
            adapter.Fill(table);
            form_add_dogovor.dataGridView_dogovor.DataSource = table;
            this.Close();
        }

        private void button_Novii_dogovor_Click(object sender, EventArgs e)
        {
            Form_Dogovori f1 = (Form_Dogovori)this.Owner;
            f1.PassID_dogovora = tb_id_dogovora.Text;
            f1.PassData_zaklucheniya_dogovora = tb_data_zakluch.Text;
            f1.PassCena_iizdeliya = tb_cena.Text;
            f1.PassID_predmeta = tb_id_predm.Text;
            f1.PassID_klienta = tb_id_klienta.Text;
            f1.PassID_sotrudnika = tb_id_sotr.Text;
            f1.PassData_okonchaniya_dogovora = tb_okonch.Text;
            f1.PassProsrochenni = tb_prosroch.Text;
            f1.PassPasportnie_dannie = tb_pasport.Text;
            f1.PassTip_izdeliya = tb_tip_izd.Text;
            f1.Show();
            this.Close();

            MessageBox.Show("Вы точно хотите добавить данные в таблицу Договоры?", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (!string.IsNullOrEmpty(tb_id_dogovora.Text) && !string.IsNullOrWhiteSpace(tb_id_dogovora.Text) &&
               !string.IsNullOrEmpty(tb_data_zakluch.Text) && !string.IsNullOrWhiteSpace(tb_data_zakluch.Text) &&
               !string.IsNullOrEmpty(tb_pasport.Text) && !string.IsNullOrWhiteSpace(tb_pasport.Text) &&
               !string.IsNullOrEmpty(tb_cena.Text) && !string.IsNullOrWhiteSpace(tb_cena.Text) &&
               !string.IsNullOrEmpty(tb_id_predm.Text) && !string.IsNullOrWhiteSpace(tb_id_predm.Text) &&
               !string.IsNullOrEmpty(tb_id_klienta.Text) && !string.IsNullOrWhiteSpace(tb_id_klienta.Text) &&
               !string.IsNullOrEmpty(tb_id_sotr.Text) && !string.IsNullOrWhiteSpace(tb_id_sotr.Text) &&
               !string.IsNullOrEmpty(tb_okonch.Text) && !string.IsNullOrWhiteSpace(tb_okonch.Text) &&
               !string.IsNullOrEmpty(tb_prosroch.Text) && !string.IsNullOrWhiteSpace(tb_prosroch.Text) &&
               !string.IsNullOrEmpty(tb_tip_izd.Text) && !string.IsNullOrWhiteSpace(tb_tip_izd.Text))
            {
                using (var connection = new SqlConnection(get_cs()))
                {
                    connection.Open();

                    using (var cmd = new SqlCommand("INSERT INTO [Dogovori] (ID_dogovora, Data_zaklucheniya_dogovora, Cena_iizdeliya, ID_predmeta, ID_klienta, ID_sotrudnika, Data_okonchaniya_dogovora, Prosrochenni, Pasportnie_dannie, Tip_izdeliya) VALUES (@ID_dogovora, @Data_zaklucheniya_dogovora, @Cena_iizdeliya, @ID_predmeta, @ID_klienta, @ID_sotrudnika, @Data_okonchaniya_dogovora, @Prosrochenni, @Pasportnie_dannie, @Tip_izdeliyai)", connection))

                    {
                        cmd.Parameters.AddWithValue("ID_sotrudnika", tb_id_dogovora.Text);
                        cmd.Parameters.AddWithValue("Imya", tb_data_zakluch.Text);
                        cmd.Parameters.AddWithValue("Familiya", tb_pasport.Text);
                        cmd.Parameters.AddWithValue("Otchestvo", tb_cena.Text);
                        cmd.Parameters.AddWithValue("Nomer_telefona", tb_id_predm.Text);
                        cmd.Parameters.AddWithValue("ID_dolgnosti", tb_id_klienta.Text);
                        cmd.Parameters.AddWithValue("Data_rozhdeniya", tb_id_sotr.Text);
                        cmd.Parameters.AddWithValue("ID_dolgnosti", tb_okonch.Text);
                        cmd.Parameters.AddWithValue("Data_rozhdeniya", tb_prosroch.Text);
                        cmd.Parameters.AddWithValue("Pasportnie_dannie", tb_prosroch.Text);
                        cmd.ExecuteNonQuery();

                    }
                    connection.Close();
                    tb_id_dogovora.Clear();
                    tb_data_zakluch.Clear();
                    tb_pasport.Clear();
                    tb_cena.Clear();
                    tb_id_predm.Clear();
                    tb_id_klienta.Clear();
                    tb_id_sotr.Clear();
                    tb_okonch.Clear();
                    tb_prosroch.Clear();
                    tb_tip_izd.Clear();
                    FillDataGridView();

                }
            }
            else
            {
                MessageBox.Show("Все поля должны быть заполнены!!!", "Предупреждение");
            }
        }

       
            private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
            {
                Form_spravka sprav = new Form_spravka();
                sprav.Show();
            }

        private void договорыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Dogovori form1 = new Form_Dogovori();
            form1.Show();
            this.Hide();
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Sotrudniki form2 = new Form_Sotrudniki();
            form2.Show();
            this.Hide();
        }

        private void составToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Sostav form3 = new Form_Sostav();
            form3.Show();
            this.Hide();
        }

        
        private void предметЗалогаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Predmet_zaloga form5 = new Form_Predmet_zaloga();
            form5.Show();
            this.Hide();
        }

        private void должностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Dolgnosti form6 = new Form_Dolgnosti();
            form6.Show();
            this.Hide();
        }

        private void клиентыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_Klienti form7 = new Form_Klienti();
            form7.Show();
            this.Hide();
        }

        private void выходToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_Vhod form8 = new Form_Vhod();
            form8.Show();
            this.Hide();
        }

        private void таблицыToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
