using System;
using System.Linq;

namespace ScriptureMemory
{
    class Program
    {
        static void Main(string[] args)
        {
            var scriptures = new Scripture[] {
                new Scripture(new Reference("John 3:16"), "\n\nFor God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."),
                new Scripture(new Reference("Mosiah 2:41"), "\n\nAnd moreover, I would desire that ye should consider on the blessed and happy state of those that keep the commandments of God. For behold, they are blessed in all things, both temporal and spiritual; and if they hold out faithful to the end they are received into heaven, that thereby they may dwell with God in a state of never-ending happiness. O remember, remember that these things are true; for the Lord God hath spoken it."),
                new Scripture(new Reference("1 Nephi 3:7"), "\n\nAnd it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."),
                new Scripture(new Reference("Moroni 10:3-4"), "\n\nBehold, I would exhort you that when ye shall read these things, if it be wisdom in God that ye should read them, that ye would remember how merciful the Lord hath been unto the children of men, from the creation of Adam even down until the time that ye shall receive these things, and ponder it in your hearts. \n\n And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost."),
            };

            var random = new Random();
            int scriptureIndex = random.Next(0, scriptures.Length);

            var scripture = scriptures[scriptureIndex];
            scripture.Start();
        }
    }

    class Reference
    {
        public string _text { get; set; }

        public Reference(string text)
        {
            _text = text;
        }
    }

    class Scripture
    {
        private Reference _reference;
        private string _text;
        private Word[] _scriptureWords;

        public Scripture(Reference reference, string text)
        {
            _reference = reference;
            _text = text;

            string[] words = text.Split(' ');
            _scriptureWords = new Word[words.Length];
            for (int i = 0; i < words.Length; i++)
            {
                _scriptureWords[i] = new Word(words[i]);
            }
        }

        public void Start()
        {
            Console.WriteLine("Scripture: " + _reference._text + " " + _text);

            while (_text.Contains(" "))
            {
                Console.WriteLine("\nPress Enter to hide a word, or type 'quit' to exit:");
                string userInput = Console.ReadLine();

                if (userInput.ToLower() == "quit")
                {
                    break;
                }

                Word[] visibleWords = _scriptureWords.Where(x => !x._hidden).ToArray();
                if (visibleWords.Length == 0)
                {
                    break;
                }

                int wordIndex = new Random().Next(0, visibleWords.Length);
                Word word = visibleWords[wordIndex];
                word.Hide();

                _text = string.Join(" ", _scriptureWords.Select(x => x._text));

                Console.Clear();
                Console.WriteLine("Scripture: " + _reference._text + " " + _text);
            }
        }
    }

    class Word
    {
        public string _text { get; set; }
        public bool _hidden { get; set; }

        public Word(string text)
        {
            _text = text;
            _hidden = false;
        }

        public void Hide()
        {
            _text = string.Join("", Enumerable.Repeat("_", _text.Length));
            _hidden = true;
        }
    }
}
