// Point.cs
namespace PointNamespace
{
    public struct Point
    {
        public double x;
        public double y;

        public Point(double x, double y)  // Constructor with different name than the struct
        {
            this.x = x;
            this.y = y;
        }

        public double getX() => x;
        public double getY() => y;
        public void setX(double _x) => x = _x;
        public void SetY(double _y) => y = _y;

        public double GetDistanceBetweenXAndY(Point other)
        {
            double dx = other.getX() - this.getX();
            double dy = other.getY() - this.getY();
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }
}
