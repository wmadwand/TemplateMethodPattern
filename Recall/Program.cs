using System;

namespace Recall
{
    public abstract class Education
    {
        public void Learn()
        {
            Enter();
            Study();
            PassExams();
            GetDocuments();
        }

        public abstract void Enter();
        public abstract void Study();

        public virtual void PassExams()
        {
            Console.WriteLine("PassExams");
        }

        public abstract void GetDocuments();
    }

    public class School : Education
    {
        public override void Enter()
        {
            Console.WriteLine("School Enter with no initial exams");
        }

        public override void GetDocuments()
        {
            Console.WriteLine("School get basic diploma");
        }

        public override void Study()
        {
            Console.WriteLine("School attend lessons");
        }
    }

    public class University : Education
    {
        public override void Enter()
        {
            Console.WriteLine("University Enter with the initial exams");
        }

        public override void GetDocuments()
        {
            Console.WriteLine("University get serious diploma");
        }

        public override void Study()
        {
            Console.WriteLine("University attend pairs");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Education school = new School();
            school.Learn();

            Education univ = new University();
            univ.Learn();
        }
    }
}
