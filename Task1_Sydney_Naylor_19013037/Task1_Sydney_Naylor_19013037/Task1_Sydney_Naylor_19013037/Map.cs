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

        const int MAPSIZE = 20;
        Random random = new Random();
        int numberUnits;
        Unit[] units;
        string[,] map;
        string[] teams = { "Zombies", "Survivors" };

        //char[,] populate = new char[X, Y];  // string[,] populate = new string[20, 20];

        public Map(int numberUnits)
        {
            this.numberUnits = numberUnits;
            Reset();
        }
        public Unit[] Units
        {
            get
            {
                return units;
            }
        }
        public Building[] Buildings
        {
            get
            {
                return buildings;
            }
        }
        public int Size
        {
            get
            {
                return MAPSIZE;
            }
        }

        public string GetMapDisplay()
        {
            string mapString = "";
            for (int y = 0; y < MAPSIZE; y++)
            {
                for (int x = 0; x < MAPSIZE; x++)
                {
                    mapString += map[x, y];
                }
                mapString += "\n";
            }
            return mapString;
        }
        public void Reset()
        {
            map = new string[MAPSIZE, MAPSIZE];
            units = new Unit[numberUnits];
            buildings = new Building[numberBuildings];
            InitializeUnits();
            UpdateMap();
        }
        public void UpdateMap()
        {
            for (int y = 0; y < MAPSIZE; y++)
            {
                for (int x = 0; x < MAPSIZE; x++)
                {
                    map[x, y] = " . ";
                }
            }
            foreach (Unit unit in units)
            {
                map[unit.xPos, unit.yPos] = unit.Team[0] + "/" + unit.Image;
            }
        }

        private void InitializeUnits()
        {
            for (int i = 0; i < units.Length; i++)
            {
                int xPosition = random.Next(0, MAPSIZE);
                int yPosition = random.Next(0, MAPSIZE);
                int teamIndex = random.Next(0, 2);
                int unitType = random.Next(0, 2);

                while (map[xPosition, yPosition] != null)
                {
                    xPosition = random.Next(0, MAPSIZE);
                    yPosition = random.Next(0, MAPSIZE);
                }
                if (unitType == 0)
                {
                    units[i] = new MeleeUnit(xPosition, yPosition, teams[teamIndex]);
                }
                else
                {
                    units[i] = new RangedUnit(xPosition, yPosition, teams[teamIndex]);
                }
                map[xPosition, yPosition] = units[i].Team[0] + "/" + units[i].Image;
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
