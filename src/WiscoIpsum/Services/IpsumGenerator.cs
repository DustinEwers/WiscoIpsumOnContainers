using System;
using System.Text;

namespace WiscoIpsum.Services
{
    public class IpsumGenerator
    {
        public static string GenerateIpsum(int numberOfParagraphs) {
            if (numberOfParagraphs < 1) { numberOfParagraphs = 1; }

            var sb = new StringBuilder();

            for (int i = 0; i < numberOfParagraphs; i++) {
                sb.AppendLine(GenerateParagraph());
                if (i + 1 < numberOfParagraphs) {
                    sb.AppendLine(Environment.NewLine);
                }
            }

            return sb.ToString();
        }

        private static string GenerateParagraph()
        {
            var random = new Random();
            var phases = GetPhrases();
            var numberOfphrases = random.Next(10, 30);

            var sb = new StringBuilder();

            for (int i = 0; i < numberOfphrases; i++) {
                var index = random.Next(0, phases.Length - 1);
                sb.Append(phases[index]);
                sb.Append(" ");
            }

            return sb.ToString();
        }

        private static string[] GetPhrases() => new string[] {
            "Ope",
            "Where-Abouts",
            "Spotted Cow",
            "Brandy Old Fashioned",
            "Stop-and-go-lights",
            "Fleet Farm",
            "Cheeshead",
            "Fish Fry",
            "Bubbler",
            "Aw Geez",
            "For Cripes Sakes",
            "Up Nort",
            "Uff-Da",
            "Ya Know?",
            "Believe You Me",
            "You betcha"
        };
    }
}
