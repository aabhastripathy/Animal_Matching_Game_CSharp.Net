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

namespace AnimalGame
{
    using System.Text.RegularExpressions;
    using System.Windows.Threading;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        DispatcherTimer timer = new DispatcherTimer();
        List<float> HighestScores = new List<float>();
        
        int tenthsOfSecondsElapsed;
        int matchFound;
        
        public MainWindow()
        {
            InitializeComponent();
            timer.Interval = TimeSpan.FromSeconds(.1);
            timer.Tick += Timer_Tick;  
            SetUpGame();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            tenthsOfSecondsElapsed++;
            timeTextBlock.Text = (tenthsOfSecondsElapsed / 10F).ToString("0.0s");
            if (matchFound == 8)
            {
                timer.Stop();

                
                float finalTime = tenthsOfSecondsElapsed / 10F;
                

                // Example: Add to static/global high scores list
                HighestScores.Add(finalTime);

                // Optionally, sort or show top score
                
               // MessageBox.Show($"Best Time: {bestScore:0.0s}");
                float bestTime = float.MaxValue;
                if (finalTime < bestTime)
                {
                    bestTime = finalTime;
                   // MessageBox.Show($"🎉 New High Score! {bestTime:0.0s}");
                }
                timeTextBlock.Text = timeTextBlock.Text +"  Highest Score=> " + HighestScores.Min() + " - Play again?";
            }
        }

        private void SetUpGame()
        {
            //throw new NotImplementedException();
            List<string> Emoji = new List<string>()
            {
                //🦁🐯🐵🐶🐮🐭
                "🦁","🦁",
                "🐯","🐯",
                "🐵","🐵",
                "🐶","🐶",
                "🐮","🐮",
                "😼","😼",
                "🐙","🐙",
                "🐭","🐭"
            };
            Random random = new Random();
            foreach (TextBlock textBlock in mainGrid.Children.OfType<TextBlock>()) 
            {
                if (textBlock.Name != "timeTextBlock")
                {
                    textBlock.Visibility = Visibility.Visible;
                    int index = random.Next(Emoji.Count);
                    string nextEmoji = Emoji[index];
                    textBlock.Text = nextEmoji;
                    Emoji.RemoveAt(index);
                }
            }
            timer.Start();
            tenthsOfSecondsElapsed = 0;
            matchFound = 0;
        }

        TextBlock lastTextBlockClicked;
        bool findingMatch = false;
        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock = sender as TextBlock;
            if (findingMatch == false)
            {
                textBlock.Visibility = Visibility.Hidden;
                lastTextBlockClicked = textBlock;
                findingMatch = true;
            }
            else if (textBlock.Text == lastTextBlockClicked.Text)
            {
                matchFound++;
                textBlock.Visibility = Visibility.Hidden;
                findingMatch = false;
            }
            else
            {
                lastTextBlockClicked.Visibility = Visibility.Visible;
                findingMatch = false;
            }
        }

        private void TimeTextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (matchFound == 8) 
            {
                SetUpGame();
            }
        }
        
    }
}




