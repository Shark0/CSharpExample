﻿using System;

namespace Example.dependencyInjection
{
    public class ConsoleMessageWriter: IMessageWriter
    {
        public void Write(string message)
        {
            Console.WriteLine(message);
        }
    }
}