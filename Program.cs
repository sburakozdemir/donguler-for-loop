
//Ekrandan Girilen sayıya kadar olan sayıları ekrana yazdır.
Console.WriteLine("Lütfen bir sayı giriniz:");
int sayac = int.Parse(Console.ReadLine()); 
for (int i = 1; i <= sayac; i++)
{
    if(i%2 == 1)
    Console.WriteLine(i);

}

//1 ile 1000 arasındaki tek ve çift sayıların kendi içlerinde toplamlarını ekrana yazdır.

int tektoplam = 0;
int cifttoplam=0;
for (int i = 1; i <= 1000; i++)
{
    if(i%2 == 1)
    tektoplam += i ;
    else
    {
        cifttoplam += i ;
    }
    
}
Console.WriteLine("Tek Toplam : " + tektoplam );
    Console.WriteLine("Cift Toplam : " + cifttoplam );