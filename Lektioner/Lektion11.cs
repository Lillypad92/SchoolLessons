using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Lesson11
{
    internal class SchoolLesson11 {}
    public class Lesson11
    {
        public void RunLesson11()
        {
            Line line = new Line();
            Circle circle = new Circle();
            Kvadrat kvadrat = new Kvadrat();

            line.Draw();
            circle.Draw();
            kvadrat.Draw();
        }
    }

    public class DrawObject 
    { 
        public virtual void Draw() 
        {
            Console.WriteLine("Jag är bas ritobjekt");
        }
    }
    public class Line :DrawObject 
    {
        public void Draw() 
        {
            Console.WriteLine("Lines -----------");
            base.Draw();
        }
    }
    public class Circle :DrawObject 
    { 
        public void Draw() 
        {
            Console.WriteLine("Circles oooooooo ");
            base.Draw();
        }
    }
    public class Kvadrat :DrawObject 
    {
        public void Draw() 
        {
            Console.WriteLine("Square [] [] [] []");
            base.Draw();
        }
    }
}
