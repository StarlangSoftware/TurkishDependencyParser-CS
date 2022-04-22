using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Corpus;

namespace DependencyParser.Universal
{
    public class UniversalDependencyTreeBankSentence : Sentence
    {
        private List<string> comments;

        public UniversalDependencyTreeBankSentence()
        {
            comments = new List<string>();
        }

        public UniversalDependencyTreeBankSentence(string sentence)
        {
            UniversalDependencyRelation relation;
            comments = new List<string>();
            var lines = sentence.Split("\n");
            foreach (var line in lines)
            {
                if (line == "")
                {
                    continue;
                }
                if (line.StartsWith("#"))
                {
                    AddComment(line.Trim());
                }
                else
                {
                    var items = line.Split('\t');
                    if (items.Length != 10)
                    {
                        Console.WriteLine("Line does not contain 10 items ->" + line);
                    }
                    else
                    {
                        var id = items[0];
                        if (new Regex("^\\d+$").IsMatch(id))
                        {
                            var surfaceForm = items[1];
                            var lemma = items[2];
                            var upos =
                                UniversalDependencyRelation.GetDependencyPosType(items[3]);

                            var xpos = items[4];
                            var features =
                                new UniversalDependencyTreeBankFeatures(items[5]);
                            if (items[6] != "_")
                            {
                                var to = int.Parse(items[6]);
                                var dependencyType = items[7].ToUpper();

                                relation = new UniversalDependencyRelation(to, dependencyType);
                            }
                            else
                            {
                                relation = null;
                            }

                            var deps = items[8];
                            var misc = items[9];
                            var word = new UniversalDependencyTreeBankWord(
                                int.Parse(id), surfaceForm,
                                lemma, upos, xpos, features, relation, deps, misc);
                            AddWord(word);
                        }
                    }
                }
            }
        }

        public void AddComment(string comment)
        {
            comments.Add(comment);
        }

        public override string ToString()
        {
            var result = "";
            foreach (var comment in comments)
            {
                result += comment + "\n";
            }

            foreach (var w in words)
            {
                var word = (UniversalDependencyTreeBankWord)w;
                result += word + "\n";
            }

            return result;
        }

        public ParserEvaluationScore CompareParses(UniversalDependencyTreeBankSentence sentence)
        {
            var score = new ParserEvaluationScore();
            for (var i = 0; i < words.Count; i++)
            {
                var relation1 = ((UniversalDependencyTreeBankWord)words[i]).GetRelation();
                var relation2 = ((UniversalDependencyTreeBankWord)sentence.GetWord(i)).GetRelation();
                if (relation1 != null && relation2 != null)
                {
                    score.Add(relation1.CompareRelations(relation2));
                }
            }

            return score;
        }
    }
}