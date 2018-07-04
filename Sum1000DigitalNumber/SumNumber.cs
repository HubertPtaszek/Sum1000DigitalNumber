using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Sum1000DigitalNumber
{
    class SumNumber
    {
        public static string sumNumber(string n1, string n2)
        {
            int[] tmpResult = new int[n1.Length + 1];
            int tmp = 0;
            for (int i = n1.Length - 1; i >= 0; i--) //w pętli wykonujemy algotytm dodwania pisemnego
            {
                int sum = (n1[i] - '0' + n2[i] - '0' + tmp);  //rzutowanie czesci string na int
                if (sum > 9)
                {
                    tmp = sum / 10;
                    if (tmp > 0)
                        tmpResult[i] = tmp;
                    sum = sum % 10;
                }
                else
                    tmp = 0;
                tmpResult[i + 1] = sum;
            }
            string result = string.Join("", tmpResult);  //wynik rzutujemy z tablicy int na string
            return result;
        }
    }
}
