namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_31520
    {
        public void solve()
        {
            char[] array = Console.ReadLine()!.ToCharArray();
            bool flag = false;
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (i < 9)
                {
                    if (i + 1 != (int)array[i])
                    {
                        flag = true;
                        break;
                    }
                }

                count++;
            }

            if(flag) Console.Write(-1);
            else Console.Write(count);
        }
    }
}
