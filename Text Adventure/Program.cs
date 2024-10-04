namespace Text_Adventure
{
    internal class Program
    {
        static string character_name;
        static string race;
        static string Class;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Ayden K's text adventure of D&D");
            Console.WriteLine("What is your characters name?");

            character_name = Console.ReadLine();
            Console.WriteLine(character_name + " nice name");
            ChoicesR();
        }
        static void ChoicesR()
        {
            Console.WriteLine("\n What race do you want to play as? \n Human | Elf | Ork");
            race = Console.ReadLine();

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
            Class = Console.ReadLine();
            if (Class.ToUpper() == "FIGHTER")
            {
                Console.WriteLine("Nice choice");
                ChoicesS();
            }
            else if (Class.ToUpper() == "BARBARIAN")
            {
                Console.WriteLine("Nice choice");
                ChoicesS();
            }
            else if(Class.ToUpper() == "ROUGE")
            {
                Console.WriteLine("Nice choice");
                ChoicesS();
            }
            else if(Class.ToUpper() == "RANGER")
            {
                Console.WriteLine("Nice choice");
                ChoicesS();
            }
            else
            {
                Console.WriteLine("That wasn't a choice pick again");
                ChoicesC();
            }
        }
        static void ChoicesS()
        {
            Console.WriteLine("\nPick a number 1-4 (in some cases) to progress the story \n You wake up in a coffin what do you do");
            Console.WriteLine("1) Break throught the top of the coffin | 2) Break through the bottom of the coffin and tunnel out");
            string choice1 = Console.ReadLine();
            if (choice1 == "1")
            {
                Console.WriteLine("You break the top of the coffin and get buried under tons of dirt but you slowly start to dig your way out");
                ChoicesS2();
            }
            else if (choice1 == "2")
            {
                Console.WriteLine("You break through the bottom of the coffin and dig to freedom");
                ChoicesS2();
            }
            else
            {
                Console.WriteLine("that wasn't a choice pick again");
                ChoicesS();
            }
        }
        static void ChoicesS2()
        {
            Console.WriteLine("\nYou have dug your way out of the ground and see that you are in an abandoned graveyard\nWhat do you do now");
            Console.WriteLine("1) Look around | 2) Look at your grave | 3) Walk in a random direction");
            string choice2 = Console.ReadLine();
            if (choice2 == "1")
            {
                Console.WriteLine("You look around and see that you are in a decripit looking abandoned graveyard");
                ChoicesS2();
            }
            else if (choice2 == "2")
            {
                Console.WriteLine("You look at your grave which reads\nHere lies "+character_name+" Died **/**/****\nwas a fantastic "+ Class +"\nhonored by their people the "+race+"s");
                ChoicesS2();
            }
            else if (choice2 == "3")
            {
                ChoicesD();
            }
            else
            {
                Console.WriteLine("That wasn't a choice pick again");
                ChoicesS2();
            }
        }
        static void ChoicesD()
        {
            Console.WriteLine("\nYou walk in a random direction and see a creature\nIt is pale yellow and looks like a 3-4ft long centipede that has 8 tenticles near it's mouth");
            Console.WriteLine("you realize you are looking at a Carrion Crawler\nwhat do you do\n1) Run away | 2) Sneak up on it | 3) charge at it and attack");
            string Direction = Console.ReadLine();
            if (Direction == "1")
            {
                Console.WriteLine("you run away from the creature before it notices you");
            }
            else if (Direction == "2")
            {
                Console.WriteLine("you slowly sneak towards it");
            }
            else if (Direction == "3")
            {
                Console.WriteLine("you start running towards it");
            }
            else
            {
                Console.WriteLine("that wasn't an option");
                ChoicesD();
            }
        }
        static void Sneak()
        {
            if (Class == "ROUGE")
            {
                Console.WriteLine("You expertly sneak behind the creature with your dagger ready");
            }
            else if (Class == "RANGER")
            {
                Console.WriteLine("You sneak to a good position in range and ready your bow");
            }
            else if (Class =="FIGHTER")
            {
                Console.WriteLine("You slowly sneak towards the creature");
            }
            else if(Class == "BARBARIAN")
            {
                Console.WriteLine("You clumsily sneak towards the creature");
            }
        }
        static void Charge()
        {
            if(Class == "BARBARIAN")
            {
                Console.WriteLine("You charge the creature while weilding a double sided axe");
            }
            else if(Class == "FIGHTER")
            {
                Console.WriteLine("You expertly start charging the creature with a short sword and shield");
            }
            if (Class == "ROUGE")
            {
                Console.WriteLine("You charge the creature with your dagger in hand");
            }
            else if (Class == "RANGER")
            {
                Console.WriteLine("You charge the creature with an arrow notched in your bow");
            }
        }
    }
}
