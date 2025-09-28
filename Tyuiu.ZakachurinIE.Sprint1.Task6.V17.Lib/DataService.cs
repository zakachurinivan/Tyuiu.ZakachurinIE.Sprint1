﻿using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ZakachurinIE.Sprint1.Task6.V17.Lib
{
    public class DataService : ISprint1Task6V17
    {
        public bool CheckPalindrome(string value)
        {
            char[] chars = value.ToCharArray();
            Array.Reverse(chars);
            if (new string(chars) == value)
                return true;
            else return false;
        }
        
    }
}
