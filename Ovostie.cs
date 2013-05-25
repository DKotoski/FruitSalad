using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VizuelnoSeminarska
{
    class Ovostie
    {
        public float X { get; set; }
        public float Y { get; set; }
        
        public float Velocity { get; set; }
        public float Angle { get; set; }
        public Rectangle Bounds;
        private float velocityX;
        private float velocityY;
        public Image imgOvoska;

        public Ovostie ( float x, float y , float velocity , float angle, Image slika)
    {
       X = x;
       Y = y;
       Velocity = velocity ;
       Angle = angle ;
       velocityX = ( float ) Math . Cos( Angle ) * Velocity ;
       velocityY = ( float ) Math . Sin( Angle ) * Velocity ;
       imgOvoska = slika; 
    }
        public void Move()
        {
            float nextX = X + velocityX;
            float nextY = Y + velocityY;
            if (nextX <= Bounds.Left || (nextX + 50 >= Bounds.Right))
            {
                velocityX = -velocityX;
            }
            if (nextY <= Bounds.Top || (nextY + 50 >= Bounds.Bottom))
            {
                velocityY = -velocityY;
            }
            X += velocityX;
            Y += velocityY;
        }

        public void Draw(Graphics g)
        {

            g.DrawImage(imgOvoska, X, Y, 50f, 50f);
           
        }

    }
}
