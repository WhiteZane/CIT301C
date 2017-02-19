using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD
using System.IO;
=======
>>>>>>> 369684e222fc63696fc4d4b2500343bb1c648181

namespace MegaEscarito
{
    public enum Material {Oak, Pine, Laminate, Purpleheart, Zebrawood, Mahogany};

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Array valArray = Enum.GetValues(typeof(Material));

            foreach (Material materialValue in valArray)
            {
                material.Items.Add(materialValue);
            }

            material.SelectedIndex = 0;

            //Initialize Order Days options
            Dictionary<int, string> orderDayOptions = new Dictionary<int, string>();
            orderDayOptions.Add(14, "14 days (standard)");
            orderDayOptions.Add(3, "3 days (rush)");
            orderDayOptions.Add(5, "5 days (rush)");
            orderDayOptions.Add(7, "7 days (rush)");

            orderDays.DataSource = new BindingSource(orderDayOptions, null);
            orderDays.DisplayMember = "Value";
            orderDays.ValueMember = "Key";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // Material material = (Material)material.SelectedItem;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            String errorList = "";
            int varWidth = 1;
            int varLength = 1;
            int varDrawerCount = 0;
            Material varMaterial = Material.Oak;
            int varOrderDays = 14;

            //**** VALIDATION SECTION ****

            //width
            if (width.Text.Trim() == "")
            {
                errorList += "Width is required.\n";
            }
            else
            {
                try
                {
                    varWidth = int.Parse(width.Text);
                }
                catch
                {
                    errorList += "Please enter a valid width (in inches).\n";
                }
            }

            //length
            if (length.Text.Trim() == "")
            {
                errorList += "Length is required.\n";
            }
            else
            {
                try
                {
                    varLength = int.Parse(length.Text);
                }
                catch
                {
                    errorList += "Please enter a valid length (in inches).\n";
                }
            }

            //material
            if (!Enum.IsDefined(typeof(Material), material.SelectedItem))
            {
                errorList += "Please select a valid material.\n";
            }
            else
            {
                varMaterial = (Material)material.SelectedItem;
            }

            //drawers
            if (drawerCount.Value < 0 || drawerCount.Value > 7)
            {
                errorList += "Please select number of drawers between 0 - 7.\n";
            }
            else
            {
                varDrawerCount = (int)drawerCount.Value;
            }

            //orderDays
            try
            {
                varOrderDays = ((KeyValuePair<int, string>)orderDays.SelectedItem).Key;
                if (varOrderDays != 3 && varOrderDays != 5 && varOrderDays != 7 && varOrderDays != 14)
                {
                    errorList += "Please select valid order days (3, 5, 7, or 14).\n";
                }
            }
            catch
            {
                errorList += "Please select valid order days (3, 5, 7, or 14).\n";
            }
    
            //if any errors then display them and return
            if (errorList.Length > 0) {
                MessageBox.Show(errorList);
                return;
            }

            DeskOrder myDeskOrder = new MegaEscarito.DeskOrder(varWidth, varLength, varDrawerCount, varMaterial, varOrderDays);

        }

    }
    public class DeskOrder
    {
        private Material material;

        public DeskOrder(int inWidth, int inLength, int inDrawerCount, Material inMaterial, int inOrderDays)
        {
<<<<<<< HEAD
            //asigning to new variables
            int width = inWidth;
            int length = inLength;
            int drawers = inDrawerCount;
            int days = inOrderDays;
            int totalSize = width * length;
            
            
            
            // rush order Array read in, You might want to use yours mine is [9,0]
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
            
            // figure out cost of rush order
            double[,] rushTable = new double[3, 3];
            double[] rushInfo = new double[3];
            double size = totalSize;
            double cost = 0;
            rushTable = rushOrderArray;

            if (days == 3)
            {
                if (size < 1000)
                {
                    cost = rushTable[0, 0];

                }
                else if (size >= 1000 && size <= 1999)
                {
                    cost = rushTable[1, 0];

                }
                else if (size >= 2000)
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

            if (days == 14)
            {
                cost = 0;
            }

            rushInfo[1] = days;
            rushInfo[2] = cost;
            
            // figure out cost send it to total
            double totalPrice = Total(totalSize, drawers, cost);

            string x2 = System.Convert.ToString(totalPrice);
            MessageBox.Show(x2);






        }
        private double Total(int totalSize, int drawers, double cost)
        {
            double totals = 0;
            double totalInch;
            double costInch = 0;
            double drawerTotal;
            double intialCost = 200;
            
            //used for finding price of area
            totalInch = totalSize;

            if (totalInch >= 1000)
            {
                double subtract = totalInch - 1000;
                costInch = subtract * 5;
            }
            //cost of drawers
            drawerTotal = (drawers * 50);

            totals = costInch + intialCost + drawerTotal;

         
            return totals;
=======

>>>>>>> 369684e222fc63696fc4d4b2500343bb1c648181
        }

        public void SetMaterial(MegaEscarito.Material deskMaterial)
        {
            this.material = deskMaterial;
            MessageBox.Show(deskMaterial.ToString());
        }
        
    }
}
