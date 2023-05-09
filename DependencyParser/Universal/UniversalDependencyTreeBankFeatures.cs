using System;
using System.Collections.Generic;

namespace DependencyParser.Universal
{
    public class UniversalDependencyTreeBankFeatures
    {
        private Dictionary<string, string> featureList;

        public static readonly string[] UniversalFeatureTypes =
        {
            "PronType", "NumType", "Poss", "Reflex", "Foreign",
            "Abbr", "Typo", "Gender", "Animacy", "NounClass",
            "Number", "Case", "Definite", "Degree", "VerbForm",
            "Mood", "Tense", "Aspect", "Voice", "Evident",
            "Polarity", "Person", "Polite", "Clusivity"
        };

        public static readonly string[][] UniversalFeatureValues =
        {
            new[] { "Art", "Dem", "Emp", "Exc", "Ind", "Int", "Neg", "Prs", "Rcp", "Rel", "Tot" },
            new[] { "Card", "Dist", "Frac", "Mult", "Ord", "Range", "Sets" },
            new[] { "Yes" },
            new[] { "Yes" },
            new[] { "Yes" },

            new[] { "Yes" },
            new[] { "Yes" },
            new[] { "Com", "Fem", "Masc", "Neut" },
            new[] { "Anim", "Hum", "Inan", "Nhum" },
            new[]
            {
                "Bantu1", "Bantu2", "Bantu3", "Bantu4", "Bantu5", "Bantu6", "Bantu7", "Bantu8", "Bantu9", "Bantu10",
                "Bantu11", "Bantu12", "Bantu13", "Bantu14", "Bantu15", "Bantu16", "Bantu17", "Bantu18", "Bantu19",
                "Bantu20", "Bantu21", "Bantu22", "Bantu23", "Wol1", "Wol2", "Wol3", "Wol4", "Wol5", "Wol6", "Wol7",
                "Wol8", "Wol9", "Wol10", "Wol11", "Wol12"
            },

            new[] { "Coll", "Count", "Dual", "Grpa", "Grpl", "Inv", "Pauc", "Plur", "Ptan", "Sing", "Tri" },
            new[]
            {
                "Abs", "Acc", "Erg", "Nom", "Abe", "Ben", "Cau", "Cmp", "Cns", "Com", "Dat", "Dis", "Equ", "Gen", "Ins",
                "Par", "Tem", "Tra", "Voc", "Abl", "Add", "Ade", "All", "Del", "Ela", "Ess", "Ill", "Ine", "Lat", "Loc",
                "Per", "Sbe", "Sbl", "Spl", "Sub", "Sup", "Ter"
            },
            new[] { "Com", "Cons", "Def", "Ind", "Spec" },
            new[] { "Abs", "Aug", "Cmp", "Dim", "Equ", "Pos", "Sup" },
            new[] { "Conv", "Fin", "Gdv", "Ger", "Inf", "Part", "Sup", "Vnoun" },

            new[]
                { "Adm", "Cnd", "Des", "Imp", "Ind", "Int", "Irr", "Jus", "Nec", "Opt", "Pot", "Prp", "Qot", "Sub" },
            new[] { "Fut", "Imp", "Past", "Pqp", "Pres" },
            new[] { "Hab", "Imp", "Iter", "Perf", "Prog", "Prosp" },
            new[] { "Act", "Antip", "Bfoc", "Cau", "Dir", "Inv", "Lfoc", "Mid", "Pass", "Rcp" },
            new[] { "Fh", "Nfh" },

            new[] { "Neg", "Pos" },
            new[] { "0", "1", "2", "3", "4" },
            new[] { "Elev", "Form", "Humb", "Infm" },
            new[] { "Ex", "In" }
        };

        public static readonly string[][] TurkishFeatureValues =
        {
            new[] { "Art", "Dem", "Ind", "Int", "Neg", "Prs", "Rcp", "Rel", "Tot" },
            new[] { "Card", "Dist", "Ord" },
            new string[] { },
            new[] { "Yes" },
            new string[] { },

            new[] { "Yes" },
            new string[] { },
            new string[] { },
            new string[] { },
            new string[] { },

            new[] { "Plur", "Sing" },
            new[] { "Acc", "Nom", "Dat", "Equ", "Gen", "Ins", "Abl", "Loc" },
            new[] { "Def", "Ind" },
            new[] { "Cmp", "Sup" },
            new[] { "Conv", "Fin", "Part", "Vnoun" },

            new[]
            {
                "Cnd", "Des", "Gen", "Imp", "Ind", "Nec", "Opt", "Pot", "DesPot", "CndPot", "CndGen", "CndGenPot",
                "GenPot", "PotPot", "GenNecPot", "GenNec", "NecPot", "GenPotPot", "ImpPot"
            },
            new[] { "Fut", "Past", "Pqp", "Pres", "Aor" },
            new[] { "Imp", "Perf", "Prog", "Prosp", "Hab", "Rapid" },
            new[]
            {
                "Cau", "Pass", "Rcp", "Rfl", "CauCau", "CauCauPass", "CauPass", "CauPassRcp", "CauRcp", "PassPass",
                "PassRfl", "PassRcp"
            },
            new[] { "Fh", "Nfh" },

            new[] { "Neg", "Pos" },
            new[] { "1", "2", "3" },
            new string[] { },
            new string[] { }
        };

