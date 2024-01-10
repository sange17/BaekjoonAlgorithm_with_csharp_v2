using System;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Greedy
{
    class Greedy_01700
    {
        public void solve()
        {
            string line = Console.ReadLine();
            int N = Int32.Parse(line.Split(' ')[0]);
            int K = Int32.Parse(line.Split(' ')[1]);

            int[] order = new int[K];
            string[] lineArray = Console.ReadLine().Split(' ');
            for(int i = 0; i < K; i++)
            {
                order[i] = Int32.Parse(lineArray[i]);
            }

            bool[] use = new bool[101];
            int put = 0;
            int ans = 0;
            int temp = 0;
            for(int i = 0; i < K; i++)
            {
                temp = order[i];

                if (!use[temp])
                {
                    if(put < N)
                    {
                        use[temp] = true;
                        put++;
                    }
                    else
                    {
                        List<int> list = new List<int>();
                        for(int j = i; j < K; j++)
                        {
                            if (use[order[j]] && !list.Contains(order[j]))
                            {
                                list.Add(order[j]);
                            }
                        }

                        if(list.Count != N)
                        {
                            for(int j = 0; j < use.Length; j++)
                            {
                                if (use[j] && !list.Contains(j))
                                {
                                    use[j] = false;
                                    break;
                                }
                            }
                        }
                        else
                        {
                            int remove = list[list.Count - 1];
                            use[remove] = false;
                        }

                        use[temp] = true;
                        ans++;
                    }
                }
            }
            Console.Write(ans);
        }
    }
}
