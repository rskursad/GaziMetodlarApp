namespace GaziMetodlarApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double sayi1, sayi2, result;
            //int[] dizi =new int
            //string cevap;
            //Console.WriteLine("Birinci sayıyı giriniz");
            //sayi1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("ikinci sayıyı giriniz");
            //sayi2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Hangi işlemi yaptırmak istiyorsunuz.(topla/cıkar/carp/bol)");
            //cevap = Console.ReadLine().ToLower();
            //if (cevap == "topla")
            //{
            //    Console.WriteLine(Topla(sayi1, sayi2));
            //}
            //else if (cevap == "cikar" || cevap == "çıkar")
            //{
            //    Console.WriteLine(Cikar(sayi1, sayi2));
            //}
            //else if (cevap == "carp" || cevap == "çarp")
            //{
            //    Console.WriteLine(Carp(sayi1, sayi2));
            //}
            //else if (cevap == "bol" || cevap == "böl")
            //{
            //    Console.WriteLine(Bol(sayi1, sayi2));
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı giriş yapıldı.");
            //}

            Console.WriteLine("Kaç sayı toplamak istiyorsunuz.");
            byte adet=byte.Parse(Console.ReadLine());
            var array= new double[adet];
            for (int i=0;i<adet;i++)
            {
                Console.WriteLine(i+1+". sayıyı giriniz:");
                array[i]=double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Girilen sayıların toplamı:"+Topla(array));
        }


        // Üç / ile açıklama ekle:

        /// <summary>
        /// Kendisine girilen sayıları toplayan metottur.
        /// </summary>
        /// <param name="sayi1">Toplanacak birinci sayı</param>
        /// <param name="sayi2">Toplanacak ikinci sayı</param>
        /// <returns>Geriye Double veri tipinde döner</returns>
        static double Topla(double sayi1, double sayi2) => sayi1 + sayi2;
        static double Topla(double sayi1, double sayi2, double sayi3) => sayi1 + sayi2 + sayi3;
        static double Topla(double[] dizi)
        {
            double sonuc=0;
            for (int i=0;i<dizi.Length;i++)
            {
                sonuc += dizi[i];
            }
            return sonuc;
        }

        static double Cikar(double sayi1, double sayi2) => sayi1 - sayi2;
        static double Cikar(double sayi1, double sayi2, double sayi3) => sayi1 - sayi2 - sayi3;

        static double Carp(double sayi1, double sayi2) => sayi1 * sayi2;
        static double Carp(double sayi1, double sayi2, double sayi3) => sayi1 * sayi2 * sayi3;

        static double Bol(double sayi1, double sayi2) => sayi1 / sayi2;
        static double Bol(double sayi1, double sayi2, double sayi3) => sayi1 / sayi2 / sayi3;


    }
}
//Method Overloading(methodların aşırı yüklenmesi): İmzaları farklı olan metodlar aynı isimlerle tanımlanabilirler.
//Method signature(metod imzası): metodların aldığı parametrelerin sayısı ve veri tipleri, metod imzasını belirler. 
