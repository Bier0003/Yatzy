//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Diagnostics.CodeAnalysis;
//using System.Globalization;
//using static System.Formats.Asn1.AsnWriter;

//namespace Yatzy
//{
//    internal class Logic(int newValue)
//    {
       
//        public int AddUpDice(int DieNumber, Dice[] myDice)
//        {
//            int Sum = 0;

//            for (int i = 0; i < 5; i++)
//            {
//                if (myDice[i].Sides == DieNumber)
//                {
//                    Sum += DieNumber;
//                }
//            }

//            return Sum;
//        }
//        public int CalculateThreeOfAKind(Dice[] myDice)
//        {
//            int Sum = 0;

//            bool ThreeOfAKind = false;

//            for (int i = 1; i <= 6; i++)
//            {
//                int Count = 0;
//                for (int j = 0; j < 5; j++)
//                {
//                    if (myDice[j].Sides == i)
//                        Count++;

//                    if (Count > 2)
//                        ThreeOfAKind = true;
//                }
//            }

//            if (ThreeOfAKind)
//            {
//                for (int k = 0; k < 5; k++)
//                {
//                    Sum += myDice[k].Sides;
//                }
//            }

//            return Sum;
//        }


//        public int FullHouse(Dice[] myDice)
//        {
//            int Sum = 0;
//            int[] i = new int[5];

//            i[0] = myDice[0].Sides;
//            i[1] = myDice[1].Sides;
//            i[2] = myDice[2].Sides;
//            i[3] = myDice[3].Sides;
//            i[4] = myDice[4].Sides;

//            if (((i[0] == i[1]) && (i[1] == i[2])//three of a kind
//                && (i[3] == i[4]) //two of a kind
//                && (i[2] != (i[3]) ||
//                (i[0] != i[1]) // two if kind
//                && (i[2] == i[3]) && (i[3] == i[4]) && (i[1] != i[2])//three of kind
//                )))
//            {
//                Sum = 25;
//            }
//            return Sum;
//        }

//        public int LargeStaight(Dice[] myDice)
//        {
//            int sum = 0;
//            int[] i = new int[5];

//            i[0] = myDice[0].Sides;
//            i[1] = myDice[1].Sides;
//            i[2] = myDice[2].Sides;
//            i[3] = myDice[3].Sides;
//            i[4] = myDice[4].Sides;

//            Array.Sort(i);
//            if (((i[0] == 1) &&
//                (i[1] == 2) &&
//                (i[2] == 3) &&
//                (i[3] == 4) &&
//                (i[4] == 5)) ||
//                ((i[0] == 2) &&
//                (i[1] == 3) &&
//                (i[2] == 4) &&
//                (i[3] == 5) &&
//                (i[4] == 6)))
//            { sum = 40; }
//            return sum;
//        }

//        public int SmallStraight(Dice[] myDice)
//        {
//            int sum = 0; 
//            int[] i = new int[5];
//            i[0] = myDice[0].Sides;
//            i[1] = myDice[1].Sides;
//            i[2] = myDice[2].Sides;
//            i[3] = myDice[3].Sides;
//            i[4] = myDice[4].Sides;

//            Array.Sort(i);

//            for (int j = 0; j < 4; j++)
//            {
//                int temp = 0;
//                if (i[j] == i[j + 1])
//                {
//                    temp = i[j];
//                    for (int k = j; k < 4; k++)
//                    {
//                        i[k] = i[k + 1];
//                    }
//                    i[4] = temp;

//                }
            
//            }
//            if (((i[0] == 1) && (i[1] == 2) && (i[2] == 3) && (i[3] == 4)) ||
//                ((i[0] == 2) && (i[1] == 3) && (i[2] == 4) && (i[3] == 5)) ||
//                ((i[0] == 3) && (i[1] == 4) && (i[2] == 5) && (i[3] == 6)) ||
//                ((i[1] == 1) && (i[2] == 2) && (i[3] == 3) && (i[4] == 4)) ||
//                ((i[1] == 2) && (i[2] == 3) && (i[3] == 4) && (i[4] == 5)) ||
//                ((i[1] == 3) && (i[2] == 4) && (i[3] == 5) && (i[4] == 6)))

//            { 
//                sum = 30;
//            }
//            return sum;

//        }

//        public int Yatzee(Dice[] myDice)
//        {
//            int Sum = 0;
//            for (int i = 1; i <= 6; i++)
//            {
//                int count = 0;
//                for (int j = 0; j <5; j++ ) 
//                {
//                   if( myDice[j].Sides == i)
//                     count++;
//                    if (count > 4)
//                        Sum = 50;
//                } 
                
//            }
//            return Sum;

//        }

//        public int AddChance(Dice[] myDice)
//        {
//            int sum = 0;
//            for (int i = 0; i < 5; i++)
//            {
//                sum += myDice[i].Sides;
//            }
//            return sum;
//        }








//    }
//}
    
    



