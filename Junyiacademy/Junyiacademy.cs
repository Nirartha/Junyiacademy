using System;
using System.Collections;
using System.Text;

namespace Junyiacademy
{
    public class Junyiacademy
    {
        public Junyiacademy()
        {
        }

        //Q1 (A) - I
        static string ReverseByArray(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        //Q1 (A) - II
        static string ReverseWordBySwap(string input)
        {
            char[] outcome = input.ToCharArray();
            for (int i = 0; i < input.Length / 2; i++)
            {
                char temp = input[i];
                outcome[i] = input[input.Length - i - 1];
                outcome[input.Length - i - 1] = temp;
            }
            return new string(outcome);
        }

        //Q1 (A) - III
        static string ReverseWordByStack(string input)
        {
            Stack stack = new Stack();
            foreach (var c in input)
            {
                stack.Push(c);
            }
            var outcome = new StringBuilder();
            while (stack.Count != 0)
            {
                outcome.Append(stack.Pop());
            }
            return outcome.ToString();
        }

        //Q1 (B)
        static string ReverseSentenceBywords(string target)
        {
            var outcome = new StringBuilder();
            string[] strArr = target.Split(' ');
            foreach (var word in strArr)
            {
                outcome.Append(ReverseByArray(word) + " ");
            }
            return outcome.ToString();
        }

        static int FindExpext3and5TotalMultiple(int input)
        {
            return 15 - FindSelectedMultiple(input, 3) - FindSelectedMultiple(input, 5) + 2 * FindSelectedMultiple(input, 3 * 5);
        }

        static int FindSelectedMultiple(int input, int selected)
        {
            return (input / selected);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Q1 (A) - I: ReverseByArray: " + ReverseByArray("junyiacademy"));
            Console.WriteLine("Q1 (A) - II: ReverseWordByStack: " + ReverseWordByStack("junyiacademy"));
            Console.WriteLine("Q1 (A) - III: ReverseWordBySwap: " + ReverseWordBySwap("junyiacademy"));

            Console.WriteLine("Q1 (B): ReverseSentenceBywords: " + ReverseSentenceBywords("flipped class room is important"));

            Console.WriteLine("Q2 Input: 15, Output: " + FindExpext3and5TotalMultiple(15));
        }
    }
}
