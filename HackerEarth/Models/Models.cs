namespace HackerEarth
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

    public class Tree
    {
        public int value { get; set; }
        public Tree left { get; set; }
        public Tree right { get; set; }

        public Tree()
        {
        }

        public Tree(int value)
        {
            this.value = value;
        }
    }
}
