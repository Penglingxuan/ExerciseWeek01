using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("請輸入第一個數值");
        var Input = Console.ReadLine();
        Console.WriteLine("請輸入第二個數值");
        var InputTwo = Console.ReadLine();
        Console.WriteLine("請輸入第三個數值");
        var InputThree = Console.ReadLine();

        if (float.TryParse(Input, out float result) &&
           float.TryParse(InputTwo, out float resultTwo) &&
           float.TryParse(InputThree, out float resultThree))
        {
            var MiddleNumber = FindMiddleNumber(result, resultTwo, resultThree);
            Console.WriteLine($"最小數為：{MiddleNumber}");
        }
        else Console.WriteLine("輸入的好像不是數字耶XD");


    }
    static string FindMiddleNumber(float result, float resultTwo, float resultThree)
    {
        var number = string.Empty;
        var value = result.ToString();
        var valueTwo = resultTwo.ToString();
        var valueThree = resultThree.ToString();
        if (result < resultTwo && result < resultThree)
        {
            number = value;
        }
        else if (resultTwo < result && resultTwo < resultThree)
        {
            number = valueTwo;
        }
        else if (result == resultTwo && result > resultThree)
        {
            number = valueThree;
        }
        else if (result == resultTwo && result < resultThree)
        {
            number = value;
        }
        else if (result == resultTwo && resultTwo == resultThree)
        {
            number = value;
        }
        else if (resultTwo == resultThree && resultThree > result)
        {
            number = value;
        }
        else if (resultTwo == resultThree && resultThree < result)
        {
            number = valueTwo;
        }
        else if (result == resultThree && result > resultTwo)
        {
            number = valueTwo;
        }
        else if (result == resultThree && result < resultTwo)
        {
            number = value;
        }
        return number;
    }
}

