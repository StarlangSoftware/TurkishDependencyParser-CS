namespace DependencyParser
{
    public class DependencyRelation
    {
        protected readonly int toWord;

        /**
         * <summary>Constructor for a {@link DependencyRelation}. Takes toWord as a parameter and sets the corresponding attribute.</summary>
         * <param name="toWord">Index of the word in the sentence that dependency relation is related</param>
         */
        protected DependencyRelation(int toWord){
            this.toWord = toWord;
        }

        /**
         * <summary>Accessor for toWord attribute</summary>
         * <returns>toWord attribute value</returns>
         */
        public int To(){
            return toWord;
        }
        
    }
}