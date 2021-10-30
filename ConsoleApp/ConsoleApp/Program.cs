using System;

namespace Sample
{
	class Test
	{
		public static void Main(string[] args)
		{
			for (int i = 1; i < 10; i++)
			{
				string testString;
				string lang;
				Console.WriteLine("WELCOME TO THE VERY EPIC TRANSLATOR (Current languages: German)");
				Console.WriteLine("Enter a word: ");
				testString = Console.ReadLine();
				Console.WriteLine("Enter the language you want this word to be translated to (There is currently only German): ");
				lang = Console.ReadLine();
				if (lang == "german")
				{
					if (testString == "hello")
					{
						Console.WriteLine("Hallo");
					}
					if (testString == "cool")
					{
						Console.WriteLine("Kühl");
					}
					if (testString == "i am")
					{
						Console.WriteLine("Ich bin");
					}
					if (testString == "am")
					{
						Console.WriteLine("Bist");
					}
					if (testString == "sheep")
					{
						Console.WriteLine("Schafe");
					}
					if (testString == "is")
					{
						Console.WriteLine("Ist");
					}
					if (testString == "play")
					{
						Console.WriteLine("Spiel");
					}
					if (testString == "epic")
					{
						Console.WriteLine("Episch");
					}
				}
			}
		}
	}
}

