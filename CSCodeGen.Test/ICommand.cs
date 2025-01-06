namespace CSCodeGen.Test
{
    public interface ICommand
    {
        string Name { get; }                  // Der Name des Befehls
        string Description { get; }           // Beschreibung des Befehls
        void Execute(string[] args);          // Ausführbare Methode
    }
}
