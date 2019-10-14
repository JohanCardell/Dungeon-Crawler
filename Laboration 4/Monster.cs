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
        public Monster(int positionX, int positionY)
            : this(positionX, positionY, false, false, 'M', Color.GREEN)
        {
            this.healthPoints = 100;
            this.damageOutput = 20;
        }
        public Monster(int positionX, int positionY, bool isPassable, bool isVisible, char mapRepresentation, Color color)
            : base(positionX, positionY, isPassable, isVisible, mapRepresentation, color) { }
        public string Interact(Player player)
        {
            Random rng = new Random();
            string message = "";
            int numberOfTurns = 0;
            while (this.HealthPoints > 0)
            {
                this.HealthPoints -= this.HealthPoints - player.DamageOutput + rng.Next(1, 25);
                player.CurrentHealthPoints -= this.DamageOutput + rng.Next(1, 20);
                numberOfTurns++;
            }
            message = $"Swinging your sword wildy, you managed to kill the monster in {numberOfTurns} turns";
            this.IsPassable = true;
            return message;
        }
    }
}
