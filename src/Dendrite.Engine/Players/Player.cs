using Dendrite.Engine.Games.TicTackToe.Enums;

namespace Dendrite.Engine.Players
{
    public abstract class Player
    {
        public string Name { get; set; }
        public PlayerMarker[] Positions { get; set; }
        public PlayerMarker Marker { get; set; }

        public virtual void Turn(int index = -1)
        {
        }

    }
}