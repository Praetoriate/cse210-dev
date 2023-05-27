public class Word
{
    //Attributes
        private string _word;
        private bool _hidden;
    //Constructors
        public Word()
        {
        }
    //Get/Sets
        public string SetWord(string text)
            {
                return _word = text;
            }
        public bool SetHide(bool state)
            {
                return _hidden = state;
            }
        
        public string GetWord()
            {
                return _word;
            }
        
        public bool GetHide()
            {
                return _hidden;
            }
    //Methods
        public void ReplaceWord()
            {
                string stringWord = GetWord();
                string stringblank = new string('_', stringWord.Length);
                
                SetWord(stringblank);
            }

}
    
