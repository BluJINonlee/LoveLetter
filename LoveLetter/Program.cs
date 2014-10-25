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
