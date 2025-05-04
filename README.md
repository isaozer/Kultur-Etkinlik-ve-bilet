# 🎭 Kültür Etkinlik ve Bilet Satış Uygulaması

Bu proje, kültürel etkinlikler için geliştirilen bir **masaüstü bilet satış uygulamasıdır**. C# (Windows Forms) ve SQL Server kullanılarak oluşturulmuştur. Kullanıcılar etkinlikleri görüntüleyebilir, bilet satın alabilir ve geçmiş işlemlerini kontrol edebilir.

---

## 🧰 Kullanılan Teknolojiler

- 🧠 **Programlama Dili:** C# (.NET Framework)
- 🖥️ **Arayüz:** Windows Forms (Guna.UI2 ile şık tasarım)
- 🗄️ **Veri Tabanı:** MSSQL (SQL Server)
- 💽 **Veri İşlemleri:** ADO.NET (SqlConnection, SqlCommand)

---

## 📸 Ekran Görüntüleri

### 🔐 Giriş Ekranı
![Giriş Ekranı](https://resmim.net/cdn/2025/05/04/NPD0Gh.png)

### 📝 Kayıt Olma
![Kayıt Olma](https://resmim.net/cdn/2025/05/04/NPDQdc.png)

### 👤 Hesabım
![Hesabım](https://resmim.net/cdn/2025/05/04/NPDhXn.png)

### 📅 Etkinlik Listesi
![Etkinlik Listesi](https://resmim.net/cdn/2025/05/04/NPDAyy.png)

### 🛒 Bilet Satın Alma
![Bilet Satın Alma](https://resmim.net/cdn/2025/05/04/NPDPKb.png)

### 🎟️ Alınan Biletler
![Alınan Biletler](https://resmim.net/cdn/2025/05/04/NPD9z6.png)

### 🚪 Çıkış Yapma
![Çıkış](https://resmim.net/cdn/2025/05/04/NPDUjk.png)

### 🗃️ Veritabanı ve Tablolar
![Veritabanı](https://resmim.net/cdn/2025/05/04/NPDzJi.png)

---

## 🔍 Özellikler

- 🔐 Kullanıcı girişi ve kimlik doğrulama
- 🎫 Etkinlikleri listeleme
- 💳 Bilet satın alma (ödeme yöntemi seçimi)
- 📜 Önceden alınan bilet geçmişi
- 👁️‍🗨️ Kendi hesabını görüntüleme
- 🧾 Toplam tutar hesaplama

---

## 🏗️ Kurulum

1. Visual Studio ile projeyi açın.
2. MSSQL'de `KulturBiletSistemi` isimli veritabanını oluşturun.
3. Tablo yapısını yukarıdaki görseldeki gibi oluşturun veya `.sql` script dosyasını kullanın.
4. Aşağıdaki bağlantıyı kendi bilgisayarınıza göre güncelleyin:

```csharp
SqlConnection baglanti = new SqlConnection("Server=\\SQLEXPRESS;Database=KulturBiletSistemi;Trusted_Connection=True;");

📌 Geliştirici
İsa Özer
🎓 İstanbul Kültür Üniversitesi