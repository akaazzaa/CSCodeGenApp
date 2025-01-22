using System.Collections.Generic;

namespace CSCodeGen.Library
{
    public class PlaceholderController
    {
        PlaceholderRepository placeholderRepository;

        public PlaceholderController()
        {
            placeholderRepository = new PlaceholderRepository();
        }

        public List<Placeholder> Placeholder()
        {
            return placeholderRepository.GetAllPlaceholder();
        }
    }
}
