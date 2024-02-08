using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace prog2500_assignment1_matheusoliveira
{
    /// <summary>
    /// Interaction logic for TagEditorControl.xaml
    /// </summary>
    public partial class TagEditorControl : UserControl
    {
        // Define properties for accessing text boxes in TagEditorControl
        public TextBox TagEditingTitleTextBox => tagEditingTitle;
        public TextBox TagEditingArtistTextBox => tagEditingArtist;
        public TextBox TagEditingAlbumTextBox => tagEditingAlbum;
        public TextBox TagEditingYearTextBox => tagEditingYear;

        // Define an event for the Save button clicked
        public event EventHandler SaveButtonClicked;

        public TagEditorControl()
        {
            InitializeComponent();
        }

        // Handler for the Save button click event
        private void Button_Save(object sender, RoutedEventArgs e)
        {
            if (this.SaveButtonClicked != null)
            {
                this.SaveButtonClicked(this, e);
            }
        }
    }
}
