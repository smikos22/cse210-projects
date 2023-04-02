using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("3314 N Brindley Ave.", "Litchfield Park", "Arizona", "USA");
        Event lecture = new Lecture("Title of Lecture", "Destription of Lecture", "10/14", "1 PM", address, 100, "Sarah Lewis");
        Event receptions = new Receptions("Title of Lecture", "Destription of Lecture", "10/14", "1 PM", address,"Lewis@lesd.k12.az.us.com", 100 );
        OutdoorGatherings outdoorGatherings = new OutdoorGatherings("Title of Lecture", "Destription of Lecture", "10/14", "1 PM", address,"Sunny");

        string lectureStandardDetails = lecture.GetStandardDetails();
        string lectureFullDetails = lecture.GetFullDetails();
        string lectureShortDescription = lecture.GetShortDescription();
        Console.WriteLine(lectureStandardDetails);
        Console.WriteLine(lectureFullDetails);
        Console.WriteLine(lectureShortDescription);

        string receptionsStandardDetails = receptions.GetStandardDetails();
        string receptionsFullDetails = receptions.GetFullDetails();
        string receptionsShortDescription = receptions.GetShortDescription();
        Console.WriteLine(receptionsStandardDetails);
        Console.WriteLine(receptionsFullDetails);
        Console.WriteLine(receptionsShortDescription);

        string outdoorGatheringsStandardDetails = outdoorGatherings.GetStandardDetails();
        string outdoorGatheringsFullDetails = outdoorGatherings.GetFullDetails();
        string outdoorGatheringsShortDescription = outdoorGatherings.GetShortDescription();
        Console.WriteLine(outdoorGatheringsStandardDetails);
        Console.WriteLine(outdoorGatheringsFullDetails);
        Console.WriteLine(outdoorGatheringsShortDescription);

    }
}