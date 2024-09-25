namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_07280
    {
        public void solve()
        {
            Dictionary<string, bool> map = new Dictionary<string, bool>();
            for (int i = 1; i <= 13; i++)
            {
                map.Add("S" + i, false);
                map.Add("B" + i, false);
                map.Add("V" + i, false);
                map.Add("K" + i, false);
            }

            for (int i = 0; i < 51; i++)
            {
                string line = Console.ReadLine()!.Replace(" ","");
                map[line] = true;
            }

            string result = map.FirstOrDefault(x => x.Value == false).Key;
            Console.Write(result.Substring(0,1) + " " + result.Substring(1));
        }
    }
}
