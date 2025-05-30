using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    public static class MyUtils
    {
        //Hay cai dat mot ham TongTu1DenN voa kieu int cua Microsoft
        public static int TongTu1DenN(this int n)
        {
            int sum = 0;
            for(int i =1; i <=n; i++)
            {
                sum += i;
            }
            return sum;
        }

        public static int Cong(this int a, int b)
        {
            return a + b;
        }

        public static void SapXepTangDan(this int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        // Hoan doi
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }

        public static void TaoMang(this int[] arr)
        {
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(1, 100); // Tao so ngau nhien tu 1 den 100
            }
        }

        public static void XuatMang(this int[] arr) {
            Console.WriteLine("Array: ");
            for(int i = 0; i < arr.Length/2; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }
            
        
    }
}
