namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_08715
    {
        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine()!);
            List<int> inputs = Console.ReadLine()!.Split(" ").Select(int.Parse).ToList();
            List<bool> list = new List<bool>();

            for (int i = 0; i < n; i++) list.Add(false);

            for (int i = 0; i < n; i++) if (inputs[i] <= n) list[inputs[i] - 1] = true;

            if(list.Contains(false)) Console.Write("NIE");
            else Console.Write("TAK");
        }
    }
}
