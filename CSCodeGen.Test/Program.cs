namespace CSCodeGen.Test
{
    internal class Program
    {


        static void Main(string[] args)
        {
            var registry = new CommandRegistry();
            var templateManager = new TemplateManager(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\Templates");

            // Befehle registrieren
            registry.RegisterCommand(new HelpCommand(registry));
            registry.RegisterCommand(new GenerateFromTemplateCommand(templateManager));
            registry.RegisterCommand(new ExitCommand());

            Console.WriteLine("Willkommen zu CSCodeGen CLI!");
            Console.WriteLine("Geben Sie 'help' ein, um verfügbare Befehle anzuzeigen.");

            while (true)
            {
                Console.Write("CodeGen> ");
                string? input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                {
                    registry.ExecuteCommand(input);
                }
            }
        }
    }
}

