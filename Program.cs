// See https://aka.ms/new-console-template for more information

try
{   
    Console.WriteLine("Lütfen bir sayı giriniz.");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Girmiş olduğunuz sayı = " + a);
}
catch (System.Exception ex)
{
    Console.WriteLine(ex.Message.ToString());
    Console.WriteLine("Bir SAYI girmenizi istemiştim ??!");
}
finally
{
    Console.WriteLine("İşlem Tamamlandı");
}

try
{
     //int c = int.Parse(null);
     //int c = int.Parse("abcd");
     int c = int.Parse("-2000000000000000000000000000");
}
catch (System.ArgumentNullException ex2)
{
    Console.WriteLine("Boş bir sayı mı? O da ne demek? " + "**" + ex2 + "**");
    throw;
}
catch (System.FormatException ex3)
{
    Console.WriteLine("Hata alabiliyorsan her şey yolunda demektir ... " + ex3);
}
catch (System.OverflowException ex4)
{
    Console.WriteLine("Tebrikler gerizekalı, sınırları zorlamakta üstüne yok ! " + ex4);
}
finally
{
    Console.WriteLine("Karga tulumba hallettik ...");
}