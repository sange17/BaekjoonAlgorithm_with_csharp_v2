namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_24923
    {
        public void solve()
        {
            string[] array = Console.ReadLine()!.Split(" ");

            if(array[array.Length - 1] == "eh?") Console.Write("Canadian!");
            else Console.Write("Imposter!");
        }
    }
}
