using Dendrite.Engine.Players;

namespace Dendrite.Engine.Games.TicTackToe
{
    public class TickTackToe
    {
        public TickTackToe()
        {
            Board=new Board(3);
            Players = new Player[2];
            Players[0] = new HumanPlayer();
            Players[1] = new ComputerPlayer();
        }
        public Board Board { get; set; }
        public Player[] Players { get; set; }

    }
}
