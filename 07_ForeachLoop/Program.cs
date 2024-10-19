using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //string[] cities = { "milano", "roma", "budapeşte", "ankara", "istanbul", "varşova" };

            //foreach (string x in cities)
            //{
            //    Console.WriteLine(x);
            //}

            //int[] numbers = { 1, 2, 22, 45, 14, 66, 854, 246, 215 };

            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}

            //int[] numbers = { 1, 2, 22, 45, 14, 66, 854, 246, 215 };

            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //int[] numbers = { 1, 2, 22, 45, 14, 66, 854, 246, 215 };

            //int total = 0;

            //foreach (int number in numbers)
            //{
            //    total += number;

            //}
            //Console.WriteLine(total);

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,8
            //};

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //string word = "Merhaba";

            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}


            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            //Console.Write("-------- C# Eğitim Uygulaması -------");
            //Console.WriteLine();
            //Console.WriteLine();

            ////sınıftaki öğrenci sayısını kullanıcıdan alma
            //Console.WriteLine("------------------------------------");
            //Console.Write("Sınıfınızda Kaç Öğrenci Var: ");
            //int studentCount = int.Parse(Console.ReadLine());
            //Console.WriteLine("------------------------------------");

            ////öğrenci isimlerini ve not ortalamalarını saklayacak diziler
            //string[] studentNames = new string[studentCount];
            //double[] studentExamAvg = new double[studentCount];

            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.Write($"{i+1}.Öğrencinin İsmini Giriniz: ");
            //    studentNames[i] = Console.ReadLine();

            //    double totalExamResult = 0;

            //    //Her öğrenci için 3 sınav notu girişi

            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{studentNames[i]} İsimli Öğrencinin {j+1} Sınav Notunu Giriniz: ");
            //        double value = double.Parse(Console.ReadLine() );
            //        totalExamResult += value;
            //    }
            //    Console.WriteLine();
            //    studentExamAvg[i] = totalExamResult / 3;
            //}

            

            //for (int i = 0;i < studentCount;i++)
            //{
            //    Console.WriteLine($"{studentNames[i]} İsimli Öğrencinin Ortalamasını: {studentExamAvg[i]} ");

            //    if (studentExamAvg[i] >= 50)
            //    {
            //        Console.WriteLine($"{studentNames[i]} İsimli Öğrenci Dersi Geçti.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{studentNames[i]} İsimli Öğrenci Dersten Kaldı.") ;
            //    }
            //    Console.WriteLine();
            //}


            #endregion

            Console.Read();
        }
    }
}
