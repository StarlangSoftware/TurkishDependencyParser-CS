using System;
using System.Collections.Generic;

namespace DependencyParser.Universal
{
    public class UniversalDependencyTreeBankFeatures
    {
        private Dictionary<string, string> featureList;

        public UniversalDependencyTreeBankFeatures(string features)
        {
            featureList = new Dictionary<string, string>();
            if (!features.Equals("_"))
            {
                var list = features.Split("\\|");
                foreach (var feature in list)
                {
                    if (feature.Contains("="))
                    {
                        var featureName = feature.Substring(0, feature.IndexOf("=")).Trim();
                        var featureValue = feature.Substring(feature.IndexOf("=") + 1).Trim();
                        featureList[featureName] = featureValue;
                    }
                    else
                    {
                        Console.WriteLine("Feature does not contain = ->" + features);
                    }
                }
            }
        }

        public string GetFeatureValue(string feature)
        {
            return featureList[feature];
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