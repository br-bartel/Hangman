﻿using System;

namespace HangmanProject
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Non-Player please enter a word: ");
            string userIn = Console.ReadLine();
            char[] array = userIn.ToCharArray();
            Console.Clear();
            GetLetter();
            /*for (int i = 0; i < array.Length; i++)
            {
                char letter = array[i];
                Console.WriteLine($"Letter: {letter}");                               
            }*/
        }

        internal static char GetLetter()
        {
            bool isInputLetter = false;
            char userChar = '1';
            do
            {
                Console.WriteLine("Please enter a lowercase letter: ");
                userChar = (char)Console.Read();
                if (userChar == 'a' || userChar == 'b' || userChar == 'c' || userChar == 'd' || userChar == 'e'
                    || userChar == 'f' || userChar == 'g' || userChar == 'h' || userChar == 'i' || userChar == 'j' || userChar == 'k' || userChar == 'l' || userChar == 'm'
                    || userChar == 'n' || userChar == 'o' || userChar == 'p' || userChar == 'q' || userChar == 'r' || userChar == 's' || userChar == 't' || userChar == 'u'
                    || userChar == 'v' || userChar == 'w' || userChar == 'x' || userChar == 'y' || userChar == 'z')
                {
                    isInputLetter = true;
                }

            } while (!isInputLetter);

            return userChar;

        }
    }

    /*Class Display
    {

        protected static int origRow;
        protected static int origCol;

        protected static void WriteAt(string s, int x, int y)
        {
            try
            {
                Console.SetCursorPosition(origCol + x, origRow + y);
                Console.Write(s);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
            }
        }
        //Hangman's Hangy thing

        WriteAt("O", 1, 3);
        WriteAt("O", 1, 4);
        WriteAt("O", 1, 5);
        WriteAt("O", 1, 6);
        WriteAt("O", 1, 7);
        WriteAt("O", 1, 8);
        WriteAt("O", 1, 9);
        WriteAt("O", 1, 10);
        WriteAt("O", 1, 11);
        WriteAt("O", 1, 12);
        WriteAt("O", 1, 13);
        WriteAt("O", 1, 14);
        WriteAt("O", 1, 15);
        WriteAt("O", 1, 16);
        WriteAt("O", 1, 17);
        WriteAt("O", 1, 18);
        WriteAt("O", 1, 19);
        WriteAt("O", 1, 20);
        WriteAt("O", 1, 21);
        WriteAt("O", 1, 22);
        WriteAt("O", 1, 23);
        WriteAt("O", 1, 24);
        WriteAt("O", 1, 25);
        WriteAt("O", 1, 26);
        //base
        WriteAt("O", 0, 26);
        WriteAt("O", 2, 26);
        //top thingy
        WriteAt("O", 2, 3);
        WriteAt("O", 3, 3);
        WriteAt("O", 4, 3);
        WriteAt("O", 5, 3);
        WriteAt("O", 6, 3);
        WriteAt("O", 6, 3);

        //head
        WriteAt("O", 5, 4);
        WriteAt("O", 5, 5);
        WriteAt("O", 5, 6);
        WriteAt("O", 6, 4);
        WriteAt("O", 6, 5);
        WriteAt("O", 6, 6);
        WriteAt("O", 7, 4);
        WriteAt("O", 7, 5);
        WriteAt("O", 7, 6);

        //body
        WriteAt("O",6,7);
        WriteAt("O",6,8);
        WriteAt("O",6,9);
        WriteAt("O",6,10);
        WriteAt("O",6,11);
        WriteAt("O",6,12);
        WriteAt("O",6,13);
        WriteAt("O",6,14);
        WriteAt("O",6,15);
        WriteAt("O",6,16);

        //left arm
        WriteAt("O",5,10);
        WriteAt("O",4,10);

        //right arm
        WriteAt("O",7,10);
        WriteAt("O",8,10);

        //left leg
        WriteAt("O",5,17);
        WriteAt("O",5,18);
        WriteAt("O",5,19);
        WriteAt("O",5,20);

        //right leg
        WriteAt("O",7,17);
        WriteAt("O",7,18);
        WriteAt("O",7,19);
        WriteAt("O",7,20);

    }

        class Words
    {

    }*/
}
