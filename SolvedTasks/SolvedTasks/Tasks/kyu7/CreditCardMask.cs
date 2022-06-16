
namespace SolvedTasks.Tasks.kyu7
{
    public class CreditCardMask
    {
        public static string Maskify(string cc)
        {
            var length = cc.Length;

            if (length <= 4) return cc;

            cc.ToCharArray();

            var newString = cc;
            var lastString = "";

            for (int i = 0; i < length - 4; i++)
            {
                var item = newString.First();

                newString = newString.Remove(0, 1);
                item = '#';

                lastString = string.Concat(lastString, item);
            }

            return string.Concat(lastString, newString);
        }
    }
}
