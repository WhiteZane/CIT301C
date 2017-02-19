using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Mega
    {
        static void Main(string[] args)
        {
            double width;
            double length;
            int drawers;
            int material;
            int days;
            int rushCost;
            double totalSize;
            double total;
            



            Console.WriteLine("\t**************************\n\t* Order Desk Application * \n\t**************************\n");
            
            //creates an array to store the orders array and shipping prices
            double[] orders = new double[5];
            double[] rushOrder = new double[3];
            

            //calls order method and stores information in the orders array 
            orders = order();

            //assign orders array to variables with names to prevent confusion
            width = orders[1];
            length = orders[2];
            drawers = Convert.ToInt32(orders[3]);
            material = Convert.ToInt32(orders[4]);
            totalSize = width * length;

            // Reads file and puts it into an array
            //getRushOrderPricing(rushOrderArray);


            string[] prices = File.ReadAllLines("rushPrices.txt");
            double[,] rushOrderArray = new double[prices.Length, 3];
            int[,] price = new int[3, 3];

            for (int i = 0; i < prices.Length; i++)
            {
                string[] fields = prices[i].Split(' ');
                for (int j = 0; j < fields.Length; j++)
                {
                    if (j == 3) break;
                    rushOrderArray[i, j] = double.Parse(fields[j]);





                }
            }


            //calls to shipping method and store in ship array
            rushOrder = rush(rushOrderArray, totalSize);

            //sets contents of rushOrder into variables
            days = Convert.ToInt32(rushOrder[1]);
            rushCost = Convert.ToInt32(rushOrder[2]);

            //calls to pricing method and stores in total price array
            total = totalPrice(orders, rushCost);
            
            //put material type into a string
            string materialString = "";
            if (material == 1)
            {
                 materialString = (" Laminate ");
            }
            else if (material == 2)
            {
                materialString = (" Oak ");
            }
            else if (material == 3)
            {
                materialString = (" Pine ");
            }

            // convert all information to string for storage
            string rWidth = width.ToString();
            string rLength = length.ToString();
            string rDrawers = drawers.ToString();
            string rMaterial = materialString;
            string rDays = days.ToString();
            string rRushCost = rushCost.ToString(); 
            string rTotalSize = totalSize.ToString(); 
            string rTotal = total.ToString();
            

            string orderOutWidth =("\n\tWidth of Desk is : " + rWidth);
            
            string orderOutLength = ("\tLength of Desk is : " + rLength);
            
            string orderOutDrawers = ("\tNumber of Drawers : " + rDrawers);
            
            string orderOutTotalSize = ("\tTotal area of the Desk: " + rTotalSize);
            
            string orderOutMaterial = ("\tDesk will be made of: " + rMaterial);
            
            string orderOutDays = ("\tDays to complete order:" + rDays);
            
            string orderOutRush = ("\tCost of rush production: $ " + rRushCost);
            
            string orderOutTotal = ("\tTotal cost of Desk: $ " + rTotal);

            string newOrder = ("\n New Desk Order ");
            
            // write to the file all information
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"C:\Users\Public\TestFolder\DeskInfo.json", true))
            {
                file.WriteLine(newOrder);
                file.WriteLine(orderOutWidth);
                file.WriteLine(orderOutLength);
                file.WriteLine(orderOutDrawers);
                file.WriteLine(orderOutTotalSize);
                file.WriteLine(orderOutMaterial);
                file.WriteLine(orderOutDays);
                file.WriteLine(orderOutRush);
                file.WriteLine(orderOutTotal);
            }
            // read out all information in file line by line after storing in string variable

            string text = System.IO.File.ReadAllText(@"C:\Users\Public\TestFolder\DeskInfo.json");
            System.Console.WriteLine("Contents of DeskInfo.json = {0}", text);

            System.Console.WriteLine("Press any key to terminate application");
            System.Console.ReadKey();




        }

        static double[] order()
        {
            double width = 0, length = 0, drawers = 0, material = 0; // variables containing the numeric values for desk dimensions
            double[] orders = new double[5]; // array for holding order
            string widthString, lengthString, drawerString, materialString; // used to get numeric values from user

            // gets the width of the desk stores in variable width
            
                do
                {
                    Console.WriteLine(" Please enter the width of the desk in inches($5 per inch)");

                try
                {
                    widthString = Console.ReadLine();
                    width = double.Parse(widthString);
                } catch (FormatException) { }

                    
                
                }

                while (width <= 0);

                 
            
                
                
            
                

                // gets the length of the desk stores in variable length

                do
                {
                    Console.WriteLine(" Please enter the length of the desk in inches($5 per inch");
                try
                    {
                        lengthString = Console.ReadLine();
                        length = double.Parse(lengthString);
                    } catch(FormatException){ }

                } while (length <= 0);

                // check output Console.WriteLine(" length is :" + length + "\n");

                // asks for amount of drawers between 0 and 7
                do
                {
                    Console.WriteLine(" Please enter how many drawers you would like between 0 - 7 ($50 a drawer)");
                    try
                    {
                        drawerString = Console.ReadLine();
                        drawers = double.Parse(drawerString);
                    } catch { }
                } while (drawers <= -1 || drawers >= 8);

                // check output Console.WriteLine(" amount of drawers is :" + drawers + "\n");

                //Asks for what type of material and to choose corresponding number 
                //Console.WriteLine(" Please choose a material with the corresponding number\n \t 1. Laminate \n\t 2. Oak \n\t 3. Pine \n");

                //materialString = Console.ReadLine();
                //material = int.Parse(materialString);

                //Asks for what type of material and to choose corresponding number 
                do
                {
                    Console.WriteLine(" Please choose a material with the corresponding number\n" + "\t1. Laminate ($100) \n" + "\t2. Oak ($200) \n" + "\t3. Pine ($50) \n");
                    try
                    {
                        materialString = Console.ReadLine();
                        material = double.Parse(materialString);
                    } catch (FormatException){ }

                } while (material <= -1 || material >= 4); // check to make sure the number does not exceed limits

                /*if (material == 1) {
                    Console.WriteLine("\n The material you choose was : " + material + ". Laminate\n");
                } else if (material == 2) {
                    Console.WriteLine("\n The material you choose was : " + material + ". Oak\n");
                } else if (material == 3) {
                    Console.WriteLine("\n The material you choose was : " + material + ". Pine\n");
                } */

                orders[1] = width;
                orders[2] = length;
                orders[3] = drawers;
                orders[4] = material;

                return orders;
            
        }

        static double[] rush(double[,] rushOrderArray, double totalSize)
        {
            //create an array to store values
            double[,] rushTable = new double[3,3];
            double[] rushInfo = new double[3];
            double size = totalSize;
            double days = 0;
            double cost = 0;
            string daysString;
            rushTable = rushOrderArray;

            
            Console.WriteLine("\t**************************\n\t* Rush Order Pricing * \n\t**************************\n");
            Console.WriteLine(" The Area of your desk is : " + totalSize + "inches\n");
            Console.WriteLine(" \n\t\tRush order pricing table\n");
            Console.WriteLine(" \t\t\tSize of desk \n\t < 1000 in \t 1000 - 1999 \t 2000+ ");
            Console.WriteLine("  3days\t $ " + rushTable[0, 0] +"\t       $ " + rushTable[1, 0] + "\t\t $ " + rushTable[2,0] );
            Console.WriteLine("  5days\t $ " + rushTable[3, 0] + "\t       $ " + rushTable[4, 0] + "\t\t $ " + rushTable[5, 0]);
            Console.WriteLine("  7days\t $ " + rushTable[6, 0] + "\t       $ " + rushTable[7, 0] + "\t\t $ " + rushTable[8, 0]);

            Console.WriteLine("\n\t Regular production takes 14 days. ");
            do
            {
                Console.WriteLine("\n\t If you would like to rush the order enter days 3,5,7 or 0 if you don't wish to rush ");
                try
                {
                    daysString = Console.ReadLine();
                    days = double.Parse(daysString);
                } catch (FormatException) { }

            } while (days != 3 && days !=5 && days != 7 && days!= 0 );

            //determine cost of rush order
            if (days == 3)
            {
                if (size < 1000 )
                {
                    cost = rushTable[0,0];
                 
                } else if (size >= 1000 && size <= 1999) 
                    {
                    cost = rushTable[1, 0];
                    
                } else if (size >= 2000)
                {
                    cost = rushTable[2, 0];
                    
                }
            }

            if (days == 5)
            {
                if (size < 1000)
                {
                    cost = rushTable[3, 0];
                    
                }
                else if (size >= 1000 && size <= 1999)
                {
                    cost = rushTable[4, 0];
                    
                }
                else if (size >= 2000)
                {
                    cost = rushTable[5, 0];
                    
                }
            }
            if (days == 7)
            {
                if (size < 1000)
                {
                    cost = rushTable[6, 0];
                    
                }
                else if (size >= 1000 && size <= 1999)
                {
                    cost = rushTable[7, 0];
                    
                }
                else if (size >= 2000)
                {
                    cost = rushTable[8, 0];
                    
                }
            }

            if (days == 0)
            {
                days = 14;
                cost = 0;
            }

            rushInfo[1] = days;
            rushInfo[2] = cost;
            return rushInfo;
        }

        static double totalPrice(double[] orders, int rushCost)
        {
            double total; //intial price of desk
            double width = orders[1]; // $5 per inch
            double length = orders[2]; // $ 5per inch
            double drawers = orders[3]; // $ 50 per drawer
            double drawerTotal = 0;
            double material = orders[4]; // 1 laminate ($100) 2 oak ($200) 3 pine ($50)
            double totalInch;
            double intialCost = 200;
            double costRush = rushCost;
            double costInch = 0;

            totalInch = (width * length);

            if (totalInch >= 1000)
            {
                double subtract = totalInch - 1000;
                costInch = subtract * 5;
            }
             

            //check for price of material and set the price

            if (material == 1)
            {
                material = 100;
            } else if (material == 2)
            {
                material = 200;
            } else if (material == 3)
            {
                material = 50;
            }
            drawerTotal = (drawers * 50);

            total = costInch + intialCost + drawerTotal + material;

            return total;
        }



    }
}


