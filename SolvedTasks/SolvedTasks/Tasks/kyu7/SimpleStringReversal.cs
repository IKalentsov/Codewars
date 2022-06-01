
using System.Text.RegularExpressions;

namespace SolvedTasks.Tasks.kyu7
{
    public class SimpleStringReversal
    {
        /// <summary>
        /// In this Kata, we are going to reverse a string while maintaining the spaces (if any) in their original place.
        /// 
        /// For example:
        /// 
        /// solve("our code") = "edo cruo"
        /// -- Normal reversal without spaces is "edocruo". 
        /// -- However, there is a space at index 3, so the string becomes "edo cruo"
        /// 
        /// solve("your code rocks") = "skco redo cruoy". 
        /// solve("codewars") = "srawedoc"
        /// </summary>
        public static String Solve(String s)
        {
            string pattern = "\\s+";
            string noSpace_s = Regex.Replace(s, pattern, String.Empty);

            char[] arrStr = s.ToCharArray();
            char[] resultStr = noSpace_s.ToCharArray();
            string space = "";

            Array.Reverse(resultStr);

            for (int i = 0, j = 0; i < arrStr.Length && j < resultStr.Length; i++)
            {
                if (char.IsWhiteSpace(arrStr[i])) space += arrStr[i];
                else
                {
                    space += resultStr[j];
                    j++;
                }
            }
            return new string(space);
        }
    }
}
