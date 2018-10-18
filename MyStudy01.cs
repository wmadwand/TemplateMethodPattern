using System;
namespace TemplateMethod
{
    public abstract class Education
    {
        public void Learn()
        {
            Enter();
            Study();
            PassExams();
            GetDocument();
        }

        protected abstract void Enter();
        protected abstract void Study();

        protected virtual void PassExams()
        {
            Console.WriteLine("PassExams");
        }

        protected abstract void GetDocument();
    }

    public class School : Education
    {
        protected override void Enter()
        {
            Console.WriteLine("School Enter with no exams");
        }

        protected override void Study()
        {
            Console.WriteLine("School Study: attend lessons");
        }

        protected override void GetDocument()
        {
            Console.WriteLine("School GetDocument: basic education doc");
        }
    }

    public class University : Education
    {
        public new void Learn()
        {
            base.Learn();
            //Console.WriteLine("University: We don't need no education! F*ck them all!");
        }

        protected override void Enter()
        {
            Console.WriteLine("University Enter with initial exams");
        }

        protected override void Study()
        {
            Console.WriteLine("University Study: attend lectures");
            Console.WriteLine("University Study: do practise");
        }

        protected override void PassExams()
        {
            base.PassExams();
            Console.WriteLine("University PassExams: use lot of hacks along");
        }

        protected override void GetDocument()
        {
            Console.WriteLine("University Study: get your diploma and get out of here");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            School school = new School();
            University university = new University();

            school.Learn();
            university.Learn();

            Console.WriteLine();
        }
    }
}
