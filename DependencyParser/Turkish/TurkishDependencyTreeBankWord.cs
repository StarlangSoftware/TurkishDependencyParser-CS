using System.Collections.Generic;
using System.Xml;
using Dictionary.Dictionary;
using MorphologicalAnalysis;

namespace DependencyParser.Turkish
{
    public class TurkishDependencyTreeBankWord : Word
    {
        private readonly MorphologicalParse _parse;
        private readonly List<MorphologicalParse> _originalParses;
        private readonly TurkishDependencyRelation _relation;

        /**
         * <summary>Given the parsed xml node which contains information about a word and related attributes including the
         * dependencies, the method constructs a {@link TurkishDependencyTreeBankWord} from it.</summary>
         * <param name="wordNode">Xml parsed node containing information about a word.</param>
         */
        public TurkishDependencyTreeBankWord(XmlNode wordNode)
        {
            int i;
            int toWord = 0, toIg = 0;
            _originalParses = new List<MorphologicalParse>();
            name = wordNode.InnerText;
            var ig = wordNode.Attributes["IG"].Value;
            _parse = new MorphologicalParse(SplitIntoInflectionalGroups(ig));
            var relationName = wordNode.Attributes["REL"].Value;
            if (relationName != "[,( )]")
            {
                char[] delimiters = {'[', '(', ')', ']', ','};
                var relationParts = relationName.Split(delimiters);
                var index = 0;
                for (i = 0; i < relationParts.Length; i++)
                {
                    if (relationParts[i].Length != 0)
                    {
                        index++;
                        switch (index)
                        {
                            case 1:
                                toWord = int.Parse(relationParts[i]);
                                break;
                            case 2:
                                toIg = int.Parse(relationParts[i]);
                                break;
                            case 3:
                                var dependencyType = relationParts[i];
                                _relation = new TurkishDependencyRelation(toWord - 1, toIg - 1, dependencyType);
                                break;
                        }
                    }
                }
            }

            for (i = 1; i <= 9; i++)
            {
                if (wordNode.Attributes["ORG_IG" + i] != null)
                {
                    ig = wordNode.Attributes["ORG_IG" + i].Value;
                    var groups = SplitIntoInflectionalGroups(ig);
                    var morphologicalParse = new MorphologicalParse(groups);
                    _originalParses.Add(morphologicalParse);
                }
                else
                {
                    break;
                }
            }
        }

        /**
        * <summary>Given the morphological parse of a word, this method splits it into inflectional groups.</summary>
        * <param name="IG">Morphological parse of the word in string form.</param>
        * <returns>An array of inflectional groups stored as strings.</returns>
        */
        private List<string> SplitIntoInflectionalGroups(string ig)
        {
            var inflectionalGroups = new List<string>();
            ig = ig.Replace("\\(\\+Punc", "@").Replace("\\)\\+Punc", "\\$");

            char[] delimiters = {'[', '(', ')', ']'};
            var iGs = ig.Split(delimiters);
            for (var i = 0; i < iGs.Length; i++)
            {
                iGs[i] = iGs[i].Replace("@", "\\(\\+Punc").Replace("\\$", "\\)\\+Punc");
                if (iGs[i].Length != 0)
                {
                    inflectionalGroups.Add(iGs[i]);
                }
            }

            return inflectionalGroups;
        }

        /**
         * <summary>Accessor for the parse attribute</summary>
         * <returns>Parse attribute</returns>
         */
        public MorphologicalParse GetParse()
        {
            return _parse;
        }

        /**
         * <summary>Accessor for a specific parse.</summary>
         * <param name="index">Index of the word.</param>
         * <returns>Parse of the index'th word</returns>
         */
        public MorphologicalParse GetOriginalParse(int index)
        {
            if (index < _originalParses.Count)
            {
                return _originalParses[index];
            }
            else
            {
                return null;
            }
        }

        /**
         * <summary>Number of words in this item.</summary>
         * <returns>Number of words in this item.</returns>
         */
        public int Size()
        {
            return _originalParses.Count;
        }

        /**
         * <summary>Accessor for the relation attribute.</summary>
         * <returns>relation attribute.</returns>
         */
        public TurkishDependencyRelation GetRelation()
        {
            return _relation;
        }
    }
}