namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_18412
    {
        public void solve()
        {
            int[] inputs = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
            char[] array = Console.ReadLine()!.ToCharArray();

            int left = inputs[1] - 1;
            int right = inputs[2] - 1;
            
            while (left <= right)
            {
                char temp = array[left];
                array[left] = array[right];
                array[right] = temp;

                left++;
                right--;
            }

            Console.Write(new string(array));
        }
    }
}
