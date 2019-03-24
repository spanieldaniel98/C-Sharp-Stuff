using System;

namespace FirstProgram {
    //contains main method that runs string altering program
    public class MainClass {
        static void Main() {
            var p = new Program();
            p.inputAlterer();
        }
    }

    //program that alters strings input in console, by moving their start character to the end
    public class Program {
        //for ReadLine strings
        private String userInput;

        //read an input string from the console, modify it, write the result to console
        public void inputAlterer() {
            Console.Write("Input a string: ");
            userInput = Console.ReadLine();
            Console.WriteLine(firstLetterToEnd(userInput));
            replay();
        }

        //move the first character of an input string to the end, return altered string
        public String firstLetterToEnd(String input) {
            return input.Substring(1) + input.Remove(1);
        }

        //ask if user wants to alter another input string
        public void replay() {
            Console.WriteLine("Would you like to continue (enter Y or N)?");
            userInput = Console.ReadLine();
            //if Y entered, replay
            if (userInput == "Y")
                inputAlterer();
            //if N entered, terminate program
            else if (userInput == "N")
                Console.Write("Goodbye!");
            //else ask for valid user input
            else
            {
                Console.WriteLine("Not a valid input, please try again:");
                replay();
            }
        }
    }
}