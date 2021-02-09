namespace DependencyParser.Turkish
{
    public class TurkishDependencyRelation : DependencyRelation
    {
        private readonly int _toIg;
        private readonly TurkishDependencyType _turkishDependencyType;

        private static readonly string[] TurkishDependencyTypes =
        {
            "VOCATIVE", "SUBJECT", "DATIVE.ADJUNCT", "OBJECT", "POSSESSOR",
            "MODIFIER", "S.MODIFIER", "ABLATIVE.ADJUNCT", "DETERMINER", "SENTENCE",
            "CLASSIFIER", "LOCATIVE.ADJUNCT", "COORDINATION", "QUESTION.PARTICLE", "INTENSIFIER",
            "INSTRUMENTAL.ADJUNCT", "RELATIVIZER", "NEGATIVE.PARTICLE", "ETOL", "COLLOCATION",
            "FOCUS.PARTICLE", "EQU.ADJUNCT", "APPOSITION", "NONE"
        };

        private static readonly TurkishDependencyType[] TurkishDependencyTags =
        {
            TurkishDependencyType.VOCATIVE, TurkishDependencyType.SUBJECT, TurkishDependencyType.DATIVE_ADJUNCT,
            TurkishDependencyType.OBJECT, TurkishDependencyType.POSSESSOR,
            TurkishDependencyType.MODIFIER, TurkishDependencyType.S_MODIFIER, TurkishDependencyType.ABLATIVE_ADJUNCT,
            TurkishDependencyType.DETERMINER, TurkishDependencyType.SENTENCE,
            TurkishDependencyType.CLASSIFIER, TurkishDependencyType.LOCATIVE_ADJUNCT,
            TurkishDependencyType.COORDINATION, TurkishDependencyType.QUESTION_PARTICLE,
            TurkishDependencyType.INTENSIFIER,
            TurkishDependencyType.INSTRUMENTAL_ADJUNCT, TurkishDependencyType.RELATIVIZER,
            TurkishDependencyType.NEGATIVE_PARTICLE, TurkishDependencyType.ETOL, TurkishDependencyType.COLLOCATION,
            TurkishDependencyType.FOCUS_PARTICLE, TurkishDependencyType.EQU_ADJUNCT, TurkishDependencyType.APPOSITION, 
            TurkishDependencyType.NONE
        };

        /**
         * <summary>The getDependencyTag method takes an dependency tag as string and returns the {@link TurkishDependencyType}
         * form of it.</summary>
         *
         * <param name="tag"> Type of the dependency tag in string form</param>
         * <returns>Type of the dependency in {@link TurkishDependencyType} form</returns>
         */
        public static TurkishDependencyType GetDependencyTag(string tag)
        {
            for (var j = 0; j < TurkishDependencyTypes.Length; j++)
            {
                if (tag.ToUpper() == TurkishDependencyTypes[j])
                {
                    return TurkishDependencyTags[j];
                }
            }

            return TurkishDependencyType.NONE;
        }

        /**
         * <summary>Another constructor for TurkishDependencyRelation. Gets input toWord, toIG, and dependencyType as arguments and
         * calls the super class's constructor and sets the IG and dependency type.</summary>
         * <param name="toWord">Index of the word in the sentence that dependency relation is related</param>
         * <param name="toIg">Index of the inflectional group the dependency relation is related</param>
         * <param name="dependencyType">Type of the dependency relation in string form</param>
         */
        public TurkishDependencyRelation(int toWord, int toIg, string dependencyType) : base(toWord)
        {
            this._toIg = toIg;
            this._turkishDependencyType = GetDependencyTag(dependencyType);
        }

        /**
         * <summary>Accessor for the toIG attribute</summary>
         * <returns>toIG attribute</returns>
         */
        public int ToIG()
        {
            return _toIg;
        }

        /**
         * <summary>Accessor for the turkishDependencyType attribute</summary>
         * <returns>turkishDependencyType attribute</returns>
         */
        public TurkishDependencyType GetTurkishDependencyType()
        {
            return _turkishDependencyType;
        }

        public override string ToString()
        {
            return TurkishDependencyTypes[(int) _turkishDependencyType];
        }
    }
}