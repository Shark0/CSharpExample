using System;

using Example.dependencyInjection;
using LibraryExample;

namespace Example
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            TestDependencyInjection();
            TestExampleLibrary();
        }

		private static void TestDependencyInjection()
		{
            IMessageWriter writer = new ConsoleMessageWriter();
            Salutation salutation = new Salutation(writer);
            salutation.Exclaim();
        }

        private static void TestExampleLibrary()
        {
            string value = "shark";
            value = new StringLibrary().ToUpper(value);
            Console.WriteLine("TestExampleLibrary value: " + value);
        }
    }
}