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
            "Polarity", "Person", "Polite", "Clusivity", "NumForm"
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
            new[] { "Ex", "In" },
            new[] { "Word", "Digit", "Roman" }
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
            new[]
            {
                "Yes"
            },
            new[]
            {
                "Yes"
            },

            new[]
            {
                "Yes"
            },
            new[]
            {
                "Yes"
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

            new[]
            {
                "Neg"
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
            },
            new[] { "Word", "Digit", "Roman" }
        };

        /// <summary>
        /// Returns the index of the universal feature type in the universalFeatureTypes array, given the name of the feature
        /// type.
        /// </summary>
        /// <param name="featureName">Name of the feature type</param>
        /// <returns>Index of the universal feature type in the universalFeatureTypes array. If the name does not exist, the
        /// function returns -1.</returns>
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

        /// <summary>
        /// Returns the index of the given universal dependency pos.
        /// </summary>
        /// <param name="uPos">Given universal dependency part of speech tag.</param>
        /// <returns>The index of the universal dependency pos.</returns>
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

        /// <summary>
        /// Returns the index of the universal dependency type in the universalDependencyTypes array, given the name of the
        /// universal dependency type.
        /// </summary>
        /// <param name="universalDependency">Universal dependency type</param>
        /// <returns>Index of the universal dependency type in the universalDependencyTypes array. If the name does not exist,
        /// the function returns -1.</returns>
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

        /// <summary>
        /// Returns the number of distinct values for a feature in a given language
        /// </summary>
        /// <param name="language">Language name. Currently, 'en' and 'tr' languages are supported.</param>
        /// <param name="featureName">Name of the feature type.</param>
        /// <returns>The number of distinct values for a feature in a given language</returns>
        public static int NumberOfValues(string language, string featureName)
        {
            var featureIndex = FeatureIndex(featureName);
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

        /// <summary>
        /// Returns the index of the given value in the feature value array for the given feature in the given
        /// language.
        /// </summary>
        /// <param name="language">Language name. Currently, 'en' and 'tr' languages are supported.</param>
        /// <param name="featureName">Name of the feature.</param>
        /// <param name="featureValue">Value of the feature.</param>
        /// <returns>The index of the given feature value in the feature value array for the given feature in the given
        /// language.</returns>
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

        /// <summary>
        /// Constructor of a UniversalDependencyTreeBankFeatures object. Given the language of the word and features of the
        /// word as a string, the method splits the features with respect to pipe character. Then for each feature type and
        /// value pair, their values and types are inserted into the featureList hash map. The method also check for validity
        /// of the feature values for that feature type.
        /// </summary>
        /// <param name="language">Language name. Currently, 'en' and 'tr' languages are supported.</param>
        /// <param name="features">Feature string.</param>
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

        /// <summary>
        /// Gets the value of a given feature.
        /// </summary>
        /// <param name="feature">Name of the feature</param>
        /// <returns>Value of the feature</returns>
        public string GetFeatureValue(string feature)
        {
            return featureList[feature];
        }

        /// <summary>
        /// Checks if the given feature exists in the feature list.
        /// </summary>
        /// <param name="feature">Name of the feature</param>
        /// <returns>True, if the feature list contains the feature, false otherwise.</returns>
        public bool FeatureExists(string feature)
        {
            return featureList.ContainsKey(feature);
        }

        /// <summary>
        /// Overridden toString method. Returns feature with their values separated with pipe characters.
        /// </summary>
        /// <returns>A string of feature values and their names separated with pipe character.</returns>
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