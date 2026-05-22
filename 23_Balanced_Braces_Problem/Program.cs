using System.Diagnostics;

namespace _23_Balanced_Braces_Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Debug.WriteLine(IsBalanced("{{[]}}").ToString());
            Debug.WriteLine(IsBalanced("(((]").ToString());
            
        
        }


        private static bool IsBalanced(string inputString)
        {
            Stack<char> stackOfClosingBraces = new Stack<char>();
            Stack<char> stackOfOpeningBraces = new Stack<char>();

            foreach (char c in inputString)
            {
                if (c == ')' || c == ']' || c == '}')
                {
                    stackOfClosingBraces.Push(c);
                }

            }

            for (int i = inputString.Length - 1; i >= 0; i--)
            {
                if (inputString[i] == '{' || inputString[i] == '[' || inputString[i] == '(')
                {
                    stackOfOpeningBraces.Push(inputString[i]);
                }
            }

            if ((stackOfClosingBraces.Count + stackOfOpeningBraces.Count) % 2 != 0)
            {
                return false;
            }

            while (stackOfClosingBraces.Count != 0)
            {
                char currentClosingBrace = stackOfClosingBraces.Pop();
                char currentOpeningBrace = stackOfOpeningBraces.Pop();

                if ((currentClosingBrace == '}' && currentOpeningBrace == '{') ||
                    (currentClosingBrace == ']' && currentOpeningBrace == '[') ||
                    (currentClosingBrace == ')' && currentOpeningBrace == '('))
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }

            return true;


        }
    }
}