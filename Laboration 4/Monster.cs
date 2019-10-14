using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_4
{
    class Monster : GameObject, IInteractable
    {
        private int healthPoints;
        private int damageOutput;
        public int HealthPoints
        {
            get => healthPoints;
            set => healthPoints = value;
        }
        public int DamageOutput
        {
            get => damageOutput;
            set => damageOutput = value;
        }
        public Monster(uint positionX, uint positionY)
            : this(positionX, positionY, false, false, 'M', Color.GREEN)
        {
            this.healthPoints = 100;
            this.damageOutput = 20;
        }
        public Monster(uint positionX, uint positionY, bool isPassable, bool isVisible, char mapRepresentation, Color color)
            : base(positionX, positionY, isPassable, isVisible, mapRepresentation, color) { }
        public string Interact(Player player)
        {
            bool inCombat = true;
            Random rng = new Random();
            string message = "";
            while (this.HealthPoints > 0 && inCombat == true)
            {
                this.HealthPoints -= this.HealthPoints - player.DamageOutput + rng.Next(0, 6);
                player.CurrentHealthPoints -= this.DamageOutput + rng.Next(0, 6);
                Console.Clear();
                message = $"You recieved {this.DamageOutput + rng.Next(0, 20)} damage from the monster, and dealt {player.DamageOutput + rng.Next(0, 6)} damage to the monster. ";
                if (player.CurrentHealthPoints <= 0 || this.HealthPoints <= 0) inCombat = false;
            }
            this.IsPassable = true;
            return message;
        }
    }
}
