using System;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Data_Structures
{
    class Data_Structures_01655
    {
        public void solve()
        {
            var sb = new System.Text.StringBuilder();
            using(var reader = new System.IO.StreamReader(Console.OpenStandardInput()))
            {
                var numbers = new List<int>();
                var N = int.Parse(reader.ReadLine());
                var number = int.Parse((reader.ReadLine()));
                numbers.Add(number);
                sb.Append(string.Format("{0}{1}", numbers[(numbers.Count - 1) / 2] , Environment.NewLine));

                number = int.Parse(reader.ReadLine());
                if (numbers[0] > number)
                    numbers.Insert(0, number);
                else
                    numbers.Add(number);
                sb.Append(string.Format("{0}{1}", numbers[(numbers.Count - 1) / 2], Environment.NewLine));

                int low = 0;
                int high = numbers.Count - 1;
                int mid = 0;
                var InsertIndex = 0;
                for(int i = 2; i < N; i++)
                {
                    number = int.Parse(reader.ReadLine());
                    low = 0;
                    high = numbers.Count - 1;
                    mid = 0;
                    InsertIndex = 0;
                    while(low <= high)
                    {
                        mid = (low + high) / 2;
                        if(number < numbers[mid])
                        {
                            high = mid - 1;
                            InsertIndex = mid;
                        }
                        else
                        {
                            low = mid + 1;
                            InsertIndex = low;
                        }
                    }

                    if (numbers.Count - 1 < InsertIndex)
                        numbers.Add(number);
                    else
                        numbers.Insert(InsertIndex, number);
                    sb.Append(string.Format("{0}{1}", numbers[(numbers.Count - 1) / 2], Environment.NewLine));
                }

                Console.Write(sb.ToString());
            }
        }
    }
}
