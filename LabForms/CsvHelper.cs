using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

internal static class CsvHelper
{
	public static async Task<string> CreateCsv(string csvName, params string[] firstLines)
	{
		string full = Application.UserAppDataPath + $"\\{csvName}.csv";
		//MessageBox.Show(full);
		if (File.Exists(full))
		{
			return full;
		}
		
		using (FileStream stream = new FileStream(full, FileMode.Create))
		{
			if (firstLines != null && firstLines.Length != 0)
			{
				using (StreamWriter writer = new StreamWriter(stream, Encoding.Default))
				{
					await writer.WriteAsync(firstLines[0]);
					for (int i = 1; i < firstLines.Length; i++)
					{
						await writer.WriteAsync($",{firstLines[i]}");
					}
				}
			}
		}
		return full;
	}

	public static string[,] LoadFromCsv(string full)
	{
		if (!File.Exists(full))
		{
			return null;
		}

		string[,] result = null;

		string[] all = File.ReadAllLines(full, Encoding.Default);
		string[] firstLines = all[0].Split(',');
		result = new string[all.Length - 1, firstLines.Length];
		for (int i = 0; i < result.GetLength(0); i++)
		{
			string[] split = all[i + 1].Split(',');
			for (int j = 0; j < firstLines.Length; j++)
			{
				result[i, j] = split[j];
			}
		}
		return result;
	}
}