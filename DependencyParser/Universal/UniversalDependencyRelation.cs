namespace DependencyParser.Universal
{
    public class UniversalDependencyRelation : DependencyRelation
    {
        private readonly UniversalDependencyType _universalDependencyType;

        private static readonly string[] UniversalDependencyTypes =
        {
            "ACL", "ADVCL", "ADVMOD", "AMOD", "APPOS", "AUX",
            "CASE", "CC", "CCOMP", "CLF", "COMPOUND", "CONJ", "COP", "CSUBJ", "DEP", "DET", "DISCOURSE",
            "DISLOCATED",
            "EXPL", "FIXED", "FLAT", "GOESWITH", "IOBJ", "LIST", "MARK", "NMOD", "NSUBJ", "NUMMOD",
            "OBJ", "OBL", "ORPHAN",
            "PARATAXIS", "PUNCT", "REPARANDUM", "ROOT", "VOCATIVE", "XCOMP", "NONE"
        };

        private static readonly UniversalDependencyType[] UniversalDependencyTags =
        {
            UniversalDependencyType.ACL, UniversalDependencyType.ADVCL,
            UniversalDependencyType.ADVMOD, UniversalDependencyType.AMOD, UniversalDependencyType.APPOS,
            UniversalDependencyType.AUX, UniversalDependencyType.CASE,
            UniversalDependencyType.CC, UniversalDependencyType.CCOMP, UniversalDependencyType.CLF,
            UniversalDependencyType.COMPOUND, UniversalDependencyType.CONJ,
            UniversalDependencyType.COP, UniversalDependencyType.CSUBJ,
            UniversalDependencyType.DEP, UniversalDependencyType.DET, UniversalDependencyType.DISCOURSE,
            UniversalDependencyType.DISLOCATED, UniversalDependencyType.EXPL, UniversalDependencyType.FIXED,
            UniversalDependencyType.FLAT,
            UniversalDependencyType.GOESWITH, UniversalDependencyType.IOBJ, UniversalDependencyType.LIST,
            UniversalDependencyType.MARK, UniversalDependencyType.NMOD,
            UniversalDependencyType.NSUBJ,
            UniversalDependencyType.NUMMOD, UniversalDependencyType.OBJ, UniversalDependencyType.OBL,
            UniversalDependencyType.ORPHAN,
            UniversalDependencyType.PARATAXIS, UniversalDependencyType.PUNCT, UniversalDependencyType.REPARANDUM,
            UniversalDependencyType.ROOT,
            UniversalDependencyType.VOCATIVE, UniversalDependencyType.XCOMP, UniversalDependencyType.NONE
        };

        private static readonly string[] universalDependencyPosTypes =
        {
            "ADJ", "ADV", "INTJ", "NOUN", "PROPN", "VERB", "ADP", "AUX", "CCONJ", "DET", "NUM", "PART", "PRON",
            "SCONJ", "PUNCT", "SYM", "X"
        };

        private static readonly UniversalDependencyPosType[] universalDependencyPosTags =
        {
            UniversalDependencyPosType.ADJ, UniversalDependencyPosType.ADV, UniversalDependencyPosType.INTJ,
            UniversalDependencyPosType.NOUN, UniversalDependencyPosType.PROPN, UniversalDependencyPosType.VERB,
            UniversalDependencyPosType.ADP, UniversalDependencyPosType.AUX, UniversalDependencyPosType.CCONJ,
            UniversalDependencyPosType.DET, UniversalDependencyPosType.NUM, UniversalDependencyPosType.PART,
            UniversalDependencyPosType.PRON, UniversalDependencyPosType.SCONJ, UniversalDependencyPosType.PUNCT,
            UniversalDependencyPosType.SYM, UniversalDependencyPosType.X
        };

        /**
         * <summary>Overriden Universal Dependency Relation constructor. Gets toWord as input and calls it super class's constructor</summary>
         * <param name="toWord">Index of the word in the sentence that dependency relation is related</param>
         */
        public UniversalDependencyRelation(int toWord) : base(toWord)
        {
        }

        /**
         * <summary>The getDependencyTag method takes an dependency tag as string and returns the {@link UniversalDependencyType}
         * form of it.</summary>
         *
         * <param name="tag"> Type of the dependency tag in string form</param>
         * <returns>Type of the dependency in {@link UniversalDependencyType} form</returns>
         */
        public static UniversalDependencyType GetDependencyTag(string tag)
        {
            for (var j = 0; j < UniversalDependencyTags.Length; j++)
            {
                if (tag == UniversalDependencyTypes[j])
                {
                    return UniversalDependencyTags[j];
                }
            }

            return UniversalDependencyType.NONE;
        }

        public static UniversalDependencyPosType GetDependencyPosType(string tag)
        {
            for (var i = 0; i < universalDependencyPosTypes.Length; i++)
            {
                if (tag == universalDependencyPosTypes[i])
                {
                    return universalDependencyPosTags[i];
                }
            }

            return UniversalDependencyPosType.X;
        }

        /**
         * <summary>Another constructor for UniversalDependencyRelation. Gets input toWord and dependencyType as arguments and
         * calls the super class's constructor and sets the dependency type.</summary>
         * <param name="toWord">Index of the word in the sentence that dependency relation is related</param>
         * <param name="dependencyType">Type of the dependency relation in string form</param>
         */
        public UniversalDependencyRelation(int toWord, string dependencyType) : base(toWord)
        {
            this._universalDependencyType = GetDependencyTag(dependencyType);
        }

        public override string ToString()
        {
            return UniversalDependencyTypes[(int) _universalDependencyType];
        }
    }
}