using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Jungle_Math
{
    internal class ScoreControl
    {
        public int ReadScore(int NumberOfTheLine)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ScoreDB.txt");
            string[] lines = File.ReadAllLines(filePath);
            int Score = lines.Length > NumberOfTheLine ? Convert.ToInt32(lines[NumberOfTheLine]) : 0 ;
            return Score;
        }
    }
}
