namespace Assignment_5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a integer to see if it is a palindrome.");
            int xInput = Convert.ToInt32(Console.ReadLine());
            bool result = IsResult(xInput);
            Console.WriteLine(result);

            
        }
        static bool IsResult(int x)
        {
            if ( x < 0)
                return false;

            int[] ints = ConvertToIntArray(x);

            for (int i = 0; i < ints.Length / 2; i++)
            {
                if (ints[i] != ints[ints.Length - 1 - i])
                    return false;
            }
            return true;
        }
        static int[] ConvertToIntArray(int num)
        {
            int length = (int)Math.Floor(Math.Log10(num) + 1);
            int[] intArray = new int[length];

            for (int i = length - 1; i >= 0; i--)
            {
                intArray[i] = num % 10;
                num /= 10;
            }

            return intArray;
        }
    }
}
