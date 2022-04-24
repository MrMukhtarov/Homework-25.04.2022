using System;
using System.Collections.Generic;
using System.Text;

namespace Homework25._4._2022.Extensions
{
    static class ExtentionMethods
    {
        //   1 IsEven() - int deyerler ucun hemin deyerini cut eded olub olmadigini geri(true/false) qaytaran method
        static bool IsEven(this int a)
        {
            if (a % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // 2 GetValueIndexes() - integer array-leri ucun parameter olaraq gonderilmis integer deyerinin 
        //bu arrayin hansi indexlerinde oldugunu tapib ,butun tapdigi indexleri array olaraq geri 
        //qaytaran metod.(hec bir deyer tapilmazsa geriya bos (0 uzunluqlu) int[] qayidir)

        static int[] GetValueIndexes(this int digit)
        {
            int[] arr = { 10, 15, 55, 78 };

            int[] arr2 = { };
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == digit)
                {
                    Array.Resize(ref arr2, arr.Length + 1);
                    arr2[arr2.Length - 1] = i;
                }
            }
            return arr2;
        }
        //IsOdd() - int deyerler ucun hemin deyerin tek eded olub olmadigini geri(true/false) qaytaran method
        static bool IsOdd(this int a)
        {
            if (a % 3 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //sContainsDigit() - string deyerler ucun hemin deyerin daxilinde digit 
        //character olub olmamsini axtarib geri(true/false)   qaytaran metod
        static bool IsContainsDigit(this string a)
        {
            foreach (char c in a)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
        //GetValueIndexes() - string-ler ucun parameter oaraq gonderilen charin stringin 
        //hansi indexlerinde yerlesdiyini tapan ve tapdigi butun indexleri array olaraq geri
        //qaytaran metod(hec bir deyer tapilmazsa geriya bos (0 uzunluqlu) int[] qayidir)

        static int[] GetValueIndex(char ch)
        {
            string a = "Nicat Muxtarov";
            int[] arr = { };
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == ch)
                {
                    Array.Resize(ref arr, arr.Length + 1);
                    arr[arr.Length - 1] = i;
                }
            }
            return arr;
        }
    }
}
