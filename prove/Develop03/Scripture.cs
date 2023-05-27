public class Scripture
{
    //Attributes
        private string _text;
        private string _reference;
        private List<Word> _wordList;
    //Constructors
        public Scripture(Reference referenceSource, string textSource)
        {            
            _reference = referenceSource.MakeString();
            _text = textSource;
            _wordList = MakeList();   
        }
    //Get/Sets
    //Methods
        public void Display()
            {                
                Console.WriteLine($"{_reference} {_text}");
            }

        public List<Word> MakeList()
            {
                //Make _text into a list of Word objects
                List<Word> wordList = new List<Word>();
                string[] wordsSplit = _text.Split(" ");
                foreach (string i in wordsSplit)
                    {
                        Word nextWord = new Word();
                        nextWord.SetWord(i);
                        nextWord.SetHide(false);
                        wordList.Add(nextWord);
                    }
                return wordList;
            }
        public void HideWords()
            {
                
                //Select three random words to hide
                int count = 0;
                Random rando = new Random();

                //Count how many words are not hidden
                List<Word> _notHiddenWords = new List<Word>();
                foreach (Word word in _wordList)
                    {
                        if (word.GetHide() == false)
                            {
                                _notHiddenWords.Add(word);
                            }
                    }
                if (_notHiddenWords.Count() >=3)
                    while (count !=3)
                        {
                            int wordListSelect =  rando.Next(_wordList.Count());
                            Word wordSelected = _wordList[wordListSelect];
                            if (wordSelected.GetHide() == false)
                                {
                                    wordSelected.SetHide(true);
                                    wordSelected.ReplaceWord();
                                    count++;
                                }
                        
                            if (wordSelected.GetHide() == true)
                                {
                                    continue;
                                }
                        }
                if (_notHiddenWords.Count() == 2)
                    while (count !=2)
                        {
                            int wordListSelect =  rando.Next(_wordList.Count());
                            Word wordSelected = _wordList[wordListSelect];
                            if (wordSelected.GetHide() == false)
                                {
                                    wordSelected.SetHide(true);
                                    wordSelected.ReplaceWord();
                                    count++;
                                }
                        
                            if (wordSelected.GetHide() == true)
                                {
                                    continue;
                                }
                        }
                if (_notHiddenWords.Count() == 1)
                    while (count !=1)
                        {
                            int wordListSelect =  rando.Next(_wordList.Count());
                            Word wordSelected = _wordList[wordListSelect];
                            if (wordSelected.GetHide() == false)
                                {
                                    wordSelected.SetHide(true);
                                    wordSelected.ReplaceWord();
                                    count++;
                                }
                        
                            if (wordSelected.GetHide() == true)
                                {
                                    continue;
                                }
                        }
                if (_notHiddenWords.Count() == 0)
                    Environment.Exit(0);

                //Update the list back to _text
                List<string> tempWords = new List<string>();
                foreach (Word word in _wordList)
                    {
                        string stringWord = word.GetWord();
                        tempWords.Add(stringWord);
                    }
                string assembledString = string.Join(" ", tempWords);
                _text = assembledString;

                //Display list of Word objects and their attributes ***DELETE AFTER TESTING***
                // foreach (Word word in _wordList)
                //     {
                //         Console.WriteLine($"{word.GetWord()} {word.GetHide()}");
                //     }
                
            }

}