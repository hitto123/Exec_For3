using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			for (int i = 1; i < 10; i++)
			{
				int space = 10 - i;
				int star = i;
				string row = new string(' ', space) + new string('*', star);
				Console.WriteLine(row);

			}
		}
	}
}
