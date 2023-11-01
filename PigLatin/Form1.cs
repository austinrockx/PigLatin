using System.Text;
using System.Text.RegularExpressions;

namespace PigLatin
{
    public partial class Pig_Latin_Translator : Form
    {
        public Pig_Latin_Translator()
        {
            InitializeComponent();
        }

        private void translate_Button_Click(object sender, EventArgs e)
        {
            string inputText = Input.Text;
            string[] words = inputText.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder translatedText = new StringBuilder();

            foreach (string word in words)
            {
                string translatedWord = TranslateToPigLatin(word);
                translatedText.Append(translatedWord).Append(" ");
            }

            Output.Text = translatedText.ToString();
        }

        private void clear_Button_Click(object sender, EventArgs e)
        {
            Input.Clear();
            Output.Clear();
        }

        private string TranslateToPigLatin(string word)
        {
            // Check if the word contains any non-alphabet characters (numbers or symbols).
            if (ContainsNonAlphabetCharacters(word))
            {
                return word;
            }

            if (string.IsNullOrWhiteSpace(word))
            {
                return word;
            }

            // Separate punctuation from the word.
            string punctuation = "";
            while (word.Length > 0 && !char.IsLetterOrDigit(word[word.Length - 1]))
            {
                punctuation = word[word.Length - 1] + punctuation;
                word = word.Substring(0, word.Length - 1);
            }

            bool isUpperCase = char.IsUpper(word[0]);
            char firstChar = char.ToLower(word[0]);

            if (IsVowel(firstChar) || (firstChar == 'y' && (!HasVowel(word) || word.IndexOf('y') > 0)))
            {
                return (isUpperCase ? char.ToUpper(word[0]) : word[0]) + word.Substring(1) + "way" + punctuation;
            }
            else
            {
                int firstVowelIndex = FindFirstVowelIndex(word);
                string prefix = word.Substring(0, firstVowelIndex);
                string rest = word.Substring(firstVowelIndex);
                return (isUpperCase ? char.ToUpper(rest[0]) : rest[0]) + rest.Substring(1) + prefix + "ay" + punctuation;
            }
        }


        private bool IsVowel(char c)
        {
            return "aeiou".IndexOf(c) >= 0;
        }

        private bool HasVowel(string word)
        {
            foreach (char c in word)
            {
                if (IsVowel(char.ToLower(c)))
                {
                    return true;
                }
            }
            return false;
        }

        private int FindFirstVowelIndex(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (IsVowel(char.ToLower(word[i])))
                {
                    return i;
                }
            }
            return 0; // No vowels found; default to the first character.
        }

        private bool ContainsNonAlphabetCharacters(string word)
        {
            // Define a regular expression pattern that matches numbers (0-9) and the specified symbols.
            string pattern = @"[0-9!@#$%^&*]";

            // Use Regex.IsMatch to check if the word contains any characters matching the pattern.
            return Regex.IsMatch(word, pattern);
        }

    }
}