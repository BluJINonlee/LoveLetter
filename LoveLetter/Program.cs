using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            //array for the script
            string[] stanza = new string[100];
            
            //the script
            stanza[0] = "Hello Jasmine..." +
                "\n(Press any key to continue)";
            stanza[1] = "Do not be alarmed...I do you no harm.";
            stanza[2] = "I am not a virus or anything...";
            stanza[3] = "I am just a messanger...created by someone who loves you very much!";
            stanza[4] = "How many years have you and Josh been together?";
            stanza[5] = "I did not know relationships between you humans lasted that long. I stand corrected!";
            stanza[6] = "However, I should not be suprised considering the things that he have told me concerning you...";
            stanza[7] = "You have made him feel like the \"luckiest man in the world\".";
            stanza[8] = "Now, I do not really know what luck is, but I asked the server of Dictionary.com. \nI compute the closest thing that we have in our computer language is a ratio approximately 1 out of 186587812E10E10 chance of you an his union occuring. I guess that means the phenomenom is rare in human terms.";
            stanza[9] = "Well, isn't that special! ";
            stanza[10] = "I must be honest, though...";
            stanza[11] = "I wasn't sent to deliver a message...";
            stanza[12] = "but to collect a message too!";
            stanza[13] = "There some knowledge that he would like me to acquire from you.";
            stanza[14] = "Let's begin.";
            stanza[15] = "If you can be anywhere in the world, where would you like to be?";
            stanza[16] = "When you're not at your residence (or \"localhost\" as we call it), what destination do you most desire to visit?";
            stanza[17] = "What is one gift you would like from your husband in the near future? (Josh said \"House\" is not an acceptable answer)";
            stanza[18] = "How about for your birthday?";
            stanza[19] = "Christmas?";

            stanza[20] = "Okay. That's enough questions for now...";
            stanza[21] = "I have withheld some of the message I have been tasked with delivering to you...";
            stanza[22] = "There are a few things you should know...";
            stanza[23] = "1.";
            stanza[24] = "You make Josh, smile.";
            stanza[25] = "Over the years you have interfaced with each other, you have truly inspired him";
            stanza[26] = "You have incremented his variable \"value\" variable significantly.";


            PlayScript(stanza);
            
        }
        
        static public void PlayScript(string[] Script)
        {
            for (int i = 0; i < Script.Length; i++)
            {
                Console.WriteLine(Script[i]);
                string answer = Console.ReadLine();

                // Clears on every multiple of 3

                if (i % 3 == 0 && i != 0)
                {
                    Console.Clear();
                }

                // On the fourth question...
                if (i == 4)
                {
                    // If the answer is blank.
                    if (answer == "")
                    {
                        Console.WriteLine("Oh...So you're just not gonna answer, huh? Let's try that again.");
                        i = 3;
                    }
                    // If the answer is not 4
                    else if (answer != "4" && answer != "four")
                    {
                        Console.WriteLine("Are you sure about that? Let try that again...");
                        i = 3;
                    }
                    else
                    {
                        Console.WriteLine("Wow..." + answer + " years. That's like a lifetime for me!");
                    }
                }
                

            }
        }
    }
}
