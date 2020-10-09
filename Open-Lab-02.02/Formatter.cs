﻿using NUnit.Framework;
using System;

namespace Open_Lab_02._02
{
    public class Formatter
    {
        public void Format(double[] numbers)
        {

            // riesenie A
            /*
            for(int i=0;i<numbers.Length-1;i++)
            {
                Console.Write(Math.Round(numbers[i], 2).ToString(System.Globalization.CultureInfo.InvariantCulture.NumberFormat));
                Console.Write(" ");
            }
            Console.Write(Math.Round(numbers[numbers.Length-1], 2).ToString(System.Globalization.CultureInfo.InvariantCulture.NumberFormat));
            */

            // riesenie B
            /*
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                Console.Write(numbers[i].ToString("#.##", System.Globalization.CultureInfo.InvariantCulture.NumberFormat));
                Console.Write(" ");
            }
            Console.Write(numbers[numbers.Length-1].ToString("#.##", System.Globalization.CultureInfo.InvariantCulture.NumberFormat));
            */

            // riesenie C
            string[] newArray = new string[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                newArray[i] = numbers[i].ToString("#.##");
            }
            string message = string.Join(' ', newArray);
            message = message.Replace(',' , '.');
            Console.Write(message);


        }
    }
}
