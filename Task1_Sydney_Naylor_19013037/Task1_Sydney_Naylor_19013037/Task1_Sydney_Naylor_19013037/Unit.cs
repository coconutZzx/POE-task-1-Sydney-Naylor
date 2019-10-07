using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Sydney_Naylor_19013037
{
    abstract class Unit  // abstract class
    {
        // protected declarations 

        protected int xPosition;
        protected int yPosition;
        protected int health;
        protected int maxHealth;
        protected int speed;
        protected int attack;
        protected int attackRange;
        protected string team;
        protected char image;
        protected bool attacking;

        // constructor that recieves parameters for every class variable excluding maxHealth
        public Unit(int xPos, int yPos, int Health, int Speed, int Attack, int AttackRange, string Team, char Image, bool Attacking)  
        {
            this.xPosition = xPos;
            this.yPosition = yPos;
            this.health = Health;
            this.speed = Speed;
            this.attack = Attack;
            this.attackRange = AttackRange;
            this.team = Team;
            this.image = Image;
            this.attacking = Attacking;
        }

        // abstract methods within class
        public abstract void Move();
        public abstract void Combat();
        public abstract bool InAttackRange();
        public abstract double ReturnUnit();
        public abstract void Death();
        public abstract string ToString();


        public abstract int xPos
        {
            get; set;
        }
        public abstract int yPos
        {
            get; set;
        }
        public abstract int Health
        {
            get; set;
        }
        public abstract int Speed
        {
            get; set;
        }
        public abstract int Attack
        {
            get; set;
        }
        public abstract int AttackRange
        {
            get; set;
        }
        public abstract string Team
        {
            get; set;
        }
        public abstract char Image
        {
            get; set;
        }
        public abstract bool Attacking
        {
            get; set;
        }
        public abstract int MaxHealth
        {
            get;
        }
    }
}
