namespace CSCodeGen.Test
{
    public class HelpCommand : ICommand
    {
        private readonly CommandRegistry registry;

        public HelpCommand(CommandRegistry registry)
        {
            this.registry = registry;
        }

        public string Name => "help";
        public string Description => "Zeigt die Liste der verfügbaren Befehle.";

        public void Execute(string[] args)
        {
            Console.WriteLine("Verfügbare Befehle:");
            foreach (var command in registry.GetCommands())
            {
                Console.WriteLine($"  {command.Name} - {command.Description}");
            }
        }
    }
}
