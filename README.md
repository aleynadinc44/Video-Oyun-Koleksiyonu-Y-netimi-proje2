 🎮 Video Oyun Koleksiyonu Yönetimi

Bu proje, kullanıcıların kendi video oyun koleksiyonlarını yönetebilecekleri bir **Windows Forms (C#)** uygulamasıdır. Uygulama, kullanıcı giriş/kayıt sistemi, oyun ekleme, yorum yapma ve oyun listesi görüntüleme gibi işlevler sunar. Arka planda **SQL Server** kullanılarak veriler güvenli bir şekilde saklanmaktadır.

       ✨ Özellikler

- 🔐 Kullanıcı kayıt ve giriş sistemi (E-posta + şifre doğrulama)
- 📚 Oyun koleksiyonu oluşturma ve listeleme
- 📝 Her oyun için yorum yapma ve puan verme
- 👤 Kayıtsız kullanıcılar için sınırlı erişim (göz atma modu)
- 📊 Oyun boyutlarının GB/MB cinsinden akıllı dönüştürülmesi
- 📌 Kullanıcıya özel karşılama ekranı

      🧰 Kullanılan Teknolojiler

- 💻 C# - Windows Forms
- 🗃️Microsoft SQL Server
- 🖼️ Visual Studio Designer ile arayüz geliştirme

      🗂️ Veritabanı Yapısı

Veritabanı adı: `videooyun`

**Tablolar**
 `kullanicilar` – Kullanıcı bilgilerini içerir (e-posta, şifre, ad, soyad, doğum tarihi)
- `oyunlar` – Oyun adı, türü, boyutu (GB,MB)
- `OyunYorum` – Oyun adı, puan, yorum
