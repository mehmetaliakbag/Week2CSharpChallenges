// 1. Task - Merhaba, Nasılsın gibi bir çıktı ekrana yazdır
/*  
Console.WriteLine("Merhaba" +
                  "\r\nNasılsın ?" +
                  "\r\nİyiyim" +
                  "\r\nSen Nnsılsın?");
*/

// 2. Metinsel ve tam sayı verisi tutan değişken atayıp, ekrana yazdır
/*
Console.Write("Metinsel bir ifade girin: ");
string textValue = Console.ReadLine();

Console.Write("Sayısal bir ifade girin: ");
int numberValue = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Text: {textValue}, Integer: {numberValue}");
*/

// 3. Rastgele bir sayı üretip ekrana yazdır
/*
Random random = new Random();
int randomNumber = random.Next();
Console.WriteLine($"Rastgele Sayı: {randomNumber}");
*/

// 4 Rastgele bir sayı üretip 3'e bölümünden kalanı yazdır
/*
Random random = new Random();
int randomNumberModulo = random.Next();
Console.WriteLine($"Rastgele seçilen bir sayının 3 ile bölümünden kalan: {randomNumberModulo % 3}");
*/

// 5 Kullanıcıdan yaş sorup, 18'den büyükse "+" küçükse "-" yazdır
/*
Console.Write("Yaşınız: ");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(age > 18 ? "+" : "-");
*/

// 6 10 defa belirli bir metni yazdır
/*
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine("Sen Vodafone gibi anı yaşarken, ben Turkcell gibi seni her yerde çekemem.");
}
*/

// 7 İki metinsel değeri birbiri ile değiştir
/*
string firstName = "Gülse Birsel";
string secondName = "Demet Evgar";
Console.WriteLine($"Öncesi: {firstName}, {secondName}");
// Swap
string temp = firstName;
firstName = secondName;
secondName = temp;
Console.WriteLine($"Sonrası: {firstName}, {secondName}");
*/

// 8 Değer döndürmeyen metot
/*
static void BenDegerDondurmem()
{
    Console.WriteLine("Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma");
}
*/

// 9 İki sayının toplamını döndüren metot
/*
static int Sum(int num1, int num2)
{
    return num1 + num2;
}
*/

// 10 Boolean parametre alıp string döndüren metot
/*
static string ReturnAStringValue(bool logical)
{
    return "Naber Müdür";
}
*/

// 11 Üç kişinin yaşını alıp en yaşlısının bilgisini döndüren metot
/*
static int OldestAge(int age1, int age2, int age3)
{
    int oldestAge;

    if (age1 > age2 && age1 > age3)
        oldestAge = age1;
    else if (age2 > age1 && age2 > age3)
        oldestAge = age2;
    else
        oldestAge = age3;

    return oldestAge;
}
*/

//12
/*
static int LargestNumber(params int[] numbers)
{
    int result = numbers.Max();
    Console.WriteLine($"Girilen en büyük sayı: {result}");
    return result;
}
*/

//13 Bir metot yardımıyle kullanıcıdan alınan iki ismin yerini değiştir
/*
static void ChangeStrings(string text1, string text2)
{
    string temp = text1;
    text1 = text2;
    text2 = temp;
    Console.WriteLine($"Text1: {text1}\r\nText2: {text2}");
}
*/

// 14 Sayının tek mi çift mi olduğunu kontrol eden metot (çift\true - tek\false)
/*
static bool SingleOrDouble(int num)
{
    if(num % 2 == 0)
        return true;

    return false;
}
*/

// 15 Kullanıcın girdiği hız ve zaman parametreleri ile gidilen yolu hesaplayan bir metot
/*
static double Distance(double speed, double time)
{
    return (speed * time);
}
*/

//16 Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot 
/*
static double CalculateArea(double radius)
{
    return (Math.PI * (radius * radius));
}
*/

//17 "Zaman bir GeRi SayIm" cümlesini alıp , hepsi büyük harf ve hepsi küçük harfle yazdırma
/*
string sentence = "Zaman bir GeRi SayIm";

Console.WriteLine(sentence.ToLower());
Console.WriteLine(sentence.ToUpper());
*/

// 18 "    Selamlar   " metnini bir değişkene atayıp , başındaki ve sonundaki boşlukları sil.
/*
string text = "    Selamlar   ";
string trimmedText = text.Trim();

Console.WriteLine(trimmedText);
*/


