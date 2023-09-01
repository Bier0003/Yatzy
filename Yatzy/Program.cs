using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Windows.Markup;

namespace Yatzy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create arr with 5 dice i there
            int[] PlayerRandomNum = new int[5];


            // make random nr for 5 dices
            Random rand = new Random();

            // get start the game by any key
            Console.WriteLine("press any key to Roll the dice");

            Console.ReadKey();

            for (int i = 0; i < 3; i++)
            {


                // build memory string  by StringBuilder
                var diceText = new StringBuilder();

                diceText.Clear();

                // create loop for store arr index 0-4 and j = amount index
                for (int j = 0; j < 5; j++)
                {
                    //value on dice from 1 to 6
                    var number = rand.Next(1, 7);
                    //position [j] value as number
                    PlayerRandomNum[j] = number;
                    //make a format from arr to string
                    diceText.AppendFormat("{0} ", number);
                }

                // show all dice number as string.
                Console.WriteLine("You get " + diceText.ToString());
                Console.WriteLine();

                // asking chance to keep , continue or change some number of dices

                Console.WriteLine("a. Change som Numbers");
                Console.WriteLine("b. Reroll all Numbers");
                Console.WriteLine("c. Keep all numbers");

                //Read condition a b or c

                ConsoleKeyInfo KeyInfo = Console.ReadKey();
                Console.WriteLine();

                //Repeat what the chioce  is picked up
                Console.WriteLine("You entered " + KeyInfo.KeyChar);
                Console.WriteLine();
                // Codition og all choices
                // a to chance some numbers and return new number
                if (KeyInfo.KeyChar == 'a')
                //index arr
                {
                    string input = Console.ReadLine();
                    char[] chars = input.ToCharArray();
                    //Sellect index arr to replace new value
                    List<char> RerollList = new List<char>();
                    RerollList.AddRange(chars);

                    foreach (var item in RerollList)
                    {

                        // make new dice in position
                        int newValue = rand.Next(1, 7);
                        PlayerRandomNum[Int32.Parse(item.ToString()) - 1] = newValue;

                        Console.WriteLine("Reroll: " + item + " with number " + newValue);

                    }
                    diceText.Clear();
                    foreach (var number in PlayerRandomNum) 
                        diceText.AppendFormat("{0} ", number);

                    
                    Console.WriteLine();
                    Console.WriteLine("You get " + diceText.ToString());
                    Console.WriteLine();
                    Console.WriteLine("a. Change som Numbers");
                    Console.WriteLine("b. Reroll all Numbers");
                    Console.WriteLine("c. Keep all numbers");
                    Console.WriteLine();

                    ConsoleKeyInfo KeyTo = Console.ReadKey();
                    Console.WriteLine();

                    //Repeat what the chioce  is picked up
                    Console.WriteLine("You entered " + KeyTo.KeyChar);
                    Console.WriteLine();

                    if (KeyTo.KeyChar == 'a')
                    //index arr
                    {
                        string input2 = Console.ReadLine();
                        char[] chars2 = input2.ToCharArray();
                        //Sellect index arr to replace new value
                        List<char> RerollList2 = new List<char>();
                        RerollList.AddRange(chars);



                        
                        Console.WriteLine();
                        Console.WriteLine("You get " + diceText.ToString());
                        Console.WriteLine();
                        Console.WriteLine("a. Change som Numbers");
                        Console.WriteLine("b. Reroll all Numbers");
                        Console.WriteLine("c. Keep all numbers");
                        Console.WriteLine();

                        ConsoleKeyInfo Key2 = Console.ReadKey();
                        Console.WriteLine();

                        //Repeat what the chioce  is picked up
                        Console.WriteLine("You entered " + KeyTo.KeyChar);
                        Console.WriteLine();


                    }
                    //b to count as continue throw as second chance
                    else if (KeyTo.KeyChar == 'b')
                    {
                        continue;
                    }
                    // c as i=3 or no need more throw and go ahead for next step
                    else
                    {

                        break;
                    }

                    Console.ReadKey();

                }



                //b to count as continue throw as second chance
                else if (KeyInfo.KeyChar == 'b')
                {
                    continue;
                }
                // c as i=3 or no need more throw and go ahead for next step
                else
                {

                    break;
                }

                Console.ReadKey();
            }









        }
    }
}