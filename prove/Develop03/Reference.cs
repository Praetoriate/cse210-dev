public class Reference
{
    //Attributes
        private string _book;
        private string _chapter;
        private string _firstVerse;
        private string _lastVerse;
        
    //Constructor
            public Reference(string book, string chapter, string verse)
            {
                _book = book;
                _chapter = chapter;
                _firstVerse = verse;
                _lastVerse = verse;
            }
        public Reference(string book, string chapter, string verse, string lastVerse)
            {
                _book = book;
                _chapter = chapter;
                _firstVerse = verse;
                _lastVerse = lastVerse;
            }
    //Get/Sets
    //Methods
        public string MakeString()
        {
            string _holder = "";
            if (_lastVerse == _firstVerse)
                {
                    _holder = _book + " " + _chapter + ":" + _firstVerse;
                }
            if (_lastVerse != _firstVerse)
                {
                    _holder = _book + " " + _chapter + ":" + _firstVerse + "-" + _lastVerse;
                }
            return _holder;            
        }

        public void Display()
        {
            Console.WriteLine(MakeString());
        }
}