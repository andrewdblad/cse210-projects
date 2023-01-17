
class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2018;
        job1._endYear = 2020;

        Job job2 = new Job();
        job2._jobTitle = "Floor Mopper";
        job2._company = "Apple";
        job2._startYear = 2000;
        job2._endYear = 2003;

        job1.Display();
        job2.Display();

        Resume myResume = new Resume();
        myResume._name = "Andrew Blad";

        myResume._jobList.Add(job1);
        myResume._jobList.Add(job2);

        myResume.Display();

    }
}