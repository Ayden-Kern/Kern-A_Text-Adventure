namespace Text_Adventure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Ayden K's text adventure of D&D");
            Console.WriteLine("What is your characters name?");

            string character_name = Console.ReadLine();
            Console.WriteLine(character_name + " nice name");
            ChoicesR();
        }
        static void ChoicesR()
        {
            Console.WriteLine("\n What race do you want to play as? \n Human | Elf | Dwarf | Ork");
            string race = Console.ReadLine();

            if (race.ToUpper() == "HUMAN")
            {
                Console.WriteLine("Nice choice");
                ChoicesC();
            }
            else if (race.ToUpper() == "ELF")
            {
                Console.WriteLine("Nice choice");
                ChoicesC();
            }
            else if (race.ToUpper() == "DWARF")
            {
                Console.WriteLine("Nice choice");
                ChoicesC();
            }
            else if (race.ToUpper() == "ORK")
            {
                Console.WriteLine("Nice choice");
                ChoicesC();
            }
            else
            {
                Console.WriteLine("That was not a choice pick again");
                ChoicesR();
            }
        }
        static void ChoicesC()
        {
            Console.WriteLine("\nWhat class do you want to play as \n Fighter | Barbarian | Rouge | Ranger");
            string Class = Console.ReadLine();
            if (Class.ToUpper() == "FIGHTER")
            {
                Console.WriteLine("Classic");
            }
            else if (Class.ToUpper() == "BARBARIAN")
            {
                Console.WriteLine("Tank");
            }
            else if(Class.ToUpper() == "ROUGE")
            {
                Console.WriteLine("Sneak");
            }
            else if(Class.ToUpper() == "RANGER")
            {
                Console.WriteLine("Long range");
            }
            else
            {
                Console.WriteLine("That wasn't a choice pick again");
                ChoicesC();
            }
        }
    }
}
