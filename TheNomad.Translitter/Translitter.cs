using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheNomad.Translitter
{
    public static partial class Translitter
    {
        public static string LatinToCyrillic(string latinSource, Language language = Language.Unknown)
        {
            if (string.IsNullOrEmpty(latinSource))
                return latinSource;

            switch (language)
            {
                case Language.Unknown:
                    return "Please specify the langauge to translit";
                case Language.Russian:
                    return "Soon..!";
                case Language.Kazakh:
                    return "Soon..!";
            }

            throw new NotSupportedException();
        }
    }
}
