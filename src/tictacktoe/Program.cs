using System;
using CommandLine;
using Dendrite.Engine.Actions;

namespace Dendrite
{
    class Program
    {
        static void Main(string[] args)
        {


            Parser.Default.ParseArguments<RunnerOptions>(args)
                .WithParsed(opts => RunOptionsAndReturnExitCode(opts))
                .WithNotParsed(errs => HandleParseError(errs));
        }

        private static void RunOptionsAndReturnExitCode(RunnerOptions opts)
        {
            switch (opts.Game)
            {
                case "TickTackToe":
                    break;
                case "Lunar":
                    break;
            }

            //throw new NotImplementedException();
            Console.WriteLine("Press enter to close!");
            Console.ReadLine();
        }

        private static void HandleParseError(object errs)
        {
            //throw new NotImplementedException();
            Console.WriteLine("Press enter to close!");
            Console.ReadLine();
        }
    }
}
