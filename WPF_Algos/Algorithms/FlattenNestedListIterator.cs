namespace WPF_Algos.Algorithms
{
    public class FlattenNestedListIterator
    {
        //341. Flatten Nested List Iterator
        //Medium
        //You are given a nested list of integers nestedList.Each element is either an integer or a list whose elements may also be integers or other lists.Implement an iterator to flatten it.

        //Implement the NestedIterator class:

        //NestedIterator(List < NestedInteger > nestedList) Initializes the iterator with the nested list nestedList.
        //int next() Returns the next integer in the nested list.
        //boolean hasNext() Returns true if there are still some integers in the nested list and false otherwise.

        //Example 1:

        //Input: nestedList = [[1, 1],2,[1, 1]]
        //Output: [1, 1, 2, 1, 1]
        //Explanation: By calling next repeatedly until hasNext returns false, the order of elements returned by next should be: [1, 1, 2, 1, 1].
        //Example 2:

        //Input: nestedList = [1, [4, [6]]]
        //Output: [1, 4, 6]
        //Explanation: By calling next repeatedly until hasNext returns false, the order of elements returned by next should be: [1, 4, 6].

        public void Run()
        {
            // Example input: [[1,1],2,[1,1]]
            IList<NestedInteger> nestedList = new List<NestedInteger>
            {
                new SimpleNestedInteger(new List<NestedInteger>
                {
                    new SimpleNestedInteger(1),
                    new SimpleNestedInteger(1)
                }),
                new SimpleNestedInteger(2),
                new SimpleNestedInteger(new List<NestedInteger>
                {
                    new SimpleNestedInteger(1),
                    new SimpleNestedInteger(1)
                })
            };

            NestedIterator nestedIterator = new NestedIterator(nestedList);

            List<int> result = new();
            while (nestedIterator.HasNext())
            {
                var p = nestedIterator.Next();
                result.Add(p);
            }
        }

        public class NestedIterator
        {
            private Stack<IEnumerator<NestedInteger>> stack;
            private NestedInteger nextInt;

            public NestedIterator(IList<NestedInteger> nestedList)
            {
                stack = new Stack<IEnumerator<NestedInteger>>();
                stack.Push(nestedList.GetEnumerator());
            }

            public bool HasNext()
            {
                while (stack.Count > 0)
                {
                    IEnumerator<NestedInteger> top = stack.Peek();
                    if (!top.MoveNext())
                    {
                        stack.Pop();
                        continue;
                    }

                    NestedInteger curr = top.Current;
                    if (curr.IsInteger())
                    {
                        nextInt = curr;
                        return true;
                    }

                    stack.Push(curr.GetList().GetEnumerator());
                }
                return false;
            }

            public int Next()
            {
                return nextInt.GetInteger();
            }

            public void Test()
            {
                List<int> l = new List<int>() { 1, 2, 3, 4 };

                List<int>.Enumerator p = l.GetEnumerator();
            }
        }



        public interface NestedInteger
        {

            // @return true if this NestedInteger holds a single integer, rather than a nested list.
            bool IsInteger();

            // @return the single integer that this NestedInteger holds, if it holds a single integer
            // Return null if this NestedInteger holds a nested list
            int GetInteger();

            // @return the nested list that this NestedInteger holds, if it holds a nested list
            // Return null if this NestedInteger holds a single integer
            IList<NestedInteger> GetList();
        }

        private class SimpleNestedInteger : NestedInteger
        {
            private readonly int? _value;
            private readonly IList<NestedInteger> _list;

            public SimpleNestedInteger(int value)
            {
                _value = value;
                _list = null;
            }

            public SimpleNestedInteger(IList<NestedInteger> list)
            {
                _list = list;
                _value = null;
            }

            public bool IsInteger()
            {
                return _value.HasValue;
            }

            public int GetInteger()
            {
                return _value.GetValueOrDefault();
            }

            public IList<NestedInteger> GetList()
            {
                return _list;
            }
        }
    }
}
