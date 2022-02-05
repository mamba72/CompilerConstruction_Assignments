using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchingForStringsHW
{
	internal class MainStuff
	{
		public static void Main(string[] args)
		{
			string text = "abababcabababc";
			text = "aaabbaabb";

			List<int> output = SearchStringsProblem3(text);

			Console.WriteLine(output);

		}



		private static List<int> SearchStringsProblem3(string text)
		{
			List<int> result = new List<int>();
			//using goto statements
			int textIndex = -1;
			char textChar;

			pos1: //initial
			textIndex++;
			if (textIndex == text.Length)
				goto end;
			textChar = text[textIndex];
			switch(textChar)
			{
				case 'a': 
					goto pos2;
				case 'b':
					goto pos1;
			}

			pos2:
			textIndex++;
			if (textIndex == text.Length)
				goto end;
			textChar = text[textIndex];
			switch (textChar)
			{
				case 'a':
					goto pos3;
				case 'b':
					goto pos4;
			}

			pos3:
			//since this is a success state, add current index to result
			textIndex++;
			result.Add(textIndex);
			if (textIndex == text.Length)
				goto end;
			textChar = text[textIndex];
			switch( textChar)
			{
				case 'a':
					goto pos3;
				case 'b':
					goto pos4;
			}

			pos4:
			textIndex++;
			if (textIndex == text.Length)
				goto end;
			textChar = text[textIndex];
			switch (textChar)
			{
				case 'a':
					goto pos2;
				case 'b':
					goto pos5;
			}

			pos5:
			//since this is a success state, add current index to result
			textIndex++;
			result.Add(textIndex);
			if (textIndex == text.Length)
				goto end;
			textChar = text[textIndex];
			switch (textChar)
			{
				case 'a':
					goto pos2;
				case 'b':
					goto pos1;
			}

			end://end label for once we are done going through string
			return result;
		}
	}
}
