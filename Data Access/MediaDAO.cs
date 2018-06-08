using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data_Access.MediaDSTableAdapters;

namespace Data_Access
{
    //dao = data access object
    public class MediaDAO
    {
        private MediaDS mediaDataSet;
        private ViewMediaTableAdapter viewMediaTableAdapter; //read only
        private TabMediaTableAdapter mediaTableAdapter; //for data insert, delete, updates
        private TabLanguageTableAdapter languageTableAdapter;
        private TabGenreTableAdapter genreTableAdapter;
        private TabDirectorTableAdapter directorTableAdapter;
        

        //Reserved
        private TabReservedTableAdapter reservedTableAdapter;
        private TabBorrowTableAdapter borrowTableAdapter;

        public MediaDAO()
        {
            mediaDataSet = new MediaDS();
            viewMediaTableAdapter = new ViewMediaTableAdapter();
            languageTableAdapter = new TabLanguageTableAdapter();
            genreTableAdapter = new TabGenreTableAdapter();
            mediaTableAdapter = new TabMediaTableAdapter();
            directorTableAdapter = new TabDirectorTableAdapter();
            reservedTableAdapter = new TabReservedTableAdapter();
            borrowTableAdapter = new TabBorrowTableAdapter();
        }
        
        //get all media
        public MediaDS.ViewMediaDataTable ListMedia()
        {
            viewMediaTableAdapter.Fill(mediaDataSet.ViewMedia);
            return mediaDataSet.ViewMedia;
        }

        public MediaDS.TabLanguageDataTable ListLanguage()
        {
            languageTableAdapter.Fill(mediaDataSet.TabLanguage);
            return mediaDataSet.TabLanguage;
        }
        public MediaDS.TabGenreDataTable ListGenre()
        {
            genreTableAdapter.Fill(mediaDataSet.TabGenre);
            return mediaDataSet.TabGenre;
        }
        public MediaDS.TabDirectorDataTable ListDirector()
        {
            directorTableAdapter.Fill(mediaDataSet.TabDirector);
            return mediaDataSet.TabDirector;
        }

        //Title
        public MediaDS.ViewMediaDataTable ListMediaByTitle(string title)
        {
            viewMediaTableAdapter.FillByTitle(mediaDataSet.ViewMedia, title);
            return mediaDataSet.ViewMedia;
        }

        //Publish year
        public MediaDS.ViewMediaDataTable ListMediaByPublishYear(int publishYear)
        {
            viewMediaTableAdapter.FillByPublishYear(mediaDataSet.ViewMedia, publishYear);
            return mediaDataSet.ViewMedia;
        }

        //Language Name
        public MediaDS.ViewMediaDataTable ListMediaByLanguageName(string languageName)
        {
            viewMediaTableAdapter.FillByLanguageName(mediaDataSet.ViewMedia, languageName);
            return mediaDataSet.ViewMedia;
        }
        //Budget
        public MediaDS.ViewMediaDataTable ListMediaByBudget(int budget)
        {
            viewMediaTableAdapter.FillByBudget(mediaDataSet.ViewMedia, budget);
            return mediaDataSet.ViewMedia;
        }

        //New Media
        public int InsertNewMedia(string title, int genre, int director, int language, int publishYear, int budget)
        {
            //return number of rows affected ( good, 0 dind't insert)
            return mediaTableAdapter.InsertNewMedia(title, genre, director, language, publishYear, budget);
        }

        //New director
        public int InsertNewDirector(string directorName)
        {
            //return number of rows affected ( good, 0 dind't insert)
            return directorTableAdapter.InsertNewDirector(directorName);
        }

        //New Genre
        public int InsertNewGenre(string genre)
        {
            //return number of rows affected ( good, 0 dind't insert)
            return genreTableAdapter.InsertNewGenre(genre);
        }

        //New Genre
        public int InsertNewLanguage(string language)
        {
            //return number of rows affected ( good, 0 dind't insert)
            return languageTableAdapter.InsertNewLanguage(language);
        }

        //Update Media
        public int UpdateMedia(string title, int genre, int director, int language, int publishYear, int budget, int mediaID)
        {
            //return member of rows affected again (0 nothing changed, 1+ entries changed)
            return mediaTableAdapter.UpdateMedia(title, genre, director, language, publishYear, budget, mediaID);
        }

        //Delete Media
        public int DeleteMediaByMediaID(int mediaID)
        {
            try
            {
                return mediaTableAdapter.DeleteMediaByMediaID(mediaID);
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        //RESERVE <<<<<<<<<<
        //get all reserved media
        public MediaDS.TabReservedDataTable ListReserved()
        {
            try
            {
                reservedTableAdapter.Fill(mediaDataSet.TabReserved);
                return mediaDataSet.TabReserved;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        
        //Insert new reserved
        public int InserNewRerserved(int user, int media, DateTime date)
        {
            
            return reservedTableAdapter.InsertNewReserved(user, media, date.ToString());
            
        }
        
        //Delete reserved
        public int DeleteMediaReservedByRID(int reservedID)
        {
            try
            {
                return reservedTableAdapter.DeleteMediaReservedByRID(reservedID);
            }
            catch (Exception ex)
            {
                return 0;
            }
        }


        //BORRROW <<<<<<<<<<<<

        //get all borrowed media
        public MediaDS.TabBorrowDataTable ListBorrowed()
        {
            try
            {
                borrowTableAdapter.Fill(mediaDataSet.TabBorrow);
                return mediaDataSet.TabBorrow;
            }
            catch (Exception ex)
            {
                return null;
            }
        }



        //Insert new borrow
        public int InsertNewBorrow(int user, int media, DateTime borrowDate, DateTime returnDate)
        {
           
           return borrowTableAdapter.InsertNewBorrow(user, media, borrowDate.ToString(), returnDate.ToString());
            
        }

        //Update Borrow
        public int UpdateBorrow(DateTime actualReturnDate, decimal lateFee, int borrowId)
        {
            //return member of rows affected again (0 nothing changed, 1+ entries changed)
            return borrowTableAdapter.UpdateBorrow(actualReturnDate.ToString(), lateFee, borrowId);
        }
                


    }
}
