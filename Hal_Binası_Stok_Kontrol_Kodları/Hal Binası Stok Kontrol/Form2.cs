using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Hal_Binası_Stok_Kontrol
{
    public partial class Satıs : Form
    {
       
        public Satıs()
        {
            InitializeComponent();
          
        }
       
        
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-ELP0PA5\\SQLEXPRESS;Initial Catalog=HalBinası;Integrated Security=True");


        private void pictureBox1_Click(object sender, EventArgs e) {
            baglanti.Open(); SqlCommand komut = new SqlCommand("SELECT KgFiyat FROM Ürünler WHERE Ürünler = @Armut;", baglanti); komut.Parameters.AddWithValue("@Armut", "Armut"); SqlDataReader dr1 = komut.ExecuteReader(); while (dr1.Read())
            { textBox4.Text = dr1["KgFiyat"].ToString(); }
             baglanti.Close(); textBox3.Text = " ARMUT ";}
        private void pictureBox2_Click(object sender, EventArgs e)  {
            baglanti.Open(); SqlCommand komut = new SqlCommand("SELECT KgFiyat FROM Ürünler WHERE Ürünler = @Mandalina;", baglanti); komut.Parameters.AddWithValue("@Mandalina", "Mandalina"); SqlDataReader dr1 = komut.ExecuteReader(); while (dr1.Read())
            {  textBox4.Text = dr1["KgFiyat"].ToString(); }
            baglanti.Close(); textBox3.Text = " MANDALİNA "; }
        private void pictureBox3_Click(object sender, EventArgs e)  { 
            baglanti.Open(); SqlCommand komut = new SqlCommand("SELECT KgFiyat FROM Ürünler WHERE Ürünler = @Elma;", baglanti); komut.Parameters.AddWithValue("@Elma", "Elma"); SqlDataReader dr1 = komut.ExecuteReader(); while (dr1.Read())
            { textBox4.Text = dr1["KgFiyat"].ToString();   }
            baglanti.Close(); textBox3.Text = " ELMA "; }
        private void pictureBox4_Click(object sender, EventArgs e) {
            baglanti.Open(); SqlCommand komut = new SqlCommand("SELECT KgFiyat FROM Ürünler WHERE Ürünler = @Muz;", baglanti); komut.Parameters.AddWithValue("@Muz", "Muz"); SqlDataReader dr1 = komut.ExecuteReader(); while (dr1.Read())
            {  textBox4.Text = dr1["KgFiyat"].ToString();   }
            baglanti.Close(); textBox3.Text = " MUZ "; }
        private void pictureBox5_Click(object sender, EventArgs e) {
            baglanti.Open(); SqlCommand komut = new SqlCommand("SELECT KgFiyat FROM Ürünler WHERE Ürünler = @Üzüm;", baglanti); komut.Parameters.AddWithValue("@Üzüm", "Üzüm"); SqlDataReader dr1 = komut.ExecuteReader(); while (dr1.Read())
            { textBox4.Text = dr1["KgFiyat"].ToString();   }
            baglanti.Close(); textBox3.Text = " ÜZÜM "; }
        private void pictureBox11_Click(object sender, EventArgs e) {
            baglanti.Open(); SqlCommand komut = new SqlCommand("SELECT KgFiyat FROM Ürünler WHERE Ürünler = @Çilek;", baglanti); komut.Parameters.AddWithValue("@Çilek", "Çilek"); SqlDataReader dr1 = komut.ExecuteReader(); while (dr1.Read())
            { textBox4.Text = dr1["KgFiyat"].ToString(); }
            baglanti.Close(); textBox3.Text = " ÇİLEK "; }
        private void pictureBox12_Click(object sender, EventArgs e) {
            baglanti.Open(); SqlCommand komut = new SqlCommand("SELECT KgFiyat FROM Ürünler WHERE Ürünler = @Kivi;", baglanti); komut.Parameters.AddWithValue("@Kivi", "Kivi"); SqlDataReader dr1 = komut.ExecuteReader(); while (dr1.Read())
            { textBox4.Text = dr1["KgFiyat"].ToString();   }
            baglanti.Close(); textBox3.Text = " KİVİ "; }
        private void pictureBox13_Click(object sender, EventArgs e) {
            baglanti.Open(); SqlCommand komut = new SqlCommand("SELECT KgFiyat FROM Ürünler WHERE Ürünler = @Şeftali;", baglanti); komut.Parameters.AddWithValue("@Şeftali", "Şeftali"); SqlDataReader dr1 = komut.ExecuteReader(); while (dr1.Read())
            { textBox4.Text = dr1["KgFiyat"].ToString();  }
            baglanti.Close(); textBox3.Text = " ŞEFTALİ "; }
        private void pictureBox14_Click(object sender, EventArgs e) {
            baglanti.Open(); SqlCommand komut = new SqlCommand("SELECT KgFiyat FROM Ürünler WHERE Ürünler = @Böğürtlen;", baglanti); komut.Parameters.AddWithValue("@Böğürtlen", "Böğürtlen"); SqlDataReader dr1 = komut.ExecuteReader(); while (dr1.Read())
            { textBox4.Text = dr1["KgFiyat"].ToString();   }
            baglanti.Close(); textBox3.Text = " BÖĞÜRTLEN "; }
        private void pictureBox15_Click(object sender, EventArgs e) {
            baglanti.Open(); SqlCommand komut = new SqlCommand("SELECT KgFiyat FROM Ürünler WHERE Ürünler = @Portakal;", baglanti); komut.Parameters.AddWithValue("@Portakal", "Portakal"); SqlDataReader dr1 = komut.ExecuteReader(); while (dr1.Read())
            {  textBox4.Text = dr1["KgFiyat"].ToString();  }
            baglanti.Close(); textBox3.Text = " PORTAKAL "; }
        private void pictureBox6_Click(object sender, EventArgs e) {
            baglanti.Open(); SqlCommand komut = new SqlCommand("SELECT KgFiyat FROM Ürünler WHERE Ürünler = @Salatalık ;", baglanti); komut.Parameters.AddWithValue("Salatalık", "Salatalık"); SqlDataReader dr1 = komut.ExecuteReader(); while (dr1.Read())
            {  textBox4.Text = dr1["KgFiyat"].ToString();  }
            baglanti.Close(); textBox3.Text = " SALATALIK "; }
        private void pictureBox7_Click(object sender, EventArgs e) {
            baglanti.Open(); SqlCommand komut = new SqlCommand("SELECT KgFiyat FROM Ürünler WHERE Ürünler = @Domates;", baglanti); komut.Parameters.AddWithValue("@Domates", "Domates"); SqlDataReader dr1 = komut.ExecuteReader(); while (dr1.Read())
            { textBox4.Text = dr1["KgFiyat"].ToString();   }
            baglanti.Close(); textBox3.Text = " DOMATES "; }
        private void pictureBox8_Click(object sender, EventArgs e) {
            baglanti.Open(); SqlCommand komut = new SqlCommand("SELECT KgFiyat FROM Ürünler WHERE Ürünler = @Patlıcan;", baglanti); komut.Parameters.AddWithValue("@Patlıcan", "Patlıcan"); SqlDataReader dr1 = komut.ExecuteReader(); while (dr1.Read())
            { textBox4.Text = dr1["KgFiyat"].ToString(); }
            baglanti.Close(); textBox3.Text = " PATLICAN "; }
        private void pictureBox9_Click(object sender, EventArgs e) {
            baglanti.Open(); SqlCommand komut = new SqlCommand("SELECT KgFiyat FROM Ürünler WHERE Ürünler = @Biber;", baglanti); komut.Parameters.AddWithValue("@Biber", "Biber"); SqlDataReader dr1 = komut.ExecuteReader(); while (dr1.Read())
            { textBox4.Text = dr1["KgFiyat"].ToString(); }
            baglanti.Close(); textBox3.Text = " BİBER "; }
        private void pictureBox10_Click(object sender, EventArgs e) {
            baglanti.Open(); SqlCommand komut = new SqlCommand("SELECT KgFiyat FROM Ürünler WHERE Ürünler = @Karnıbahar;", baglanti); komut.Parameters.AddWithValue("@Karnıbahar", "Karnıbahar"); SqlDataReader dr1 = komut.ExecuteReader(); while (dr1.Read())
            { textBox4.Text = dr1["KgFiyat"].ToString(); }
            baglanti.Close(); textBox3.Text = " KARNIBAHAR "; }
        private void pictureBox16_Click(object sender, EventArgs e) {
            baglanti.Open(); SqlCommand komut = new SqlCommand("SELECT KgFiyat FROM Ürünler WHERE Ürünler = @Havuç;", baglanti); komut.Parameters.AddWithValue("@Havuç", "Havuç"); SqlDataReader dr1 = komut.ExecuteReader(); while (dr1.Read())
            { textBox4.Text = dr1["KgFiyat"].ToString();  }
            baglanti.Close(); textBox3.Text = " HAVUÇ "; }
        private void pictureBox17_Click(object sender, EventArgs e) {
            baglanti.Open(); SqlCommand komut = new SqlCommand("SELECT KgFiyat FROM Ürünler WHERE Ürünler = @Karalahana;", baglanti); komut.Parameters.AddWithValue("@Karalahana", "Karalahana"); SqlDataReader dr1 = komut.ExecuteReader(); while (dr1.Read())
            { textBox4.Text = dr1["KgFiyat"].ToString(); }
            baglanti.Close(); textBox3.Text = " KARALAHANA "; }
        private void pictureBox18_Click(object sender, EventArgs e) {
            baglanti.Open(); SqlCommand komut = new SqlCommand("SELECT KgFiyat FROM Ürünler WHERE Ürünler = @Brokoli;", baglanti); komut.Parameters.AddWithValue("@Brokoli", "Brokoli"); SqlDataReader dr1 = komut.ExecuteReader(); while (dr1.Read())
            {  textBox4.Text = dr1["KgFiyat"].ToString();  }
            baglanti.Close(); textBox3.Text = " BROKOLİ "; }
        private void pictureBox19_Click(object sender, EventArgs e) {
            baglanti.Open(); SqlCommand komut = new SqlCommand("SELECT KgFiyat FROM Ürünler WHERE Ürünler = @Limon;", baglanti); komut.Parameters.AddWithValue("@Limon", "Limon"); SqlDataReader dr1 = komut.ExecuteReader(); while (dr1.Read())
            {  textBox4.Text = dr1["KgFiyat"].ToString(); }
            baglanti.Close(); textBox3.Text = " LİMON "; }
        private void pictureBox20_Click(object sender, EventArgs e) {
            baglanti.Open(); SqlCommand komut = new SqlCommand("SELECT KgFiyat FROM Ürünler WHERE Ürünler = @Turp;", baglanti); komut.Parameters.AddWithValue("@Turp", "Turp"); SqlDataReader dr1 = komut.ExecuteReader(); while (dr1.Read())
            { textBox4.Text = dr1["KgFiyat"].ToString(); }
            baglanti.Close(); textBox3.Text = " TURP "; }
        private void pictureBox21_Click(object sender, EventArgs e) {
            baglanti.Open(); SqlCommand komut = new SqlCommand("SELECT KgFiyat FROM Ürünler WHERE Ürünler = @Ayva;", baglanti); komut.Parameters.AddWithValue("@Ayva", "Ayva"); SqlDataReader dr1 = komut.ExecuteReader(); while (dr1.Read())
            { textBox4.Text = dr1["KgFiyat"].ToString();  }
            baglanti.Close(); textBox3.Text = " AYVA "; }
        private void pictureBox22_Click(object sender, EventArgs e) {
            baglanti.Open(); SqlCommand komut = new SqlCommand("SELECT KgFiyat FROM Ürünler WHERE Ürünler = @Vişne;", baglanti); komut.Parameters.AddWithValue("@Vişne", "Vişne"); SqlDataReader dr1 = komut.ExecuteReader(); while (dr1.Read())
            { textBox4.Text = dr1["KgFiyat"].ToString(); }
            baglanti.Close(); textBox3.Text = " VİŞNE "; }
        private void pictureBox23_Click(object sender, EventArgs e) {
            baglanti.Open(); SqlCommand komut = new SqlCommand("SELECT KgFiyat FROM Ürünler WHERE Ürünler = @Kabak;", baglanti); komut.Parameters.AddWithValue("@Kabak", "Kabak"); SqlDataReader dr1 = komut.ExecuteReader(); while (dr1.Read())
            { textBox4.Text = dr1["KgFiyat"].ToString();}
            baglanti.Close(); textBox3.Text = " KABAK "; }
        private void pictureBox24_Click(object sender, EventArgs e) {
            baglanti.Open(); SqlCommand komut = new SqlCommand("SELECT KgFiyat FROM Ürünler WHERE Ürünler = @Patates;", baglanti); komut.Parameters.AddWithValue("@Patates", "Patates"); SqlDataReader dr1 = komut.ExecuteReader(); while (dr1.Read())
            { textBox4.Text = dr1["KgFiyat"].ToString();  }
            baglanti.Close(); textBox3.Text = " PATATES "; }

        private void fiyatGnclle_Click(object sender, EventArgs e)
        { 
            {
                string text = textBox3.Text;
                text = text.Trim();
                if (text.Equals("ARMUT")|| text.Equals("ELMA")|| text.Equals("MANDALİNA")|| text.Equals("MUZ")|| text.Equals("ÜZÜM")|| text.Equals("AYVA")|| text.Equals("ÇİLEK") || text.Equals("KİVİ") || text.Equals("ŞEFTALİ") || text.Equals("BÖĞÜRTLEN") || text.Equals("PORTAKAL") || text.Equals("VİŞNE")
                || text.Equals("SALATALIK") || text.Equals("DOMATES") || text.Equals("PATLICAN") || text.Equals("BİBER") || text.Equals("KARNIBAHAR") || text.Equals("KABAK") || text.Equals("HAVUÇ") || text.Equals("KARALAHANA") || text.Equals("BROKOLİ") || text.Equals("LİMON") || text.Equals("TURP") || text.Equals("PATATES"))
                {

                    baglanti.Open(); SqlCommand guncelle = new SqlCommand("UPDATE Ürünler SET KgFiyat =@YeniFiyat WHERE Ürünler=@Ürün ", baglanti);
                    guncelle.Parameters.AddWithValue("@Ürün", text); guncelle.Parameters.AddWithValue("@YeniFiyat", int.Parse(textBox4.Text));
                    guncelle.ExecuteReader(); baglanti.Close();
                }
         
            }
            MessageBox.Show("Ürün Fiyatı Başarılı Bir Şekilde Değiştirildi ..!");
        }


        public static string GidenTutar = "";
        public static int RaporGidenTutar=0;
        public static string GidenBilgi1 = "";
        public static string GidenBilgi2 = "";
        public static string GidenBilgi3 = "";
        int toplam3 = 0;
        int toplam1 = 0;
        int toplam2 = 0;

        public void satis_Click(object sender, EventArgs e)
        {
                DateTime tarihsaat = new DateTime();
                tarihsaat = DateTime.Now;

            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(textBox3.Text) ||
               (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked))
            {
                MessageBox.Show("Lütfen Tüm Metin Kutularını Doldurun ve Kasa Hacmi Seçin.");
            }

            int a;
            try
            {
                a = Convert.ToInt32(textBox1.Text);
                
            }
            catch (FormatException ex)
            {         
                return;   
            }


            int b = Convert.ToInt32(textBox4.Text);
                // int a = Convert.ToInt32(textBox1.Text);

                int dusurulecekSayi = a;
                int dusurulecekKg = a;

                string text = textBox3.Text;
                text = text.Trim();
        

            if (radioButton1.Checked)
                {
              
                // StokKg Düşüş Kodu
                baglanti.Open();
                    SqlCommand getirr = new SqlCommand("SELECT StokKg FROM Ürünler WHERE Ürünler = @ürünadi", baglanti);
                    getirr.Parameters.AddWithValue("@ürünadi", text);

                    using (SqlDataReader dr1 = getirr.ExecuteReader())
                    {
                        if (dr1.Read())
                        {
                            // Mevcut ürünün StokKg sayısını al
                            int stok = Convert.ToInt32(dr1["StokKg"]); dr1.Close();
                            if (stok > 0)
                            {
                                int mevcutStok = stok;

                                using (SqlCommand guncel = new SqlCommand("UPDATE Ürünler SET StokKg=@yenikg WHERE Ürünler=@ürünAdi", baglanti))
                                {
                                    // Yeni Stok sayısını hesapla ve parametre olarak ekle
                                    int yeniStok = mevcutStok - dusurulecekKg * 20;
                                    
                                        guncel.Parameters.AddWithValue("@ürünAdi", text);
                                        guncel.Parameters.AddWithValue("@yenikg", yeniStok);
                                        guncel.ExecuteNonQuery();
                                    
                                       baglanti.Close();
                                      // Kasa Sayısı Düşüş Kodu
                                      baglanti.Open();
                                      SqlCommand getir = new SqlCommand("SELECT KalanAdet FROM Kasalar WHERE KasaAdı = @kasaAdi", baglanti);
                                      getir.Parameters.AddWithValue("@kasaAdi", "BüyükKasa");

                                      using (SqlDataReader dr = getir.ExecuteReader())
                                      {
                                        if (dr.Read())
                                        {
                                           
                                            // Mevcut büyükKasa sayısını al
                                            int mevcutBüyükKasa = Convert.ToInt32(dr["KalanAdet"]); dr.Close();
                                            if (mevcutBüyükKasa > 0)
                                            {
                                                using (SqlCommand guncell = new SqlCommand("UPDATE Kasalar SET KalanAdet=@yenisayi WHERE KasaAdı=@adı", baglanti))
                                                {
                                                    // Yeni büyükKasa sayısını hesapla ve parametre olarak ekle
                                                    int yeniBüyükKasa = mevcutBüyükKasa - dusurulecekSayi;
                                                    guncell.Parameters.AddWithValue("@adı", "BüyükKasa");
                                                    guncell.Parameters.AddWithValue("@yenisayi", yeniBüyükKasa);
                                                    guncell.ExecuteNonQuery();

                                                    listBox1.Items.Add(tarihsaat + " 'de " + textBox2.Text + " " + a + " Adet Büyük Kasa Ve " + (20 * b * a) + " TL Değerinde " + textBox3.Text + " Satın Almıştır.");
                                                    toplam1 += 20 * b * a;

                                                    SqlCommand komut = new SqlCommand("insert into Tbl_Fatura(Rapor)values(@p1)", baglanti);
                                                    komut.Parameters.AddWithValue("@p1", tarihsaat + " 'de " + textBox2.Text + " "  + (20 * b * a) + " TL Değerinde " + textBox3.Text + " Satın Almıştır.");
                                                    komut.ExecuteNonQuery();
                                                    

                                                    string l = Convert.ToString(a + "  Adet Büyük Kasa  " + textBox3.Text + "      Fiyatı= " + (20 * b * a));

                                                    GidenBilgi1 += l + Environment.NewLine;
                                                    
                                                }

                                            }
                                            else if(mevcutBüyükKasa < 0 || mevcutBüyükKasa ==0)
                                            {
                                                MessageBox.Show("Büyük Kasa Bitti.");
                                            }
                                           
                                        }
                                      }
                                    baglanti.Close();

                                }
                                   
                                   
                                


                            }
                            else if (stok <0 ||stok == 0) { MessageBox.Show(text +"Ürün Stokta Kalmadı..!"); }
                        }
                    }
                    baglanti.Close();
          
                   
                }


                else if (radioButton2.Checked)
                {
                // StokKg Düşüş Kodu
                baglanti.Open();
                SqlCommand getirr = new SqlCommand("SELECT StokKg FROM Ürünler WHERE Ürünler = @ürünadi", baglanti);
                getirr.Parameters.AddWithValue("@ürünadi", text);

                using (SqlDataReader dr1 = getirr.ExecuteReader())
                {
                    if (dr1.Read())
                    {
                        // Mevcut ürünün StokKg sayısını al
                        int stok = Convert.ToInt32(dr1["StokKg"]);  dr1.Close();
                        if (stok > 0)
                        {
                            int mevcutStok = stok;

                            using (SqlCommand guncel = new SqlCommand("UPDATE Ürünler SET StokKg=@yenikg WHERE Ürünler=@ürünAdi", baglanti))
                            {
                                // Yeni Stok sayısını hesapla ve parametre olarak ekle
                                int yeniStok = mevcutStok - dusurulecekKg * 10;
                                
                                    guncel.Parameters.AddWithValue("@ürünAdi", text);
                                    guncel.Parameters.AddWithValue("@yenikg", yeniStok);
                                    guncel.ExecuteNonQuery();    

                                    baglanti.Close();

                                    // Kasa Sayısı Düşüş Kodu
                                    baglanti.Open();

                                    SqlCommand getir = new SqlCommand("SELECT KalanAdet FROM Kasalar WHERE KasaAdı = @kasaAdi", baglanti);
                                    getir.Parameters.AddWithValue("@kasaAdi", "OrtaKasa");

                                    using (SqlDataReader dr = getir.ExecuteReader())
                                    {
                                        if (dr.Read())
                                        {

                                            // Mevcut OrtaKasa sayısını al
                                            int mevcutOrtaKasa = Convert.ToInt32(dr["KalanAdet"]); dr.Close();
                                            if (mevcutOrtaKasa > 0)
                                            {
                                                using (SqlCommand guncell = new SqlCommand("UPDATE Kasalar SET KalanAdet=@yenisayi WHERE KasaAdı=@adı", baglanti))
                                                {
                                                    // Yeni OrtaKasa sayısını hesapla ve parametre olarak ekle
                                                    int yeniOrtaKasa = mevcutOrtaKasa - dusurulecekSayi;
                                                    guncell.Parameters.AddWithValue("@adı", "OrtaKasa");
                                                    guncell.Parameters.AddWithValue("@yenisayi", yeniOrtaKasa);
                                                    guncell.ExecuteNonQuery();

                                                    listBox1.Items.Add(tarihsaat + " 'de " + textBox2.Text + " " + a + " Adet Orta Kasa Ve " + (20 * b * a) + " TL Değerinde " + textBox3.Text + " Satın Almıştır.");
                                                    toplam1 += 20 * b * a;

                                                    SqlCommand komut = new SqlCommand("insert into Tbl_Fatura(Rapor)values(@p1)", baglanti);
                                                    komut.Parameters.AddWithValue("@p1", tarihsaat + " 'de " + textBox2.Text + " " +  (20 * b * a) + " TL Değerinde " + textBox3.Text + " Satın Almıştır.");
                                                    komut.ExecuteNonQuery();
                                                    

                                                    string h = Convert.ToString(a + "  Adet Orta Kasa  " + textBox3.Text + "      Fiyatı= " + (20 * b * a));
                                                    GidenBilgi2 += h + Environment.NewLine;

                                                }

                                            }
                                            else if (mevcutOrtaKasa < 0 || mevcutOrtaKasa == 0)
                                            {
                                                MessageBox.Show("Orta Kasa Bitti.");
                                            }

                                        }
                                    }
                                    baglanti.Close();
                               

                            }


                        }
                        else if (stok < 0 || stok == 0) { MessageBox.Show(text + "Ürün Stokta Kalmadı..!"); }
                    }
                }
                baglanti.Close();


            }


                else if (radioButton3.Checked)
                {
                // StokKg Düşüş Kodu
                baglanti.Open();
                SqlCommand getirr = new SqlCommand("SELECT StokKg FROM Ürünler WHERE Ürünler = @ürünadi", baglanti);
                getirr.Parameters.AddWithValue("@ürünadi", text);

                using (SqlDataReader dr1 = getirr.ExecuteReader())
                {
                    if (dr1.Read())
                    {
                        // Mevcut ürünün StokKg sayısını al
                        int stok = Convert.ToInt32(dr1["StokKg"]); dr1.Close();
                        if (stok > 0)
                        {
                            int mevcutStok = stok;

                            using (SqlCommand guncel = new SqlCommand("UPDATE Ürünler SET StokKg=@yenikg WHERE Ürünler=@ürünAdi", baglanti))
                            {
                                // Yeni Stok sayısını hesapla ve parametre olarak ekle
                                int yeniStok = mevcutStok - dusurulecekKg * 5;
                                
                                    guncel.Parameters.AddWithValue("@ürünAdi", text);
                                    guncel.Parameters.AddWithValue("@yenikg", yeniStok);
                                    guncel.ExecuteNonQuery();
                                    baglanti.Close();

                                    // Kasa Sayısı Düşüş Kodu
                                    baglanti.Open();

                                    SqlCommand getir = new SqlCommand("SELECT KalanAdet FROM Kasalar WHERE KasaAdı = @kasaAdi", baglanti);
                                    getir.Parameters.AddWithValue("@kasaAdi", "KüçükKasa");

                                    using (SqlDataReader dr = getir.ExecuteReader())
                                    {
                                        if (dr.Read())
                                        {

                                            // Mevcut KüçükKasa sayısını al
                                            int mevcutKüçükKasa = Convert.ToInt32(dr["KalanAdet"]); dr.Close();
                                            if (mevcutKüçükKasa > 0)
                                            {
                                                using (SqlCommand guncell = new SqlCommand("UPDATE Kasalar SET KalanAdet=@yenisayi WHERE KasaAdı=@adı", baglanti))
                                                {
                                                    // Yeni KüçükKasa sayısını hesapla ve parametre olarak ekle
                                                    int yeniKücükKasa = mevcutKüçükKasa - dusurulecekSayi;
                                                    guncell.Parameters.AddWithValue("@adı", "KüçükKasa");
                                                    guncell.Parameters.AddWithValue("@yenisayi", yeniKücükKasa);
                                                    guncell.ExecuteNonQuery();

                                                    listBox1.Items.Add(tarihsaat + " 'de " + textBox2.Text + " " + a + " Adet Küçük Kasa Ve " + (20 * b * a) + " TL Değerinde " + textBox3.Text + " Satın Almıştır.");
                                                    toplam1 += 20 * b * a;

                                                    SqlCommand komut = new SqlCommand("insert into Tbl_Fatura(Rapor)values(@p1)", baglanti);
                                                    komut.Parameters.AddWithValue("@p1", tarihsaat + " 'de " + textBox2.Text + " "  + (20 * b * a) + " TL Değerinde " + textBox3.Text + " Satın Almıştır.");
                                                    komut.ExecuteNonQuery();
                                                    

                                                    string s = Convert.ToString(a + "  Adet Küçük Kasa  " + textBox3.Text + "      Fiyatı= " + (20 * b * a));
                                                    GidenBilgi3 += s + Environment.NewLine;

                                                }

                                            }
                                            else if (mevcutKüçükKasa < 0 || mevcutKüçükKasa == 0)
                                            {
                                                MessageBox.Show("Küçük Kasa Bitti.");
                                            }

                                        }
                                    }
                                    baglanti.Close();
                               

                            }


                        }
                        else if (stok < 0 || stok == 0) { MessageBox.Show(text + "Ürün Stokta Kalmadı..!"); }
                    }
                }
                baglanti.Close();


            }

            int TOPLAM = (toplam1 + toplam2 + toplam3);
                label21.Text = TOPLAM.ToString();
                GidenTutar = label21.Text;

            RaporGidenTutar += TOPLAM;


        }
       
        

        private void button2_Click(object sender, EventArgs e)
        {    //TEMİZLE
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            listBox1.Items.Clear();
            label21.Text = "0";
            
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            textBox2.Focus();
        }
        
        private void urunEkle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-ELP0PA5\\SQLEXPRESS;Initial Catalog=HalBinası;Integrated Security=True");
            
            string text = textBox3.Text;
            text = text.Trim();
            
            int sayi = Convert.ToInt32(textBox1.Text);

            if (radioButton1.Checked)
            {
                if (text.Equals("PATLICAN") || text.Equals("BİBER") || text.Equals("LİMON") || text.Equals("SALATALIK") || text.Equals("DOMATES") || text.Equals("KARNIBAHAR") || text.Equals("KABAK") || text.Equals("HAVUÇ") || text.Equals("KARALAHANA") || text.Equals("BROKOLİ") || text.Equals("TURP") || text.Equals("PATATES")
                 || text.Equals("ARMUT") || text.Equals("MANDALİNA") || text.Equals("ELMA") || text.Equals("MUZ") || text.Equals("ÜZÜM") || text.Equals("AYVA") || text.Equals("ÇİLEK") || text.Equals("KİVİ") || text.Equals("ŞEFTALİ") || text.Equals("BÖĞÜRTLEN") || text.Equals("PORTAKAL") || text.Equals("VİŞNE"))
                {
                    baglanti.Open();
                    SqlCommand getir = new SqlCommand("SELECT StokKg FROM Ürünler WHERE Ürünler = @ürünAdi", baglanti);
                    getir.Parameters.AddWithValue("@ürünAdi", text);

                    using (SqlDataReader dr1 = getir.ExecuteReader())
                    {
                        if (dr1.HasRows)
                            dr1.Read();
                        {
                            // ürün stok sayısını al
                            int ürünStok = Convert.ToInt32(dr1["StokKg"]);
                            baglanti.Close();
                            baglanti.Open();
                            using (SqlCommand guncel = new SqlCommand("UPDATE Ürünler SET StokKg=@yeni WHERE Ürünler=@ürünAdi", baglanti))
                            {
                                // Yeni ürün stoğunu hesapla ve parametre olarak ekle
                                int yeniStok = ürünStok + (20 * sayi);
                                guncel.Parameters.AddWithValue("@ürünAdi", text);
                                guncel.Parameters.AddWithValue("@yeni", yeniStok);

                                int affectedRows = guncel.ExecuteNonQuery();
                                if (affectedRows > 0) { MessageBox.Show(text.ToString() + " Başarılı Bir Şekilde Stok'a Eklenmiştir !"); }
                                if (affectedRows == 0)
                                {
                                    MessageBox.Show(text.ToString() + " Stokta Bitti.");
                                }
                            }
                            baglanti.Close();
                        }
                    }

                }

                baglanti.Open();
                SqlCommand getirr = new SqlCommand("SELECT KalanAdet FROM Kasalar WHERE KasaAdı = @kasaAd", baglanti);
                getirr.Parameters.AddWithValue("@kasaAd", "BüyükKasa");
                using (SqlDataReader dr2 = getirr.ExecuteReader())
                {
                    if (dr2.Read())
                    {
                        //kalan büyük kasa sayısını al
                        int eskiKasaAdeti = Convert.ToInt32(dr2["KalanAdet"]);
                        // Yeni BüyükKasa sayısını parametre olarak ekle
                        int yeniBüyükKasa = eskiKasaAdeti + sayi;
                        baglanti.Close();
                        baglanti.Open();
                        using (SqlCommand guncel = new SqlCommand("UPDATE Kasalar SET KalanAdet=@yeniAdet WHERE KasaAdı=@kasaAd", baglanti))
                        {
                           
                            guncel.Parameters.AddWithValue("@kasaAd", "BüyükKasa");
                            guncel.Parameters.AddWithValue("@yeniAdet", yeniBüyükKasa);
                            guncel.ExecuteNonQuery();
                            baglanti.Close();
                        }

                    }
                }
              
            }
            if (radioButton2.Checked)
            {
                if (text.Equals("PATLICAN") || text.Equals("BİBER") || text.Equals("LİMON") || text.Equals("SALATALIK") || text.Equals("DOMATES") || text.Equals("KARNIBAHAR") || text.Equals("KABAK") || text.Equals("HAVUÇ") || text.Equals("KARALAHANA") || text.Equals("BROKOLİ") || text.Equals("TURP") || text.Equals("PATATES")
                 || text.Equals("ARMUT") || text.Equals("MANDALİNA") || text.Equals("ELMA") || text.Equals("MUZ") || text.Equals("ÜZÜM") || text.Equals("AYVA") || text.Equals("ÇİLEK") || text.Equals("KİVİ") || text.Equals("ŞEFTALİ") || text.Equals("BÖĞÜRTLEN") || text.Equals("PORTAKAL") || text.Equals("VİŞNE"))
                {
                    baglanti.Open();
                    SqlCommand getir = new SqlCommand("SELECT StokKg FROM Ürünler WHERE Ürünler = @ürünAdi", baglanti);
                    getir.Parameters.AddWithValue("@ürünAdi", text);

                    using (SqlDataReader dr1 = getir.ExecuteReader())
                    {
                        if (dr1.HasRows)
                        {
                            dr1.Read();
                            // ürün stok sayısını al
                            int ürünStok = Convert.ToInt32(dr1["StokKg"]);
                            baglanti.Close();
                            baglanti.Open();
                            using (SqlCommand guncel = new SqlCommand("UPDATE Ürünler SET StokKg=@yeni WHERE Ürünler=@ürünAdi", baglanti))
                            {
                                // Yeni ürün stoğunu hesapla ve parametre olarak ekle
                                int yeniStok = ürünStok + (10 * sayi);
                                guncel.Parameters.AddWithValue("@ürünAdi", text);
                                guncel.Parameters.AddWithValue("@yeni", yeniStok);

                                int affectedRows = guncel.ExecuteNonQuery();
                                if (affectedRows > 0) { MessageBox.Show(text.ToString() + " Başarılı Bir Şekilde Stok'a Eklenmiştir !"); }
                                if (affectedRows == 0)
                                {
                                    MessageBox.Show(text.ToString() + " Stokta Bitti.");
                                }
                            }
                            baglanti.Close();
                        }
                    }

                }
                baglanti.Open();
                SqlCommand getirr = new SqlCommand("SELECT KalanAdet FROM Kasalar WHERE KasaAdı = @kasaAd", baglanti);
                getirr.Parameters.AddWithValue("@kasaAd", "OrtaKasa");
                using (SqlDataReader dr2 = getirr.ExecuteReader())
                {
                    if (dr2.Read())
                    {
                        //kalan orta kasa sayısını al
                        int eskiKasaAdeti = Convert.ToInt32(dr2["KalanAdet"]);
                        // Yeni ortaKasa sayısını parametre olarak ekle
                        int yeniOrtaKasa = eskiKasaAdeti + sayi;
                        baglanti.Close();
                        baglanti.Open();
                        using (SqlCommand guncel = new SqlCommand("UPDATE Kasalar SET KalanAdet=@yeniAdet WHERE KasaAdı=@kasaAd", baglanti))
                        {

                            guncel.Parameters.AddWithValue("@kasaAd", "OrtaKasa");
                            guncel.Parameters.AddWithValue("@yeniAdet", yeniOrtaKasa);
                            guncel.ExecuteNonQuery();
                            baglanti.Close();
                        }

                    }
                }
            }

            else if (radioButton3.Checked)
            {
                if (text.Equals("PATLICAN") || text.Equals("BİBER") || text.Equals("LİMON") || text.Equals("SALATALIK") || text.Equals("DOMATES") || text.Equals("KARNIBAHAR") || text.Equals("KABAK") || text.Equals("HAVUÇ") || text.Equals("KARALAHANA") || text.Equals("BROKOLİ") || text.Equals("TURP") || text.Equals("PATATES")
                 || text.Equals("ARMUT") || text.Equals("MANDALİNA") || text.Equals("ELMA") || text.Equals("MUZ") || text.Equals("ÜZÜM") || text.Equals("AYVA") || text.Equals("ÇİLEK") || text.Equals("KİVİ") || text.Equals("ŞEFTALİ") || text.Equals("BÖĞÜRTLEN") || text.Equals("PORTAKAL") || text.Equals("VİŞNE"))
                {
                    baglanti.Open();
                    SqlCommand getir = new SqlCommand("SELECT StokKg FROM Ürünler WHERE Ürünler = @ürünAdi", baglanti);
                    getir.Parameters.AddWithValue("@ürünAdi", text);

                    using (SqlDataReader dr1 = getir.ExecuteReader())
                    {
                        if (dr1.HasRows)
                        {
                            dr1.Read();
                            // ürün stok sayısını al
                            int ürünStok = Convert.ToInt32(dr1["StokKg"]);
                            baglanti.Close();
                            baglanti.Open();
                            using (SqlCommand guncel = new SqlCommand("UPDATE Ürünler SET StokKg=@yeni WHERE Ürünler=@ürünAdi", baglanti))
                            {
                                // Yeni ürün stoğunu hesapla ve parametre olarak ekle
                                int yeniStok = ürünStok + (5 * sayi);
                                guncel.Parameters.AddWithValue("@ürünAdi", text);
                                guncel.Parameters.AddWithValue("@yeni", yeniStok);

                                int affectedRows = guncel.ExecuteNonQuery();
                                if (affectedRows > 0) { MessageBox.Show(text.ToString() + " Başarılı Bir Şekilde Stok'a Eklenmiştir !"); }
                                if (affectedRows == 0)
                                {
                                    MessageBox.Show(text.ToString() + " Stokta Bitti.");
                                }
                            }
                            baglanti.Close();
                        }
                    }

                }
                baglanti.Open();
                SqlCommand getirr = new SqlCommand("SELECT KalanAdet FROM Kasalar WHERE KasaAdı = @kasaAd", baglanti);
                getirr.Parameters.AddWithValue("@kasaAd", "KüçükKasa");
                using (SqlDataReader dr2 = getirr.ExecuteReader())
                {
                    if (dr2.Read())
                    {
                        //kalan küçük kasa sayısını al
                        int eskiKasaAdeti = Convert.ToInt32(dr2["KalanAdet"]);
                        // Yeni KüçükKasa sayısını parametre olarak ekle
                        int yeniKüçükKasa = eskiKasaAdeti + sayi;
                        baglanti.Close();
                        baglanti.Open();
                        using (SqlCommand guncel = new SqlCommand("UPDATE Kasalar SET KalanAdet=@yeniAdet WHERE KasaAdı=@kasaAd", baglanti))
                        {

                            guncel.Parameters.AddWithValue("@kasaAd", "KüçükKasa");
                            guncel.Parameters.AddWithValue("@yeniAdet", yeniKüçükKasa);
                            guncel.ExecuteNonQuery();
                            baglanti.Close();
                        }

                    }
                }
            }
        }


        private void pictureBox26_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            
            Form1 frm = new Form1();    
            frm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = ""; textBox4.Text = "";
            listBox1.Items.Clear();
            label21.Text = "0";
            radioButton1.Checked = false; radioButton2.Checked = false; radioButton3.Checked = false;
            toplam1 = 0; toplam2 = 0; toplam3 = 0;
            //Fatura
            FaturaGstr göster = new FaturaGstr();
            göster.Show();
        }
    }
}
