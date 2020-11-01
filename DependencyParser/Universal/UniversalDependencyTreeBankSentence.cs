using System.Collections.Generic;
using Corpus;

namespace DependencyParser.Universal
{
    public class UniversalDependencyTreeBankSentence : Sentence
    {
        private List<string> comments;

        public UniversalDependencyTreeBankSentence(){
            comments = new List<string>();
        }

        public void AddComment(string comment){
            comments.Add(comment);
        }

        public override string ToString(){
            var result = "";
            foreach (var comment in comments){
                result += comment + "\n";
            }
            foreach (var w in words){
                var word = (UniversalDependencyTreeBankWord) w;
                result += word + "\n";
            }
            return result;
        }

    }
}