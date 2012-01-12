using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace DebudAndTrace
{
	class Program
	{
		static void Main(string[] args)
		{
			// Create a path to the My Documents folder and the file name
			string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + Path.DirectorySeparatorChar + "examplefile.txt";

			// If the files doesn't exist, create it by using WriteAllText
			if (!File.Exists(filePath))
			{
				string content = "This is a text file." + Environment.NewLine;
				Console.WriteLine("Creating the file...");
				File.WriteAllText(filePath, content);
				Debug.WriteLine("Created the file");
			}

			// Use the AppendAllText method to add text to the content
			string addedText = "Text added to the file" + Environment.NewLine;
			Console.WriteLine("Adding content to the file...");
			File.AppendAllText(filePath, addedText);

			// Read the contents of the file
			Console.WriteLine("The current contents of the file are:");
			Console.WriteLine("-------------------------------------");
			string currentContent = File.ReadAllText(filePath);
			Console.WriteLine(currentContent);

			Console.ReadLine();
		}
	}
}
