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

