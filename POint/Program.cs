using System;



namespace Plan
{
    class Point
    {
        private double x;

        private double y;



        public void setY(double y)
        {
            this.y = y;
        }

        public double getX()

        {
            return x;

        }

        public double getY()
        {

            return y;
        }


        public double Distance(Point p)

        {

            return Math.Sqrt((x - p.x) * (x - p.x) + (y - p.y) * (y - p.y));

        }


        public bool Equals(Point p)

        {

            return (x == p.x && y == p.y);

        }
        public void Translation(double x, double y)
        {
            this.x += x;
            this.y += y;

        }

        public bool linearite(Point p1, Point p2)
        {
            double a = this.x - p1.x;
            double b = this.y - p1.y;
            double c = this.x - p2.x;
            double d = this.y - p2.y;

            return (a * d == b * c);
        }
    }

}


