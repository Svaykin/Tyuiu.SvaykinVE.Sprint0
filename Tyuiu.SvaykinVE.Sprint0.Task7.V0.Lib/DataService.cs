﻿namespace Tyuiu.SvaykinVE.Sprint0.Task7.V0.Lib
{
    public class DataService
    {
        public static int[] AdditionArrays(int[] numeOne, int[] numTwo)
        {
            int[] resultArray = new int[5];
            for (var i = 0; i < resultArray.Length; i++)
            {
                resultArray[i] = numeOne[i] + numTwo[i];
            }
            return resultArray;
        }
    }
}
