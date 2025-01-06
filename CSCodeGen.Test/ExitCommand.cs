namespace CSCodeGen.Test
{
    public class ExitCommand : ICommand
    {
        public string Name => "exit";
        public string Description => "Beendet das Programm.";

        public void Execute(string[] args)
        {
            Console.WriteLine("Programm wird beendet...");
            Environment.Exit(0);
        }
    }

}
