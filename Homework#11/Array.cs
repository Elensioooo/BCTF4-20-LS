
namespace Homework_11
{
    public class Array : IOutput2, ICalc2
    {
        private int[] _array;
        
        public Array(int[] array)
        {
            if(array == null)
                throw new ArgumentNullException("Array cannot be null");
            if (array.Length == 0)
                throw new ArithmeticException("Array cannot be empty");
            this.ArrayProperty = array;
        }
        public int[] ArrayProperty
        {
            get
            {
                return _array;
            }
            set
            {
                if(value == null)
                    throw new ArgumentNullException("Array cannot be null");
                _array = value;
            }
        }
   
        public void ShowEven()
        {
            for(int i = 0; i < ArrayProperty.Length; i++)
            {
                if (ArrayProperty[i] % 2 == 0)
                    Console.WriteLine(ArrayProperty[i]);
            }
        }

        public void ShowOdd()
        {

            for (int i = 0; i < ArrayProperty.Length; i++)
            {
                if (ArrayProperty[i] % 2 != 0)
                    Console.WriteLine(ArrayProperty[i]);
            }
        }

        public int CountDistinct()
        {
            int count = 0;
            for (int i = 0; i < ArrayProperty.Length; i++)
            {
                bool isUsed = false;
                for (int j = 0; j < i; j++)
                {
                    if (ArrayProperty[i] == ArrayProperty[j])
                    {
                        isUsed = true;
                        break;
                    }
                }

                if (!isUsed)
                    count++;
            }
            return count;
        }

        public int EqualToValue(int valueToCompare)
        {
            int count = 0;
            for (int i = 0; i < ArrayProperty.Length; i++)
            {
                if (ArrayProperty[i] == valueToCompare)
                    count++;
            }
            return count;
        }


    }
}
