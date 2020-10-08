using System;
using System.Linq;
namespace Open_Lab_04._08
{
    public class StringTools
    {
        public string[] IsFourLetters(string[] strings) => strings.Where(p => p.Length == 4).ToArray();
        
    }
}
