namespace SolvedTasks.Tasks
{
    /// <summary>
    /// Complete the solution so that it returns true if the first argument(string) passed in ends with the 2nd argument (also a string).
    /// 
    /// Examples:
    /// 
    /// solution('abc', 'bc') // returns true
    /// solution('abc', 'd') // returns false
    /// </summary>
    public class StringEndsWith
    {
        public static bool Solution(string str, string ending)
        {
            if (str.Length < ending.Length) return false;
            
            var strNew = str.Remove(0, str.Length - ending.Length);

            if (strNew != ending) return false;
            return true;
        }
    }
}
