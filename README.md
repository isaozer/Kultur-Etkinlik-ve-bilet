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
![Kayıt Olma](https://i.hizliresim.com/5mz0je8.jpg)

### 👤 Hesabım
![Hesabım](https://i.hizliresim.com/f067tju.png)

### 📅 Etkinlik Listesi
![Etkinlik Listesi](https://i.hizliresim.com/mm51l61.png)

### 🛒 Bilet Satın Alma
![Bilet Satın Alma](https://i.hizliresim.com/5iomw1a.png)

### 🎟️ Alınan Biletler
![Alınan Biletler](https://i.hizliresim.com/fpm53uo.png)

### 🚪 Çıkış Yapma
![Çıkış](https://i.hizliresim.com/ci79wj7.png)

### 🗃️ Veritabanı ve Tablolar
![Veritabanı](https://i.hizliresim.com/chdzfqk.png)

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