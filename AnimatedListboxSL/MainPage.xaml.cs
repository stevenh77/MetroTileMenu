using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using System.Windows.Media;

namespace AnimatedListboxSL
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();

            var list = new List<Tile>()
                           {
                               new Tile() {Brush = new SolidColorBrush(Colors.Red)},
                               new Tile() {Brush = new SolidColorBrush(Colors.Blue)},
                               new Tile() {Brush = new SolidColorBrush(Colors.Orange)},
                               new Tile() {Brush = new SolidColorBrush(Colors.Green)},
                               new Tile() {Brush = new SolidColorBrush(Colors.Black)},
                               new Tile() {Brush = new SolidColorBrush(Colors.Gray)},
                               new Tile() {Brush = new SolidColorBrush(Colors.Purple)},
                               new Tile() {Brush = new SolidColorBrush(Colors.Brown)},
                               new Tile() {Brush = new SolidColorBrush(Colors.Red)},
                               new Tile() {Brush = new SolidColorBrush(Colors.Blue)},
                               new Tile() {Brush = new SolidColorBrush(Colors.Orange)},
                               new Tile() {Brush = new SolidColorBrush(Colors.Green)},
                               new Tile() {Brush = new SolidColorBrush(Colors.Black)},
                               new Tile() {Brush = new SolidColorBrush(Colors.Gray)},
                               new Tile() {Brush = new SolidColorBrush(Colors.Purple)},
                               new Tile() {Brush = new SolidColorBrush(Colors.Brown)}
                           };
            listbox1.ItemsSource = list;
        }
    }

    public class Tile
    {
        public Brush Brush { get; set; }
    }
}
