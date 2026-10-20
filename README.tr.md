# 💣 Mayın Tarlası (C# WinForms)

[🇬🇧 English](README.md) | 🇹🇷 **Türkçe**

![C#](https://img.shields.io/badge/C%23-239120?logo=csharp&logoColor=white)
![.NET Framework](https://img.shields.io/badge/.NET_Framework-4.7.2-512BD4?logo=dotnet&logoColor=white)
![Windows Forms](https://img.shields.io/badge/Windows_Forms-0078D6?logo=windows&logoColor=white)

C# Windows Forms ile geliştirilmiş bir mayın tarlası oyunu. Oyuncu, 20x20'lik bir alanın **sol üst köşesinden** başlar ve yön butonlarıyla ilerleyerek **mayınlara basmadan sağ alt köşedeki hedefe** ulaşmaya çalışır.

<p align="center">
  <img width="700" alt="Oyun ekranı" src="https://github.com/user-attachments/assets/e8a5f727-7ace-4d16-b8dc-a5df6a7069b9" />
</p>

## ⬇️ İndir ve Oyna

Visual Studio gerekmez:

1. [Son sürüm](https://github.com/busrayanal/MayinTarlasi/releases/latest) sayfasından **`MayinTarlasi-v1.0.zip`** dosyasını indir.
2. Zip dosyasını klasöre çıkar ve **`MayinTarlasi.exe`** dosyasını çalıştır.

Windows ve .NET Framework 4.7.2 veya üstü gerekir (Windows 10/11'de zaten yüklüdür).

## 🕹️ Nasıl Oynanır?

1. Oyuncu adını gir.
2. Zorluk seviyesini seç: mayınlar alana rastgele yerleştirilir.
3. **⬆️ ⬇️ ⬅️ ➡️** butonlarıyla hareket et. İlk hamlede süre başlar.
4. Ekrandaki **"Mayınlara Yakın"** sayacı, bulunduğun hücrenin hemen yanındaki (üst, alt, sol, sağ) mayın sayısını gösterir. Bu ipucunu kullanarak güvenli yolu bul.
5. Sağ alt köşeye ulaşırsan **kazanırsın**, mayına basarsan **oyun biter** ve tüm mayınlar gösterilir.

## ✨ Özellikler

| Özellik | Açıklama |
|---|---|
| 🗺️ Oyun alanı | 20x20 hücre |
| 🎚️ Zorluk seviyeleri | Kolay (40 mayın), Orta (50 mayın), Zor (80 mayın) |
| 🧭 Mayın ipucu | Yakındaki mayın sayısı anlık olarak gösterilir |
| ⏱️ Süre takibi | Timer ile oyun süresi tutulur |
| 🏆 Skor tablosu | Her oyunun sonucu (isim, süre, kazandı/kaybetti) `skorlar.txt` dosyasına kaydedilir ve uygulama içinden görüntülenebilir |
| 🚧 Sınır kontrolü | Oyun alanının dışına çıkılamaz |
| 🔁 Yeni oyun | Oyun bitince tek tıkla yeniden başlatılabilir |

## 🎯 Projenin Amacı

Bu proje oyun mantığını öğrenmek ve pekiştirmek amacıyla yapılmıştır:

- Dizi (array), koşullar (if), döngüler ve event yapısını öğrenmek
- Zamanlayıcı (`Timer`) ve dosya işlemleri (`File`) kullanmak
- Oyun mantığını adım adım kavramak

> [!NOTE]
> Normalde tekrar eden kodlar fonksiyonlara ayrılarak daha kısa yazılabilirdi. Ancak bu projede mantığı daha iyi öğrenebilmek ve her adımı net görebilmek için bazı kodlar **bilinçli olarak** tekrar edilmiştir.

## 🧰 Kullanılan Teknolojiler

- C#
- Windows Forms (.NET Framework 4.7.2)
- Visual Studio
- [Guna.UI2.WinForms](https://www.nuget.org/packages/Guna.UI2.WinForms): arayüz bileşenleri için NuGet paketi

## ▶️ Kaynak Koddan Derleme

1. Repoyu bilgisayarına indir:
   ```bash
   git clone https://github.com/busrayanal/MayinTarlasi.git
   ```
2. `MayinTarlasi.sln` dosyasını **Visual Studio** ile aç.
3. Visual Studio eksik NuGet paketini (Guna.UI2) otomatik olarak geri yükler. Yüklemezse: *Solution'a sağ tık → Restore NuGet Packages*.
4. **F5** ile çalıştır.

## 📁 Proje Yapısı

```
MayinTarlasi/
├── MayinTarlasi.sln          # Visual Studio çözüm dosyası
└── MayinTarlasi/
    ├── Form1.cs              # Oyun mantığı (hareket, mayın kontrolü, skorlar)
    ├── Form1.Designer.cs     # Arayüz tasarımı
    ├── Program.cs            # Uygulamanın giriş noktası
    └── Resources/            # Görseller (mayın, yön okları, saat, arka plan)
```

## 📸 Ekran Görüntüleri

| Oyun sırasında | Oynanmış oyun |
|:---:|:---:|
| <img width="300" alt="Mayına basmadan ilerleme" src="https://github.com/user-attachments/assets/af10b31d-1865-477e-a3de-fbb16c1ec934" /> | <img width="400" alt="Oynanmış oyun" src="https://github.com/user-attachments/assets/6dbf1ecc-6e35-4f9b-aa7b-d045b33da585" /> |

| İsim girişi | Yardım | Skorlar |
|:---:|:---:|:---:|
| <img width="280" alt="İsim girişi" src="https://github.com/user-attachments/assets/bb803b09-42e4-49d0-8cc3-1de2ddd6c650" /> | <img width="220" alt="Yardım" src="https://github.com/user-attachments/assets/573b04c2-00fb-446f-ac17-3c3f2304cfb0" /> | <img width="130" alt="Skorlar" src="https://github.com/user-attachments/assets/4dce00d6-655b-4212-a425-a01d753f866b" /> |

## 📄 Lisans

Bu proje [MIT Lisansı](LICENSE) ile lisanslanmıştır.

## 👩‍💻 Geliştirici

**Büşra Amine Yanal** · [GitHub](https://github.com/busrayanal)
