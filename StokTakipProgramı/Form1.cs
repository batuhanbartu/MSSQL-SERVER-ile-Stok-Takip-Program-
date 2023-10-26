using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;    


namespace StokTakipProgramı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection bagla = new SqlConnection("Data Source=\". \\sqlexpress\";Initial Catalog=StokTakip;Integrated Security=True");
        public void verileriGöster(string veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler, bagla);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void button1_Click(object sender, EventArgs e)
        {
            verileriGöster("select * from StokTakipTablosu");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bagla.Open();
            SqlCommand komut = new SqlCommand("insert into StokTakipTablosu(Kod, Ad, AlışFiyatı, SatışFiyatı, Birim, Miktar, Tarih) values (@Kod,@Ad,@AlışFiyatı,@SatışFiyatı,@Birim,@Miktar,@Tarih)", bagla);
            komut.Parameters.AddWithValue("@Kod", textBox1.Text);
            komut.Parameters.AddWithValue("@Ad", textBox2.Text);
            komut.Parameters.AddWithValue("@AlışFiyatı", textBox3.Text);
            komut.Parameters.AddWithValue("@SatışFiyatı", textBox4.Text);
            komut.Parameters.AddWithValue("@Birim", textBox5.Text);
            komut.Parameters.AddWithValue("@Miktar", textBox6.Text);
            komut.Parameters.AddWithValue("@Tarih", textBox7.Text);
            komut.ExecuteNonQuery();
            verileriGöster("Select * from StokTakipTablosu");
            bagla.Close();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
        }
    }
}
