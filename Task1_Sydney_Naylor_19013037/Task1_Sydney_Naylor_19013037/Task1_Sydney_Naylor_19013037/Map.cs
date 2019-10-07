using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;


namespace Task1_Sydney_Naylor_19013037
{
    class Map
    {
        //public int x = 20;
        //public int y = 20;

        const int X = 20;
        const int Y = 20;
        public int numberUnits;
        

        private Unit[] units;
        Random random = new Random();
        char[,] populate = new char[X, Y];  // string[,] populate = new string[20, 20];

        public Map(int numberUnits)
        {
            this.units = new Unit[numberUnits];
        }

        public void GenerateBattlefield()
        {
            // array to store things
            // for loop to generate units randomly 
            
            for(int i = 0; i < units.Length; i++)  // controls number of times the loop is executed, for loop will be executed as long as this condition is valid, increment 
            {
                int variable = random.Next(0, 2);

                // sequence of statements that will execute repeatedly 

                if (variable == 0)  // random.Next(0, 2) == 0
                {
                    units[i] = new MeleeUnit();
                }
                else
                {
                    units[i] = new RangedUnit();
                }
                units[i].xPos = random.Next(0, X);
                units[i].yPos = random.Next(0, Y);
            }
        }

        public void Populate()
        {
            // 2d array of string and fill it with either nothing(blank spaces) or someother place holder
            // 2 for loops to manage x and y
            populate = new char[X, Y];

            for (int i = 0; i < units.Length; i++)
            {
                Unit unit = units[i];
                populate[unit.xPos, unit.yPos] = unit.Image;
            }

            for (int x = 0; x < 20; x++)
            {
                for(int y = 0; y < 20; y++)
                {
                    if (populate[x, y] == '\0')
                    {
                        populate[x, y] = '_';
                    }
                }
            }
        }

        public void Render(Label lbl)
        {
            lbl.Text = "";
            for (int x = 0; x < 20; x++)
            {
                for (int y = 0; y < 20; y++)
                {
                    lbl.Text = lbl.Text + populate[x, y];
                }
                lbl.Text += "\n";
            }
        }
        //public void Update(Label lbl)  // int x, int y, Unit u
        //{
        //    /*populate[u.xPos, u.yPos] = ',';
        //    u.xPos = x;
        //    u.yPos = y;
        //    populate[u.xPos, u.yPos] = u.Image;*/
        //    System.Diagnostics.Debug.WriteLine("Updating...");
        //    lbl.Text = "";

        //    for (int x = 0; x < X; x++)
        //    {
        //        for (int y = 0; y < Y; y++)
        //        {
        //            lbl.Text += populate[x, y];
        //        }
        //        lbl.Text += "\n";
        //    }
        //    System.Diagnostics.Debug.WriteLine("Units placed...");

        //}
        public string GetInfo()
        {
            string info = "";
            for (int i = 0; i < units.Length; i++)
            {
                info += units[i].ToString() + "\n\n";
            }
            return info;
        }
        //public void Information (TextBox txtBox)
        //{
        //    for (int i = 0; i < numberUnits ; i++)
        //    {
        //        txtBox.Text += units[i].ToString();
        //    }
        //}
    }
}
