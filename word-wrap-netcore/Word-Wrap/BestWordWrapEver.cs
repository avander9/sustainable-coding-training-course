namespace Word_Wrap
{
    public class BestWordWrapEver
    {
        public WrapedWord WrapWord(string word, int width)
        {
            if (string.IsNullOrWhiteSpace(word))
                return new WrapedWord { Word = word};

            if (width < 0)
                return new WrapedWord { Word = word, Warning = "Width should be greater than zero" };

            if(word.Length <= width)
                return new WrapedWord { Word = word };

            return new WrapedWord();
        }
    }

    public class WrapedWord
    {
        public string Word { get;set; }
        public string Warning { get; set; }
    }
}