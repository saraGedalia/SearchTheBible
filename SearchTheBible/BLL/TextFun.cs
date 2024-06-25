using Newtonsoft.Json;

namespace BLL
{
    public class TextFun : DTO.JsonPasuks
    {
        static string allBile = DAL.Text.ReadAllText();
        
        public static async Task<string[]> AllBibleAsync()
        {
            string[] g = { "Exeeption: the file not fund" };
            try
            {
                return allBile.Split(".");
            }
            catch (Exception ex)
            {
                return g;
            }
        }

        public static async Task<int[]> countWordAsync(String word)
        {
            int[] i = { -1 };
            try
            {
                String AllBile = allBile;
                int[] count = new int[1]; int num = 1;
                while (num > 0)
                {
                    num = AllBile.IndexOf(word);
                    //חותך את המחרוזת מהאחרון
                    //num האינדקס של המילה האחרונה ששווה
                    if (num > 0)
                    {
                        count[0]++;
                        AllBile = AllBile.Substring(num + word.Length, AllBile.Length - (num + word.Length));
                    }
                }
                return count;
            }
            catch (Exception ex)
            {
                return i;
            }
        }

        public static async Task<List<string>> nameAsync(String name)
        {
            int x = 0, y = 0;
            String AllBile = allBile;
            string[] s = AllBile.Split('.');
            List<string> words = new List<string>();
            string st;
            foreach (string s2 in s)
            {
                y = s2.IndexOf('[');
                x = s2.IndexOf(']') + 2;
                st = (s2.Substring(x, (s2.Length - x)));
        
                if (name.Substring(0, 1).Equals(st.Substring(0, 1)))
                {
                    if (st.Substring(st.Length - 1) == name.Substring(name.Length - 1))
                    {
                        words.Add(s2.Substring(y, s2.Length - y));
                    }
                }
            }
            return words;
        }

        public static async Task<List<String>> findWordAsync(String word)
        {
            string textJson = File.ReadAllText(DAL.Text.ReadAllJsonAsync());

            var jsonPasuks = JsonConvert.DeserializeObject<List<DTO.JsonPasuks>>(textJson);
            int x = 0;
            String AllBile = allBile;
            String[] psu = AllBile.Split('.');
            List<string> words = new List<string>();
            bool valueExists = false;
            if (jsonPasuks != null)

                valueExists = jsonPasuks.Any(d => d.NamePasuk == word);
            if (valueExists)
            {
                foreach (var data in jsonPasuks)
                    if (data.NamePasuk == word)
                    {
                        return words = data.Pasuks;
                    }
            }
            if (valueExists == false)
            {
                foreach (string s in psu)
                {
                    x = s.IndexOf(']');

                    if (s.IndexOf(word) > x)
                    {
                        x = s.IndexOf('[');
                        words.Add(s.Substring(x, s.Length - x));
                    }
                }
            }
            DTO.JsonPasuks p = new DTO.JsonPasuks { NamePasuk = word, Pasuks = words };

            jsonPasuks.Add(p);
            string json1 = JsonConvert.SerializeObject(jsonPasuks);
            File.WriteAllText(DAL.Text.ReadAllJsonAsync(), json1);

            return words;
        }
    }
}

