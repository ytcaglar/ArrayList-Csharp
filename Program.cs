using System;
using System.Collections;

namespace arrayList_ders
{
    class Program
    {
        static void Main(string[] args)
        {
            // ArrayList
            Console.WriteLine("**************** ArrayList ****************");

            ArrayList list = new ArrayList();
            list.Add(5);
            list.Add("Tolunay");
            list.Add(true);
            list.Add('C');

            //ArrayList içerisindeki elemanlara erişmek.

            Console.WriteLine(list[0]);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            // AddRange : Array List içine dizi veya list eklenebiliyor.
            Console.WriteLine("**************** AddRange ****************");

            ArrayList list1 = new ArrayList();
            List<int> sayi = new List<int>();
            sayi.Add(34);
            sayi.Add(55);
            sayi.Add(91);
            sayi.Add(22);
            sayi.Add(2);
            sayi.Add(5);

            int[] sayilar = {28,35,61,95,9,44};

            list1.AddRange(sayi);
            list1.AddRange(sayilar);

            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }

            // Sort : ArrayList içindeki elemanları sıralar mutlaka int veya float filan olmalıdır.
            // Farklı türde olursa örn. string ve int olursa hata verir.
            Console.WriteLine("**************** Sort ****************");
            list1.Sort();

            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }

            // BinarySearch : Liste içinde eleman arama ve index numarasını alma.
            Console.WriteLine("**************** BinarySearch ****************");

            Console.WriteLine(list1.BinarySearch(9));

            // Reverse : Liste elemanlarını tersten yazar.
            Console.WriteLine("**************** Reverse ****************");

            list1.Reverse();

            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }

            // Count : Liste eleman sayısı.
            Console.WriteLine("**************** Count ****************");

            Console.WriteLine(list1.Count);

            // Remove ve RemoveAt : Liste eleman sayısı.
            Console.WriteLine("**************** Remove ****************");

            list1.Remove(9); // eleman
            list1.RemoveAt(5); // index

            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }

            // Clear : Liste eleman sayısı.
            Console.WriteLine("**************** Clear ****************");

            list1.Clear();
            Console.WriteLine(list1.Count);




            


        }
    }
}