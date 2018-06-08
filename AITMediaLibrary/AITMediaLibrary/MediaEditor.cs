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
    public partial class MediaEditor : Form
    {
        private MediaLogic mediaLogic = new MediaLogic();
        private MediaModel selectedMedia = null;
               
        public MediaEditor()
        {
            InitializeComponent();
        }

        //Refresh        
        private void RefreshMedia()
        {
            mediaGridView.DataSource = mediaLogic.ListMedia();
            genreGridView.DataSource = mediaLogic.ListGenre();
            directorGridView.DataSource = mediaLogic.ListDirector();
            languageGridView.DataSource = mediaLogic.ListLanguage();
            ComboBoxContent();

        }
        //Clear (Cleans the text box after a search is done
        private void clear()
        {
            newDirectorTextBox.Text = "";
            newGenreTextBox.Text = "";
            newLanguageTextBox.Text = "";            

        }
        private void clearForm()
        {
            titleTextBox.Text = " ";
            publishYearTextBox.Text = " ";
            budgetTextBox.Text = " ";
        }
        
        //Display ComboBox
        private void ComboBoxContent()
        {
            //Genre combo box
            genreComboBox.DataSource = mediaLogic.ListGenre();
            genreComboBox.DisplayMember = "PairName";
            genreComboBox.ValueMember = "PairId";

            //Language combo box
            languageComboBox.DataSource = mediaLogic.ListLanguage();
            languageComboBox.DisplayMember = "PairName";
            languageComboBox.ValueMember = "PairId";

            //Director combo box
            directorComboBox.DataSource = mediaLogic.ListDirector();
            directorComboBox.DisplayMember = "PairName";
            directorComboBox.ValueMember = "PairId";
        }
        
        //Display data
        private void MediaEditor_Load(object sender, EventArgs e)
        {
            //Auto resize columns
            mediaGridView.AutoResizeColumns();
            mediaGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; 

            //Media grid view
            mediaGridView.DataSource = mediaLogic.ListMedia();

            //Genre grid view
            genreGridView.DataSource = mediaLogic.ListGenre();

            //Director grid view
            directorGridView.DataSource = mediaLogic.ListDirector();

            //Language grid view
            languageGridView.DataSource = mediaLogic.ListLanguage();

            //Show genre, director and language combo box content
            ComboBoxContent();
            
        }

        //Refresh button
        private void refreshButton_Click(object sender, EventArgs e)
        {
            RefreshMedia();
        }

        //Media data grid view
        private void mediaGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row > 1)
            {
                List<MediaModel> medias = (List<MediaModel>)mediaGridView.DataSource;
                selectedMedia = medias.ElementAt<MediaModel>(row);

                //Get the individual media selected
                MediaModel media = medias[row];
                selectedMediaLabel.Text = "Selected Media: " + media.MediaName;

                //Fill form by selecting media
                titleTextBox.Text = media.MediaName;
                publishYearTextBox.Text = Convert.ToString(selectedMedia.PublishYear);
                budgetTextBox.Text = Convert.ToString(selectedMedia.Budget);
                directorComboBox.SelectedValue = selectedMedia.getDirector();
                genreComboBox.SelectedValue = selectedMedia.getGenre();
                languageComboBox.SelectedValue = selectedMedia.getLanguage();
            }
            
        }

        //Add new media button
        private void addMediaButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                int affectedRows = mediaLogic.AddNewMedia(titleTextBox.Text, (int)genreComboBox.SelectedValue, (int)directorComboBox.SelectedValue, (int)languageComboBox.SelectedValue, int.Parse(publishYearTextBox.Text), int.Parse(budgetTextBox.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please, make sure all form is filled!");
            }
            clearForm();
            RefreshMedia();
        }

        //Add new genre button
        private void addGenreButton_Click(object sender, EventArgs e)
        {
            if (newGenreTextBox.Text != "")
            {
                int affectedRows = mediaLogic.AddNewGenre(newGenreTextBox.Text);
            }
            clear();
            RefreshMedia();
        }

        //Add new director button
        private void addDirectorButton_Click(object sender, EventArgs e)
        {
            if (newDirectorTextBox.Text != "")
            {
                int affectedRows = mediaLogic.AddNewDirector(newDirectorTextBox.Text);
            }
            clear();
            RefreshMedia();
        }

        //Add new language button
        private void addLanguageButton_Click(object sender, EventArgs e)
        {
            if (newLanguageTextBox.Text != "")
            {
                int affectedRows = mediaLogic.AddNewLanguage(newLanguageTextBox.Text);
            }
            clear();
            RefreshMedia();
        }

        //Update Media
        private void updateMediaButton_Click(object sender, EventArgs e)
        {
            try
            {
                int rowsAffected = mediaLogic.UpdateMedia(titleTextBox.Text, (int)genreComboBox.SelectedValue, (int)directorComboBox.SelectedValue, (int)languageComboBox.SelectedValue, Int32.Parse(publishYearTextBox.Text), Int32.Parse(budgetTextBox.Text), selectedMedia.MediaId, CurrentUser.UserLevel);
                if (rowsAffected > 0)
                {
                    //worked
                    MessageBox.Show(selectedMedia.MediaName + " media updated!");
                    clear();
                }
                else
                {
                    //didnt
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No media selected");
            }
            RefreshMedia();            
        }

        //Delete media
        private void deleteMediaButton_Click(object sender, EventArgs e)
        {
            try
            {
                int affectedRows = mediaLogic.DeleteMediaByMediaID(selectedMedia.MediaId, CurrentUser.UserLevel);
                //if affectedRows > 0, deleted some people, else didnt
                if (affectedRows > 0)
                {   
                    //worked
                    MessageBox.Show(selectedMedia.MediaName + " media deleted!");
                    selectedMedia = null;

                    
                }
                else
                {
                    MessageBox.Show(selectedMedia.MediaName + " can not be deleted at this time. It has been borrowed!");
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show("No media selected");
            }
            RefreshMedia(); 
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

        //Show borrowed report
        private void listAllBorrowedButton_Click(object sender, EventArgs e)
        {
            mediaGridView.DataSource = mediaLogic.ListAllMediasBorrowed();
        }
        //Show reserved report
        private void listAllReservedButton_Click(object sender, EventArgs e)
        {
            mediaGridView.DataSource = mediaLogic.ListAllMediasReserved();
        }
        //Show all medias
        private void listAllMediasButton_Click(object sender, EventArgs e)
        {
            mediaGridView.DataSource = mediaLogic.ListMedia();
        }

        //Clear form button
        private void clearButton_Click(object sender, EventArgs e)
        {
            clearForm();
            RefreshMedia();
        }
        
    }
}
