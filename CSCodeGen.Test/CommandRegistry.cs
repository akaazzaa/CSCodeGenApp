namespace CSCodeGen.Test
{
    public class CommandRegistry
    {
        private readonly Dictionary<string, ICommand> commands = new();

        public void RegisterCommand(ICommand command)
        {
            commands[command.Name] = command;
        }

        public ICommand? GetCommand(string name)
        {
            commands.TryGetValue(name, out var command);
            return command;
        }

        public IEnumerable<ICommand> GetCommands()
        {
            return commands.Values;
        }

        public void ExecuteCommand(string input)
        {
            var parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length == 0) return;

            string commandName = parts[0].ToLower();
            string[] args = parts.Length > 1 ? parts[1..] : Array.Empty<string>();

            var command = GetCommand(commandName);
            if (command != null)
            {
                command.Execute(args);
            }
            else
            {
                Console.WriteLine($"Unbekannter Befehl: {commandName}");
            }
        }
    }
}
