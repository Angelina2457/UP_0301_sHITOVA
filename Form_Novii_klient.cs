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
    public partial class Form_Novii_klient : Form
    {
        private string ID_klienta;
        private string Imya_klienta;
        private string Familiya_klienta;
        private string Otchestvo_klienta;
        private string Nomer_telefona;
        private string Pasportnie_dannie_kl;
        private string ID_adresa;
        private string Gorod;
        private string Ulica;
        private string Dom;
        private string Nomer_kvartiri;

        public string PassID_klienta
        {
            get { return ID_klienta; }
            set { ID_klienta = value; }
        }

        public string PassImya_klienta
        {
            get { return Imya_klienta; }
            set { Imya_klienta = value; }
        }
        public string PassFamiliya_klienta
        {
            get { return Familiya_klienta; }
            set { Familiya_klienta = value; }
        }

        public string PassOtchestvo_klienta
        {
            get { return Otchestvo_klienta; }
            set { Otchestvo_klienta = value; }
        }
        public string PassNomer_telefona
        {
            get { return Nomer_telefona; }
            set { Nomer_telefona = value; }
        }
        public string PassPasportnie_dannie_kl
        {
            get { return Pasportnie_dannie_kl; }
            set { Pasportnie_dannie_kl = value; }
        }
        public string PassID_adresa
        {
            get { return ID_adresa; }
            set { ID_adresa = value; }
        }
        public string PassGorod
        {
            get { return Gorod; }
            set { Gorod = value; }
        }
        public string PassUlica
        {
            get { return Ulica; }
            set { Ulica = value; }
        }
        public string PassDom
        {
            get { return Dom; }
            set { Dom = value; }
        }
        public string PassNomer_kvartiri
        {
            get { return Nomer_kvartiri; }
            set { Nomer_kvartiri = value; }
        }
        public Form_Novii_klient()
        {
            InitializeComponent();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_spravka sprav = new Form_spravka();
            sprav.Show();
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Klienti form1 = new Form_Klienti();
            form1.Show();
            this.Hide();
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Sotrudniki form2 = new Form_Sotrudniki();
            form2.Show();
            this.Hide();
        }

        private void договорыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Dogovori form3 = new Form_Dogovori();
            form3.Show();
            this.Hide();
        }

       private void должностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Dolgnosti form5 = new Form_Dolgnosti();
            form5.Show();
            this.Hide();
        }

        private void предметЗалогаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Predmet_zaloga form6 = new Form_Predmet_zaloga();
            form6.Show();
            this.Hide();
        }

        private void составToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_Sostav form7 = new Form_Sostav();
            form7.Show();
            this.Hide();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Vhod form8 = new Form_Vhod();
            form8.Show();
            this.Hide();
        }

        private void таблицыToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form_Novii_klient_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fluere1DataSet9.FIAS". При необходимости она может быть перемещена или удалена.
            this.fIASTableAdapter1.Fill(this.fluere1DataSet9.FIAS);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fluere1DataSet8.FIAS". При необходимости она может быть перемещена или удалена.
            this.fIASTableAdapter.Fill(this.fluere1DataSet8.FIAS);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fluereDataSet11._FIAS_adres_". При необходимости она может быть перемещена или удалена.
            // this.fIAS_TableAdapter.Fill(this.fluere1DataSet3._FIAS);

        }

        private void button_Dobavit_kl_Click(object sender, EventArgs e)
        {
            string get_cs()
            {
                return "Data Source=laptop-k6o5apb7;Initial Catalog=Fluere1;Integrated Security=True";
            }
            PassID_klienta = tb_nom_kl.Text;
            PassFamiliya_klienta = tb_fam_kl.Text;
            PassImya_klienta = tb_imya_kl.Text;
            PassOtchestvo_klienta = tb_otch_kl.Text;
            PassNomer_telefona = tb_nom_tel_kl.Text;
            PassNomer_telefona = tb_Pasportnie_dannie_kl.Text;
            PassID_adresa = tb_ID_adresa.Text;
            PassGorod = cb_gorod.Text;
            PassUlica = cb_ulica.Text;
            PassDom = cb_dom.Text;
            PassNomer_kvartiri = cb_nom_kv.Text;


            MessageBox.Show("Вы точно хотите добавить данные в таблицу Клиенты?", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (!string.IsNullOrEmpty(tb_nom_kl.Text) && !string.IsNullOrWhiteSpace(tb_nom_kl.Text) &&
               !string.IsNullOrEmpty(tb_fam_kl.Text) && !string.IsNullOrWhiteSpace(tb_fam_kl.Text) &&
               !string.IsNullOrEmpty(tb_imya_kl.Text) && !string.IsNullOrWhiteSpace(tb_imya_kl.Text) &&
               !string.IsNullOrEmpty(tb_otch_kl.Text) && !string.IsNullOrWhiteSpace(tb_otch_kl.Text) &&
               !string.IsNullOrEmpty(tb_nom_tel_kl.Text) && !string.IsNullOrWhiteSpace(tb_nom_tel_kl.Text) &&
               !string.IsNullOrEmpty(tb_Pasportnie_dannie_kl.Text) && !string.IsNullOrWhiteSpace(tb_Pasportnie_dannie_kl.Text) &&
               !string.IsNullOrEmpty(tb_ID_adresa.Text) && !string.IsNullOrWhiteSpace(tb_ID_adresa.Text) &&
               !string.IsNullOrEmpty(cb_oblast.Text) && !string.IsNullOrWhiteSpace(cb_oblast.Text) &&
               !string.IsNullOrEmpty(cb_gorod.Text) && !string.IsNullOrWhiteSpace(cb_gorod.Text) &&
               !string.IsNullOrEmpty(cb_ulica.Text) && !string.IsNullOrWhiteSpace(cb_ulica.Text) &&
               !string.IsNullOrEmpty(cb_dom.Text) && !string.IsNullOrWhiteSpace(cb_dom.Text) &&
               !string.IsNullOrEmpty(cb_nom_kv.Text) && !string.IsNullOrWhiteSpace(cb_nom_kv.Text))

            {
                using (var connection = new SqlConnection(get_cs()))
                {
                    connection.Open();

                    using (var cmd = new SqlCommand(" INSERT INTO [Klienti] (ID_klienta, Familiya_klienta, Imya_klienta, " +
                        "Otchestvo_klienta, Nomer_telefona, Pasportnie_dannie_kl) VALUES (@ID_klienta, @Familiya_klienta, @Imya_klienta, " +
                        "@Otchestvo_klienta, @Nomer_telefona, @Pasportnie_dannie_kl); INSERT INTO [FIAS] (ID_adresa, Oblast, Gorod, Ulica, Dom, Nomer_kvartiri) VALUES (@ID_adresa, @Oblast, @Gorod, @Ulica, @Dom, @Nomer_kvartiri)", connection))

                    {
                        cmd.Parameters.AddWithValue("ID_klienta", tb_nom_kl.Text);
                        cmd.Parameters.AddWithValue("Familiya_klienta", tb_fam_kl.Text);
                        cmd.Parameters.AddWithValue("Imya_klienta", tb_imya_kl.Text);
                        cmd.Parameters.AddWithValue("Otchestvo_klienta", tb_otch_kl.Text);
                        cmd.Parameters.AddWithValue("Nomer_telefona", tb_nom_tel_kl.Text);
                        cmd.Parameters.AddWithValue("Pasportnie_dannie_kl", tb_Pasportnie_dannie_kl.Text);
                        cmd.Parameters.AddWithValue("ID_adresa", tb_ID_adresa.Text);
                        cmd.Parameters.AddWithValue("Oblast", cb_oblast.SelectedText);
                        cmd.Parameters.AddWithValue("Gorod", cb_gorod.SelectedText);
                        cmd.Parameters.AddWithValue("Ulica", cb_ulica.SelectedText);
                        cmd.Parameters.AddWithValue("Dom", cb_dom.SelectedText);
                        cmd.Parameters.AddWithValue("Nomer_kvartiri", cb_nom_kv.SelectedText);

                        cmd.ExecuteNonQuery();
                    }
                    connection.Close();
                    tb_nom_kl.Clear();
                    tb_fam_kl.Clear();
                    tb_imya_kl.Clear();
                    tb_otch_kl.Clear();
                    tb_nom_tel_kl.Clear();
                    tb_Pasportnie_dannie_kl.Clear();
                    tb_ID_adresa.Clear();
                    }
            }
            else
            {
                MessageBox.Show("Все поля должны быть заполнены!!!", "Предупреждение");
            }

        }
    }
}
