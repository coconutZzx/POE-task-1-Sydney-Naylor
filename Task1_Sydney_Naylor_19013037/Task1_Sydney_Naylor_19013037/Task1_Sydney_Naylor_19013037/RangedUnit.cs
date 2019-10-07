using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Sydney_Naylor_19013037
{
    class RangedUnit : Unit  // inherits from unit
    {
        public RangedUnit() : base(0, 0, 100, 2, 10, 5, "Ranged", 'R', false)
        {

        }
        public override void Move()
        {
            this.xPos++;
            this.yPos++;
        }
        public override void Combat()
        {

        }
        public override void Death()
        {
            if (health == 0)
            {
                
            }
        }
        public override bool InAttackRange()
        {
            return false;
        }
        public override double ReturnUnit()
        {
            return (0.0);
        }
        public override string ToString()
        {
            return ("Position: " + xPosition + ", " + yPosition + 
                "\nHealth: " + health + 
                /*"\nMax Health: " + maxHealth +*/ 
                "\nSpeed: " + speed + 
                /*"\nAttack: " + attack + 
                 * "\nAttack Range: " + attackRange +*/ 
                 "\nTeam: " + team + 
                 "\nImage: " + image 
                 /*+ "\nAttacking: " + attack*/);
        }


        public override int xPos
        {
            get
            {
                return xPosition;
            }
            set
            {
                xPosition = value;
            }
        }
        public override int yPos
        {
            get
            {
                return yPosition;
            }
            set
            {
                yPosition = value;
            }
        }
        public override int Health
        {
            get
            {
                return health;
            }
            set
            {
                health = value;
            }
        }
        public override int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                speed = value;
            }
        }
        public override int Attack
        {
            get
            {
                return attack;
            }
            set
            {
                attack = value;
            }
        }
        public override int AttackRange
        {
            get
            {
                return attackRange;
            }
            set
            {
                attackRange = value;
            }
        }
        public override string Team
        {
            get
            {
                return team;
            }
            set
            {
                team = value;
            }
        }
        public override char Image
        {
            get
            {
                return image;
            }
            set
            {
                image = value;
            }
        }
        public override bool Attacking
        {
            get
            {
                return attacking;
            }
            set
            {
                attacking = value;
            }
        }
        public override int MaxHealth
        {
            get
            {
                return maxHealth;
            }
        }
    }
}
