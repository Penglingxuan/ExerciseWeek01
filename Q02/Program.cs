using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("今天是:" + DateTime.Now.ToString("ddd dd MMM, yyyy"));
        Console.WriteLine("請輸入今日溫度");
        var inputTemperature = Console.ReadLine();
        var result = string.Empty;
        var inputWeather = string.Empty;
        if (int.TryParse(inputTemperature, out var temperature))
        {
            Console.WriteLine("請輸入今天天氣(天氣好/天氣不好)");
            inputWeather = Console.ReadLine();
            if (inputWeather == "天氣好" || inputWeather == "天氣不好")
            {
                result = WhatNeedToDo(DateTime.Now, temperature, inputWeather);
            }
            else
            {
                result = "只能輸入天氣好/天氣不好";
            }
        }
        else
        {
            result = "輸入的好像不是數字耶XD";
        }

        Console.WriteLine(result);
    }
    static string WhatNeedToDo(DateTime Date, float temperature, string Weather)
    {

       var toDo = string.Empty;
       if(Date.DayOfWeek == DayOfWeek.Sunday || Date.DayOfWeek == DayOfWeek.Saturday)
        {
            if (temperature >= 30)
            {
                toDo = "游泳";
            }
            else
            {
                toDo = "爬山";
            }
        }
        else
        {
            if (Weather == "天氣好")
            {
                toDo = "談業務";
            }
            else
            {
                toDo = "上網查資料";
            }
        }
        return toDo;
    }
}

