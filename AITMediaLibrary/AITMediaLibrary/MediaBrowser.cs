using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Business_Logic;


namespace AITMediaLibrary
{
    public partial class MediaBrowser : Form
    {
        MediaLogic mediaLogic;
        
        private MediaModel selectedMedia = null;
        private ReserveModel selectedReserve = null;
        private BorrowModel selectedBorrowed = null;
        private const decimal feePerDay = 3.50m; //Const fee per each late day
        private const int borrowDays = 7; //Cons Maxium days a user can have a media without paying late fees

        public MediaBrowser()
        {
            mediaLogic = new MediaLogic();
            InitializeComponent();
        }

        //Refresh media
        private void RefreshMedia()
        {
            mediaGridView.DataSource = mediaLogic.ListMedia();
            ComboBoxContent();
        }
        //Load
        private void MediaBrowser_Load(object sender, EventArgs e)
        {
            mediaGridView.DataSource = mediaLogic.ListMedia();
            userLabel.Text = "Username: " + CurrentUser.UserName;
            ComboBoxContent();
        }

        //Clear (Cleans the text box after a search is done
        public void clear()
        {
            languageNameTextBox.Text = "";
            budgetTextBox.Text = "";
            publishYearTextBox.Text = "";
            titleTextBox.Text = "";

        }


        //Budget Search
        private void budgetButton_Click(object sender, EventArgs e)
        {
            try
            {
                mediaGridView.DataSource = mediaLogic.ListMediaByBudget(Int32.Parse(budgetTextBox.Text));
            }
            catch (Exception ex)
            {
                mediaGridView.DataSource = mediaLogic.ListMedia();//if error, list everything
            }
            clear();
        }

        //Title Search
        private void titleButton_Click(object sender, EventArgs e)
        {
            try
            {
                mediaGridView.DataSource = mediaLogic.ListMediaByTitle(titleTextBox.Text);
            }
            catch (Exception ex)
            {
                mediaGridView.DataSource = mediaLogic.ListMedia();//if error, list everything
            }
            clear();
        }

