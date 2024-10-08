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
using System.Xml;

namespace PR_7_02._01
{
    public partial class Form_Predmet_zaloga : Form
    {
        private string ID_predmeta;
        private string Predmet;
        private string Ves_predmeta;
        private string Tip_predmeta;
        private string Proba_metalla;
        private string Imya_klienta;
        private string Familiya_klienta;
        private string Nomer_telefona;
        private string Sostav_izdeliya;
        private string Status;
        private readonly Form_Novii_predmet_zaloga novii_predmet_zaloga_1 = null;
        private SqlConnection connection = null;
        private SqlDataAdapter adapter = null;
        private DataTable table;
        private DataRow table1;
        private object dataGridView_predmet_1;
        private object textBoxDel;
        private object textBoxDelText;
        private string query;
       

        public string PassID_predmeta
        {
            get { return ID_predmeta; }
            set { ID_predmeta = value; }
        }

        public string PassPredmet
        {
            get { return Predmet; }
            set { Predmet = value; }
        }
        public string PassVes_predmeta
        {
            get { return Ves_predmeta; }
            set { Ves_predmeta = value; }
        }
        public string PassTip_predmeta
        {
            get { return Tip_predmeta; }
            set { Tip_predmeta = value; }
        }
        public string PassProba_metalla
        {
            get { return Proba_metalla; }
            set { Proba_metalla = value; }
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
        public string PassNomer_telefona
        {
            get { return Nomer_telefona; }
            set { Nomer_telefona = value; }
        }
        public string PassSostav_izdeliya
        {
            get { return Sostav_izdeliya; }
            set { Sostav_izdeliya = value; }
        }
        public string PassStatus
        {
            get { return Status; }
            set { Status = value; }
        }
       
        public Form_Predmet_zaloga()
        {
            InitializeComponent();
        }

        private void Form_Predmet_zaloga_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fluere1DataSet10.Predmet_zaloga". При необходимости она может быть перемещена или удалена.
            this.predmet_zalogaTableAdapter2.Fill(this.fluere1DataSet10.Predmet_zaloga);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fluere1DataSet1.Predmet_zaloga". При необходимости она может быть перемещена или удалена.
            //this.predmet_zalogaTableAdapter1.Fill(this.fluere1DataSet1.Predmet_zaloga);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fluereDataSet7.Predmet_zaloga". При необходимости она может быть перемещена или удалена.
            //this.predmet_zalogaTableAdapter.Fill(this.fluereDataSet7.Predmet_zaloga);

        }

        private void таблицыToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        private void составToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_Sostav form6 = new Form_Sostav();
            form6.Show();
            this.Hide();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Vhod form7 = new Form_Vhod();
            form7.Show();
            this.Hide();
        }

