using System;

namespace Gelecegiyazanlarodev
{
    class Program
    {
        static void Main(string[] args)
        {
            string myInput;
            Console.Write("Index Of için ---> 'Index Of' yazınız \n"+"Contains için ----> 'Contains' yazınız \n"+"Split için ----> 'Split' yazınız:");
            myInput = Console.ReadLine();

            
            switch (myInput)
            {
                case "Index Of":
                    Console.WriteLine("Index Of methodu örneğini seçtiniz");
                    Console.Write("Örnek İçin Bir Kelime Giriniz: ");
                    string kelime = Console.ReadLine();

                    Console.Write("Kelimede Aranacak Bir Harf Giriniz: ");
                    string harf = Console.ReadLine();

                    if (kelime.IndexOf(harf) < 0)
                    {
                        Console.WriteLine("Aradığınız Harf '{0}' Girdiğiniz Kelimede Bulunamadı.", harf);
                    }
                    else
                    {
                        Console.WriteLine("{0} Harf {1}. Indexte", harf, kelime.IndexOf(harf));
                    }

                    Console.WriteLine("--------------------------------------------------");
                    break;


                case "Contains": 
                    Console.WriteLine("Contains methodu örneğini seçtiniz");


                    Console.Write("Bir Cümle Girniz: ");
                    string cumle = Console.ReadLine();

                    Console.Write("Bir Kelime Giriniz: ");
                    string kelimeConst= Console.ReadLine();

                    if (cumle.Contains(kelimeConst))
                    {
                        Console.WriteLine("Cümlenin İçinde '{0}' Kelimesi Geçiyor.", kelimeConst);
                    }
                    else
                    {
                        Console.WriteLine("Cümlenin İçinde '{0}' Kelimesi Geçmiyor.", kelimeConst);
                    }

                    Console.WriteLine("--------------------------------------------------");

                    break;


                case "Split":
                    Console.WriteLine("Split methodu örneğini seçtiniz");
                    Console.WriteLine("Split methodu için aralarında virgül kullanarak birden fazla kelime giriniz :");
                    string splitkullanici = Console.ReadLine();
                    string[] splitkullaniciArray = splitkullanici.Split(new char[] { ',' });

                    Console.WriteLine("Girilen dizi :"+ splitkullanici);
                    Console.WriteLine("--------------------------------");
                    for (int i = 0; i < splitkullaniciArray.Length; i++)
                    {
                        Console.WriteLine(splitkullaniciArray[i]);
                    }
                    
                    break;




                default:
                    Console.WriteLine("Hatalı Giriş");
                    break;
            }
        }
    }
}