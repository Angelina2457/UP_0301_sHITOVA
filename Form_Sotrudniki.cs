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
    public partial class Form_Sotrudniki : Form
    {
        private string ID_sotrudnika;
        private string Imya;
        private string Familiya;
        private string Otchestvo;
        private string Nomer_telefona;
        private string ID_dolgnosti;
        private string Data_rozhdeniya;
        private string Pasportnie_dannie;
        private string Login;
        private string Parol;
        private string Rol;
        private readonly Form_Novii_sotrudnik novii_Sotrudnik1 = null;
        private SqlConnection connection = null;
        private SqlDataAdapter adapter = null;
        private DataTable table;
        private object dataGridView_Sotrudnik_1;
        private object textBoxDel;
        private object textBoxDelText;
        private string query;

        public string PassID_sotrudnika
        {
            get { return ID_sotrudnika; }
            set { ID_sotrudnika = value; }
        }
              
        public string PassImya
        {
            get { return Imya; }
            set { Imya = value; }
        }
        public string PassFamiliya
        {
            get { return Familiya; }
            set { Familiya = value; }
        }

        public string PassOtchestvo
        {
            get { return Otchestvo; }
            set { Otchestvo = value; }
        }
        public string PassNomer_telefona
        {
            get { return Nomer_telefona; }
            set { Nomer_telefona = value; }
        }
        public string PassID_dolgnosti
        {
            get { return ID_dolgnosti; }
            set { ID_dolgnosti = value; }
        }
        public string PassData_rozhdeniya
        {
            get { return Data_rozhdeniya; }
            set { Data_rozhdeniya = value; }
        }
        public string PassPasportnie_dannie
        {
            get { return Pasportnie_dannie; }
            set { Pasportnie_dannie = value; }
        }
        public string PassLogin
        {
            get { return Login; }
            set { Login = value; }
        }
        public string PassParol
        {
            get { return Parol; }
            set { Parol = value; }
        }
        public string PassRol
        {
            get { return Rol; }
            set { Rol = value; }
        }
        public Form_Sotrudniki()
        {
            InitializeComponent();
            
        }
        private void Form_Sotrudniki_Activated(object sender, EventArgs e)
        {

            int n = dataGridView_sotr.Rows.Add();
            dataGridView_sotr.Rows[n].Cells[0].Value = ID_sotrudnika;
            dataGridView_sotr.Rows[n].Cells[1].Value = Imya;
            dataGridView_sotr.Rows[n].Cells[2].Value = Familiya;
            dataGridView_sotr.Rows[n].Cells[3].Value = Otchestvo;
            dataGridView_sotr.Rows[n].Cells[3].Value = Nomer_telefona;
            dataGridView_sotr.Rows[n].Cells[2].Value = ID_dolgnosti;
            dataGridView_sotr.Rows[n].Cells[3].Value = Data_rozhdeniya;
            dataGridView_sotr.Rows[n].Cells[3].Value = Pasportnie_dannie;
            dataGridView_sotr.Rows[n].Cells[3].Value = Login;
            dataGridView_sotr.Rows[n].Cells[2].Value = Parol;
            dataGridView_sotr.Rows[n].Cells[3].Value = Rol;
        }
        private void Form_Sotrudniki_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fluere1DataSet7.Sotrudniki". При необходимости она может быть перемещена или удалена.
            this.sotrudnikiTableAdapter4.Fill(this.fluere1DataSet7.Sotrudniki);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fluere1DataSet2.Sotrudniki". При необходимости она может быть перемещена или удалена.
        }
        private void Form_Activated(object sender, EventArgs e)
        {
            
        }

        private void таблицыToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void договорыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Dogovori form1 = new Form_Dogovori();
            form1.Show();
            this.Hide();
        }

        private void новыйДоговорToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Novii_dogovor form2 = new Form_Novii_dogovor();
            form2.Show();
            this.Hide();
        }

        private void button_novii_sotrudnik_Click(object sender, EventArgs e)
        {
            Form_Novii_sotrudnik form3 = new Form_Novii_sotrudnik();
            form3.Show();
            this.Hide();
        }

        private void dataGridView_sotr_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       
        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_spravka sprav = new Form_spravka();
            sprav.Show();
        }

        private void составToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Sostav form4 = new Form_Sostav();
            form4.Show();
            this.Hide();
        }

     

        private void предметЗалогаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Predmet_zaloga form6 = new Form_Predmet_zaloga();
            form6.Show();
            this.Hide();
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void sotrudnikiBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            string query = "SELECT ID_sotrudnika, Familia, Imya, Otchestvo, Nomer_telefona, Dolgnosti.Dolgnost_sotr, Data_rozhdeniya, Pasportnie_dannie, login, parol, rol FROM [Sotrudniki] inner join [Dolgnosti] on Sotrudniki.ID_dolgnosti = Dolgnosti.ID_dolgnosti";
            SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-K6O5APB7;Initial Catalog=Fluere1;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView_sotr.RowHeadersVisible = false;
            dataGridView_sotr.DataSource = table;
            dataGridView_sotr.Columns[0].HeaderCell.Value = "Номер сотрудника";
            dataGridView_sotr.Columns[0].Width = 30;
            dataGridView_sotr.Columns[1].HeaderCell.Value = "Фамилия сотрудника";
            dataGridView_sotr.Columns[1].Width = 150;
            dataGridView_sotr.Columns[2].HeaderCell.Value = "Имя сотрудника";
            dataGridView_sotr.Columns[2].Width = 120;
            dataGridView_sotr.Columns[3].HeaderCell.Value = "Отчество сотрудника";
            dataGridView_sotr.Columns[3].Width = 170;
            dataGridView_sotr.Columns[4].HeaderCell.Value = "Номер телефона";
            dataGridView_sotr.Columns[4].Width = 120;
            dataGridView_sotr.Columns[5].HeaderCell.Value = "Должность сотрудника";
            dataGridView_sotr.Columns[5].Width = 120;
            dataGridView_sotr.Columns[6].HeaderCell.Value = "Дата рождения";
            dataGridView_sotr.Columns[6].Width = 120;
            dataGridView_sotr.Columns[7].HeaderCell.Value = "Паспортные данные";
            dataGridView_sotr.Columns[7].Width = 120;
            dataGridView_sotr.Columns[8].HeaderCell.Value = "Логин";
            dataGridView_sotr.Columns[8].Width = 120;
            dataGridView_sotr.Columns[9].HeaderCell.Value = "Пароль";
            dataGridView_sotr.Columns[9].Width = 120;
            dataGridView_sotr.Columns[10].HeaderCell.Value = "Роль";
            dataGridView_sotr.Columns[10].Width = 120;
            connection.Close();
        }
    }
}

