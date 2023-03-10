using System.Windows.Forms;

namespace Saper
{
    internal class ButtonField : Button
    {

        bool isBomb;
        public bool IsBomb
        {
            get => isBomb;
            set
            {
                isBomb = value;
                Text = "BB";
            }

        }
        public int nearBombs;
        public int NearBombs
        {
            get => nearBombs;
            set 
            {
                nearBombs = value;
                Text = value.ToString();
            }


        }
    }
}