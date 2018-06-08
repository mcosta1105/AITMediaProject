using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data_Access;

namespace Business_Logic
{
    public class ReserveModel
    {
        //Reserve ID
        private int reserveId;

        public int ReserveId
        {
            get { return reserveId; }
            set { reserveId = value; }
        }

        //User ID
        private int userId;

        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }

        public int getUserId()
        {
            return userId;
        }

        //Media ID
        private int mediaId;

        public int MediaId
        {
            get { return mediaId; }
            set { mediaId = value; }
        }

        
        //Date
        private DateTime reservedDate;

        public DateTime ReservedDate
        {
            get { return reservedDate; }
            set { reservedDate = value; }
        }
        
        
        public static ReserveModel Parse(MediaDS.TabReservedRow reserveRow)
        {
            if (reserveRow == null)            
                return null;

            ReserveModel reserve = new ReserveModel();
            reserve.reserveId = reserveRow.RID;
            reserve.mediaId = reserveRow.MediaID;
            reserve.userId = reserveRow.UID;
            reserve.reservedDate = reserveRow.ReservedDate;
            
            
            return reserve;
        }
        
    }
}
