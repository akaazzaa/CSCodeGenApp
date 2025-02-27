namespace CSCodeGen.DataAccess.Model.Config
{
    public class DefaultKeyword
    {
        public const string PREFABCLASSNAME = "Classname";
        public const string PREFABNAMESPACE = "Namespace";
        public const string PREFABVARNAME = "VariabelnName";
        public const string PREFABPROPERTIENAME = "PropertyName";

        #region Properties
        public string Classname
        {
            get
            {
                return PREFABCLASSNAME;
            }
        }
        public string Namespace
        {
            get
            {
                return PREFABNAMESPACE;
            }
        }
        public string Variable
        {
            get
            {
                return PREFABVARNAME;
            }
        }
        public string Propertie
        {
            get
            {
                return PREFABPROPERTIENAME;
            }
        }
        #endregion
    }
}
