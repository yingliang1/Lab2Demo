using System;

namespace Exercise5
{
    class Box {
        private double length;
        private double breadth;
        private double height;
        public double getVolume()
        {
            return length * breadth * height;
        }
        public void setLength(double len)
        {
            length = len;
        }

        public void setBreadth(double bre)
        {
            breadth = bre;
        }

        public void setHeight(double hei)
        {
            height = hei;
        }

        // didn't get this part, this method is from online resources.
        // Overload + operator to add two Box objects.
        public static Box operator +(Box b, Box c)
        {
            Box box = new Box();
            box.length = b.length + c.length;
            box.breadth = b.breadth + c.breadth;
            box.height = b.height + c.height;
            return box;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Box box1 = new Box();
            box1.setLength(10);
            box1.setHeight(20);
            box1.setBreadth(30);

            Box box2 = new Box();
            box2.setLength(3);
            box2.setHeight(4);
            box2.setBreadth(5);

            Box box3 = new Box();
            box3 = box1 + box2;

            Console.WriteLine(box1.getVolume());
            Console.WriteLine(box2.getVolume());
            Console.WriteLine(box3.getVolume());


        }
    }
}
