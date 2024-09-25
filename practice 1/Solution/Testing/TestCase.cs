namespace Testing
{
    public class TestCase : ImplementedCode
    {
        private int[] array1;
        private int Size;
        public TestCase()
        {
            array1 = new int[10]; 
            Size = 0;
        }
        public void add(int value)
        {
            array1[Size++] = value;

        }

        public void remove(int value)
        {
            for (int i = 0; i < Size; i++)
            {
                if (array1[i] == value)
                {
                    for (int j = i; j < Size - 1; j++)
                    {
                        array1[j] = array1[j + 1];
                    }
                    Size--;
                    return;
                }
            }
        }

        public int get(int index)
        {
            return array1[index];
        }

        public int count()
        {
            return Size;
        }
    }
}