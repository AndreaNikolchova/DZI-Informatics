using _2._7._8;

TextAnalyzer textAnalyzer = new TextAnalyzer();
string fileName  = Console.ReadLine()!;

textAnalyzer.InputText(fileName);
textAnalyzer.WordFrequences();
