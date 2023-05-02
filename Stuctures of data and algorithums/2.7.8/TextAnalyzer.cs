namespace _2._7._8
{
    public class TextAnalyzer
    {
        public string Text { get; set; } = null!;
        public void InputText(string name)
        {
            StreamReader streamReader = new StreamReader(name);
            this.Text = streamReader.ReadToEnd();
        }
        public  void WordFrequences()
        {
            string[] line = this.Text!.ToLower().Split(" ").ToArray();
            SortedDictionary<string, int> words = new SortedDictionary<string, int>();
            foreach (var word in line)
            {
                string actual = word;
                for (int i = 0; i < word.Length; i++)
                {
                    if (!char.IsLetterOrDigit(word[i]))
                    {
                        actual = word.Remove(i);
                    }
                }
                if (!words.ContainsKey(actual))
                {
                    words.Add(actual, 1);
                }
                else
                {
                    words[actual]++;
                }

            }
            string result = "";
            foreach (var word in words)
            {
                result += $" {word.Key}  {word.Value};";
            }
            Console.WriteLine(result.TrimStart());
        }
    }
}
