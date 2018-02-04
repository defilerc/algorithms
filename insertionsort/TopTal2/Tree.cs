namespace Algo.TopTal2
{
    public class Tree
    {
        public int x;
        public Tree l;
        public Tree r;

        public override string ToString()
        {
            var left = l?.x.ToString() ?? "-";
            var right = r?.x.ToString() ?? "-";

            return $"V: {x}, L: {left}, R: {right}";
        }

        public Tree(int x)
        {
            this.x = x;
        }
    };
}
