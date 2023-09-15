namespace DependencyParser.Universal
{
    public class UniversalDependencyRelation : DependencyRelation
    {
        private readonly UniversalDependencyType _universalDependencyType;

        public static readonly string[] UniversalDependencyTypes =
        {
            "ACL", "ADVCL", "ADVMOD", "AMOD", "APPOS", "AUX",
            "CASE", "CC", "CCOMP", "CLF", "COMPOUND", "CONJ", "COP", "CSUBJ", "DEP", "DET", "DISCOURSE",
            "DISLOCATED",
            "EXPL", "FIXED", "FLAT", "GOESWITH", "IOBJ", "LIST", "MARK", "NMOD", "NSUBJ", "NUMMOD",
            "OBJ", "OBL", "ORPHAN",
            "PARATAXIS", "PUNCT", "REPARANDUM", "ROOT", "VOCATIVE", "XCOMP", "ACL:RELCL", "AUX:PASS",
            "CC:PRECONJ", "COMPOUND:PRT", "DET:PREDET", "FLAT:FOREIGN",
            "NSUBJ:PASS", "CSUBJ:PASS", "NMOD:NPMOD", "NMOD:POSS",
            "NMOD:TMOD", "ADVMOD:EMPH", "AUX:Q", "COMPOUND:LVC",
            "COMPOUND:REDUP", "CSUBJ:COP", "NMOD:COMP", "NMOD:PART",
            "NSUBJ:COP", "OBL:AGENT", "OBL:TMOD", "OBL:NPMOD", "NSUBJ:OUTER",
            "CSUBJ:OUTER", "ADVCL:RELCL", "NONE"
        };

        public static readonly UniversalDependencyType[] UniversalDependencyTags =
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
            UniversalDependencyType.VOCATIVE, UniversalDependencyType.XCOMP, UniversalDependencyType.ACL_RELCL,
            UniversalDependencyType.AUX_PASS,
            UniversalDependencyType.CC_PRECONJ, UniversalDependencyType.COMPOUND_PRT,
            UniversalDependencyType.DET_PREDET, UniversalDependencyType.FLAT_FOREIGN,
            UniversalDependencyType.NSUBJ_PASS, UniversalDependencyType.CSUBJ_PASS, UniversalDependencyType.NMOD_NPMOD,
            UniversalDependencyType.NMOD_POSS,
            UniversalDependencyType.NMOD_TMOD, UniversalDependencyType.ADVMOD_EMPH, UniversalDependencyType.AUX_Q,
            UniversalDependencyType.COMPOUND_LVC,
            UniversalDependencyType.COMPOUND_REDUP, UniversalDependencyType.CSUBJ_COP,
            UniversalDependencyType.NMOD_COMP, UniversalDependencyType.NMOD_PART,
            UniversalDependencyType.NSUBJ_COP, UniversalDependencyType.OBL_AGENT, UniversalDependencyType.OBL_TMOD,
            UniversalDependencyType.OBL_NPMOD, UniversalDependencyType.NSUBJ_OUTER,
            UniversalDependencyType.CSUBJ_OUTER, UniversalDependencyType.ADVCL_RELCL,
            UniversalDependencyType.NONE
        };

        public static readonly string[] UniversalDependencyPosTypes =
        {
            "ADJ", "ADV", "INTJ", "NOUN", "PROPN", "VERB", "ADP", "AUX", "CCONJ", "DET", "NUM", "PART", "PRON",
            "SCONJ", "PUNCT", "SYM", "X"
        };

        public static readonly UniversalDependencyPosType[] UniversalDependencyPosTags =
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

        public UniversalDependencyRelation Clone()
        {
            return new UniversalDependencyRelation(toWord, ToString());
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
                if (tag.ToUpper() == UniversalDependencyTypes[j])
                {
                    return UniversalDependencyTags[j];
                }
            }

            return UniversalDependencyType.NONE;
        }

        public static UniversalDependencyPosType GetDependencyPosType(string tag)
        {
            for (var i = 0; i < UniversalDependencyPosTypes.Length; i++)
            {
                if (tag.ToUpper() == UniversalDependencyPosTypes[i])
                {
                    return UniversalDependencyPosTags[i];
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

        public ParserEvaluationScore CompareRelations(UniversalDependencyRelation relation)
        {
            double LS = 0.0, LAS = 0.0, UAS = 0.0;
            if (ToString() == relation.ToString())
            {
                LS = 1.0;
                if (toWord == relation.To())
                {
                    LAS = 1.0;
                }
            }

            if (toWord == relation.To())
            {
                UAS = 1.0;
            }

            return new ParserEvaluationScore(LAS, UAS, LS, 1);
        }

        public override string ToString()
        {
            return UniversalDependencyTypes[(int)_universalDependencyType];
        }
    }
}