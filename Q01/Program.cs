using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("請輸入分數0-100");
        var input = Console.ReadLine();
        var result = string.Empty;
        if (int.TryParse(input, out var value))
        {
            result = ScoreGrade(value);
        }
        else
        {
            result = "輸入的好像不是數字耶XD";
        }
        Console.WriteLine(result);
    }
    static string ScoreGrade(int score)
    {
        
        var grade = string.Empty;
        if (score < 0 || score > 100)
        {
            grade = "超出輸入範圍";
        }
        else if (score <= 100 && score >= 90)
        {
            grade = "成績優秀";
        }
        else if (score <= 90 && score >= 80)
        {
            grade = "考試良好";
        }
        else if (score <= 80 && score >= 60)
        {
            grade = "考試及格";
        }
        else if (score < 60)
        {
            grade = "下次繼續努力";
        }

        return grade;
    }
}

