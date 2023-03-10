using System;
using System.Windows.Forms;

namespace Saper
{
    internal class PanelGame : Panel
    {
        ButtonField[,] board;
        const int SIZE=30;
        Random generator;

        public PanelGame(int width ,int height, int bombCount)
        {
            this.AutoSize = true;
            //this.AutoSize.Mode = AutoSizeMode.GrowAndShrink;
            board = new ButtonField[width, height];
            for(int i=0;i<height;i++)
            {
                for(int j=0;j<width;j++)
                {
                    board[i, j] = new ButtonField();
                    board[i, j].Size = new System.Drawing.Size(SIZE, SIZE);
                    board[i, j].Location = new System.Drawing.Point(i * SIZE, j * SIZE);
                    this.Controls.Add(board[i, j]);
                }
            }

            int bombToGiveLeft = bombCount;
            generator = new Random();
            for (int i=0;i<bombCount;i++)
            {
                int x = generator.Next(width);
                int y = generator.Next(height);
                if (board[x, y].IsBomb == false)
                {
                    board[x, y].IsBomb = true;

                    for (int m = x - 1 ;  m< x + 1; m++)
                    {
                        for(int n = y-1; n < y+1; n++ )
                        {
                            if(m>=0 && m<width && n>=0 &&  n<height)
                            board[m, n].NearBombs++; 
                        }

                    }



                }
                else
                {
                    i--;
                }

            }
            
            

        }
    }
}