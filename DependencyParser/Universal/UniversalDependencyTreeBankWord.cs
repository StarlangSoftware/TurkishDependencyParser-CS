using Dictionary.Dictionary;

namespace DependencyParser.Universal
{
    public class UniversalDependencyTreeBankWord : Word
    {
        private readonly int id;
        private readonly string lemma;
        private readonly UniversalDependencyPosType upos;
        private readonly string xpos;
        private readonly UniversalDependencyTreeBankFeatures features;
        private readonly UniversalDependencyRelation relation;
        private readonly string deps;
        private readonly string misc;

        public UniversalDependencyTreeBankWord(int id, string name, string lemma, UniversalDependencyPosType upos, 
            string xpos, UniversalDependencyTreeBankFeatures features,
            UniversalDependencyRelation relation, string deps, string misc) : base(name){
            this.id = id;
            this.lemma = lemma;
            this.upos = upos;
            this.xpos = xpos;
            this.deps = deps;
            this.features = features;
            this.relation = relation;
            this.misc = misc;
        }

        public int GetId() {
            return id;
        }

        public string GetLemma() {
            return lemma;
        }

        public UniversalDependencyPosType GetUpos() {
            return upos;
        }

        public string GetXpos() {
            return xpos;
        }

        public UniversalDependencyTreeBankFeatures GetFeatures() {
            return features;
        }

        public string GetFeatureValue(string featureName) {
            return features.GetFeatureValue(featureName);
        }

        public UniversalDependencyRelation GetRelation() {
            return relation;
        }

        public string GetDeps() {
            return deps;
        }

        public string GetMisc() {
            return misc;
        }

        public override string ToString(){
            return id + "\t" + name + "\t" + lemma + "\t" + upos + "\t" +
                   xpos + "\t" + features + "\t" + relation.To() + "\t" +
                   relation.ToString().ToLower() + "\t" + deps + "\t" + misc;
        }

    }
}