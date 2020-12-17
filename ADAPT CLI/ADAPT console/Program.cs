using ADAPT_console.Conversion;
using ADAPT_console.Utils;
using Newtonsoft.Json;
using System;
using System.IO;

namespace ADAPT_console
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Starting ADAPT conversion");
			DateTime startTime = DateTime.Now;

			// Initialise ADAPT Convertor
			AdaptConverter converter = new AdaptConverter(args);
			if (!converter.IsInitialised)
			{
				Console.WriteLine($"Could not initialise conversion settings, stopped");
				return;
			}

			// Start ADAPT Conversion
			if (converter.Convert())
			{
				Console.WriteLine($"Conversion successful!");
			}
			else
			{
				Console.WriteLine($"Conversion not successful!");
				return;
			}

			TimeSpan conversionTime = DateTime.Now.Subtract(startTime);
			Console.WriteLine($"Completed ADAPT conversion in {conversionTime}");
			Console.ReadKey();
		}		
	}
}
