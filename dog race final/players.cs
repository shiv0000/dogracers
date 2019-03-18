
using System.Windows.Forms;

namespace dog_race_final
{
   public class Guy
    {

        public string Name;
        public int Cash;
        public gamble Mygamble = null;
        public Label MyLabel;
        public RadioButton MyRadioButton;

        public void UpdateLabel()
        {
            MyLabel.Text = Mygamble.GetDescription();
        }

        public bool Placegamble(int gambleAmount, int DogToWin)
        {
            if (gambleAmount <= Cash)
            {
                Mygamble = new gamble() { Amount = gambleAmount, Dog = DogToWin, Bettor = this };
                UpdateLabel();
                return true;
            }
            MessageBox.Show(Name + " doesn't have enough in cash to gamble this amount!");
            return false;
        }

        public void Cleargamble()
        {
            Mygamble = null;
            MyLabel.Text = Name + " hasn't placed gamble yet!";
        }

        public void Collect(int Amount)
        {
            Cash += Amount;
            MessageBox.Show(Name + " has received " + Amount.ToString() + "!");
        }

    }
}
