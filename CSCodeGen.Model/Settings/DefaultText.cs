namespace CSCodeGen.Model.Settings
{
    public class DefaultText
    {
        public const string PREFABCLASSNAME = "Classname";
        public const string PREFABNAMESPACE = "Namespace";
        public const string PREFABVARNAME = "VariablenName";
        public const string PREFABPROPERTIENAME = "PropertyName";
        public const string PREFABMETHODENNAME = "MethodenName";
        public const string PREFABFUNCTIONNAME = "FunctionName";
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
        public string Function
        {
            get
            {
                return PREFABFUNCTIONNAME;
            }
        }
        public string Methode
        {
            get
            {
                return PREFABMETHODENNAME;
            }
        }

        #endregion
    }
}
