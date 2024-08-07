namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_06030
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int[] inputs = sr.ReadLine()!.Split().Select(int.Parse).ToArray();
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();

            for (int i = 1; i <= inputs[0]; i++)
            {
                if (inputs[0] % i == 0)
                    list1.Add(i);
            }

            for (int i = 1; i <= inputs[1]; i++)
            {
                if (inputs[1] % i == 0)
                    list2.Add(i);
            }

            for (int i = 0; i < list1.Count; i++)
            {
                for(int j = 0; j <  list2.Count; j++)
                {
                    sw.WriteLine(list1[i] + " " + list2[j]);
                }
            }

            sr.Close();
            sw.Close();
        }
    }
}
