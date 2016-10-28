using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeeCode_CS
{
    public class Solution
    {
        public Solution() { }
        public string ReverseString(string s)
        {
            char[] chars = s.ToCharArray();
            int length = s.Length;
            char temp;
            for (int i = 0,j=length-1; i < j; i++,j--)
            {
                temp = chars[i];
                chars[i] = chars[j];
                chars[j] = temp;
            }
            s = new string(chars);
            return s;
        }

        //389. Find the Difference
        public char FindTheDifference(string s, string t)
        {
            char diff = '?';
            if (s.Length != t.Length - 1) return '!';
            int i = 0,count_s=0,count_t=0;
            for (i = 0; i < s.Length; i++)
            {
                //if (s[i] != t[i]) return t[i];
                count_s = count_s + s[i];
                count_t = count_t + t[i];
                //Console.WriteLine("i={0}:count_s={1},count_t={2}",i,count_s,count_t);
            }
            //if (i == s.Length) return t[t.Length - 1];
            count_t = count_t + t[i];
            diff = (char)(count_t - count_s);
            //Console.WriteLine("{0}", count_t-count_s);
            return diff;
        }

        //283. Move Zeroes
        public void MoveZeroes(int[] nums)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0) count++;
                else nums[i - count] = nums[i];
            }
            if(count>0){
                for (int j = 0; j < count; j++)
                {
                    nums[nums.Length - 1 - j] = 0;
                }
            }   
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            //test data
            int[] nums = { 0, 1, 0, 3, 12 };
            //print result
            solution.MoveZeroes(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine("[{0}]:{1}", i, nums[i]);
            }
            

        }
    }
}
