## Hastane Yönetim Sistemi

Bu proje, hastane süreçlerini dijital ortamda yönetebilmek amacıyla geliştirilmiş bir web uygulamasıdır. Amaç; hasta, doktor ve randevu yönetimini tek bir panel üzerinden kolayca yapılabilir hale getirmektir.

## Projenin Amacı

Gerçek hayatta hastanelerde kullanılan temel iş akışlarını modellemek ve bu süreçleri yazılım mimarisi kullanarak geliştirmek.

Bu proje özellikle aşağıdaki konuların öğrenilmesi amacıyla geliştirilmiştir:

Katmanlı mimari mantığını öğrenmek
ASP.NET Core MVC yapısını uygulamalı görmek
Entity Framework ile veritabanı işlemlerini yönetmek
CRUD işlemlerini gerçek bir senaryo üzerinden uygulamak
Kullanılan Teknolojiler
ASP.NET Core MVC
Entity Framework Core
MSSQL / SQLite
HTML
CSS
Bootstrap
C#
Uygulama Özellikleri
Hasta Yönetimi
Yeni hasta ekleme
Hasta bilgilerini güncelleme
Hasta silme
Hasta listeleme
Doktor Yönetimi
Doktor ekleme
Branş bilgisi yönetimi
Doktor listeleme ve düzenleme
Randevu Sistemi
Hastaya randevu oluşturma
Doktor – hasta eşleştirme
Randevu listeleme ve düzenleme
Proje Mimarisi

Proje katmanlı mimari yaklaşımıyla geliştirilmiştir.

Entity Layer → Veritabanı modelleri
Data Access Layer → Veritabanı işlemleri
Business Layer → İş kuralları
Presentation Layer → Kullanıcı arayüzü (MVC)

Bu yapı sayesinde proje daha okunabilir, sürdürülebilir ve geliştirilebilir hale getirilmiştir.

Kurulum Adımları

Projeyi kendi bilgisayarında çalıştırmak için:

1. Repoyu klonla
git clone https://github.com/a1eynayildiz/HastaneYonetimSistemi.git
2. Projeyi Visual Studio ile aç
3. Veritabanını oluştur
Update-Database
4. Uygulamayı çalıştır
Geliştirme Notları

Bu proje eğitim amaçlı geliştirilmiştir ve geliştirilmeye açıktır. İleride eklenebilecek özellikler:

Yetkilendirme (Admin / Doktor paneli)
Gerçek zamanlı randevu sistemi
Mail bildirimleri
API entegrasyonu

## Uygulama Görselleri

### Giriş Ekranı
![Giriş](https://raw.githubusercontent.com/a1eynayildiz/HastaneYonetimSistemi/main/girişekranı.png)

### İşlem Ekranı
![İşlemler](https://raw.githubusercontent.com/a1eynayildiz/HastaneYonetimSistemi/main/işlemekranı.png)

### Kayıt Ekranı
![Kayıt](https://raw.githubusercontent.com/a1eynayildiz/HastaneYonetimSistemi/main/kayıtekranı.png)
