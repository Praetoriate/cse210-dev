public class Generate
{
    public Generate()
        {
        }
    //public string _prompt; **Not written to, left in case
    public string GeneratePrompt()
    // selects from a list of 10 prompts and returns the randomly selected prompt.
        {
            Random rando = new Random();
            int promptNum = rando.Next(1, 11);
            //Console.WriteLine($"{promptNum}"); //**used for testing. WORKS!
            
            List<string> prompts = new List<string>();
            prompts.Add("What happened today?");
            prompts.Add("What was the best thing that happened today?");
            prompts.Add("What was the worst thing that happened today?");
            prompts.Add("What was the most interesting thing I saw or heard today?");
            prompts.Add("What was the most challenging thing I faced today?");
            prompts.Add("What am I grateful for today?");
            prompts.Add("What did I learn today?");
            prompts.Add("What was the most fun thing I did today?");
            prompts.Add("What was the most surprising thing that happened today?");
            prompts.Add("What did I do today that I am proud of?");

            string prompt = prompts[promptNum];

            return prompt;
        }
    
    

}
