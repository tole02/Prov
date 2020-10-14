using System;
using System.Collections.Generic;

namespace Prov
{
    public class Book
    {
        public int price = 0;

        private string name = "";

        private int rarity = 0;

        private string category = "";

        private int actualValue = 0;

        private bool cursed = false;

        private Random generator = new Random();

        public Book(){
            List<string> names = new List<string>() {"Wizards and dragons", "Haunted house", "Space adventure"};

            List<string> categories = new List<string>() {"Fantasy", "Horror", "Sci-fi"};

            int b = generator.Next(3);

            if(b == 1){
                name = names[0];
            }
            else if(b == 2){
                name = names[1];
            }
            else if(b==3){
                name = names[2];
            }

            int c =generator.Next(3);

            if(c==1){
                category = categories[0];
            }
            else if(c == 2){
                category = categories[1];
            }
            else if(c == 3){
                category = categories[2];
            }

            actualValue = generator.Next(1,11);

            rarity = generator.Next(1,6);

            int a = generator.Next(1,3);

            if(a == 1){
                cursed = true;
            }
            else if(a == 2){
                cursed = false;
            }
        }

        public void PrintInfo(){
            System.Console.WriteLine("The books name is " + name + " and it's a " + rarity + "/5 on the rarity scale. It is from the " + category + " category and is priced at " + price + ".");
        }

        public int Evaluate(){
            int d = actualValue * rarity;

            int e = generator.Next(4);

            int f = 0;

            if(e == 1){
                f = d/2;
            }
            else if(e == 2){
                f = d;
            }
            else if(e == 3){
                f = d/2 + d;           
            }
            return f;
        }

        public string GetCategory(){
            return category;
        }

        public string GetName(){
            return name;
        }

        public bool IsCursed(){
            

        }





    }
}
