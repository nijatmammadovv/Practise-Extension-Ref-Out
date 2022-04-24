using System;
using System.Text;

namespace Practise_Extension_Ref_Out
{
    static class Program
    {
        static void Main(string[] args)
        {

            //int[] nums = { 1, 3, 5 };
            //int num = 7;
            //RefOut(ref nums, num);
            //foreach (var item in nums)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("===================================================================");
            //string name = "Nicat Memmedov";
            //Refout(ref name);
            //Console.WriteLine(name);
            Console.WriteLine("=====================================================================");
            string word= "exTensiON claSSi staTIc OLMalIdiR";
            Console.WriteLine(word.IlkHerfiBoyutme());
        }
        //public static void RefOut(ref int [] nums,int num)
        //{
        //    Array.Resize(ref nums, nums.Length + 1);
        //    nums[nums.Length - 1] = num;
        //}
        //public static void REFOUT(ref string text)
        //{
        //    string newtext = "";
        //    foreach (var item in text)
        //    {
        //        if(item == ' ')
        //        {
        //            continue;
        //        }
        //        else
        //        {
        //            newtext += item;
        //        }
        //    }
        //    text = newtext;
        //}
    //    static StringBuilder Refout(ref string text)
    //    {
    //        StringBuilder result = new StringBuilder();
    //        foreach (var item in text)
    //        {
    //            if (item != ' ')
    //            {
    //                result.Append(item);
    //            }
    //        }
    //        text = result.ToString();
    //        return result;
    //    }
    static string IlkHerfiBoyutme(this string word)
        {
            string NewText = "";
            string result = "";
            foreach (var item in word)
            {
                NewText += char.ToLower(item);
            }
            result += char.ToUpper(NewText[0]);
            for (int i = 1; i < NewText.Length; i++)
            {
                if (NewText[i] == ' ')
                {
                    result += NewText[i];
                    result += char.ToUpper(NewText[i + 1]);
                    i++;
                }
                else
                {
                    result += NewText[i];
                }
            }
            return result;
        }
    }
    static StringBuilder Ilkherfiboyutme(this string word)
    {
        StringBuilder result = new StringBuilder();
        foreach (var item in word)
        {
            result += char.ToLower(item);
        }
    }
}
