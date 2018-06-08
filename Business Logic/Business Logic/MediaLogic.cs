using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data_Access;


namespace Business_Logic
{
    public class MediaLogic
    {
        private MediaDAO mediaDAO;

        public MediaLogic()
        {
            mediaDAO = new MediaDAO();

        }

        public List<MediaModel> ListMedia()
        {
            //empty list of media models to start us off
            List<MediaModel> medias = new List<MediaModel>();
            MediaDS.ViewMediaDataTable mediaTable = mediaDAO.ListMedia();

            foreach (MediaDS.ViewMediaRow row in mediaTable.Rows)
            {
                //create a model representing that row
                MediaModel media = MediaModel.Parse(row);
                medias.Add(media);//add it to our list of media
            }
            return medias;
        }

        //List All reserve
        public List<ReserveModel> ListAllMediasReserved()
        {
            //empty list of media models to start us off
            List<ReserveModel> reservedMedias = new List<ReserveModel>();
            MediaDS.TabReservedDataTable reservedTable = mediaDAO.ListReserved();

            foreach (MediaDS.TabReservedRow row in reservedTable.Rows)
            {
                //create a model representing that row
                ReserveModel media = ReserveModel.Parse(row);
                reservedMedias.Add(media);//add it to our list of media
            }
            return reservedMedias;
        }
        //Reserved medias
        public List<ReserveModel> GetReservedByMedia(int mediaId)
        {
            List<ReserveModel> reservedMedias = new List<ReserveModel>();
            MediaDS.TabReservedDataTable reservedTable = mediaDAO.ListReserved();

            foreach (MediaDS.TabReservedRow row in reservedTable.Rows)
            {
                if (row.MediaID == mediaId)
                {
                    ReserveModel reservedMedia = ReserveModel.Parse(row);
                    reservedMedias.Add(reservedMedia);                    
                }
            }

            if (reservedMedias.Count == 0)
                reservedMedias = null;
            return reservedMedias;
        }

        public ReserveModel GetReserved(int mediaId)
        {
            List<ReserveModel> reservedMedias = new List<ReserveModel>();
            MediaDS.TabReservedDataTable reservedTable = mediaDAO.ListReserved();

            foreach (MediaDS.TabReservedRow row in reservedTable.Rows)
            {
                if (row.MediaID == mediaId)
                {
                    ReserveModel reservedMedia = ReserveModel.Parse(row);
                    reservedMedias.Add(reservedMedia);
                }
            }

            ReserveModel reserved = null;

            if (reservedMedias.Count == 0)
            {
                reservedMedias = null;
                
            }
            else
            {
                reserved = reservedMedias[0];
            }
            return reserved;
        }

        //Borrowed medias <<<<<
        //Lista all borrowed medias
        public List<BorrowModel> ListAllMediasBorrowed()
        {
            //empty list of media models to start us off
            List<BorrowModel> borrowedMedias = new List<BorrowModel>();
            MediaDS.TabBorrowDataTable borrowedTable = mediaDAO.ListBorrowed();

            foreach (MediaDS.TabBorrowRow row in borrowedTable.Rows)
            {
                //create a model representing that row
                BorrowModel media = BorrowModel.Parse(row);
                borrowedMedias.Add(media);//add it to our list of media
            }
            return borrowedMedias;
        }


        //List Borrowed by actual return date
        public BorrowModel GetBorrowed(int mediaId)
        {
            List<BorrowModel> borrowedMedias = new List<BorrowModel>();
            MediaDS.TabBorrowDataTable borrowedTable = mediaDAO.ListBorrowed();

            foreach (MediaDS.TabBorrowRow row in borrowedTable.Rows)
            {
                if (row.MediaID == mediaId && row.ActualReturnDate < row.BorrowDate)
                {
                    BorrowModel borrowedMedia = BorrowModel.Parse(row);
                    borrowedMedias.Add(borrowedMedia);
                }
            }

            BorrowModel borrowed = null;
            if (borrowedMedias.Count == 0)
                borrowedMedias = null;
            else
                borrowed = borrowedMedias[0];
            return borrowed;
        }

