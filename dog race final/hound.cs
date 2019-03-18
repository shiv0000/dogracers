﻿
using System.Windows.Forms;

namespace dog_race_final
{
    public class hound
    {

        public int StartingPosition;
        public int RacetrackLength;
        public PictureBox MyPictureBox;
        public int Location;
        public System.Random Randomizer;

        public void Run()
        {
            int Stride = Randomizer.Next(20, 50);
            Location += Stride;
            MyPictureBox.Left += Stride;
        }

        public void TakeStartingPosition()
        {
            Location = 0;
            MyPictureBox.Left = StartingPosition;
        }
    }
}
