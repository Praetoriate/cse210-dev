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
            prompts.Add("Prompt1");
            prompts.Add("Prompt2");
            prompts.Add("Prompt3");
            prompts.Add("Prompt4");
            prompts.Add("Prompt5");
            prompts.Add("Prompt6");
            prompts.Add("Prompt7");
            prompts.Add("Prompt8");
            prompts.Add("Prompt9");
            prompts.Add("Prompt10");

            string prompt = prompts[promptNum];

            return prompt;
        }
    
    

}
