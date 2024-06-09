using Dictionary.Dictionary;

namespace DependencyParser.Universal
{
    public class UniversalDependencyTreeBankWord : Word
    {
        private readonly int _id;
        private readonly string _lemma;
        private readonly UniversalDependencyPosType _upos;
        private readonly string _xpos;
        private UniversalDependencyTreeBankFeatures _features;
        private UniversalDependencyRelation _relation;
        private readonly string _deps;
        private readonly string _misc;

        /// <summary>
        /// Constructor of the universal dependency word. Sets the attributes.
        /// </summary>
        /// <param name="id">Id of the word</param>
        /// <param name="name">Name of the word</param>
        /// <param name="lemma">Lemma of the word</param>
        /// <param name="upos">Universal part of speech tag.</param>
        /// <param name="xpos">Extra part of speech tag</param>
        /// <param name="features">Feature list of the word</param>
        /// <param name="relation">Universal dependency relation of the word</param>
        /// <param name="deps">External dependencies for the word</param>
        /// <param name="misc">Miscellaneous information for the word.</param>
        public UniversalDependencyTreeBankWord(int id, string name, string lemma, UniversalDependencyPosType upos,
            string xpos, UniversalDependencyTreeBankFeatures features,
            UniversalDependencyRelation relation, string deps, string misc) : base(name)
        {
            _id = id;
            _lemma = lemma;
            _upos = upos;
            _xpos = xpos;
            _deps = deps;
            _features = features;
            _relation = relation;
            _misc = misc;
        }

        /// <summary>
        /// Default constructor for the universal dependency word. Sets the attributes to default values.
        /// </summary>
        public UniversalDependencyTreeBankWord() : base("root"){
            _id = 0;
            _lemma = "";
            _upos = UniversalDependencyPosType.X;
            _xpos = "";
            _features = null;
            _deps = "";
            _misc = "";
            _relation = new UniversalDependencyRelation(-1, "DEP");
        }

        public new UniversalDependencyTreeBankWord Clone()
        {
            var word = new UniversalDependencyTreeBankWord(_id, name, _lemma, _upos, _xpos, null, null, _deps, _misc);
            word._features = _features.Clone();
            if (_relation != null)
            {
                word._relation = _relation.Clone();
            }
            else
            {
                word._relation = null;
            }

            return word;
        }

        /// <summary>
        /// Accessor for the id attribute.
        /// </summary>
        /// <returns>Id attribute</returns>
        public int GetId()
        {
            return _id;
        }

        /// <summary>
        /// Accessor for the lemma attribute
        /// </summary>
        /// <returns>Lemma attribute</returns>
        public string GetLemma()
        {
            return _lemma;
        }

        /// <summary>
        /// Accessor for the upos attribute
        /// </summary>
        /// <returns>Upos attribute</returns>
        public UniversalDependencyPosType GetUpos()
        {
            return _upos;
        }

        /// <summary>
        /// Accessor for the xpos attribute
        /// </summary>
        /// <returns>Xpos attribute</returns>
        public string GetXpos()
        {
            return _xpos;
        }

        /// <summary>
        /// Accessor for the features attribute
        /// </summary>
        /// <returns>Features attribute</returns>
        public UniversalDependencyTreeBankFeatures GetFeatures()
        {
            return _features;
        }

        /// <summary>
        /// Gets the value of a given feature.
        /// </summary>
        /// <param name="featureName">Name of the feature</param>
        /// <returns>Value of the feature</returns>
        public string GetFeatureValue(string featureName)
        {
            return _features.GetFeatureValue(featureName);
        }

        /// <summary>
        /// Checks if the given feature exists.
        /// </summary>
        /// <param name="featureName">Name of the feature</param>
        /// <returns>True if the given feature exists, false otherwise.</returns>
        public bool FeatureExists(string featureName)
        {
            return _features.FeatureExists(featureName);
        }

        /// <summary>
        /// Accessor for the relation attribute.
        /// </summary>
        /// <returns>Relation attribute</returns>
        public UniversalDependencyRelation GetRelation()
        {
            return _relation;
        }

        /// <summary>
        /// Mutator for the relation attribute
        /// </summary>
        /// <param name="relation">New relation attribute</param>
        public void SetRelation(UniversalDependencyRelation relation)
        {
            this._relation = relation;
        }
        
        /// <summary>
        /// Accessor for the deps attribute
        /// </summary>
        /// <returns>Xpos attribute</returns>
        public string GetDeps()
        {
            return _deps;
        }

        /// <summary>
        /// Accessor for the misc attribute
        /// </summary>
        /// <returns>Misc attribute</returns>
        public string GetMisc()
        {
            return _misc;
        }

        public override string ToString()
        {
            return _id + "\t" + name + "\t" + _lemma + "\t" + _upos + "\t" +
                   _xpos + "\t" + _features + "\t" + _relation.To() + "\t" +
                   _relation.ToString().ToLower() + "\t" + _deps + "\t" + _misc;
        }
    }
}