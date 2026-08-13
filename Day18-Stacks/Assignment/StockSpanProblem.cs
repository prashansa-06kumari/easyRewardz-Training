using System;
using System.Collections.Generic;

class StockSpanProblem
{
    public static int[] CalculateSpan(int[] prices)
    {
        int[] span = new int[prices.Length];

        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < prices.Length; i++)
        {
            while (stack.Count > 0 && prices[stack.Peek()] <= prices[i])
            {
                stack.Pop();
            }

            if (stack.Count == 0)
            {
                span[i] = i + 1;
            }
            else
            {
                span[i] = i - stack.Peek();
            }

            stack.Push(i);
        }

        return span;
    }
}