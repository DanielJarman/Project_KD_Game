using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    class Feld
    {
        PictureBox pBox;
        Boolean player = false;
        Boolean wall = false;
        Boolean npc = false;
        int xCord;
        int yCord;

        public Feld(PictureBox pBox, int x, int y)
        {
            this.PBox = pBox;
            this.XCord = x;
            this.YCord = y;
        }



        //Get'er & Set'er
        public PictureBox PBox
        {
            get
            {
                return pBox;
            }

            set
            {
                pBox = value;
            }
        }

        public bool Player
        {
            get
            {
                return player;
            }

            set
            {
                player = value;
            }
        }

        public bool Wall
        {
            get
            {
                return wall;
            }

            set
            {
                wall = value;
            }
        }

        public bool Npc
        {
            get
            {
                return npc;
            }

            set
            {
                npc = value;
            }
        }

        public int XCord
        {
            get
            {
                return xCord;
            }

            set
            {
                xCord = value;
            }
        }

        public int YCord
        {
            get
            {
                return yCord;
            }

            set
            {
                yCord = value;
            }
        }
    }
}