        //List borrowed by media Id
        public List<BorrowModel> GetBorrowedByMediaId(int mediaId)
        {
            List<BorrowModel> borrowedMedias = new List<BorrowModel>();
            MediaDS.TabBorrowDataTable borrowedTable = mediaDAO.ListBorrowed();

            foreach (MediaDS.TabBorrowRow row in borrowedTable.Rows)
            {
                if (row.MediaID == mediaId)
                {
                    BorrowModel borrowedMedia = BorrowModel.Parse(row);
                    borrowedMedias.Add(borrowedMedia);
                }
            }

            if (borrowedMedias.Count == 0)
                borrowedMedias = null;
            return borrowedMedias;
        }

        //List all borrowed medias by current user
        public List<PairModel> ListBorrowedByUid(int uid)
        {
            List<PairModel> pairs = new List<PairModel>();
            MediaDS.TabBorrowDataTable borrowTable = mediaDAO.ListBorrowed();
            MediaDS.ViewMediaDataTable mediaTable = mediaDAO.ListMedia();

            foreach (MediaDS.TabBorrowRow row in borrowTable.Rows)
            {
                foreach (MediaDS.ViewMediaRow row2 in mediaTable.Rows)
                {
                    //Filter borrowed medias by user and actualReturnDate
                    if (row.MediaID == row2.MediaID && row.ActualReturnDate < row.BorrowDate && uid == row.UID)
                    {
                        PairModel pair = PairModel.Parse(row.BID, row2.Title);
                        pairs.Add(pair);                        
                    }
                }
            }
            if (pairs.Count == 0)
                pairs = null;

            return pairs;
        }

        //List borrowed by borrow Id
        public BorrowModel ListBorrowedByBID(int borrowId)
        {
            //empty list of media models to start us off
            List<BorrowModel> borrowedMedias = new List<BorrowModel>();
            MediaDS.TabBorrowDataTable borrowedTable = mediaDAO.ListBorrowed();

            foreach (MediaDS.TabBorrowRow row in borrowedTable.Rows)
            {
                if (row.BID == borrowId)
                {
                    BorrowModel media = BorrowModel.Parse(row);
                    borrowedMedias.Add(media);//add it to our list of media
                }
            }
            BorrowModel borrowed = null;
            if (borrowedMedias.Count == 0)
                borrowedMedias = null;
            else
                borrowed = borrowedMedias[0];
            return borrowed;
        }

        //Language Title
        public List<MediaModel> ListMediaByTitle(string title)
        {
            List<MediaModel> medias = new List<MediaModel>();
            MediaDS.ViewMediaDataTable mediaTable = mediaDAO.ListMediaByTitle(title);

            foreach (MediaDS.ViewMediaRow row in mediaTable.Rows)
            {
                MediaModel media = MediaModel.Parse(row);
                medias.Add(media);
            }
            return medias;
        }

        //Language Name    
        public List<MediaModel> ListMediaByLanguageName(string languageName)
        {
            List<MediaModel> medias = new List<MediaModel>();
            MediaDS.ViewMediaDataTable mediaTable = mediaDAO.ListMediaByLanguageName(languageName);

            foreach (MediaDS.ViewMediaRow row in mediaTable.Rows)
            {
                MediaModel media = MediaModel.Parse(row);
                medias.Add(media);
            }
            return medias;
        }

        //Publish Year
        public List<MediaModel> ListMediaByPublishYear(int publishYear)
        {
            List<MediaModel> medias = new List<MediaModel>();
            MediaDS.ViewMediaDataTable mediaTable = mediaDAO.ListMediaByPublishYear(publishYear);

            foreach (MediaDS.ViewMediaRow row in mediaTable.Rows)
            {
                MediaModel media = MediaModel.Parse(row);
                medias.Add(media);
            }
            return medias;
        }

