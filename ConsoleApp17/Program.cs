using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> lines = new List<string>();

        for (int i = 0; ; i++)
        {
            lines.Add(Console.ReadLine());
            if (lines[i] == "")
                break;
        }

        lines.RemoveAt(lines.Count - 1);

        List<string[]> wordsColumns = new List<string[]>();

        for (int i = 0; i < lines.Count; i++)
        {
            if (lines[i][0] != '+')
            {
                string[] strs = lines[i].Replace("||", "| |").Split(new[] { '|', '|' }, StringSplitOptions.RemoveEmptyEntries);

                for (int i2 = 0; i2 < strs.Length; i2++)
                {
                    strs[i2] = strs[i2].Trim() == string.Empty ? " " : strs[i2].Trim();
                }

                wordsColumns.Add(strs);
            }
        }

        string line = "+";
        int[] maxs = new int[wordsColumns[0].Length];

        for (int i = 0; i < wordsColumns[0].Length; i++)
        {
            int[] maxs_ = new int[wordsColumns.Count];

            for (int i2 = 0; i2 < wordsColumns.Count; i2++)
                maxs_[i2] = wordsColumns[i2][i].Length;

            maxs[i] = maxs_.Max();

            for (int i3 = 0; i3 < maxs[i] + 2; i3++)
                line += "-";

            line += "+";
        }

        Console.WriteLine(line);

        for (int i = 0; i < wordsColumns.Count; i++)
        {
            string line_ = "| ";
            int k = 0;
            for (int i2 = 0; i2 < wordsColumns[i].Length; i2++)
            {
                line_ += wordsColumns[i][i2];

                if (line_[^1] == '-')
                    k += 1;

                for (int i3 = 0; i3 < maxs[i2] - wordsColumns[i][i2].Length; i3++)
                    line_ += " ";

                line_ += " | ";
            }

            if (k == 0)              
                Console.WriteLine(line_ + "\n" + line);
            else
                Console.WriteLine(line_);
        }
        
        Console.ReadLine();
    }
}