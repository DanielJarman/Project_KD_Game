using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_KD_Game
{
    class Player
    {
        int x;
        int y;
        Form1 form;

        public Player(Form1 form)
        {
            this.Form = form;
        }
        public void MovePlayer(KeyEventArgs key)
        {
            int keyValue = key.KeyValue;
            switch (keyValue)
            {
                case 37:
                    MoveLeft();
                    break;
                case 38:
                    MoveUp();
                    break;
                case 39:
                    MoveRight();
                    break;
                case 40:
                    MoveDown();
                    break;
            }
        }
        public void MoveLeft()
        {
            X = X - 1;
            Form.Draw();
        }
        public void MoveRight()
        {
            X = X + 1;
            Form.Draw();
        }
        public void MoveUp()
        {
            Y = Y - 1;
            Form.Draw();
        }
        public void MoveDown()
        {
            Y = Y + 1;
            Form.Draw();
        }
        public int Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }

        public int X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }

        public Form1 Form
        {
            get
            {
                return form;
            }

            set
            {
                form = value;
            }
        }
    }
}
