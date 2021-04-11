using System;

namespace IntergenicResearchLibraryTest
{
    class UniversityLibrary
    {
        static void Main(string[] args)
        {
            Date issue = new Date(17, 04, 2019);
            Date dateReturn = new Date(17, 08, 2019);
            Library getStudent = new Library("James Paul", 2019, "Peace By piece", 15576, issue, dateReturn );

            Date issue1 = new Date(30, 09, 2020);
            Date dateReturn1 = new Date(09, 11, 2020);
            Library getStudent1 = new Library("Williams Peter", 2020, "Women of Owu", 2376, issue1, dateReturn1 );

            Date issue2 = new Date(24, 11, 2020);
            Date dateReturn2 = new Date(24, 12, 2020);
            Library getStudent2 = new Library("Magret Zakariya", 2020, "Pride of Women", 78076, issue2, dateReturn2 );
            

            GenericDefaulterList<Library> student = new GenericDefaulterList<Library>();

            student.Enqueue(getStudent);
            student.Enqueue(getStudent1);
            student.Enqueue(getStudent2);

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(student.Dequeue());
            }


            
        }
    }
}
