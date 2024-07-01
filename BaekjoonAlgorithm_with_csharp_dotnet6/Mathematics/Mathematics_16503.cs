using System.ComponentModel.Design;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_16503
    {
        public void solve()
        {
            string[] array = Console.ReadLine().Split(" ");

            int num1 = int.Parse(array[0]);
            string opr1 = array[1];
            int num2 = int.Parse(array[2]);
            string opr2 = array[3];
            int num3 = int.Parse(array[4]);

            int front = 0;
            int result1 = 0;
            if (opr1.Equals("+"))
            {
                front = num1 + num2;
            }
            else if(opr1.Equals("-"))
            {
                front = num1 - num2;
            }
            else if (opr1.Equals("*"))
            {
                front = num1 * num2;
            }
            else if (opr1.Equals("/"))
            {
                front = num1 / num2;
            }

            if (opr2.Equals("+"))
            {
                result1 = front + num3;
            }
            else if (opr2.Equals("-"))
            {
                result1 = front - num3;
            }
            else if (opr2.Equals("*"))
            {
                result1 = front * num3;
            }
            else if (opr2.Equals("/"))
            {
                result1 = front / num3;
            }

            int back = 0;
            int result2 = 0;
            if (opr2.Equals("+"))
            {
                back = num2 + num3;
            }
            else if (opr2.Equals("-"))
            {
                back = num2 - num3;
            }
            else if (opr2.Equals("*"))
            {
                back = num2 * num3;
            }
            else if (opr2.Equals("/"))
            {
                back = num2 / num3;
            }

            
            if (opr1.Equals("+"))
            {
                result2 = num1 + back;
            }
            else if (opr1.Equals("-"))
            {
                result2 = num1 - back;
            }
            else if (opr1.Equals("*"))
            {
                result2 = num1 * back;
            }
            else if (opr1.Equals("/"))
            {
                result2 = num1 / back;
            }

            if (result1 < result2)
            {
                Console.Write(result1 + "\n" + result2);
            }
            else
            {
                Console.Write(result2 + "\n" + result1);
            }
        }
    }
}
