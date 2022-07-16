namespace CsharpTypes.Lessons;

internal static class L_04_ReferenceType
{
    private class Bullet
    {
        public int Velocity;

        public Bullet(int velocity, Point position)
        {
            Velocity = velocity;
            Position = position;
        }

        public Point Position { get; set; }
    }

    private class Point
    {
        public int x;
        public int y;
        public int z;

        public Point(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }

    public static void Run()
    {
        var velocitoy = 10;
        Bullet bullet = new Bullet(velocitoy, new Point(1, 2, 10));

        //----------
        // linked list 
        var first = new Node();
        var second = new Node() { Weight = 10 };
        first.Next = second;
        first.Next.Next = new Node();

        //------------
        StructNode structNode = new StructNode();
    }


    internal class Node
    {
        internal Node Next { get; set; }
        internal int Weight { get; set; }
    }

    // this is recursive 
    struct StructNode 
    {
        internal Node Next { get; set; }
        internal int Weight { get; set; }
    }
}