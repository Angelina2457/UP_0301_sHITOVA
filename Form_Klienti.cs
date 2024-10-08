using System;
using System.Collections;
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
    public partial class Form_Klienti : Form
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
        private readonly Form_Novii_klient novii_Klienti_1 = null;
        private SqlConnection connection = null;
        private SqlDataAdapter adapter = null;
        private DataTable table;
        private object dataGridView_Klient_1;
        private object textBoxDel;
        private object textBoxDelText;
        private string query;

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
      
        public Form_Klienti()
        {
            InitializeComponent();
        }
        private void Form_Sotrudniki_Activated(object sender, EventArgs e)
        {

            int n = dataGridView_klienti.Rows.Add();
            dataGridView_klienti.Rows[n].Cells[0].Value = ID_klienta;
            dataGridView_klienti.Rows[n].Cells[1].Value = Imya_klienta;
            dataGridView_klienti.Rows[n].Cells[2].Value = Familiya_klienta;
            dataGridView_klienti.Rows[n].Cells[3].Value = Otchestvo_klienta;
            dataGridView_klienti.Rows[n].Cells[4].Value = Nomer_telefona;
            dataGridView_klienti.Rows[n].Cells[5].Value = Pasportnie_dannie_kl;
            dataGridView_klienti.Rows[n].Cells[6].Value = ID_adresa;
            dataGridView_klienti.Rows[n].Cells[7].Value = Gorod;
            dataGridView_klienti.Rows[n].Cells[8].Value = Ulica;
            dataGridView_klienti.Rows[n].Cells[9].Value = Nomer_kvartiri;
            dataGridView_klienti.Rows[n].Cells[10].Value = Dom;
        }
        private void Form_Klienti_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fluere1DataSet3.Klienti". При необходимости она может быть перемещена или удалена.
            this.klientiTableAdapter2.Fill(this.fluere1DataSet3.Klienti);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fluereDataSet13._FIAS_adres_". При необходимости она может быть перемещена или удалена.
           // this.fIAS_adres_TableAdapter.Fill(this.fluereDataSet13._FIAS_adres_);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fluereDataSet12.Klienti". При необходимости она может быть перемещена или удалена.
           // this.klientiTableAdapter1.Fill(this.fluereDataSet12.Klienti);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fluereDataSet6.Klienti". При необходимости она может быть перемещена или удалена.
            
        }
        private void Form_Activated(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchet_personalaDataSet.Sotrudnik_1". При необходимости она может быть перемещена или удалена.
            // this.klientiTableAdapter.Fill(this.fluereDataSet6.Klienti);
            this.klientiTableAdapter2.Fill(this.fluere1DataSet3.Klienti);
        }
        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_spravka sprav = new Form_spravka();
            sprav.Show();
        }

        private void составToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Sostav form1 = new Form_Sostav();
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

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Vhod form7 = new Form_Vhod();
            form7.Show();
            this.Hide();
        }

        private void справкаToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form_spravka sprav = new Form_spravka();
            sprav.Show();
        }

        private void таблицыToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button_dobavit_novogo_klienta_Click(object sender, EventArgs e)
        {
            Form_Novii_klient form8 = new Form_Novii_klient();
            form8.Show();
            this.Hide();
        }

        private void klientiBindingSource2_CurrentChanged(object sender, EventArgs e)
        {
            string query = "SELECT  ID_klienta, Familiya_klienta, Imya_klienta, Otchestvo_klienta, Nomer_telefona, Pasportnie_dannie_kl, Gorod, Ulica, Dom, Nomer_kvartiri FROM [Klienti] inner join [FIAS] on Klienti.ID_adresa=[FIAS].ID_adresa";
            SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-K6O5APB7;Initial Catalog=Fluere1;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView_klienti.RowHeadersVisible = false;
            dataGridView_klienti.DataSource = dt;
            dataGridView_klienti.Columns[0].HeaderCell.Value = "Номер клиента";
            dataGridView_klienti.Columns[0].Width = 80;
            dataGridView_klienti.Columns[1].HeaderCell.Value = "Фамилия клиента";
            dataGridView_klienti.Columns[1].Width = 110;
            dataGridView_klienti.Columns[2].HeaderCell.Value = "Имя клиента";
            dataGridView_klienti.Columns[2].Width = 110;
            dataGridView_klienti.Columns[3].HeaderCell.Value = "Отчество клиента";
            dataGridView_klienti.Columns[4].Width = 130;
            dataGridView_klienti.Columns[4].HeaderCell.Value = "Номер телефона";
            dataGridView_klienti.Columns[5].Width = 120;
            dataGridView_klienti.Columns[5].HeaderCell.Value = "Паспортные данные клиента";
            dataGridView_klienti.Columns[6].Width = 120;
            dataGridView_klienti.Columns[6].HeaderCell.Value = "Номер адреса";
            dataGridView_klienti.Columns[7].Width = 120;
            dataGridView_klienti.Columns[7].HeaderCell.Value = "Город";
            dataGridView_klienti.Columns[8].Width = 120;
            dataGridView_klienti.Columns[8].HeaderCell.Value = "Улица";
            dataGridView_klienti.Columns[9].Width = 90;
            dataGridView_klienti.Columns[9].HeaderCell.Value = "Дом";
            dataGridView_klienti.Columns[0].Width = 70;
            dataGridView_klienti.Columns[0].HeaderCell.Value = "Номер квартиры";
           // dataGridView_klienti.Columns[4].Width = 90;
            connection.Close();
        }
    }
}
