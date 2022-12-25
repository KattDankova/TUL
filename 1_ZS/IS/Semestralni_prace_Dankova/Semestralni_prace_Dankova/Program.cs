Console.WriteLine("Překladač textu do Morseovy abecedy");

var key = ConsoleKey.Enter;
while (key == ConsoleKey.Enter)
{
    string[,] table =
    {
        {"A", ".-" },
        {"B", "-..." },
        {"C", "-.-." },
        {"D", "-.." },
        {"E", "." },
        {"F", "..-." },
        {"G", "--." },
        {"H", "...." },
        {"CH", "----" },
        {"I", ".." },
        {"J", ".---" },
        {"K", "-.-" },
        {"L", ".-.." },
        {"M", "--" },
        {"N", "-." },
        {"O", "---" },
        {"P", ".--." },
        {"Q", "--.-" },
        {"R", ".-." },
        {"S", "..." },
        {"T", "-" },
        {"U", "..-" },
        {"V", "...-" },
        {"W", ".--" },
        {"X", "-..-" },
        {"Y", "-.--" },
        {"Z", "--.." },
        {"0", "-----" },
        {"1", ".----" },
        {"2", "..---" },
        {"3", "...--" },
        {"4", "....-" },
        {"5", "....." },
        {"6", "-...." },
        {"7", "--..." },
        {"8", "---.." },
        {"9", "----." },
        {".", ".-.-.-" },
        {",", "--..--" },
        {"'", ".----." },
        {"/", "-..-." },
        {";", "-.-.-." },
        {"!", "--...-" },
        {"?", "..--.." },
        {":", "---..." },
        {"-", "-....-" },
        {"=", "-...-" },
        {"\"", ".-..-."},
        {"(", "-.--." },
        {")", "-.--.-" },
        {"&", ".-..." },
        {"+", ".-.-." },
        {"_", "..--.-" },
        {"$", "...-..-" },
        {"¿", "..-.-" },
        {"¡", "--...-" },
        {"@", ".--.-." },
    };
    string text = "";
    string result = "";

    Console.WriteLine("Zadejte text (bez diakritiky): ");
    text = Console.ReadLine();

    char[] chars = text.ToCharArray();
    for (int i = 0; i < chars.Length; i++)
    {
        char temp = chars[i];
        bool next = true;
        if (temp >= 97 && temp <= 122)
        {
            temp = (char)(chars[i] - 32);
            next = true;
        }
        else if (temp == '.' && chars.Length >= chars[i] + 1 && chars[i + 1] == ' ')
        {
            result += "//";
            next = false;
            i++;
        }
        else if (temp == ' ')
        {
            result += "/";
            next = false;
        }

        if (next)
        {
            for (int j = 0; j < table.GetLength(0); j++)
            {
                if (table[j, 0] == temp.ToString())
                {
                    result += table[j, 1];
                    break;
                }
                else if (j == table.GetLength(0) - 1)
                {
                    result += "#";
                }
            }
            if (i + 1 != chars.Length)
            {
                result += "/";
            }
        }
    }

    Console.WriteLine($"\nVýsledek: \n {result}");

    Console.WriteLine("\nPro opakovani stisknete ENTER");
    key = Console.ReadKey().Key;
}