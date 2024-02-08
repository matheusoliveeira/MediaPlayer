using Microsoft.Win32;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using TagLib;

namespace prog2500_assignment1_matheusoliveira
{
    public partial class MainWindow : Window
    {
        private TagLib.File? currentFile;
        private bool mediaPlayerIsPlaying = false;

        public MainWindow()
        {
            InitializeComponent();
            // Subscribe to the SaveButtonClicked event of the tagEditorControl
            tagEditorControl.SaveButtonClicked += TagEditorControl_SaveButtonClicked;
        }

        // Method to open a file
        private void OpenFile(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Media files (*.mp3;*.mpg;*.mpeg)|*.mp3;*.mpg;*.mpeg|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                try
                {
                    // Open the file and set the currentFile and media source
                    fileNameBox.Text = openFileDialog.FileName;
                    currentFile = TagLib.File.Create(openFileDialog.FileName);
                    mediaPlayer.Source = new Uri(openFileDialog.FileName);

                    // Enable edit and play buttons
                    btnEdit.IsEnabled = true;
                    btnPlaying.IsEnabled = true;
                    menuEdit.IsEnabled = true;

                    // Display file information
                    Button_Click_Playing(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error opening file: " + ex.Message);
                }
            }
        }

        // Method to handle editing button click
        private void Button_Click_Edit(object sender, RoutedEventArgs e)
        {
            // Show tag editor and hide now playing control
            tagEditorControl.Visibility = Visibility.Visible;
            nowPlaying.Visibility = Visibility.Hidden;

            try
            {
                // Populate tag editor with current file information
                if (currentFile != null)
                {
                    var year = currentFile.Tag.Year;
                    var title = currentFile.Tag.Title;
                    var artist = currentFile.Tag.AlbumArtists.FirstOrDefault();
                    var album = currentFile.Tag.Album;

                    tagEditorControl.TagEditingTitleTextBox.Text = title;
                    tagEditorControl.TagEditingArtistTextBox.Text = artist;
                    tagEditorControl.TagEditingAlbumTextBox.Text = album;
                    tagEditorControl.TagEditingYearTextBox.Text = year.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error editing tags: " + ex.Message);
            }
        }

        // Method to handle playing button click
        private void Button_Click_Playing(object sender, RoutedEventArgs e)
        {
            // Show now playing control and hide tag editor
            nowPlaying.Visibility = Visibility.Visible;
            tagEditorControl.Visibility = Visibility.Hidden;

            try
            {
                // Display current file information in the now playing control
                if (currentFile != null)
                {
                    var title = currentFile.Tag.Title;
                    var artist = currentFile.Tag.AlbumArtists.FirstOrDefault();
                    var album = currentFile.Tag.Album;
                    var year = currentFile.Tag.Year.ToString();
                    nowPlaying.NowPlayingTextBox.Text = $"{title}\n{album}\n{artist} ({year})";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Method to handle saving button click in the tag editor
        private void TagEditorControl_SaveButtonClicked(object? sender, EventArgs e)
        {
            try
            {
                mediaPlayer.Stop();
                mediaPlayer.Close();

                if (currentFile != null)
                {
                    var newTitle = tagEditorControl.TagEditingTitleTextBox.Text;
                    var newArtist = new[] { tagEditorControl.TagEditingArtistTextBox.Text };
                    var newAlbum = tagEditorControl.TagEditingAlbumTextBox.Text;

                    // Validate and parse the year input
                    if (uint.TryParse(tagEditorControl.TagEditingYearTextBox.Text, out uint newYear))
                    {
                        // Check if the year has more than four digits
                        if (newYear <= 9999)
                        {
                            currentFile.Tag.Title = newTitle;
                            currentFile.Tag.Year = newYear;
                            currentFile.Tag.AlbumArtists = newArtist;
                            currentFile.Tag.Album = newAlbum;
                            currentFile.Save();
                            MessageBox.Show("The changes were saved!");
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid year with up to four digits.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid numeric year.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving tags: " + ex.Message);
            }
        }

        // Method to handle application shutdown
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        // Command handlers for opening, playing, pausing, and stopping media
        private void Open_CanExecute(object sender, CanExecuteRoutedEventArgs e) => e.CanExecute = true;
        private void Open_Executed(object sender, ExecutedRoutedEventArgs e) => OpenFile(sender, e);
        private void Play_CanExecute(object sender, CanExecuteRoutedEventArgs e) => e.CanExecute = (mediaPlayer != null) && (mediaPlayer.Source != null);
        private void Play_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            mediaPlayer.Play();
            mediaPlayerIsPlaying = true;
        }
        private void Pause_CanExecute(object sender, CanExecuteRoutedEventArgs e) => e.CanExecute = mediaPlayerIsPlaying;
        private void Pause_Executed(object sender, ExecutedRoutedEventArgs e) => mediaPlayer.Pause();
        private void Stop_CanExecute(object sender, CanExecuteRoutedEventArgs e) => e.CanExecute = mediaPlayerIsPlaying;
        private void Stop_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            mediaPlayer.Stop();
            mediaPlayerIsPlaying = false;
        }

        // Method to handle edit menu item click
        private void MenuItem_Edit(object sender, RoutedEventArgs e) => Button_Click_Edit(sender, e);
    }
}