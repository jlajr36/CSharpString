using System;

namespace CSharpStrings
{
	class Program
	{
		public static void Main(string[] args)
		{
			System.String authorName = "RJ South";
			System.String age = "33";
			System.String numberString = "33.23";
			
			Console.WriteLine("Name: {0}", authorName);
			Console.WriteLine("Age: {0}", age);
			Console.WriteLine("Number: {0}", numberString);
			
			string authorDetails = "Name: " + authorName + " Age: " + " Pay Rate: " + numberString;
			Console.WriteLine(authorDetails);
			
			char[] chars = {'M','U','S','H'};
			string name = new string(chars);
			Console.WriteLine(name);
			
			string nowDateTime = "Date: " + DateTime.Now.ToString();
			Console.WriteLine(nowDateTime);
			
			string statment = "There are 5";
			char theCh = 'a';
			int arePos = statment.IndexOf(theCh);
			Console.WriteLine("The position of " + theCh + " in the statement is " + arePos.ToString());
			
			Console.WriteLine("Size of string: {0}", statment.Length);
			
			char[] charArr = statment.ToCharArray();
			foreach (char ch in charArr) {
				Console.WriteLine(ch);
			}
			
			string nullStr = null;
			string empStr = string.Empty;
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}