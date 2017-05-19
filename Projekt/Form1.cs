using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class Form1 : Form
    {
        Feld[,] feldArray;
        PictureBox pBox;
        public Form1()
        {
            feldArray = new Feld[15, 15];
            InitializeComponent();
            fillFields();
        }

        private void fillFields()
        {

            for(int x = 0; x < 15; x++)
            {
                for(int y = 0; y < 15; y++)
                {
                    pBox = new PictureBox();
                    pBox.Dock = DockStyle.Fill;
                    pBox.Margin = new Padding(0);
                    //pBox.BackColor = Color.Black;
                    tableLayoutPanelSpielfeld.Controls.Add(pBox, x, y);
                    feldArray[x, y] = new Feld(pBox, x, y);
                }
            }
        }

        private void createWalls()
        {
            for(int i = 0; i < 15; i++)
            {

            }
        }
    }
}
