# LINQ - Pratik

Bu uygulama, **C# LINQ** kullanarak rastgele üretilmiş sayılar listesi üzerinde çeşitli filtreleme ve dönüştürme işlemleri yapar.

---

## 🎯 Amaç

* `List<int>` koleksiyonu üzerinde LINQ sorgularını kullanmak.
* `Where` ile filtreleme, `Select` ile dönüştürme işlemlerini öğrenmek.
* Konsolda liste çıktıları oluşturmak.

---

## 🧠 Mantık Özeti

1. `Random` sınıfı ile -30 ile 30 arasında 10 rastgele sayı üretilir ve listeye eklenir.
2. LINQ sorguları ile aşağıdaki işlemler yapılır:

   * **Çift sayılar** (`% 2 == 0`)
   * **Tek sayılar** (`% 2 != 0`)
   * **Negatif sayılar** (`< 0`)
   * **Pozitif sayılar** (`> 0`)
   * **15'ten büyük ve 22'den küçük sayılar** (`> 15 && < 22`)
   * **Her sayının karesi** (yeni liste: `Select(s => s * s)`)

---

## 📁 Kullanılan LINQ Metotları

* **`Where`** → Filtreleme yapmak için.
* **`Select`** → Elemanları dönüştürmek için.
* **`string.Join`** → Liste elemanlarını virgülle ayırarak ekrana yazdırmak için.

---

## 🖨️ Örnek Çıktı

```
Oluşturulan Liste: -5, 12, 0, 27, -19, 20, 16, 3, 18, -7

Çift Sayılar: 12, 0, 20, 16, 18
Tek Sayılar: -5, 27, -19, 3, -7
Negatif Sayılar: -5, -19, -7
Pozitif Sayılar: 12, 27, 20, 16, 3, 18
15 < sayı < 22: 20, 16, 18
Sayıların Kareleri: 25, 144, 0, 729, 361, 400, 256, 9, 324, 49
```

---

## 📌 Notlar

* Sayı aralığı **(-30, 30)** olarak belirlenmiştir; istenirse değiştirilebilir.
* Liste boyutu kolayca değiştirilebilir (örneğin 10 yerine 20 sayı).
* Çıktılar her çalıştırmada farklı olacaktır çünkü sayılar rastgele üretilir.
