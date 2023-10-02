using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Search_Insert_Position
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 3, 5, 6 };
            int target = 2;

            //Binary Search
            int lowest = 0, highest = nums.Length - 1, mid;
            while (lowest <= highest) 
            { 
                mid = (lowest + highest) / 2;
                if (nums[mid] < target)
                {
                    lowest = mid + 1;
                }else if (nums[mid] > target)
                {
                    highest = mid - 1;
                }
                else
                {
                    Console.WriteLine(mid);
                }
            }
            Console.WriteLine(lowest);
            Console.ReadLine();
        }
    }
}
