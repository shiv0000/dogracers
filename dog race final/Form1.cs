using System;
using System.Windows.Forms;

namespace dog_race_final
{
    public partial class Form1 : Form
    {

        //guy
        public Guy shivam = new Guy() { Name = "shivam", Cash = 50 };
        public Guy manpreet = new Guy() { Name = "manpreet", Cash = 75 };
        public Guy joban = new Guy() { Name = "joban", Cash = 100 };
        public Guy[] guyArray = new Guy[3];
        public Guy guyPointer;

        //dog
        public hound[] dogArr = new hound[4];
        public PictureBox[] dogPict = new PictureBox[4];

        private Random MyRandomizer = new Random();
        private Timer raceTimer = new Timer();
        private int number;
        private int DogWin;

        private int maxLoc = 0;
        private int trigger = 0;

        public Form1()
        {
            InitializeComponent();

            //Initialize guys
            shivam.MyLabel = shivamBetLabel;
            shivam.MyRadioButton = shivamRadioButton;

            manpreet.MyLabel = manpreetBetLabel;
            manpreet.MyRadioButton = manpreetRadioButton;

            joban.MyLabel = jobanBetLabel;
            joban.MyRadioButton = jobanRadioButton;

            guyArray[0] = shivam;
            guyArray[1] = manpreet;
            guyArray[2] = joban;

            guyPointer = shivam;

            //dog
            dogPict[0] = dog0Pict;
            dogPict[1] = dog1Pict;
            dogPict[2] = dog2Pict;
            dogPict[3] = dog3Pict;

            for (int i = 0; i < 4; i++)
            {
                dogArr[i] = new hound();
                dogArr[i].MyPictureBox = dogPict[i];
                dogArr[i].StartingPosition = 26;
                dogArr[i].RacetrackLength = 596;
                dogArr[i].Randomizer = MyRandomizer;
            }

            //timer
            raceTimer.Interval = 1000;
            raceTimer.Tick += new EventHandler(raceTimer_Tick);
        }

        private void raceTimer_Tick(object Sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                dogArr[i].Run();

                if (dogArr[i].Location >= dogArr[i].RacetrackLength)
                {
                    trigger = 1;
                    if (dogArr[i].Location > maxLoc)
                    {
                        maxLoc = dogArr[i].Location;
                        DogWin = i;
                    }
                }
            }

            if (trigger == 1)
            {
                raceTimer.Stop();
                MessageBox.Show("Dog " + (DogWin + 1).ToString() + " won!");
                Pay();
                bettingGroupBox.Enabled = true;
            }

            number += 1;
            timerLabel.Text = number.ToString();
        }

        private void Pay()
        {
            for (int i = 0; i < 3; i++)
            {
                if (guyArray[i].Mygamble != null)
                {
                    guyArray[i].Mygamble.Payout(DogWin);
                    guyArray[i].Cleargamble();
                }
            }
            UpdateForm();
        }

        private void UpdateForm()
        {
            infoLabel.Text = guyPointer.Name + " is being chosen! Cash: " + guyPointer.Cash;
            nameLabel.Text = guyPointer.Name;
        }

        private void joeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            guyPointer = shivam;
            UpdateForm();
        }

        private void bobRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            guyPointer = manpreet;
            UpdateForm();
        }

        private void alRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            guyPointer = joban;
            UpdateForm();
        }

        private void betButton_Click(object sender, EventArgs e)
        {
            guyPointer.Placegamble((int)betValueSelect.Value, (int)dogNumberSelect.Value - 1);
            UpdateForm();
        }

        private void makeRun_Click(object sender, EventArgs e)
        {
            bettingGroupBox.Enabled = false;
            StartRunning();
        }

        private void StartRunning()
        {
            for (int i = 0; i < 4; i++)
                dogArr[i].TakeStartingPosition();
            trigger = 0;
            maxLoc = 0;
            raceTimer.Start();
            number = 0;
        }

        private void makeRun_Click_1(object sender, EventArgs e)
        {
            bettingGroupBox.Enabled = false;
            StartRunning();
        }

        private void bobRadioButton_CheckedChanged_1(object sender, EventArgs e)
        {
            guyPointer = manpreet;
            UpdateForm();
        }

        private void alRadioButton_CheckedChanged_1(object sender, EventArgs e)
        {
            guyPointer = joban;
            UpdateForm();
        }

        private void joeBetLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
    