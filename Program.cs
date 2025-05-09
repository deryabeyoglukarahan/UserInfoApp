Console.WriteLine("Lütfen aşağıdaki bilgileri giriniz:");

Console.Write("T.C. Kimlik Numarasi: ");
string tckno = Console.ReadLine();

Console.Write("Adi: ");
string name = Console.ReadLine();

Console.Write("Soyadi: ");
string surname = Console.ReadLine();

Console.Write("Telefon Numarasi: ");
string phone = Console.ReadLine();
//Telefon numarası sadece "kullanıcı bilgisi" olarak değerlendirilir. Üzerinde herhangi bir matematiksel işlem yapılmaz. 
//Bu yüzden string(metin)olarak saklanabilir.
//Telefon numarası başında yer alan 0 rakamının bulunması da string olarak tanımlanma nedenlerinden biridir.
//int gibi başka bir değişken ile tanımlanırsa başındaki 0 rakamı otomatik olarak silinecektir.

Console.Write("Yas: ");
string age = Console.ReadLine();

Console.Write("Ilk Aldigi Urunun Fiyati: ");
double firstProduct = Convert.ToDouble(Console.ReadLine());

Console.Write("Ikinci Aldigi Urunun Fiyati: ");
double secondProduct = Convert.ToDouble(Console.ReadLine());
//Ürün fiyatlarında toplama işlemi yapılacağı için, ondalıklı olabilme ihtimalinden dolayı double veri tipi kullanılmıştır.
//Console.Readline kullanıcıdan alınan veriyi her zaman string türünde döndürür.
//Ürün fiyatları üzerinden hesaplama yapılacağı için ürün fiyatlarına tür dönüşümü uygulanmıştır.

double total = firstProduct + secondProduct;
double reward = total * 0.10;

Console.WriteLine("------------------------------------");
Console.WriteLine($"{tckno} Tc numarali {name} {surname} isimli kisi için kayit olusturulmustur.");
Console.WriteLine($"{phone} telefon numarasina bildirim mesaji gönderilmistir.");
Console.WriteLine($"{total} toplam harcama karsiligi kazanilan 10% patika puan miktari -> {reward} TL'dir.");