        private void button_Zapros_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-K6O5APB7;Initial Catalog=Fluere1;Integrated Security=True"))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("select Predmet as 'Предмет', Proba_metalla as 'Проба металла', Tip_predmeta as 'Тип предмета', Ves_predmeta as 'Вес предмета', Sostav.Sostav_izdeliya as 'Состав изделия' from Predmet_zaloga inner join Sostav on Predmet_zaloga.ID_sostava = Sostav.ID_sostava", connection);
                table = new DataTable();
                adapter.Fill(table);
                dataGridView_predmet.RowHeadersVisible = false;
                dataGridView_predmet.DataSource = table;
            }
        }

        private void predmetzalogaBindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            string query = "select ID_predmeta as '№ предмета'," +
                "\r\nPredmet as 'Предмет залога', " +
                "\r\nVes_predmeta as 'Вес предмета'," +
                "\r\nTip_predmeta as 'Тип предмета'," +
                "\r\nPredmet_zaloga.Proba_metalla as 'Проба металла', " +
                "\r\nKlienti.Imya_klienta as 'Имя клиента'," +
                "\r\nKlienti.Familiya_klienta as 'Фамилия клиента'," +
                "\r\nKlienti.Nomer_telefona as 'Номер телефона клиента', " +
                "\r\nSostav.Sostav_izdeliya as 'Состав изделия'," +
                "\r\nPredmet_zaloga.Status as 'Статус предмета'" +
                "\r\nfrom Predmet_zaloga" +
                "\r\nleft join Klienti on Predmet_zaloga.ID_klienta = Klienti.ID_klienta" +
                "\r\nleft join Sostav on Predmet_zaloga.ID_sostava = Sostav.ID_sostava ";
            SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-K6O5APB7;Initial Catalog=Fluere1;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView_predmet.RowHeadersVisible = false;
            dataGridView_predmet.DataSource = dt;
            dataGridView_predmet.Columns[0].HeaderCell.Value = "Номер предмета";
            dataGridView_predmet.Columns[0].Width = 80;
            dataGridView_predmet.Columns[1].HeaderCell.Value = "Предмет залога";
            dataGridView_predmet.Columns[1].Width = 90;
            dataGridView_predmet.Columns[2].HeaderCell.Value = "Вес предмета";
            dataGridView_predmet.Columns[2].Width = 130;
            dataGridView_predmet.Columns[3].HeaderCell.Value = "Тип предмета";
            dataGridView_predmet.Columns[4].Width = 90;
            dataGridView_predmet.Columns[4].HeaderCell.Value = "Проба металла";
            dataGridView_predmet.Columns[5].Width = 120;
            dataGridView_predmet.Columns[5].HeaderCell.Value = "Имя клиента";
            dataGridView_predmet.Columns[6].Width = 110;
            dataGridView_predmet.Columns[6].HeaderCell.Value = "Фамилия клиента";
            dataGridView_predmet.Columns[7].Width = 110;
            dataGridView_predmet.Columns[7].HeaderCell.Value = "Номер телефона клиента";
            dataGridView_predmet.Columns[8].Width = 120;
            dataGridView_predmet.Columns[8].HeaderCell.Value = "Состав изделия";
            dataGridView_predmet.Columns[9].Width = 120;
            dataGridView_predmet.Columns[9].HeaderCell.Value = "Статус предмета";
            connection.Close();
        }

        private void predmetzalogaBindingSource2_CurrentChanged(object sender, EventArgs e)
        {
            string query = "select ID_predmeta as '№ предмета'," +
               "\r\nPredmet as 'Предмет залога', " +
               "\r\nVes_predmeta as 'Вес предмета'," +
               "\r\nTip_predmeta as 'Тип предмета'," +
               "\r\nPredmet_zaloga.Proba_metalla as 'Проба металла', " +
               "\r\nKlienti.Imya_klienta as 'Имя клиента'," +
               "\r\nKlienti.Familiya_klienta as 'Фамилия клиента'," +
               "\r\nKlienti.Nomer_telefona as 'Номер телефона клиента', " +
               "\r\nSostav.Sostav_izdeliya as 'Состав изделия'," +
               "\r\nPredmet_zaloga.Status as 'Статус предмета'" +
               "\r\nfrom Predmet_zaloga" +
               "\r\nleft join Klienti on Predmet_zaloga.ID_klienta = Klienti.ID_klienta" +
               "\r\nleft join Sostav on Predmet_zaloga.ID_sostava = Sostav.ID_sostava ";
            SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-K6O5APB7;Initial Catalog=Fluere1;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView_predmet.RowHeadersVisible = false;
            dataGridView_predmet.DataSource = dt;
            dataGridView_predmet.Columns[0].HeaderCell.Value = "Номер предмета";
            dataGridView_predmet.Columns[0].Width = 80;
            dataGridView_predmet.Columns[1].HeaderCell.Value = "Предмет залога";
            dataGridView_predmet.Columns[1].Width = 90;
            dataGridView_predmet.Columns[2].HeaderCell.Value = "Вес предмета";
            dataGridView_predmet.Columns[2].Width = 130;
            dataGridView_predmet.Columns[3].HeaderCell.Value = "Тип предмета";
            dataGridView_predmet.Columns[4].Width = 90;
            dataGridView_predmet.Columns[4].HeaderCell.Value = "Проба металла";
            dataGridView_predmet.Columns[5].Width = 120;
            dataGridView_predmet.Columns[5].HeaderCell.Value = "Имя клиента";
            dataGridView_predmet.Columns[6].Width = 110;
            dataGridView_predmet.Columns[6].HeaderCell.Value = "Фамилия клиента";
            dataGridView_predmet.Columns[7].Width = 110;
            dataGridView_predmet.Columns[7].HeaderCell.Value = "Номер телефона клиента";
            dataGridView_predmet.Columns[8].Width = 120;
            dataGridView_predmet.Columns[8].HeaderCell.Value = "Состав изделия";
            dataGridView_predmet.Columns[9].Width = 120;
            dataGridView_predmet.Columns[9].HeaderCell.Value = "Статус предмета";
            connection.Close();
        }

        private void button_dobavit_novii_predmet_Click(object sender, EventArgs e)
        {
            Form_Novii_predmet_zaloga form8 = new Form_Novii_predmet_zaloga();
            form8.Show();
            this.Hide();
        }

        private void выгрузкаВXmlфайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlElement rootElement = xmlDoc.CreateElement("FormPredmet_zaloga");
            xmlDoc.AppendChild(rootElement);
            foreach (DataRow row in table.Rows)
            {
                XmlElement sotrElement = xmlDoc.CreateElement("Predmet_zaloga");
                XmlElement idElement = xmlDoc.CreateElement("ID_predmeta");
                idElement.InnerText = row["ID_predmeta"].ToString();
                sotrElement.AppendChild(idElement);
                XmlElement nazvanieElement = xmlDoc.CreateElement("Predmet");
                nazvanieElement.InnerText = row["Predmet"].ToString();
                sotrElement.AppendChild(nazvanieElement);
                XmlElement mosklement = xmlDoc.CreateElement("Predmet");
                mosklement.InnerText = row["Predmet"].ToString();
                sotrElement.AppendChild(nazvanieElement);
                XmlElement prodoljitelnostElement = xmlDoc.CreateElement("Ves_predmeta");
                prodoljitelnostElement.InnerText = row["Ves_predmeta"].ToString();
                sotrElement.AppendChild(prodoljitelnostElement);
                XmlElement Tsena_kursaElement = xmlDoc.CreateElement("Tip_predmeta");
                Tsena_kursaElement.InnerText = row["Tip_predmeta"].ToString();
                sotrElement.AppendChild(Tsena_kursaElement);
                XmlElement Kolvo_mestElement = xmlDoc.CreateElement("Proba_metalla");
                Kolvo_mestElement.InnerText = row["Proba_metalla"].ToString();
                sotrElement.AppendChild(Kolvo_mestElement);
                XmlElement mestElement = xmlDoc.CreateElement("Status");
                mestElement.InnerText = row["Status"].ToString();
                sotrElement.AppendChild(Kolvo_mestElement);

                rootElement.AppendChild(sotrElement);
            }
            xmlDoc.Save("C:\\vigruzka xml faila\\josko.xml");
            MessageBox.Show("Форма успешно экспортирована в папку с приложением.", "Выгрузка xml-файла",
            MessageBoxButtons.OK);
        }
    }
}
