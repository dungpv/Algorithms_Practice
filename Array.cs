using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Array
    {
        //chèn phần tử vào mảng
        public static void insertItemToArray()
        {
            int n = 10;
            int[] arr = new int[n];
            int i;

            // initial array of size 10 
            for (i = 0; i < n; i++)
                arr[i] = i + 1;

            // print the original array 
            for (i = 0; i < n; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();

            // element to be inserted 
            int x = 50;

            // position at which element  
            // is to be inserted 
            int pos = 5;

            // create a new array of size n+1 
            int[] newarr = new int[n + 1];

            // insert the elements from the  
            // old array into the new array 
            // insert all elements till pos 
            // then insert x at pos 
            // then insert rest of the elements 
            for (i = 0; i < n + 1; i++)
            {
                if (i < pos - 1)
                    newarr[i] = arr[i];
                else if (i == pos - 1)
                    newarr[i] = x;
                else
                    newarr[i] = arr[i - 1];
            }

            // print the updated array 
            for (i = 0; i < n + 1; i++)
                Console.Write(newarr[i] + " ");
            Console.ReadLine();

        }

        //xóa phần tử vào mảng
        public static void deleteItemToArray()
        {
            int i = 0;
            int pos;
            int[] arr = new int[5] { 35, 50, 55, 77, 98 };

            Console.WriteLine("Elements before deletion:");
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Element[" + (i) + "]: " + arr[i]);
            }

            // Let's say the position to delete the item is 2 i.e. arr[1]
            pos = 2;
            // Shifting elements
            for (i = pos - 1; i < 4; i++)
            {
                arr[i] = arr[i + 1];
            }
            Console.WriteLine("Elements after deletion: ");
            for (i = 0; i < 4; i++)
            {
                Console.WriteLine("Element[" + (i + 1) + "]: " + arr[i]);
            }
            Console.ReadLine();

        }

        //tim kiem phần tử vào mảng
        public static void findItemToArray()
        {
            int[] LA = { 1, 3, 5, 7, 8 };
            int item = 5, n = 5;
            int i = 0, j = 0;

            Console.Write("Danh sach phan tu trong mang ban dau:\n");

            for (i = 0; i < n; i++)
            {
                Console.Write(string.Format("LA[{0}] = {1} \n", i, LA[i]));
            }

            while (j < n)
            {

                if (LA[j] == item)
                {
                    break;
                }

                j = j + 1;
            }

            Console.Write(string.Format("Tim thay phan tu {0} tai vi tri {1}\n", item, j + 1));
            Console.ReadLine();

        }

        //update phần tử vào mảng
        public static void updateItemToArray()
        {
            int[] LA = { 1, 3, 5, 7, 8 };
            int k = 3, n = 5, item = 10;
            int i, j;

            Console.Write("Danh sach phan tu trong mang ban dau:\n");

            for (i = 0; i < n; i++)
            {
                Console.Write(string.Format("LA[{0}] = {1} \n", i, LA[i]));
            }

            LA[k - 1] = item;

            Console.Write("Danh sach phan tu trong mang sau hoat dong update:\n");
            for (i = 0; i < n; i++)
            {
                Console.Write(string.Format("LA[{0}] = {1} \n", i, LA[i]));
            }
            Console.ReadLine();

        }
    }
}
