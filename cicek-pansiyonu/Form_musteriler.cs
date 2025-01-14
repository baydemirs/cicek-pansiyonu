using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace cicek_pansiyonu
{
    public partial class Form_musteriler : XtraForm
    {
        private readonly string connectionString = ProgramDatabaseConfig.ConnectionString;
        private int musteriId = 0; // Tanımlandı
        private int odaId = 0;     // Tanımlandı

        public Form_musteriler()
        {
            InitializeComponent();
        }
        
        private void Form_musteriler_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde label11'i gizle
            label11.Visible = false;
        }

        private void MstGoster_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string query = "SELECT * FROM Müşteriler";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                gridControl1.DataSource = dataTable;
            }
        }

        private void GridVerileriniYenile()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string query = "SELECT * FROM Müşteriler";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                gridControl1.DataSource = dataTable;
            }
        }


        private void MüsteriyiBul_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                // Dinamik sorgu oluşturma
                string query = "SELECT * FROM Müşteriler WHERE 1=1"; // 1=1 tüm koşulların başlangıcı için
                if (!string.IsNullOrWhiteSpace(TxtBulAdi.Text))
                {
                    query += " AND adı LIKE @adi";
                }
                if (!string.IsNullOrWhiteSpace(TxtBulTel.Text))
                {
                    query += " AND telefon LIKE @telefon";
                }
                if (!string.IsNullOrWhiteSpace(TxtBulTC.Text))
                {
                    query += " AND tc_kimlik_no LIKE @tcKimlik";
                }

                SQLiteCommand command = new SQLiteCommand(query, connection);

                // Girilen değerlere göre parametre ekleme
                if (!string.IsNullOrWhiteSpace(TxtBulAdi.Text))
                {
                    command.Parameters.AddWithValue("@adi", $"%{TxtBulAdi.Text}%");
                }
                if (!string.IsNullOrWhiteSpace(TxtBulTel.Text))
                {
                    command.Parameters.AddWithValue("@telefon", $"%{TxtBulTel.Text}%");
                }
                if (!string.IsNullOrWhiteSpace(TxtBulTC.Text))
                {
                    command.Parameters.AddWithValue("@tcKimlik", $"%{TxtBulTC.Text}%");
                }

                // Verileri DataTable'a yükleme
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // GridControl'e yükleme
                gridControl1.DataSource = dataTable;

                // Sonuç yoksa kullanıcıya bildirim
                if (dataTable.Rows.Count == 0)
                {
                    XtraMessageBox.Show("Hiçbir kayıt bulunamadı.", "Arama Sonucu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            int[] selectedRowHandles = gridView1.GetSelectedRows();
            if (selectedRowHandles.Length > 0)
            {
                DataRow row = gridView1.GetDataRow(selectedRowHandles[0]);
                Txtadi.Text = row["adı"].ToString();
                TxtSoyadi.Text = row["soyadı"].ToString();
                comboBoxEdit1.Text = row["cinsiyet"].ToString();
                TxtMail.Text = row["mail"].ToString();
                MskTxtTelefon.Text = row["telefon"].ToString();
                TxtKimlikNo.Text = row["tc_kimlik_no"].ToString();
                TxtOdaNo.Text = row["oda_id"].ToString();
                TxtUcret.Text = row["ücret"].ToString();
                DtpGirisTarihi.Value = Convert.ToDateTime(row["giriş_tarihi"]);
                DtpCikisTarihi.Value = Convert.ToDateTime(row["çıkış_tarihi"]);

                
                // Hafızada saklanacak ID'ler
                musteriId = Convert.ToInt32(row["müşteri_id"]); // müşteriID yerine musteriId
               // musteriId = Convert.ToInt32(row["müşteri_id"]); // Değer doğru okunmalı
                odaId = Convert.ToInt32(row["oda_id"]);         // odaID yerine odaId
            }
        }

        private void MstSil_Click(object sender, EventArgs e)
        {
            if (musteriId > 0 && odaId > 0)
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    SQLiteTransaction transaction = connection.BeginTransaction();

                    try
                    {
                        // Oda doluluk durumunu güncelle
                        string updateRoomQuery = "UPDATE Odalar SET doluluk_durumu = 0 WHERE oda_id = @odaID";
                        SQLiteCommand updateRoomCommand = new SQLiteCommand(updateRoomQuery, connection);
                        updateRoomCommand.Parameters.AddWithValue("@odaID", odaId);
                        updateRoomCommand.ExecuteNonQuery();

                        // Müşteriyi sil
                        string deleteCustomerQuery = "DELETE FROM Müşteriler WHERE müşteri_id = @müşteriID";
                        SQLiteCommand deleteCustomerCommand = new SQLiteCommand(deleteCustomerQuery, connection);
                        deleteCustomerCommand.Parameters.AddWithValue("@müşteriID", musteriId);
                        deleteCustomerCommand.ExecuteNonQuery();

                        transaction.Commit();
                        XtraMessageBox.Show("Müşteri başarıyla silindi.");
                        // GridControl verilerini yenile
                        GridVerileriniYenile();
                    }
                    catch
                    {
                        transaction.Rollback();
                        XtraMessageBox.Show("Bir hata oluştu.");
                    }
                }
            }
            else
            {
                XtraMessageBox.Show("Lütfen silmek için bir müşteri seçin.");
            }
        }

        private void DtpGirisTarihi_ValueChanged(object sender, EventArgs e)
        {
            DtpCikisTarihi.MinDate = DtpGirisTarihi.Value;
            DtpCikisTarihi.Value = DtpGirisTarihi.Value;
            DtpCikisTarihi.Enabled = true;
            HesaplaUcret();
        }
        private void HesaplaUcret()
        {
            if (DtpGirisTarihi.Value <= DtpCikisTarihi.Value && odaId > 0)
            {
                TimeSpan fark = DtpCikisTarihi.Value - DtpGirisTarihi.Value;
                int gunSayisi = fark.Days == 0 ? 1 : fark.Days;
                // Gün farkını label11'e yazdır
                label11.Text = $"Gün Sayısı: {gunSayisi}";
                label11.Visible = true;

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    string query = "SELECT fiyat FROM Odalar WHERE oda_id = @odaID";
                    SQLiteCommand command = new SQLiteCommand(query, connection);
                    command.Parameters.AddWithValue("@odaID", odaId);
                    connection.Open();

                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        decimal fiyat = Convert.ToDecimal(result);
                        decimal toplamUcret = fiyat * gunSayisi;
                        TxtUcret.Text = toplamUcret.ToString("0.00");
                    }
                }
            }
        }

        private void MstGuncelle_Click(object sender, EventArgs e)
        {
            // Alanların boş olup olmadığını kontrol edin
            if (string.IsNullOrWhiteSpace(Txtadi.Text) || string.IsNullOrWhiteSpace(TxtSoyadi.Text))
            {
                XtraMessageBox.Show("Ad ve Soyad alanları boş bırakılamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Seçili müşteri_id kontrolü
            if (musteriId > 0) // musteriId, global bir değişken olarak tanımlı olmalı
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    string query = "UPDATE Müşteriler SET adı = @adi, soyadı = @soyadi, cinsiyet = @cinsiyet, " +
                                   "giriş_tarihi = @giris, çıkış_tarihi = @cikis, ücret = @ucret WHERE müşteri_id = @musteriId";

                    SQLiteCommand command = new SQLiteCommand(query, connection);
                    command.Parameters.AddWithValue("@adi", Txtadi.Text);
                    command.Parameters.AddWithValue("@soyadi", TxtSoyadi.Text);
                    command.Parameters.AddWithValue("@cinsiyet", comboBoxEdit1.Text);
                    command.Parameters.AddWithValue("@giris", DtpGirisTarihi.Value);
                    command.Parameters.AddWithValue("@cikis", DtpCikisTarihi.Value);
                    command.Parameters.AddWithValue("@ucret", Convert.ToDecimal(TxtUcret.Text));
                    command.Parameters.AddWithValue("@musteriId", musteriId);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        XtraMessageBox.Show("Müşteri bilgileri başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // GridControl verilerini yenile
                        GridVerileriniYenile();
                    }
                    else
                    {
                        XtraMessageBox.Show("Güncelleme sırasında bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                XtraMessageBox.Show("Lütfen önce bir müşteri seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void DtpCikisTarihi_ValueChanged(object sender, EventArgs e)
        {
            HesaplaUcret();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
