﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TowersWindows
{
    class AnimateView
    {
        public static Panel view;
        public void moveUp(PictureBox Disk, int newY)
        {
            // Start moving.
            while(Disk.Location.Y > newY)
            {
                Disk.Location = new System.Drawing.Point(Disk.Location.X, Disk.Location.Y - 10);
                view.Refresh();
                Thread.Sleep(10);
            }
        }
        public void moveDown(PictureBox Disk, int newY)
        {
            // Start moving.
            while (Disk.Location.Y < newY)
            {
                Disk.Location = new System.Drawing.Point(Disk.Location.X, Disk.Location.Y + 10);
                view.Refresh();
                Thread.Sleep(10);
            }
        }
        public void moveRight(PictureBox Disk, int newX)
        {
            // Start moving.
            while (Disk.Location.X < newX)
            {
                Disk.Location = new System.Drawing.Point(Disk.Location.X + 10, Disk.Location.Y);
                view.Refresh();
                Thread.Sleep(10);
            }

        }
        public void moveLeft(PictureBox Disk, int newX)
        {
            // Start moving.
            while (Disk.Location.X > newX)
            {
                Disk.Location = new System.Drawing.Point(Disk.Location.X - 10, Disk.Location.Y);
                view.Refresh();
                Thread.Sleep(10);
            }
        }
    }
}
