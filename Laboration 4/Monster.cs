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
        #region setters and getters
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
        #endregion
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
            int damageMultiplier=1;
            string message = "";
            int numberOfMoves = 0;
            foreach (var sword in player.inventory.swords)
            {
                if (AssetColor==Color.SILVER)
                {
                    damageMultiplier = 2;
                }
                else if (AssetColor==Color.GOLD)
                {
                    damageMultiplier = 4;
                }
            }
            do
            {
                this.HealthPoints -= (player.DamageOutput*damageMultiplier) + rng.Next(1, 25);
                player.CurrentHealthPoints -= this.DamageOutput - rng.Next(1, 20);
                numberOfMoves++;
            } while (this.HealthPoints > 0);
            message = $"Swinging your sword wildy, you managed to kill the monster in {numberOfMoves} turns";
            this.IsPassable = true;
            return message;
        }
    }
}
