using System;

class Program
{
    static void Main(string[] args)
    {
        string standardDetails = "";
        string fullDetails = "";
        string shortDescription = "";
        Address address1 = new Address("398 pioneer rd", "Boise", "ID", "US");
        Address address2 = new Address("10010 west meadowlark st.", "Rexburg", "ID", "US");
        Address address3 = new Address("123 Main st.", "Rigby", "ID", "US");

        LectureEvent lectureEvent = new LectureEvent("The Beginning", "President Nelson discusses the beginning of the world", "10-10-2023", "10:00pm", address1, "President Nelson", 10000);
        fullDetails = lectureEvent.GetFullDetails();
        standardDetails = lectureEvent.GetStandardDetails();
        shortDescription = lectureEvent.GetShortDescription();
        Console.WriteLine();
        Console.WriteLine("---------- Lecture Event ----------");
        Console.WriteLine("- STANDARD DETAILS");
        Console.WriteLine(standardDetails);
        Console.WriteLine("- FULL DETAILS");
        Console.WriteLine(fullDetails);
        Console.WriteLine("- SHORT DESCRIPTION");
        Console.WriteLine(shortDescription);
        Console.WriteLine();

        ReceptionEvent receptionEvent = new ReceptionEvent("Andrew X Payge Wedding", "Andrew and Payge's wedding reception", "10-15-2022", "11am", address2, "andrewxpaygewedding@gmail.com");
        fullDetails = receptionEvent.GetFullDetails();
        standardDetails = receptionEvent.GetStandardDetails();
        shortDescription = receptionEvent.GetShortDescription();
        Console.WriteLine("---------- Reception Event ----------");
        Console.WriteLine("- STANDARD DETAILS");
        Console.WriteLine(standardDetails);
        Console.WriteLine("- FULL DETAILS");
        Console.WriteLine(fullDetails);
        Console.WriteLine("- SHORT DESCRIPTION");
        Console.WriteLine(shortDescription);
        Console.WriteLine();

        OutdoorEvent outdoorEvent = new OutdoorEvent("Park Games", "Join us for some fun park games!", "01-01-2024", "3pm", address3, "Sunny");
        fullDetails = outdoorEvent.GetFullDetails();
        standardDetails = outdoorEvent.GetStandardDetails();
        shortDescription = outdoorEvent.GetShortDescription();
        Console.WriteLine("---------- Outdoor Event ----------");
        Console.WriteLine("- STANDARD DETAILS");
        Console.WriteLine(standardDetails);
        Console.WriteLine("- FULL DETAILS");
        Console.WriteLine(fullDetails);
        Console.WriteLine("- SHORT DESCRIPTION");
        Console.WriteLine(shortDescription);
        Console.WriteLine();

    }
}