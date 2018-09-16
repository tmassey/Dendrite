using CommandLine;

namespace Dendrite.Engine.Actions
{
    [Verb("Play")]
    public class RunnerOptions
    {
        [Option('g', "Game", Required = true, HelpText = "Game to Play\n\t*TickTackToe\n\t*Lunar ")]
        public string Game { get; set; }

        [Option('p', "Players", Required = true, HelpText = "Number Of Human Players")]
        public int NumberOfHumanPlayers { get; set; }

        [Option('i', "IntelegenceMode", Required = true, HelpText = "Artificial Intelegence mode Options:\n\t*MinMax\n\t*Genetic\n\t*Anneal")]
        public string ArtificialIntelegenceMode { get; set; }
    }
}
