namespace Text_Adventure
{
    internal class Program
    {
        static string character_name;
        static string race;
        static string Class;

        //Pick a name
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Ayden K's text adventure of D&D");
            Console.WriteLine("What is your characters name?");

            character_name = Console.ReadLine();
            Console.WriteLine(character_name + " nice name");
            ChoicesR();
        }
        //Pick a race
        static void ChoicesR()
        {
            Console.WriteLine("\n What race do you want to play as? \n Human | Elf | Ork");
            race = Console.ReadLine();

            if (race.ToUpper() == "HUMAN")
            {
                ChoicesC();
            }
            else if (race.ToUpper() == "ELF")
            {
                ChoicesC();
            }
            else if (race.ToUpper() == "ORK")
            {
                ChoicesC();
            }
            else
            {
                Console.WriteLine("That was not a choice pick again");
                ChoicesR();
            }
        }
        //Pick a class
        static void ChoicesC()
        {
            Console.WriteLine("\nWhat class do you want to play as \n Fighter | Barbarian | Rouge | Ranger");
            Class = Console.ReadLine();
            if (Class.ToUpper() == "FIGHTER")
            {
                ChoicesS();
            }
            else if (Class.ToUpper() == "BARBARIAN")
            {
                ChoicesS();
            }
            else if(Class.ToUpper() == "ROUGE")
            {
                ChoicesS();
            }
            else if(Class.ToUpper() == "RANGER")
            {
                ChoicesS();
            }
            else
            {
                Console.WriteLine("That wasn't a choice pick again");
                ChoicesC();
            }
        }
        //Explains choices and starts the story
        static void ChoicesS()
        {
            Console.WriteLine("\nPick a number 1-4 (in some cases) to progress the story \nYou wake up in a coffin what do you do");
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
                Console.WriteLine("That wasn't a choice pick again");
                ChoicesS();
            }
        }
        //continues the story after escaping the coffin
        static void ChoicesS2()
        {
            Console.WriteLine("\nYou have dug your way out of the ground and see that you are in an abandoned graveyard\nWhat do you do now");
            Console.WriteLine("1) Look around | 2) Look at your grave | 3) Walk in a random direction");
            string choice2 = Console.ReadLine();
            int ChoiceAsInt = Convert.ToInt32(choice2);
            if (choice2 == "1")
            {
                Console.WriteLine("You look around and see that you are in a decripit looking abandoned graveyard");
                Console.WriteLine("You notice the gravestone of the grave you crawled out of");
                ChoiceAsInt += 1;
            }
            if (ChoiceAsInt == 2 || choice2 =="2")
            {
                Console.WriteLine("You look at your grave which reads\nHere lies "+character_name+" Died **/**/****\nWas a fantastic "+ Class +"\nHonored by their people the "+race+"s");
                ChoicesD();
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
        //starts combat choices
        static void ChoicesD()
        {
            Console.WriteLine("\nYou walk in a random direction and see a creature\nIt is pale yellow and looks like a 3-4ft long centipede that has 8 tenticles near it's mouth");
            Console.WriteLine("you realize you are looking at a Carrion Crawler\nwhat do you do\n1) Run away | 2) Sneak up on it | 3) charge at it and attack");
            string Direction = Console.ReadLine();
            if (Direction == "1")
            {
                Console.WriteLine("You run away from the creature before it notices you");
                Console.WriteLine("\nYou wind up running and bumping into the jaws of a dragon skeleton\nYou noticed that since you triped over it that the top jaw is now falling towards you");
                Death();
            }
            else if (Direction == "2")
            {
                Console.WriteLine("You slowly sneak towards it");
                Sneak();
            }
            else if (Direction == "3")
            {
                Console.WriteLine("You start running towards it");
                Charge();
            }
            else
            {
                Console.WriteLine("That wasn't an option");
                ChoicesD();
            }
        }
        //starts stealth for classes
        static void Sneak()
        {
            if (Class == "ROUGE")
            {
                Console.WriteLine("You expertly sneak behind the creature with your dagger ready\n");
                SneakAttack();
            }
            else if (Class == "RANGER")
            {
                Console.WriteLine("You sneak to a good position in range and ready your bow\n");
                SneakAttack();
            }
            else if (Class =="FIGHTER")
            {
                Console.WriteLine("You slowly sneak towards the creature\n");
                SneakAttack();
            }
            else if(Class == "BARBARIAN")
            {
                Console.WriteLine("You clumsily sneak towards the creature and it turns to you slowly\n");
                SneakAttack();
            }
        }
        //starts charging at enemies for characters
        static void Charge()
        {
            if(Class == "BARBARIAN")
            {
                Console.WriteLine("You charge the creature while weilding a double sided axe\n");
                Fight();
            }
            else if(Class == "FIGHTER")
            {
                Console.WriteLine("You expertly start charging the creature with a short sword and shield\n");
                Fight();
            }
            else if (Class == "ROUGE")
            {
                Console.WriteLine("You charge the creature with your dagger in hand quickly crossing the graveyard towards the creature\n");
                Fight();
            }
            else if (Class == "RANGER")
            {
                Console.WriteLine("You charge the creature with an arrow notched in your bow\n");
                Fight();
            }
        }
        //Starts close combat
        static void Fight()
        {
            if (Class == "BARBARIAN")
            {
                Console.WriteLine("You bring your double sided axe down on the creature splitting its head in half");
                Win();
            }
            else if (Class == "FIGHTER")
            {
                Console.WriteLine("You drive your sword through a chink in the creatures bony plating and it rears back");
                CCF();
            }
            else if (Class == "ROUGE")
            {
                Console.WriteLine("You notice that the creature has bony plates and you bring your dagger down on a lethal spot between 2 plates that you recognize");
                Win();
            }
            else if (Class == "RANGER")
            {
                Console.WriteLine("You fire your arrow at the creature but it seems to slightly sink in to its bony plating and it turns to you\nIts charging at you now");
                CCR();
            }
        }
        //Starts stealth combat
        static void SneakAttack()
        {
            if (Class == "BARBARIAN")
            {
                Console.WriteLine("You see the bony plating move as it turns to you");
                CCB();
            }
            else if (Class == "FIGHTER")
            {
                Console.WriteLine("You see the spacing between it's bony plating and drive your swort sword through its back and heart\nYou see it start wriggling and convulsing till it stops dead");
                Win();
            }
            else if (Class == "ROUGE")
            {
                Console.WriteLine("You see all of it's bony plating close up and all the spaces between the plating");
                Console.WriteLine("You jump onto the back of the creature and drive your dagger through a space in the plating killing it instantly");
                Win();
            }
            else if (Class == "RANGER")
            {
                Console.WriteLine("Your expert eyes notice the bony plating and spaces between them along with the eyes even from far away");
                LRC();
            }
        }
        //Death screen
        static void Death()
        {
            Console.WriteLine("\nYou realize you died for a second time and now you are forced to stay dead");
        }
        //Ranger close combat
        static void LRC()
        {
            Console.WriteLine("What do you do\n1) Fire the arrow through its eyes | 2) Fire it through the space in the plating | 3) Run away\n");
            string action = Console.ReadLine();
            if (action == "1")
            {
                Console.WriteLine("You fire your arrow through one of its eyes and it drops dead");
            }
            else if (action == "2")
            {
                Console.WriteLine("The arrow flies through a space in the plating and into the creatures cheast and it keels over dead\n");
                Win();
            }
            else if(action == "3")
            {
                Console.WriteLine("You run away and fall off the edge of a cliff and fall for around thirty minutes before hitting the ground");
                Death();
            }
            else
            {
                Console.WriteLine("Pick again");
                LRC();
            }
        }
        //Barbarian close combat
        static void CCB()
        {
            Console.WriteLine("What do you do\n1) Swing your axe towards the space on the neck of the creature | 2) Run away\n");
            string action = Console.ReadLine();
            if (action == "1")
            {
                Console.WriteLine("You cleanly decapitate the creature\n");
                Win();
            }
            else if (action == "2")
            {
                Console.WriteLine("You run and get caught by the tentacles of the creature and realize you can't move anymore\nIt towers over your paralized form and starts eating you");
                Death();
            }
            else
            {
                Console.WriteLine("Pick again");
                CCB();
            }
        }
        //Win\End game
        static void Win()
        {
            Console.WriteLine("As you stand over the dead creature you realise it was overlooking a cliff");
            Console.WriteLine("You look over and see a vast land with deserts and forests that probably have tons of creatures\nYou relize you will have to explore these lands to find out what brought you back from the dead");
            Console.WriteLine("To be continued");
        }
        //Close combat for ranger
        static void CCR()
        {
            Console.WriteLine("What do you do now\n1) Dodge | 2) Use your dagger to fight | 3) Run away");
            string action = Console.ReadLine();
            if (action == "1")
            {
                Console.WriteLine("you dodge the creture as it lunges at you");
                CCR();
            }
            else if (action == "2")
            {
                Console.WriteLine("You drive your dagger into a chink in the bony plates and it starts convulsing and dying");
                Win();
            }
            else if (action == "3")
            {
                Console.WriteLine("You run and get caught by the tentacles of the creature and realize you can't move anymore\nIt towers over your paralized form and starts eating you");
                Death();
            }
            else
            {
                Console.WriteLine("Pick again\n");
                CCR();
            }
        }
        //Close combat for fighter
        static void CCF()
        {
            Console.WriteLine("What do you do\n1) Drive your sword deeper | 2) jump off the creature and use your dagger to continue the fight | 3) Run) ");
            string action = Console.ReadLine();
            if (action == "1")
            {
                Console.WriteLine("You drive the sword deeper in the creature and it starts convulsing");
                Win();
            }
            else if (action == "2")
            {
                Console.WriteLine("You flip off the creature and charge at it and drive your dagger through a space in its plating killing it");
                Win();
            }
            else if(action == "3")
            {
                Console.WriteLine("You run and get caught by the tentacles of the creature and realize you can't move anymore\nIt towers over your paralized form and starts eating you");
                Death();
            }
            else
            {
                Console.WriteLine("Pick again\n");
                CCR();
            }
        }
    }
}
