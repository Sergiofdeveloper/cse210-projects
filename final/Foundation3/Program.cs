using System;

class Program
{
    static void Main()
    {
        
        Address address1 = new Address("Avenida el Cid 24", "Zaragoza", "Aragon");
        Address address2 = new Address("Calle Maestro Estremenia 12 1º", "Alpicat", "Lleida");
    
        Event event1 = new Event("Event 1", "Description 1", DateTime.Now.Date, new TimeSpan(10, 0, 0), address1);
        LectureEvent lectureEvent = new LectureEvent("Lecture Event", "Lecture Description", DateTime.Now.Date.AddDays(1), new TimeSpan(14, 0, 0), address1, "Pedro Jimenez", 100);
        ReceptionEvent receptionEvent = new ReceptionEvent("Reception Event", "Reception Description", DateTime.Now.Date.AddDays(2), new TimeSpan(18, 0, 0), address, "pedro_jimemez24@gmail.com");
        OutdoorGatheringEvent outdoorEvent = new OutdoorGatheringEvent("Outdoor Event", "Outdoor Description", DateTime.Now.Date.AddDays(3), new TimeSpan(16, 0, 0), address2, "Sunny");

        Console.WriteLine("Event 1 info:");
        Console.WriteLine(event1.GetCommonDetails());
        Console.WriteLine(event1.GetCompleteDetails());
        Console.WriteLine(event1.GetShortDescription());

        Console.WriteLine("Lecture Event info:");
        Console.WriteLine(lectureEvent.GetCommonDetails());
        Console.WriteLine(lectureEvent.GetCompleteDetails());
        Console.WriteLine(lectureEvent.GetShortDescription());

        Console.WriteLine("Reception Event info:");
        Console.WriteLine(receptionEvent.GetCommonDetails());
        Console.WriteLine(receptionEvent.GetCompleteDetails());
        Console.WriteLine(receptionEvent.GetShortDescription());

        Console.WriteLine("Outdoor Event info:");
        Console.WriteLine(outdoorEvent.GetCommonDetails());
        Console.WriteLine(outdoorEvent.GetCompleteDetails());
        Console.WriteLine(outdoorEvent.GetShortDescription());
    }
}
