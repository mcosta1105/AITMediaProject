using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data_Access;

namespace Business_Logic
{
    public class PairModel
    {
        private int pairId;

        public int PairId
        {
            get { return pairId; }
            set { pairId = value; }
        }

        private string pairName;

        public string PairName
        {
            get { return pairName; }
            set { pairName = value; }
        } 

        public static PairModel Parse(MediaDS.TabGenreRow genreRow)
        {
            if (genreRow == null)
                return null;

            PairModel pair = new PairModel();
            pair.PairId = genreRow.GID;
            pair.PairName = genreRow.GenreName;

            return pair;
        }

        public static PairModel Parse(MediaDS.TabLanguageRow languageRow)
        {
            if (languageRow == null)
                return null;

            PairModel pair = new PairModel();
            pair.PairId = languageRow.LID;
            pair.PairName = languageRow.LanguageName;

            return pair;
        }

        public static PairModel Parse(MediaDS.TabDirectorRow directorRow)
        {
            if (directorRow == null)
                return null;

            PairModel pair = new PairModel();
            pair.PairId = directorRow.DID;
            pair.PairName = directorRow.DirectorName;

            return pair;
        }
        
        public static PairModel Parse(int id, string title)
        {
            PairModel pair = new PairModel();
            pair.PairId = id;
            pair.PairName = title;          
                      
            return pair;
        }
    }
}
