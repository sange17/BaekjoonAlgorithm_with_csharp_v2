namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_16675
    {
        public void solve()
        {
            string[] array = Console.ReadLine()!.Split();
            string[] msArr = new string[2] { array[0], array[1] };
            string[] tkArr = new string[2] { array[2], array[3] };

            string result = "";
            // 둘 다 같은 걸 낼 때
            if (msArr[0] == msArr[1] && tkArr[0] == tkArr[1])
            {
                // 같은 것을 냈지만 서로 종류가 다른 경우
                if (msArr[0] != tkArr[0])
                {
                    if (msArr[0] == "R" && tkArr[0] == "S")
                        result = "MS";
                    else if (msArr[0] == "R" && tkArr[0] == "P")
                        result = "TK";
                    else if (msArr[0] == "S" && tkArr[0] == "R")
                        result = "TK";
                    else if (msArr[0] == "S" && tkArr[0] == "P")
                        result = "MS";
                    else if (msArr[0] == "P" && tkArr[0] == "R")
                        result = "MS";
                    else if (msArr[0] == "P" && tkArr[0] == "S")
                        result = "TK";
                }
            }
            // 민성이만 같은 걸 낼 때
            else if (msArr[0] == msArr[1] && tkArr[0] != tkArr[1])
            {
                if (msArr[0] == "R")
                {
                    if (tkArr.Contains("S"))
                        result = "MS";
                    if (tkArr.Contains("P"))
                        result = "TK";
                }
                if (msArr[0] == "S")
                {
                    if (tkArr.Contains("R"))
                        result = "TK";
                    if (tkArr.Contains("P"))
                        result = "MS";
                }
                if (msArr[0] == "P")
                {
                    if (tkArr.Contains("R"))
                        result = "MS";
                    if (tkArr.Contains("S"))
                        result = "TK";
                }
            }
            // 태경이만 같은 걸 낼 때
            else if (msArr[0] != msArr[1] && tkArr[0] == tkArr[1])
            {
                if (tkArr[0] == "R")
                {
                    if (msArr.Contains("S"))
                        result = "TK";
                    if (msArr.Contains("P"))
                        result = "MS";
                }
                if (tkArr[0] == "S")
                {
                    if (msArr.Contains("R"))
                        result = "MS";
                    if (msArr.Contains("P"))
                        result = "TK";
                }
                if (tkArr[0] == "P")
                {
                    if (msArr.Contains("R"))
                        result = "TK";
                    if (msArr.Contains("S"))
                        result = "MS";
                }
            }
            // 둘 다 다른 걸 낼 때
            else
            {
                if (msArr.Contains("R") && tkArr.Contains("R"))
                {
                    if (msArr.Contains("S") && tkArr.Contains("P"))
                        result = "MS";
                    if (msArr.Contains("P") && tkArr.Contains("S"))
                        result = "TK";
                }
                else if (msArr.Contains("S") && tkArr.Contains("S"))
                {
                    if (msArr.Contains("R") && tkArr.Contains("P"))
                        result = "TK";
                    if (msArr.Contains("P") && tkArr.Contains("R"))
                        result = "MS";
                }
                else if (msArr.Contains("P") && tkArr.Contains("P"))
                {
                    if (msArr.Contains("R") && tkArr.Contains("S"))
                        result = "MS";
                    if (msArr.Contains("S") && tkArr.Contains("R"))
                        result = "TK";
                }
            }
            
            if (string.IsNullOrEmpty(result))
            {
                result = "?";
                Console.Write(result);
            }else
            {
                Console.Write(result);
            }

        }
    }
}
