namespace Algo
{
    public class Tree<T>
    {
        public T value { get; set; }
        public Tree<T> left { get; set; }
        public Tree<T> right { get; set; }

        public Tree()
        {
            
        }

        public Tree(T value)
        {
            this.value = value;
        }

        public override string ToString()
        {
            var l = left?.value.ToString() ?? "-";
            var r = right?.value.ToString() ?? "-";

            return $"V: {value}, L: {l}, R: {r}";
        }
    }

    public class Tree : Tree<int>
    {
        public Tree(int value) : base(value)
        {
        }
    }
}
