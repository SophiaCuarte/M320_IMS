﻿using System;

namespace Browsersimulator
{
    internal class StringStack
    {
        private string[] values;
        private int index;

        public StringStack(int size)
        {
            values = new string[size];
            index = 0;
        }

        public void Push(string value)
        {
            if (IsFull)
            {
                Console.WriteLine("Stack is full. Cannot push more elements.");
                return;
            }

            values[index++] = value;
        }

        public string Pop()
        {
            if (IsEmpty)
            {
                Console.WriteLine("Stack is empty. Cannot pop elements.");
                return null;
            }

            return values[--index];
        }

        public string Peek()
        {
            if (IsEmpty)
            {
                Console.WriteLine("Stack is empty. Cannot peek elements.");
                return null;
            }

            return values[index - 1];
        }

        public void Swap()
        {
            if (index < 2)
            {
                Console.WriteLine("Stack has less than two elements. Cannot swap.");
                return;
            }

            string temp = values[index - 1];
            values[index - 1] = values[index - 2];
            values[index - 2] = temp;
        }

        public void Clear()
        {
            Array.Clear(values, 0, values.Length);
            index = 0;
        }

        public bool IsEmpty => index == 0;

        public int Count => index;

        public bool IsFull => index == values.Length;
    }
}
