namespace MorseCodeTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the text that will be translated into morse code:");
            Translator.Encode(Console.ReadLine());
        }
    }
    class Translator
    {
        public static void Encode(string? text)
        {
            if(!string.IsNullOrEmpty(text))
            {
                Dictionary<char, string> morseDictionary = new Dictionary<char, string>()
                {
		            {'a', ".-"}, {'b', "-..."}, {'c', "-.-."}, {'d', "-.."}, {'e', "."}, {'f', "..-."}, {'g', "--."}, {'h', "...."}, {'i', ".."}, {'j', ".---"}, {'k', "-.-"}, {'l', ".-.."},
                    {'m', "--"}, {'n', "-."}, {'o', "---"}, {'p', ".--."}, {'q', "--.-"}, {'r', ".-."}, {'s', "..."}, {'t', "-"}, {'u', "..-"}, {'v', "...-"}, {'w', ".--"}, {'x', "-..-"},
		            {'y', "-.--"}, {'z', "--.."}, {' ', "/"}, {'1', ".----"}, {'2', "..---"}, {'3', "...--"}, {'4', "....-"}, {'5', "....."}, {'6', "-...."}, {'7', "--..."}, {'8', "---.."}, {'9', "----."}, {'0', "-----"}
		        };
                string translatedText = "";

                foreach(char index in text)
                {
                    if(index >= 97 && index <= 122)
                    {
                        char.ToLower(index);
                    }
                    translatedText += morseDictionary[index] + " ";
                }
                Console.WriteLine($"translated text: {translatedText}");
            }
        }
    }
}