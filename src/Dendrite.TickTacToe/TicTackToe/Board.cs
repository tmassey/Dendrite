using Dendrite.Engine.Games.TicTackToe.Enums;

namespace Dendrite.Engine.Games.TicTackToe
{
    public class Board
    {
        public int Size { get; set; }
        public PlayerMarker[] Positions { get; set; }

        public Board(int size)
        {
            Positions = new PlayerMarker[size*size];
            Size = size;
        }
    }
}