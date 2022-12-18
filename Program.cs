namespace LearningArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = {"Jonas", "Antanas", "Aloizas", "Martynas", "Jurgis"};
            for (int i = 0; i < 5; i++) {
                Console.WriteLine(names[i]);
            }

            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20};
            Array.Reverse(numbers);
            Console.WriteLine(String.Join(',', numbers));

        }
    }
}
