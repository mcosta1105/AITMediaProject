using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data_Access;


namespace Business_Logic
{
    public class BorrowModel
    {
        //Borrow id
        private int borrowId;

        public int BorrowId
        {
            get { return borrowId; }
            set { borrowId = value; }
        }

        //User Id
        private int userId;

        public int UserdId
        {
            get { return userId; }
            set { userId = value; }
        }
        
        //Media Id
        private int mediaId;

        public int MediaId
        {
            get { return mediaId; }
            set { mediaId = value; }
        }
        
        //Borrow day
        private DateTime borrowDate;

        public DateTime BorrowDate
        {
            get { return borrowDate; }
            set { borrowDate = value; }
        }
        
        //Return date
        private DateTime returnDate;

        public DateTime ReturnDate
        {
            get { return returnDate; }
            set { returnDate = value; }
        }

        //Actal return date
        private DateTime actualReturnDate;

        public DateTime ActualReturnDate
        {
            get { return actualReturnDate; }
            set { actualReturnDate = value; }
        }

        //Late fee
        private decimal lateFee;

        public decimal LateFee
        {
            get { return lateFee; }
            set { lateFee = value; }
        }

        public static BorrowModel Parse(MediaDS.TabBorrowRow borrowRow)
        {
            if (borrowRow == null)
                return null;

            BorrowModel borrow = new BorrowModel();
            borrow.borrowId = borrowRow.BID;
            borrow.userId = borrowRow.UID;
            borrow.mediaId = borrowRow.MediaID;
            borrow.borrowDate = borrowRow.BorrowDate;
            borrow.returnDate = borrowRow.ReturnDate;
            borrow.actualReturnDate = borrowRow.ActualReturnDate;
            borrow.lateFee = borrowRow.LateFee;           
            
            return borrow;
        }
    }
}
