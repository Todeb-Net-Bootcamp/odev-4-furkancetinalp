### odev-4
7. Hafta sonunda tanımlayacağımız Web Api Projesinin(BİTİRME PROJESİ DEĞİL) Codefirst yaklaşımı kullanılarak DataAccessLayer katmanını oluşturacağız. 
# Son Teslim Tarihi: 22 Temmuz Cuma saat 23.00

##PaymentApp
Ödeme Sistemi Projesi'nin Entity ve DAL Katmanlarının Oluşturulması
Projede 8 adet sınıf vardır:
1) Banks => Bankaların kendine ait Id ve ismi olmasını sağlayan sınıftır.
2) BankAddress => Bankaların adreslerini tutan ayrı bir sınıftır.
3) CustomerList => Her bankanın kendi müşterilerini içeren bir her müşteriyi kapsayan bir tablo oluşmasını sağlayan sınıftır.
4) Customers => Bankalara ait müşterilerin tanımlanmasını sağlayan sınıftır.
5) Accounts => Her bir müşterinin(Customers sınıfı) bir Account(hesap) sınıfı olmasını sağlayan sınıftır.
6) CardTypes => Account(hesap) sınıfının kredi veya banka kartı olmak üzere 2 çeşit kart içermesini sağlayan sınıftır.
7) Cards => Müşterinin kartını simgeleyen sınıftır.
8) Addresses => Müşterinin adresini saklayan sınıftır.

Taboların İlişki Diyagramı
![Diagram](https://user-images.githubusercontent.com/99509540/180515300-82648db0-efd4-42d2-8c37-ee5c6246c995.png)

Program.cs görüntüsü:
![Ekran Görüntüsü (250)](https://user-images.githubusercontent.com/99509540/180516681-0969346a-9813-41bb-96de-c842473b0393.png)

### Kod Tarafındaki Girdilerin Eklenmesi ile Tablolara Verilerin Eklenmesi Sonucu Tabloların Görüntüsü

Accounts, Addresses, BankAddress , Banks Tabloları
![Ekran Görüntüsü (252)](https://user-images.githubusercontent.com/99509540/180517007-13a06083-3720-49ce-b269-fec272b43aa3.png)
