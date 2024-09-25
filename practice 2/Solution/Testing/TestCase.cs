namespace Testing
{
    public class TestCase : AdvancedStack
    {
        private int[] array1;
        private int Size;
        private int[] max;
        private int[] min;
        public TestCase()
        {
            array1 = new int[10];
            max = new int[10];
            min = new int[10];
            Size = 0;
        }
        public void push(int value)
        {
            if (Size == 0)
            {
                // First value in the stack, so it's both min and max
                min[Size] = value;
                max[Size] = value;
            }
            else
            {
                min[Size] = Math.Min(value, min[Size - 1]);
                max[Size] = Math.Max(value, max[Size - 1]);
            }
            array1[Size++] = value;
        }
        public int pop()
        {
            if (Size == 0)
            {
                return -1;
            }
            return array1[--Size];
        }
        public int peek()
        {
            return array1[Size];
        }
        public int getMax()
        {
            if (Size == 0)
            {
                Console.WriteLine("Stack is empty");
            }
            return max[Size - 1];
        }
        public int getMin()
        {
            if (Size == 0)
            {
                Console.WriteLine("Stack is empty");
            }
            return min[Size - 1];
        }
    }
}