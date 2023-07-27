// Дана строка, содержащая только следующие символы:'(', ')', '{', '}', '[', ']'. Определите, является ли ваша строка допустимой.
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string s = "(())";
        bool isValid = IsValidParentheses(s);
        Console.WriteLine(isValid);
    }

    static bool IsValidParentheses(string s)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char c in s)
        {
            if (c == '(' || c == '[' || c == '{')
            {
                stack.Push(c);
            }
            else if (c == ')' || c == ']' || c == '}')
            {
                if (stack.Count == 0)
                {
                    return false;
                }

                char open = stack.Pop();

                if ((c == ')' && open != '(') || (c == ']' && open != '[') || (c == '}' && open != '{'))
                {
                    return false;
                }
            }
        }

        return stack.Count == 0;
    }
}