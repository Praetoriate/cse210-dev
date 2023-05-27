using System;

class Program
{
    static void Main(string[] args)
    {
        
        string contText = "";

        //Set Scripture text source
        Reference Mastery = new Reference("Alma","44","16");
        string TextSource = "And thus mercy can satisfy the demands of justice, and encircles them in the arms of safety, while he that exercises no faith unto repentance is exposed to the whole law of the demands of justice; therefore only unto him that has faith unto repentance is brought about the great and eternal plan of redemption.";
        
        Scripture LearnScripture = new Scripture(Mastery,TextSource);

        while (contText != "quit")
            {
                Console.Clear();
                LearnScripture.Display();
                LearnScripture.HideWords();
                contText = Console.ReadLine();            
            }
    }
}