        public static readonly string[][] EnglishFeatureValues =
        {
            new[]
            {
                "Art", "Dem", "Emp", "Ind", "Int", "Neg", "Prs", "Rcp", "Rel", "Tot"
            },
            new[]
            {
                "Card", "Frac", "Mult", "Ord"
            },
            new[]
            {
                "Yes"
            },
            new string[]
            {
            },
            new string[]
            {
            },

            new string[]
            {
            },
            new string[]
            {
            },
            new[]
            {
                "Fem", "Masc", "Neut"
            },
            new string[]
            {
            },
            new string[]
            {
            },

            new[]
            {
                "Plur", "Sing"
            },
            new[]
            {
                "Acc", "Nom", "Gen"
            },
            new[]
            {
                "Def", "Ind"
            },
            new[]
            {
                "Cmp", "Pos", "Sup"
            },
            new[]
            {
                "Fin", "Ger", "Inf", "Part"
            },

            new[]
            {
                "Imp", "Ind", "Sub"
            },
            new[]
            {
                "Past", "Pres"
            },
            new string[]
            {
            },
            new[]
            {
                "Pass"
            },
            new string[]
            {
            },

            new string[]
            {
            },
            new[]
            {
                "1", "2", "3"
            },
            new string[]
            {
            },
            new string[]
            {
            }
        };

        private static int FeatureIndex(string featureName)
        {
            if (featureName.Contains("["))
            {
                featureName = featureName.Substring(0, featureName.IndexOf('['));
            }

            for (var i = 0; i < UniversalFeatureTypes.Length; i++)
            {
                if (UniversalFeatureTypes[i] == featureName)
                {
                    return i;
                }
            }

            return -1;
        }

        public static int PosIndex(string uPos)
        {
            var index = 0;
            foreach (var universalDependencyPosType in Enum.GetNames(typeof(UniversalDependencyPosType)))
            {
                if (universalDependencyPosType == uPos)
                {
                    return index;
                }

                index++;
            }

            return -1;
        }

        public static int DependencyIndex(string universalDependency)
        {
            var index = 0;
            foreach (var dependency in UniversalDependencyRelation.UniversalDependencyTypes)
            {
                if (dependency == universalDependency)
                {
                    return index;
                }

                index++;
            }

            return -1;
        }

        public static int NumberOfValues(string language, string featureName)
        {
            int featureIndex = FeatureIndex(featureName);
            if (featureIndex != -1)
            {
                switch (language)
                {
                    case "en":
                        return EnglishFeatureValues[featureIndex].Length;
                    case "tr":
                        return TurkishFeatureValues[featureIndex].Length;
                }
            }

            return -1;
        }

        public static int FeatureValueIndex(string language, string featureName, string featureValue)
        {
            string[][] searchArray;
            int featureIndex = FeatureIndex(featureName);
            if (featureIndex != -1)
            {
                switch (language)
                {
                    case "en":
                        searchArray = EnglishFeatureValues;
                        break;
                    case "tr":
                        searchArray = TurkishFeatureValues;
                        break;
                    default:
                        searchArray = UniversalFeatureValues;
                        break;
                }

                var featureValueIndex = -1;
                for (var i = 0; i < searchArray[featureIndex].Length; i++)
                {
                    if (searchArray[featureIndex][i] == featureValue)
                    {
                        featureValueIndex = i;
                    }
                }

                return featureValueIndex;
            }

            return -1;
        }

        public UniversalDependencyTreeBankFeatures(string language, string features)
        {
            featureList = new Dictionary<string, string>();
            if (!features.Equals("_"))
            {
                var list = features.Split("|");
                foreach (var feature in list)
                {
                    if (feature.Contains("="))
                    {
                        var featureName = feature.Substring(0, feature.IndexOf("=")).Trim();
                        var featureValue = feature.Substring(feature.IndexOf("=") + 1).Trim();
                        if (FeatureValueIndex(language, featureName, featureValue) != -1)
                        {
                            featureList[featureName] = featureValue;
                        }
                        else
                        {
                            Console.WriteLine("Either the feature " + featureName + " or the value " + featureValue +
                                              " is wrong");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Feature does not contain = ->" + features);
                    }
                }
            }
        }

        public UniversalDependencyTreeBankFeatures Clone()
        {
            return new UniversalDependencyTreeBankFeatures("u", ToString());
        }

        public string GetFeatureValue(string feature)
        {
            return featureList[feature];
        }

        public bool FeatureExists(string feature)
        {
            return featureList.ContainsKey(feature);
        }

        public override string ToString()
        {
            if (featureList.Count == 0)
            {
                return "_";
            }

            var result = "";
            foreach (var feature in featureList.Keys)
            {
                if (result == "")
                {
                    result = feature + "=" + GetFeatureValue(feature);
                }
                else
                {
                    result += "|" + feature + "=" + GetFeatureValue(feature);
                }
            }

            return result;
        }
    }
}