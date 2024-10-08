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
    public partial class Form_Dogovori : Form
    {
        private string ID_dogovora;
        private string Data_zaklucheniya_dogovora;
        private string Cena_iizdeliya;
        private string ID_predmeta;
        private string ID_klienta;
        private string ID_sotrudnika;
        private string Data_okonchaniya_dogovora;
        private string Prosrochenni;
        private string Pasportnie_dannie;
        private string Tip_izdeliya;
        private string Familiya_klienta;
        private string Imya_klienta;
        private string Nomer_telefona;
        private string Pasportnie_dannie_kl;
        private string Familia;
        private string Imya;
        private string Dolgnost_sotr;
        private string Predmet;
        private string Tip_predmeta;
        private readonly Form_Novii_dogovor novii_Dogovor1 = null;
        private SqlConnection connection = null;
        private SqlDataAdapter adapter = null;
        private DataTable table;
        private object dataGridView_Dogovor1;
        private object textBoxDel;
        private object textBoxDelText;

        public string PassID_dogovora
        {
            get { return ID_dogovora; }
            set { ID_dogovora = value; }
        }
        public string PassData_zaklucheniya_dogovora
        {
            get { return Data_zaklucheniya_dogovora; }
            set { Data_zaklucheniya_dogovora = value; }
        }

        public string PassCena_iizdeliya
        {
            get { return Cena_iizdeliya; }
            set { Cena_iizdeliya = value; }
        }
        public string PassID_predmeta
        {
            get { return ID_predmeta; }
            set { ID_predmeta = value; }
        }
        public string PassID_klienta
        {
            get { return ID_klienta; }
            set { ID_klienta = value; }
        }
        public string PassID_sotrudnika
        {
            get { return ID_sotrudnika; }
            set { ID_sotrudnika = value; }
        }
        public string PassData_okonchaniya_dogovora
        {
            get { return Data_okonchaniya_dogovora; }
            set { Data_okonchaniya_dogovora = value; }
        }
        public string PassProsrochenni
        {
            get { return Prosrochenni; }
            set { Prosrochenni = value; }
        }
        public string PassPasportnie_dannie
        {
            get { return Pasportnie_dannie; }
            set { Pasportnie_dannie = value; }
        }
        public string PassTip_izdeliya
        {
            get { return Tip_izdeliya; }
            set { Tip_izdeliya = value; }
        }
        public string PassFamiliya_klienta
        {
            get { return Familiya_klienta; }
            set { Familiya_klienta = value; }
        }
        public string PassImya_klienta
        {
            get { return Imya_klienta; }
            set { Imya_klienta = value; }
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
        public string PassFamilia
        {
            get { return Familia; }
            set { Familia = value; }
        }
        public string PassImya
        {
            get { return Imya; }
            set { Imya = value; }
        }
        public string PassDolgnost_sotr
        {
            get { return Dolgnost_sotr; }
            set { Dolgnost_sotr = value; }
        }
        public string PassPredmet
        {
            get { return Predmet; }
            set { Predmet = value; }
        }
        public string PassTip_predmeta
        {
            get { return Tip_predmeta; }
            set { Tip_predmeta = value; }
        }

        public Form_Dogovori()
        {
            InitializeComponent();
        }
        private void Form_Sotrudniki_Activated(object sender, EventArgs e)
        {

            int n = dataGridView_dogovor.Rows.Add();
            dataGridView_dogovor.Rows[n].Cells[0].Value = ID_dogovora;
            dataGridView_dogovor.Rows[n].Cells[1].Value = Data_zaklucheniya_dogovora;
            dataGridView_dogovor.Rows[n].Cells[3].Value = Cena_iizdeliya;
            dataGridView_dogovor.Rows[n].Cells[3].Value = ID_predmeta;
            dataGridView_dogovor.Rows[n].Cells[3].Value = ID_klienta;
            dataGridView_dogovor.Rows[n].Cells[2].Value = ID_sotrudnika;
            dataGridView_dogovor.Rows[n].Cells[3].Value = Data_okonchaniya_dogovora;
            dataGridView_dogovor.Rows[n].Cells[3].Value = Prosrochenni;
            dataGridView_dogovor.Rows[n].Cells[2].Value = Pasportnie_dannie;
            dataGridView_dogovor.Rows[n].Cells[2].Value = Tip_izdeliya;
            dataGridView_dogovor.Rows[n].Cells[2].Value = Familiya_klienta;
            dataGridView_dogovor.Rows[n].Cells[2].Value = Imya_klienta;
            dataGridView_dogovor.Rows[n].Cells[2].Value = Nomer_telefona;
            dataGridView_dogovor.Rows[n].Cells[2].Value = Pasportnie_dannie_kl;
            dataGridView_dogovor.Rows[n].Cells[2].Value = Familia;
            dataGridView_dogovor.Rows[n].Cells[2].Value = Imya;
            dataGridView_dogovor.Rows[n].Cells[2].Value = Dolgnost_sotr;
            dataGridView_dogovor.Rows[n].Cells[2].Value = Tip_predmeta;
        }
        private void Form_Dogovori_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fluere1DataSet6.Dogovori". При необходимости она может быть перемещена или удалена.
            this.dogovoriTableAdapter3.Fill(this.fluere1DataSet6.Dogovori);
        }
        private void Form_Activated(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchet_personalaDataSet.Sotrudnik_1". При необходимости она может быть перемещена или удалена.
            //this.dogovoriTableAdapter.Fill(this.fluereDataSet.Dogovori);

            {
                connection = new SqlConnection(@"Data Source=LAPTOP_K6O5APB7;Initial Catalog=Fluere1;Integrated Security=True");
                connection.Open();
                adapter = new SqlDataAdapter("select ID_dogovora as'№ договора', " +
                    "Data_zaklucheniya_dogovora as 'Дата заключени ядоговора'," +
                    "Cena_izdeliya as 'Цена изделия', " +
                    "Data_okonchaniya_dogovora as 'Дата окончаниядоговра', " +
                    "Dogovori.Pasportnie_dannie as 'Паспортные данные'," +
                    "Prosrochenni as 'Просрочено'," +
                    "Tip_izdeliya as 'Тип предмета'," +
                    "Predmet_zaloga.Predmet as 'Предмет залога'," +
                    "Klienti.Imya_klienta as 'Имя клиента', " +
                    "Klienti.Familiya_klienta as 'Фамилия клиента', " +
                    "Klienti.Nomer_telefona as 'Номер телефона клиента', " +
                    "Sotrudniki.Imya as 'Имя сотрудника', " +
                    "Sotrudniki.Familia as 'Фамилия сотрудника' " +
                    "from Dogovori" +
                    "inner join Klienti on Dogovori.ID_klienta = Klienti.ID_klienta" +
                    "inner join Sotrudniki on Dogovori.ID_sotrudnika = Sotrudniki.ID_sotrudnika " +
                    "inner join Predmet_zaloga on Dogovori.ID_predmeta = Predmet_zaloga.ID_predmeta", connection);
                table = new DataTable();
                adapter.Fill(table);
                dataGridView_dogovor.RowHeadersVisible = false;
                dataGridView_dogovor.DataSource = table;
                dataGridView_dogovor.Columns[0].HeaderCell.Value = "Номер договора";
                dataGridView_dogovor.Columns[0].Width = 80;
                dataGridView_dogovor.Columns[1].HeaderCell.Value = "Дата заключения договора";
                dataGridView_dogovor.Columns[1].Width = 150;
                dataGridView_dogovor.Columns[3].HeaderCell.Value = "Цена изделия";
                dataGridView_dogovor.Columns[3].Width = 170;
                dataGridView_dogovor.Columns[4].HeaderCell.Value = "Номер предмета";
                dataGridView_dogovor.Columns[4].Width = 120;
                dataGridView_dogovor.Columns[2].HeaderCell.Value = "Номер клиента";
                dataGridView_dogovor.Columns[2].Width = 120;
                dataGridView_dogovor.Columns[3].HeaderCell.Value = "Номер сотрудника";
                dataGridView_dogovor.Columns[2].Width = 120;
                dataGridView_dogovor.Columns[3].HeaderCell.Value = "Дата окончанияния договора";
                dataGridView_dogovor.Columns[2].Width = 120;
                dataGridView_dogovor.Columns[3].HeaderCell.Value = "Просрочено";
                dataGridView_dogovor.Columns[2].Width = 120;
                dataGridView_dogovor.Columns[3].HeaderCell.Value = "Паспортные данные";
                dataGridView_dogovor.Columns[2].Width = 120;
                dataGridView_dogovor.Columns[3].HeaderCell.Value = "Тип изделия";
                dataGridView_dogovor.Columns[2].Width = 120;
                dataGridView_dogovor.Columns[3].HeaderCell.Value = "Фамилия клиента";
                dataGridView_dogovor.Columns[2].Width = 120;
                dataGridView_dogovor.Columns[3].HeaderCell.Value = "Имя клиента";
                dataGridView_dogovor.Columns[2].Width = 120;
                dataGridView_dogovor.Columns[3].HeaderCell.Value = "Номер телефона";
                dataGridView_dogovor.Columns[2].Width = 120;
                dataGridView_dogovor.Columns[3].HeaderCell.Value = " Паспортные данные клиента";
                dataGridView_dogovor.Columns[2].Width = 120;
                dataGridView_dogovor.Columns[3].HeaderCell.Value = "Фамилия сотрудника";
                dataGridView_dogovor.Columns[2].Width = 120;
                dataGridView_dogovor.Columns[3].HeaderCell.Value = "Имя сотрудника";
                dataGridView_dogovor.Columns[2].Width = 120;
                dataGridView_dogovor.Columns[3].HeaderCell.Value = "Должность сотрудника";
                dataGridView_dogovor.Columns[2].Width = 120;
                dataGridView_dogovor.Columns[3].HeaderCell.Value = "Тип предмета залога";
                dataGridView_dogovor.Columns[2].Width = 120;
            }
        }
        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_spravka sprav = new Form_spravka();
            sprav.Show();
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

         private void ДолжностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Dolgnosti form2 = new Form_Dolgnosti();
            form2.Show();
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
            Form_Predmet_zaloga form5 = new Form_Predmet_zaloga();
            form5.Show();
            this.Hide();
        }

        private void составToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Sostav form6 = new Form_Sostav();
            form6.Show();
            this.Hide();
        }

        private void выходToolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void button_Zapros_1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-K6O5APB7;Initial Catalog=Fluere1;Integrated Security=True"))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("select ID_dogovora as '№ договора', Data_zaklucheniya_dogovora as 'Дата заключения договора', Cena_izdeliya as 'Цена изделия', Data_okonchaniya_dogovora as 'Дата окончания договора', Pasportnie_dannie as 'Паспортные данные', Prosrochenni as 'Просрочено', Predmet_zaloga.Predmet as 'Предмет залога', Predmet_zaloga.Proba_metalla as 'Проба металла', Predmet_zaloga.Ves_predmeta as 'Вес предмета' from Dogovori inner join Predmet_zaloga on Dogovori.ID_predmeta = Predmet_zaloga.ID_predmeta", connection);
                table = new DataTable();
                adapter.Fill(table);
                dataGridView_dogovor.RowHeadersVisible = false;
                dataGridView_dogovor.DataSource = table;
            }
        }

        private void button_Zapros_2_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-K6O5APB7;Initial Catalog=Fluere1;Integrated Security=True"))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("select ID_dogovora as '№ договора', Data_zaklucheniya_dogovora as 'Дата заключения договора', Cena_izdeliya as 'Цена изделия', Data_okonchaniya_dogovora as 'Дата окончания договора', Pasportnie_dannie as 'Паспортные данные', Prosrochenni as 'Просрочено', Klienti.Familiya_klienta as 'Фамилия клиента', Klienti.Imya_klienta as 'Имя клиента', Klienti.Nomer_telefona as 'Номер телефона клиента' from Dogovori inner join Klienti on Dogovori.ID_klienta = Klienti.ID_klienta", connection);
                table = new DataTable();
                adapter.Fill(table);
                dataGridView_dogovor.RowHeadersVisible = false;
                dataGridView_dogovor.DataSource = table;
            }
        }

       
         private void dogovoriBindingSource_CurrentChanged_1(object sender, EventArgs e)
        {
            connection = new SqlConnection(@"Data Source=LAPTOP-K6O5APB7;Initial Catalog=Fluere1;Integrated Security=True");
            connection.Open();
            adapter = new SqlDataAdapter("select ID_dogovora as'№ договора', " +
                "Data_zaklucheniya_dogovora as 'Дата заключени ядоговора'," +
                "Cena_izdeliya as 'Цена изделия', " +
                "Data_okonchaniya_dogovora as 'Дата окончаниядоговра', " +
                "Dogovori.Pasportnie_dannie as 'Паспортные данные'," +
                "Prosrochenni as 'Просрочено'," +
                "Tip_izdeliya as 'Тип предмета'," +
                "Predmet_zaloga.Predmet as 'Предмет залога'," +
                "Klienti.Imya_klienta as 'Имя клиента', " +
                "Klienti.Familiya_klienta as 'Фамилия клиента', " +
                "Klienti.Nomer_telefona as 'Номер телефона клиента', " +
                "Sotrudniki.Imya as 'Имя сотрудника', " +
                "Sotrudniki.Familia as 'Фамилия сотрудника' " +
                "from Dogovori "  +
                " inner join Klienti on Dogovori.ID_klienta = Klienti.ID_klienta " + 
                " inner join Sotrudniki on Dogovori.ID_sotrudnika = Sotrudniki.ID_sotrudnika " +
                " inner join Predmet_zaloga on Dogovori.ID_predmeta = Predmet_zaloga.ID_predmeta", connection);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView_dogovor.RowHeadersVisible = false;
            dataGridView_dogovor.DataSource = table;
            dataGridView_dogovor.Columns[0].HeaderCell.Value = "Номер договора";
            dataGridView_dogovor.Columns[0].Width = 80;
            dataGridView_dogovor.Columns[1].HeaderCell.Value = "Дата заключения договора";
            dataGridView_dogovor.Columns[1].Width = 150;
            dataGridView_dogovor.Columns[2].HeaderCell.Value = "Цена изделия";
            dataGridView_dogovor.Columns[2].Width = 170;
            dataGridView_dogovor.Columns[3].HeaderCell.Value = "Дата окончанияния договора";
            dataGridView_dogovor.Columns[3].Width = 120;
            dataGridView_dogovor.Columns[4].HeaderCell.Value = "Паспортные данные клиента";
            dataGridView_dogovor.Columns[4].Width = 120;
            dataGridView_dogovor.Columns[5].HeaderCell.Value = "Просрочено";
            dataGridView_dogovor.Columns[5].Width = 120;
            dataGridView_dogovor.Columns[6].HeaderCell.Value = "Тип предмета залога";
            dataGridView_dogovor.Columns[6].Width = 120;
            dataGridView_dogovor.Columns[7].HeaderCell.Value = "Предмет залога";
            dataGridView_dogovor.Columns[7].Width = 120;
            dataGridView_dogovor.Columns[8].HeaderCell.Value = "Имя клиента";
            dataGridView_dogovor.Columns[8].Width = 120;
            dataGridView_dogovor.Columns[9].HeaderCell.Value = "Фамилия клиента";
            dataGridView_dogovor.Columns[9].Width = 120;
            dataGridView_dogovor.Columns[10].HeaderCell.Value = "Номер телефона клиента";
            dataGridView_dogovor.Columns[10].Width = 120;
            dataGridView_dogovor.Columns[11].HeaderCell.Value = "Имя сотрудника";
            dataGridView_dogovor.Columns[11].Width = 120;
            dataGridView_dogovor.Columns[12].HeaderCell.Value = "Фамилия сотрудника";
            dataGridView_dogovor.Columns[12].Width = 120;
         }

        private void button_novii_dogovor_Click(object sender, EventArgs e)
        {
            Form_Novii_dogovor form8 = new Form_Novii_dogovor();
            form8.Show();
            this.Hide();
        }
    }
}
