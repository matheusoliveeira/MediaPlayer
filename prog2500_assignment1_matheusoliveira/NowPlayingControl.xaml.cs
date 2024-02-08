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
    /// Interaction logic for NowPlayingControl.xaml
    /// </summary>
    public partial class NowPlayingControl : UserControl
    {

        public TextBox NowPlayingTextBox => nowPlayingData;

        public NowPlayingControl()
        {
            InitializeComponent();
        }
    }
}
