namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_31775
    {
        public void solve()
        {
            string[] sArray = new string[3];
            for (int i = 0; i < 3; i++)
                sArray[i] = Console.ReadLine()!;

            int lCount = sArray.Where(x => x.StartsWith('l')).Count();
            int kCount = sArray.Where(x => x.StartsWith('k')).Count();
            int pCount = sArray.Where(x => x.StartsWith('p')).Count();

            if(lCount == 1 && kCount == 1 && pCount == 1)
                Console.Write("GLOBAL");
            else 
                Console.Write("PONIX");
        }
    }
}
