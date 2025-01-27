
using CSCodeGen.DataAccess.Repository;
using CSCodeGen.Library;

namespace CSCodeGen.Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            PlaceholderRepository repository = new PlaceholderRepository();

            PlaceholderController placeholderController = new PlaceholderController(repository);
            
           var t =  placeholderController.GetAll();

        }
    }
}


