/*
 Author: Akeem Brown
 Date: 07/22/2024
 Purpose: The class below will harness all code that
          has nothing effecting with events or the windows from UI
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Hangman_Game
{
    internal class Functionality
    {
        public string[] fruits = 
            {
                "apple", "banana", "cherry", "date", "elderberry",
                "fig", "grape", "honeydew", "kiwi", "lemon",
                "mango", "nectarine", "orange", "papaya", "quince",
                "raspberry", "strawberry", "tangerine", "ugli", "vanilla",
                "watermelon", "xigua", "yellowfruit", "zucchini"
            };
        // The function will randomly select words from a List of strings.
        public string WordSelect()
        {
            ArrayList Words = new ArrayList();
            Words.AddRange(fruits);

            Random selectRandom = new Random();

            int index = selectRandom.Next(Words.Count);
            string selectedWord = Words[index].ToString();

            return selectedWord;
        }

        // The function will convert the string to an ArrayList for later use
        public ArrayList ConvertToArray(string word)
        {
            ArrayList newWord = new ArrayList();

            foreach (char c in word)
            {
                newWord.Add(c);
            }

            return newWord;
        }

        // The function will take an ArrayList and convert all elements to underscores
        public ArrayList MakeHidden(ArrayList array)
        {
            ArrayList hiddenWord = new ArrayList();

            for (int i = 1; i <= array.Count; i++)
            {
                hiddenWord.Add("_ ");
            }

            return hiddenWord;
        }

        // This function will compare two ArrayLists and compare them if they are equal to one another
        public bool AreTheySame(ArrayList arr1, ArrayList arr2)
        {
            if (arr1.Count != arr1.Count)
                return false;

            for (int i = 0; i < arr1.Count; i++)
            {
                if (!arr1[i].Equals(arr2[i]))
                    return false;
            }

            return true;
        }
    }
}
