# Pulp Stone AI Test GUI

**Pulp Stone AI Test GUI**, pulpa taşı analizi için özel olarak tasarlanmış bir Windows Forms uygulamasıdır. Bu uygulama, AI modellerini görüntü algılama görevlerinde test etmek amacıyla geliştirilmiştir.

## Özellikler

- Bir klasörü tarayarak görüntüleri kontrol edilebilir bir liste kutusuna yükler.
- Liste kutusunu tüm görüntelerden temizler.
- Liste kutusundaki tüm öğeleri işaretler veya işaretlerini kaldırır.
- AI işleme için bir model dosyası seçer.
- Güven düzeyi ayarı için kaydırma çubuğu ve sayısal yukarı/aşağı kontrolü kullanır.
- Durum ve seçilen model bilgilerini görüntüler.

## Gereksinimler

- Sistemde **.NET Framework** yüklü olmalıdır.
- Model dosyaları (`.pt` uzantılı) uygulamaya göreli `models/` dizininde bulunmalıdır.

## Kullanım

1. Uygulamayı çalıştırın.
2. **"Klasör Tara"** butonuna tıklayarak bir klasörü tarayın ve görüntüleri yükleyin.
3. **"Tümünü Seç"** veya **"Tümünü Temizle"** butonlarıyla görüntü seçimlerini yönetin.
4. **"Model Seç"** butonuna tıklayarak bir model dosyası seçin.
5. Güven düzeyini kaydırma çubuğu veya sayısal kontrol ile ayarlayın.
6. Durum ve görüntü sayısını gösteren etiketleri takip edin.

## Notlar

- `models/` dizininin geçerli model dosyalarını içerdiğinden emin olun.
- Uygulama, kullanıcı seçimlerine ve model seçimine göre durumu dinamik olarak günceller.