        //Budget
        public List<MediaModel> ListMediaByBudget(int budget)
        {
            List<MediaModel> medias = new List<MediaModel>();
            MediaDS.ViewMediaDataTable mediaTable = mediaDAO.ListMediaByBudget(budget);

            foreach (MediaDS.ViewMediaRow row in mediaTable.Rows)
            {
                MediaModel media = MediaModel.Parse(row);
                medias.Add(media);
            }
            return medias;
        }
        

        public List<PairModel> ListGenre()
        {
            List<PairModel> pairs = new List<PairModel>();
            MediaDS.TabGenreDataTable genreTable = mediaDAO.ListGenre();

            foreach (MediaDS.TabGenreRow row in genreTable.Rows)
            {
                PairModel pair = PairModel.Parse(row);
                pairs.Add(pair);
            }
            return pairs;

            
        }

        public List<PairModel> ListLanguage()
        {
            List<PairModel> pairs = new List<PairModel>();
            MediaDS.TabLanguageDataTable languageTable = mediaDAO.ListLanguage();

            foreach (MediaDS.TabLanguageRow row in languageTable.Rows)
            {
                PairModel pair = PairModel.Parse(row);
                pairs.Add(pair);
            }
            return pairs;            
        }

        public List<PairModel> ListDirector()
        {
            List<PairModel> pairs = new List<PairModel>();
            MediaDS.TabDirectorDataTable directorTable = mediaDAO.ListDirector();

            foreach (MediaDS.TabDirectorRow row in directorTable.Rows)
            {
                PairModel pair = PairModel.Parse(row);
                pairs.Add(pair);
            }
            return pairs;
        }

        //NEW
        //New Media
        public int AddNewMedia(string title, int genre, int director, int language, int publishYear, int budget)
        {
            return mediaDAO.InsertNewMedia(title, genre, director, language, publishYear, budget);
        }

        //New Director
        public int AddNewDirector(string directorName)
        {
            return mediaDAO.InsertNewDirector(directorName);
        }

        //New Director
        public int AddNewGenre(string genre)
        {
            return mediaDAO.InsertNewGenre(genre);
        }

        //New Director
        public int AddNewLanguage(string language)
        {
            return mediaDAO.InsertNewLanguage(language);
        }

        //Update Media
        public int UpdateMedia(string newTitle, int newGenre, int newDirector, int newLanguage, int newPublishYear, int newBudget, int mediaID, int userLevel)
        {
            if (userLevel < 3)//not an admin, can't change users password!
                return -1;
            else
                return mediaDAO.UpdateMedia(newTitle, newGenre, newDirector, newLanguage, newPublishYear, newBudget, mediaID);
        }

        //Delete media by ID
        public int DeleteMediaByMediaID(int mediaID, int userLevel)
        {
            if (userLevel < 3)//not an admin, can't delete medias!
                return -1;
            else
                return mediaDAO.DeleteMediaByMediaID(mediaID);
        }

        //RESERVE <<<<<<
        //Add new reserve
        public int AddNewReservedMedia(int user, int media, DateTime date)
        {
            return mediaDAO.InserNewRerserved(user, media, date);
        }

        //Delete media reserved
        public int DeleteMediaReservedByRID(int reservedID)
        {
            return mediaDAO.DeleteMediaReservedByRID(reservedID);
        }

        //BORROW <<<<<<<
        //Add new borrow
        public int AddNewBorrowedMedia(int user, int media, DateTime borrowDate, DateTime returnDate)
        {
            return mediaDAO.InsertNewBorrow(user, media, borrowDate, returnDate);
        }

        //Update borrow
        public int UpdateBorrow(DateTime actualReturnDate, decimal lateFee, int borrowId)
        {
            return mediaDAO.UpdateBorrow(actualReturnDate, lateFee, borrowId);
        }
    }
}
