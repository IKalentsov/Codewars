namespace SolvedTasks.Tasks.kyu6
{
    public class UniqueInOrder
    {
        /// <summary>
        /// Implement the function unique_in_order which takes as argument a sequence and returns a list of items without any elements with the same value next to each other and preserving the original order of elements.
        /// 
        /// For example:
        /// 
        /// uniqueInOrder("AAAABBBCCDAABBB") == {'A', 'B', 'C', 'D', 'A', 'B'}
        /// uniqueInOrder("ABBCcAD")         == {'A', 'B', 'C', 'c', 'A', 'D'}
        /// uniqueInOrder([1,2,2,3,3])       == {1,2,3}
        /// </summary>
        public static IEnumerable<T> UniqueInOrderSolver<T>(IEnumerable<T> iterable)
        {
            var arr1 = new List<T>();

            if (iterable.Count() == 0) return iterable;

            // Добавляем первое значение
            arr1.Add(iterable.First());

            // Помечаем первое значение как последнее добавленное
            var lastItem = iterable.First();
            
            foreach (var item in iterable)
            {
                // Если текущий и предыдущий item разные - добавляем в массив
                if (!item.Equals(lastItem))
                {
                    lastItem = item;
                    arr1.Add(item);
                }
            }

            return arr1;
        }
    }
}
