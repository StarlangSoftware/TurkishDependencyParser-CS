using System;
using System.IO;
using System.Text.RegularExpressions;

namespace DependencyParser.Universal
{
    public class UniversalDependencyTreeBankCorpus : Corpus.Corpus
    {
        public UniversalDependencyTreeBankCorpus(string fileName)
        {
            UniversalDependencyTreeBankSentence sentence = null;
            UniversalDependencyRelation relation;
            var assembly = typeof(UniversalDependencyTreeBankCorpus).Assembly;
            var stream = assembly.GetManifestResourceStream("DependencyParser." + fileName);
            var streamReader = new StreamReader(stream);
            var line = streamReader.ReadLine();
            while (line != null)
            {
                if (line.Length == 0)
                {
                    AddSentence(sentence);
                    sentence = null;
                }
                else
                {
                    if (line.StartsWith("#"))
                    {
                        if (sentence == null)
                        {
                            sentence = new UniversalDependencyTreeBankSentence();
                        }

                        sentence.AddComment(line.Trim());
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
                                    if (dependencyType.Contains(":"))
                                    {
                                        dependencyType = dependencyType.Substring(0, dependencyType.IndexOf(":"));
                                    }

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
                                sentence.AddWord(word);
                            }
                        }
                    }
                }

                line = streamReader.ReadLine();
            }
        }
    }
}