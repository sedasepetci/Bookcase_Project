using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bookcase_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\fasla\OneDrive\Masaüstü\Kitaplik.mdb");
        void Listele()
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter da=new OleDbDataAdapter("Select * From Kitaplar",baglanti);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        string durum="";
        private void Form1_Load(object sender, EventArgs e)
        {
         
            Listele();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("insert into Kitaplar (KitapAd,Yazar,Sayfa,Tur,Durum) values (@a1,@a2,@a3,@4,@5)",baglanti);
            komut.Parameters.AddWithValue("@a1", TxtKitapAd.Text);
            komut.Parameters.AddWithValue("@a2",TxtYazar.Text);
            komut.Parameters.AddWithValue("@a3",TxtSayfa.Text);
            komut.Parameters.AddWithValue("@a4", CmbTur.Text);
            komut.Parameters.AddWithValue("@a5",durum);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap sisteme kaydedildi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Listele();
        }

        private void RdbKullanilmis_CheckedChanged(object sender, EventArgs e)
        {
            durum = "0";
        }

        private void RdbYeni_CheckedChanged(object sender, EventArgs e)
        {
            durum = "1";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtKitapid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtKitapAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtYazar.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            CmbTur.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtSayfa.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            if (dataGridView1.Rows[secilen].Cells[5].Value.ToString()=="True")
            {
                RdbYeni.Checked = true;
            }
            else
                RdbKullanilmis.Checked = true;
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut=new OleDbCommand("Delete From Kitaplar where Kitapid=@p1",baglanti);
            komut.Parameters.AddWithValue("@p1",TxtKitapid.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Listeden Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Listele();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Update Kitaplar set KitapAd=@p1,Yazar=@p2,Tur=@p3,Sayfa=@p4,Durum=@p5 where Kitapid=@p6", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtKitapAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtYazar.Text);
            komut.Parameters.AddWithValue("@p3", CmbTur.Text);
            komut.Parameters.AddWithValue("@p4", TxtSayfa.Text);

            if (RdbKullanilmis.Checked == true)
            {
                komut.Parameters.AddWithValue("@p5", durum);

            }
            if (RdbYeni.Checked == true)
            {
                komut.Parameters.AddWithValue("@p5", durum);
            }
            komut.Parameters.AddWithValue("@p6", TxtKitapid.Text);
            komut.ExecuteNonQuery() ;
            baglanti.Close();
            MessageBox.Show("Bilgileriniz güncellendi","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void BtnBul_Click(object sender, EventArgs e)
        {
           
            OleDbCommand komut = new OleDbCommand("Select * From Kitaplar where KitapAd=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1",TxtKitapBul.Text);
            DataTable dt=new DataTable();
            OleDbDataAdapter da=new OleDbDataAdapter(komut);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void BtnAra_Click(object sender, EventArgs e)
        {

            OleDbCommand komut = new OleDbCommand("Select * From Kitaplar where KitapAd like '%"+TxtKitapBul.Text+"%'", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtKitapBul.Text);
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void TxtKitapBul_KeyDown(object sender, KeyEventArgs e)
        {
         
        }
    }
}