        //Language Search
        private void languageSearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                mediaGridView.DataSource = mediaLogic.ListMediaByLanguageName(languageNameTextBox.Text);
            }
            catch (Exception ex)
            {
                mediaGridView.DataSource = mediaLogic.ListMedia();//if error, list everything
            }
            clear();
        }

        //Year Search
        private void yearSearchButton_Click(object sender, EventArgs e)
        {
            try
            {                
                mediaGridView.DataSource = mediaLogic.ListMediaByPublishYear(Int32.Parse(publishYearTextBox.Text));
            }
            catch(Exception ex)
            {
                mediaGridView.DataSource = mediaLogic.ListMedia();//if error, list everything
            }
            clear();
        }

        private void listAllButton_Click(object sender, EventArgs e)
        {
            mediaGridView.DataSource = mediaLogic.ListMedia();
        }

        //Search by keypress "ENTER"
        private void titleTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                titleButton_Click(sender, e);
        }

        private void languageNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                languageSearchButton_Click(sender, e);
        }

        private void publishYearTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                yearSearchButton_Click(sender, e);
        }

        private void budgetTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                budgetButton_Click(sender, e);
        }


        private void mediaGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;//get which row was selected
            //if user clicks column headers, row = -1, so ignore
            
            if (row >= 0)
            {
                //cast dataSource from object back into what we put it in
                List<MediaModel> medias = (List<MediaModel>)mediaGridView.DataSource;

                //get the individual media selected
                MediaModel media = medias[row];
                selectMediaLable.Text = "Selected Media: " + media.MediaName;
                selectedMedia = media;
                selectedReserve = mediaLogic.GetReserved(selectedMedia.MediaId);
                selectedBorrowed = mediaLogic.GetBorrowed(selectedMedia.MediaId);

                //Media availability                
                if (mediaLogic.GetReservedByMedia(selectedMedia.MediaId) != null)
                {
                    availabilityLabel.Text = "Media Availability: Reserved";
                    reserveButton.Text = "Unreserve";//Changes button text to unreserve
                }
                else if (mediaLogic.GetBorrowedByMediaId(selectedMedia.MediaId)!= null)
                {
                    var item = mediaLogic.GetBorrowedByMediaId(selectedMedia.MediaId);
                    if (item.Last().ActualReturnDate < item.Last().BorrowDate)                
                        availabilityLabel.Text = "Media Availability: Borrowed";
                        
                    else
                        availabilityLabel.Text = "Media Availability: Available";
                    reserveButton.Text = "Reserve";
                }
                else
                {
                    availabilityLabel.Text = "Media Availability: Available";
                    reserveButton.Text = "Reserve"; //Returns button text to reserve
                }                      
            }

        }

        //Log out
        private void logOutButton_Click(object sender, EventArgs e)
        {
            CurrentUser.UserName = " ";
            CurrentUser.UserId = 0;
            CurrentUser.UserLevel = 0;

            System.Threading.Thread t = new System.Threading.Thread(OpenLogin);
            t.Start();
            Close();
        }
        //Open login
        private static void OpenLogin()
        {
            Application.Run(new Form1());
        }

        //RESERVE <<<<<    
        private void reserveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (mediaLogic.GetReservedByMedia(selectedMedia.MediaId) == null)
                {

                    if (mediaLogic.GetBorrowedByMediaId(selectedMedia.MediaId) == null || selectedBorrowed == null)
                    {
                        //Reserves a media
                        int affectedRows = mediaLogic.AddNewReservedMedia(CurrentUser.UserId, selectedMedia.MediaId, DateTime.Now);
                        MessageBox.Show(selectedMedia.MediaName + " successfully reserved!");
                        availabilityLabel.Text = "Media Availability: Reserved";
                        reserveButton.Text = "Unreserve";//Changes button text to unreserve
                    }
                    else
                        MessageBox.Show("Sorry, media has been borrowed.");
                    
                }                         
                else if (selectedReserve.UserId == CurrentUser.UserId)
                {
                    //Unreserves a media
                    DeleteReserve();
                    MessageBox.Show("Successfully unreserved!");
                    availabilityLabel.Text = "Media Availability: Available";
                    reserveButton.Text = "Reserve";  //Returns button text to reserve
                }

                else
                {
                    MessageBox.Show(selectedMedia.MediaName + " is reserved by another user, you can not unreserve it!");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No media selected");
            }
            RefreshMedia();
        }

        //Unreserve method
        private void DeleteReserve()
        {
            try
            {
                if (selectedMedia != null)
                {
                    int affectedRows = mediaLogic.DeleteMediaReservedByRID(selectedReserve.ReserveId);
                    reserveButton.Text = "Reserve";

                }
            }
            catch (Exception ex)
            {
                //no reserve found
            }
            RefreshMedia();
        }

        //Borrow <<<<
        //add new borrow        
        private void borrowButton_Click(object sender, EventArgs e)
        {   try
            {
                if (mediaLogic.GetReservedByMedia(selectedMedia.MediaId) == null || selectedReserve.UserId == CurrentUser.UserId)
                    Borrow();
                else
                    MessageBox.Show("You can not borrow a media reserved by another user!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No media selected!");
            }
            RefreshMedia();
        }

        //Return Borrowed
        private void returnButton_Click(object sender, EventArgs e)
        {
            
            try
            {                
                int rowsAffected = mediaLogic.UpdateBorrow(DateTime.Now, CalculateFee(DateTime.Now), (int)borrowedComboBox.SelectedValue);
                availabilityLabel.Text = "Media Availability: Available";
                reserveButton.Text = "Reserve";
                MessageBox.Show("Media returned!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't return");
            }
            RefreshMedia();
        }

        //Borrow method
        private void Borrow()
        {            
                if (mediaLogic.GetBorrowedByMediaId(selectedMedia.MediaId) == null || selectedBorrowed == null)//If it is null it means no one has borrowed it yet
                {
                    int affectedRows = mediaLogic.AddNewBorrowedMedia(CurrentUser.UserId, selectedMedia.MediaId, DateTime.Now, DateTime.Now.AddDays(borrowDays));// 7 days is the maximum a user can have a media without paying late fees.
                    MessageBox.Show(selectedMedia.MediaName + " successfully borrowed!");
                    DeleteReserve();
                    availabilityLabel.Text = "Media Availability: Borrowed";                    
                }
                else if (selectedBorrowed.UserdId == CurrentUser.UserId)
                {
                    MessageBox.Show("You have already borrowed this media!");
                }
                else
                {
                    MessageBox.Show("Sorry, media already borrowed by another user!");
                }                      
        }

        //Calculate late fee
        private decimal CalculateFee(DateTime actualReturnDate)
        {
            decimal actualFee = 0;        
            TimeSpan difference;
            difference = actualReturnDate - mediaLogic.ListBorrowedByBID((int)borrowedComboBox.SelectedValue).ReturnDate;
            var days = difference.TotalDays;
            if (days > 0)
            {   //If late calculate fee to be paid
                actualFee = feePerDay * (decimal)days;
                MessageBox.Show("A$ " + String.Format("{0:0.00}", actualFee) + " late fee apply!");
                return actualFee;
            }
            else//No fee aplies
                return 0;
        }

        //Display combobox
        private void ComboBoxContent()
        {   
            borrowedComboBox.DataSource = mediaLogic.ListBorrowedByUid(CurrentUser.UserId);            
            borrowedComboBox.DisplayMember = "PairName";
            borrowedComboBox.ValueMember = "PairId";                      
                       
        }       
               
    }
}
