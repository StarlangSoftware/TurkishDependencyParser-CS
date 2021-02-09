namespace DependencyParser.Stanford
{
    public class StanfordDependencyRelation : DependencyRelation
    {
        private readonly StanfordDependencyType _stanfordDependencyType;

        private static readonly string[] StanfordDependencyTypes =
        {
            "acomp", "advcl", "advmod", "agent", "amod", "appos", "aux",
            "auxpass", "cc", "ccomp", "conj", "cop", "csubj", "csubjpass", "dep", "det", "discourse", "dobj", "expl",
            "goeswith",
            "iobj", "mark", "mwe", "neg", "nn", "npadvmod", "nsubj", "nsubjpass", "num", "number", "parataxis", "pcomp",
            "pobj", "poss", "possessive", "preconj", "predet", "prep", "prepc", "prt", "punct", "quantmod", "rcmod",
            "ref",
            "root", "tmod", "vmod", "xcomp", "xsubj", "none"
        };

        private static readonly StanfordDependencyType[] StanfordDependencyTags =
        {
            StanfordDependencyType.ACOMP, StanfordDependencyType.ADVCL,
            StanfordDependencyType.ADVMOD, StanfordDependencyType.AGENT, StanfordDependencyType.AMOD,
            StanfordDependencyType.APPOS, StanfordDependencyType.AUX,
            StanfordDependencyType.AUXPASS, StanfordDependencyType.CC, StanfordDependencyType.CCOMP,
            StanfordDependencyType.CONJ, StanfordDependencyType.COP,
            StanfordDependencyType.CSUBJ, StanfordDependencyType.CSUBJPASS, StanfordDependencyType.DEP,
            StanfordDependencyType.DET, StanfordDependencyType.DISCOURSE,
            StanfordDependencyType.DOBJ, StanfordDependencyType.EXPL, StanfordDependencyType.GOESWITH,
            StanfordDependencyType.IOBJ, StanfordDependencyType.MARK,
            StanfordDependencyType.MWE, StanfordDependencyType.NEG, StanfordDependencyType.NN,
            StanfordDependencyType.NPADVMOD, StanfordDependencyType.NSUBJ,
            StanfordDependencyType.NSUBJPASS, StanfordDependencyType.NUM, StanfordDependencyType.NUMBER,
            StanfordDependencyType.PARATAXIS, StanfordDependencyType.PCOMP,
            StanfordDependencyType.POBJ, StanfordDependencyType.POSS, StanfordDependencyType.POSSESSIVE,
            StanfordDependencyType.PRECONJ, StanfordDependencyType.PREDET,
            StanfordDependencyType.PREP, StanfordDependencyType.PREPC, StanfordDependencyType.PRT,
            StanfordDependencyType.PUNCT, StanfordDependencyType.QUANTMOD,
            StanfordDependencyType.RCMOD, StanfordDependencyType.REF, StanfordDependencyType.ROOT,
            StanfordDependencyType.TMOD, StanfordDependencyType.VMOD,
            StanfordDependencyType.XCOMP, StanfordDependencyType.XSUBJ, StanfordDependencyType.NONE
        };

        /**
         * The getDependencyTag method takes an dependency tag as string and returns the {@link StanfordDependencyType}
         * form of it.
         *
         * @param tag  Type of the dependency tag in string form
         * @return Type of the dependency in {@link StanfordDependencyType} form
         */
        public static StanfordDependencyType GetDependencyTag(string tag)
        {
            for (var j = 0; j < StanfordDependencyTags.Length; j++)
            {
                if (tag.ToLower() == StanfordDependencyTypes[j])
                {
                    return StanfordDependencyTags[j];
                }
            }

            return StanfordDependencyType.NONE;
        }

        /**
         * Another constructor for StanfordDependencyRelation. Gets input toWord and dependencyType as arguments and
         * calls the super class's constructor and sets the dependency type.
         * @param toWord Index of the word in the sentence that dependency relation is related
         * @param dependencyType Type of the dependency relation in string form
         */
        public StanfordDependencyRelation(int toWord, string dependencyType) : base(toWord)
        {
            this._stanfordDependencyType = GetDependencyTag(dependencyType);
        }

        public override string ToString()
        {
            return StanfordDependencyTypes[(int) _stanfordDependencyType];
        }
    }
}