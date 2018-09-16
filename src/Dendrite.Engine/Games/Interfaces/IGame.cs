using Dendrite.Engine.Actions;

namespace Dendrite.Engine.Games.Interfaces
{
    public interface IGame
    {
        string Name { get; set; }
        void SetupGame(RunnerOptions options);
        void Begin();

    }
}
