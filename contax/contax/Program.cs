using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contax
{
    class Program
    {
        public static class global
        { //initialize list 
            public static List<Dictionary<string, string>> contacts = new List<Dictionary<string, string>>();
        }
        static void Main()
        {
            //add default list values
            string[] maria = {"Mary", "m.sue@birds.com", "780 430 1372"};
            add(maria);
            string[] mario = {"Satan", "s.lucifer@hotmail.com", "666 666 6666"};
            add(mario);
            string[] mari = {"redacted", "r.edacted@redact.ed", "000 000 0000"};
            add(mari);
            int a = 0;
            //loop (draw) infinitely
            while (a < 47897013)
            {
                draw();
            }
        }
        static void draw()
        {
            //write commands
            Console.WriteLine("Welcome to your contacts sir");
            Console.WriteLine("1. Display contact names");
            Console.WriteLine("2. Search for contact");
            Console.WriteLine("3. Edit contact");
            Console.WriteLine("4. Add new contact");
            Console.WriteLine("5. send a hitman to eliminate contact");
            Console.WriteLine("6.    a a jdk , , fjhi  , s,sup 😉");
            //detect n scan input
            int input = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (input == 1)
            {
                //loop through all list values and print all names
                for (int i = 0; i < global.contacts.Count; i++) {
                    Console.WriteLine(Convert.ToString(global.contacts[i]["Name"]));
                }
            } else if (input == 2)
            {
                //get search input
                Console.Write("Search for: ");
                string searched = Console.ReadLine();
                bool finded = false; //bool to detect whether search was successful
                for (int i = 0; i < global.contacts.Count; i++)
                {
                    bool present = trySearch(searched, i);
                    if (present)
                    {
                        //write all info if found
                        Console.WriteLine("Name: " + Convert.ToString(global.contacts[i]["Name"]));
                        Console.WriteLine("Email: " + Convert.ToString(global.contacts[i]["Email"]));
                        Console.WriteLine("Phone: " + Convert.ToString(global.contacts[i]["Phone"]));
                        finded = true;
                    }
                }
                if (!finded)
                {
                    //if not found, do nothing
                    Console.WriteLine(searched + " not found!");
                }
            } else if (input == 3)
            {
                //search for user input
                Console.Write("Search for: ");
                string searched = Console.ReadLine();
                bool finded = false;
                for (int i = 0; i < global.contacts.Count; i++)
                {
                    bool present = trySearch(searched, i);
                    if (present)
                    {
                        //change info if found
                        Console.WriteLine(searched + " was found!");
                        Console.Write("Print the new name: ");
                        string newname = Console.ReadLine();
                        Console.Write("Print the new email: ");
                        string newmail = Console.ReadLine();
                        Console.Write("Print the new phone number: ");
                        string newnumb = Console.ReadLine();
                        global.contacts[i]["Name"] = newname;
                        global.contacts[i]["Email"] = newmail;
                        global.contacts[i]["Phone"] = newnumb;
                        break;
                    }
                }
                if (!finded)
                {
                    //do nothing if not found 
                    Console.WriteLine(searched + " not found!");
                }
            } else if (input == 4)
            { //get user input 
                Console.Write("Print the new name: ");
                string newname = Console.ReadLine();
                Console.Write("Print the new email: ");
                string newmail = Console.ReadLine();
                Console.Write("Print the new phone number: ");
                string newnumb = Console.ReadLine();
                string[] info = new string[] {newname, newmail, newnumb};
                //call creation function
                add(info);
            } else if (input == 5)
            { // search and remove. pretty simple
                Console.Write("Search for: ");
                string searched = Console.ReadLine();
                bool finded = false;
                for (int i = 0; i < global.contacts.Count; i++)
                {
                    bool present = trySearch(searched, i);
                    if (present)
                    {
                        global.contacts.RemoveAt(i);
                        finded = true; 
                    }
                }
                if (!finded)
                { //you know what this does by now
                    Console.WriteLine(searched + " not found!");
                }
            } else if (input == 6)
            { // a  a a
                System.Environment.Exit(0);
            } else
            {
                Console.WriteLine("not a valid input");
            }
        }
        static void add(string[] data)
        { //Take in string array and split into data needed
            Dictionary<string,string> newDict = new Dictionary<string,string>();
            newDict.Add("Name", data[0]);
            newDict.Add("Email", data[1]);
            newDict.Add("Phone", data[2]);
            global.contacts.Add(newDict);
        }
        static bool trySearch(string tryfor, int index)
        { //detect if list contains a value equivalent to user input string 
            if (global.contacts[index]["Name"] == tryfor) {
                return true;
            } else
            {
                return false;
            }
        }
    }
}

