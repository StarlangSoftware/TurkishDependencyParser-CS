using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Corpus;

namespace DependencyParser.Universal
{
    public class UniversalDependencyTreeBankSentence : Sentence
    {
        private readonly List<string> _comments;
        private readonly List<string> _splits;

        /// <summary>
        /// Empty constructor for the UniversalDependencyTreeBankSentence. Initializes comments.
        /// </summary>
        public UniversalDependencyTreeBankSentence()
        {
            _comments = [];
            _splits = [];
        }

        /// <summary>
        /// Constructor for the UniversalDependencyTreeBankSentence.  Get a line as input and splits the line wrt tab
        /// character. The number of items should be 10. The items are id, surfaceForm, lemma, upos, xpos, feature list,
        /// head word index, dependency type, external dependencies and miscellaneous things for one word.
        /// </summary>
        /// <param name="language">Language name. Currently, 'en' and 'tr' languages are supported.</param>
        /// <param name="sentence">Sentence string to be processed.</param>
        public UniversalDependencyTreeBankSentence(string language, string sentence)
        {
            UniversalDependencyRelation relation;
            _comments = [];
            _splits = [];
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
                                new UniversalDependencyTreeBankFeatures(language, items[5]);
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
                        else
                        {
                            if (new Regex("^\\d+-\\d+$").IsMatch(id))
                            {
                                _splits.Add(id);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Adds a comment string to comments array list.
        /// </summary>
        /// <param name="comment">Comment to be added.</param>
        public void AddComment(string comment)
        {
            _comments.Add(comment);
        }

        /// <summary>
        /// Overridden toString method. Concatenates the strings of words to get the string of a sentence.
        /// </summary>
        /// <returns>Concatenation of the strings of thw strings of words.</returns>
        public override string ToString()
        {
            var result = "";
            foreach (var comment in _comments)
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

        /// <summary>
        /// Returns number of splits in the sentence
        /// </summary>
        /// <returns>Number of splits in the sentence</returns>
        public int SplitSize()
        {
            return _splits.Count;
        }

        /// <summary>
        /// Returns the split at position index
        /// </summary>
        /// <param name="index">Position</param>
        /// <returns>The split at position index</returns>
        public string GetSplit(int index)
        {
            return  _splits[index];
        }

        /// <summary>
        /// Compares the sentence with the given sentence and returns a parser evaluation score for this comparison. The result
        /// is calculated by summing up the parser evaluation scores of word by word dpendency relation comparisons.
        /// </summary>
        /// <param name="sentence">Universal dependency sentence to be compared.</param>
        /// <returns>A parser evaluation score object.</returns>
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