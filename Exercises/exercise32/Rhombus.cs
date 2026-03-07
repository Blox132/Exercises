namespace exercise32
{
    public class Rhombus
    {
        private int _size;

        public int Size
        {
            get { return _size; }
            set { _size = ValidateSize(value); }
        }

        public Rhombus(int size)
        {
            Size = size;
        }

        private int ValidateSize(int size)
        {
            if (size < 1) return 1;
            if (size % 2 == 0) return size + 1;
            return size;
        }

        public void Print()
        {
            int n = Size / 2;

            for (int i = 0; i <= n; i++)
            {
                PrintLine(n - i, 2 * i + 1);
            }

            for (int i = n - 1; i >= 0; i--)
            {
                PrintLine(n - i, 2 * i + 1);
            }
        }
        private void PrintLine(int spaces, int symbols)
        {
            Console.Write(new string(' ', spaces));

            for (int j = 1; j <= symbols; j++)
            {
                if (j == 1 || j == symbols)
                {
                    Console.Write("#");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}