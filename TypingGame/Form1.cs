using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TypingGame
{
    public partial class TypingGame : Form
    {
        Random random = new Random();
        Stats stats = new Stats();

        public TypingGame()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            listBox1.Items.Add((Keys)random.Next(65, 90));
            if(listBox1.Items.Count > 7)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Fin..");
                timer1.Enabled = false;
            }
        }

        private void TypingGame_KeyDown(object sender, KeyEventArgs e)
        {
            playGame(e);
        }

        private void playGame(KeyEventArgs e)
        {
            if (!timer1.Enabled)
                return;

            // make it faster every time the user presses a key
            if (listBox1.Items.Contains(e.KeyCode))
            {
                listBox1.Items.Remove(e.KeyCode);
                listBox1.Refresh();
                if (timer1.Interval > 400)
                    timer1.Interval -= 10;
                if (timer1.Interval > 250)
                    timer1.Interval -= 7;
                if (timer1.Interval > 100)
                    timer1.Interval -= 2;
                difficultyProgressBar.Value = 800 - timer1.Interval;

                stats.Update(true);
            }
            else
            {
                // wrong key so update it
                stats.Update(false);
            }

            updateLabels();
        }

        private void updateLabels()
        {
            correctLabel.Text = "Correct: " + stats.Correct;
            missedLabel.Text = "Missed: " + stats.Missed;
            totalLabel.Text = "Total: " + stats.Total;
            accuracyLabel.Text = "Accuracy: " + stats.Accuracy + " %";
        }
    }
}
