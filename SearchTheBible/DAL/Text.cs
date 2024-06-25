using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Text
    {
        public static string ReadAllText()
        {
            return File.ReadAllTextAsync("./תנך.txt").Result;
        }
        public static string ReadAllJsonAsync()
        {
            return "./humash.json";
        }
    }
}
