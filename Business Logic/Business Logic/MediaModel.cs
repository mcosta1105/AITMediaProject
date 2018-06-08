using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data_Access;

namespace Business_Logic
{
    public class MediaModel
    {
        
        //Attribute
        private int mediaId;
        //Property (helps manage the attribute above)
        public int MediaId
        {
            get { return mediaId; }
            set { mediaId = value; }
        }

        private string mediaName;

        public string MediaName
        {
            get { return mediaName; }
            set { mediaName = value; }
        }

        //Publish Year
        private int publishYeasr;

        public int PublishYear
        {
            get { return publishYeasr; }
            set { publishYeasr = value; }
        }

        //Language Name
        private string languageName;

        public string LanguageName
        {
            get { return languageName; }
            set { languageName = value; }
        }
        
        //Director
        private int director;
        public int getDirector()
        {
            return director;
        }

        public void setDirector(int d)
        {
            director = d;
        }

        //Language
        private int language;
        public int getLanguage()
        {
            return language;
        }

        public void setLanguage(int l)
        {
            language = l;
        }

        //Genre
        private int genre;
        public int getGenre()
        {
            return genre;
        }

        public void setGenre(int g)
        {
            genre = g;
        }

        //Budget
        private int budget;

        public int Budget
        {
            get { return budget; }
            set { budget = value; }
        }
        //Director
        private string directorName;

        public string DirectorName
        {
            get { return directorName; }
            set { directorName = value; }
        }
        

        public static MediaModel Parse(MediaDS.ViewMediaRow mediaRow)
        {
            if (mediaRow == null)
                return null;

            MediaModel media = new MediaModel();
            media.MediaId = mediaRow.MediaID;
            media.MediaName = mediaRow.Title;
            media.PublishYear = mediaRow.PublishYear;
            media.LanguageName = mediaRow.LanguageName;
            media.Budget = (int) mediaRow.Budget;
            media.DirectorName = mediaRow.DirectorName;
            

            media.setDirector(mediaRow.Director);
            media.setGenre(mediaRow.Genre);
            media.setLanguage(mediaRow.Language);

            return media;
        }
    }
}
