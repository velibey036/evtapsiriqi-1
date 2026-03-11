// See https://aka.ms/new-console-template for more information
//metod - a n dəyəri göndəriləcək.Metod həmin ədədin kvadratını qaytaracaq
//Metod-a n dəyəri göndəriləcək. metod 1-dən n-dək olan cüt ədədlərin cəmini qaytaracaq
//metod-a ədədlər massiv göndəriləcək. Həmin massivdəki, ən kiçik elementi tapıb geri qaytaracaq
//Metod-a söz və hərf göndəriləcək. Həmin sözdə verilən hərfdən neçə ədəd olduğunu qaytaracaq metod
//Metod-a n və m ədədləri göndəriləcək. Həmin n və m ededleri arasindaki tek ededlerin sayini tapin.


//#1metod - a n dəyəri göndəriləcək.Metod həmin ədədin kvadratını qaytaracaq

//int Kvadrat (int n)
//{
//    int kok = n * n;
//    return kok;
//}
//int kok = Kvadrat(6);
//Console.WriteLine(kok);


//#2Metod-a n dəyəri göndəriləcək. metod 1-dən n-dək olan cüt ədədlərin cəmini qaytaracaq

using System.Diagnostics.CodeAnalysis;

//int Cuteded(int n)
//{
//    int sum = 0;
//    for (int i = 1; i <=n ; i++)
//    {
//        if (i % 2 == 0)
//        {
//            sum += i;
//        }

//    }
//    return sum;
//}
//int sum = Cuteded(12);
//Console.WriteLine(sum);


//#3metod-a ədədlər massiv göndəriləcək. Həmin massivdəki, ən kiçik elementi tapıb geri qaytaracaq

//int ENkicik(int[] numb)
//{
//    int min = numb[0];
//    {
//        for (int i = 1; i < numb.Length; i++)
//        {
//           if (numb[0] < min)
//            {
//                min=numb[0];
//            }
//        } 
//    }
//    return min;
//}
//int[] numbers = { 3, 4, 56, 8, 9, 36, 77 };
//int son =ENkicik(numbers);
//Console.WriteLine(son);


//#4Metod-a söz və hərf göndəriləcək. Həmin sözdə verilən hərfdən neçə ədəd olduğunu qaytaracaq metod


//int Herfsayi ( string soz,char herf)
//{
//    int sum = 0;
//    for (int i = 0; i < soz.Length; i++)
//    {
//        if (soz[i] == herf)
//        {
//            sum++;
//        }
//    }
//    return sum;
//}
//string sozz = "salamlaar";
//char herifff = 'a';
//int son = Herfsayi(sozz, herifff);
//Console.WriteLine(son);


//#5Metod-a n və m ədədləri göndəriləcək.
//Həmin n və m ededleri arasindaki tek ededlerin sayini tapin.

//int TekEded ( int n,int m)
//{
//    int sum = 0;
//    for (int i = n; i <=m ; i++)
//    {
//        if (i % 2 == 1)
//        {
//            sum++;
//        }
//    }
//    return sum;
//}
//int sum = TekEded(7, 36);
//Console.WriteLine(sum);




