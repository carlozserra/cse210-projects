using System;

class Program
{
    static void Main(string[] args)
    {
       
       
        
        Address address1 = new Address("123 Elm St.","Salt Lake City", "Utah", "USA");
        Lecture lecture = new Lecture("Lecture", "programming discussion", "06/08/2024", "10:00 am", "Chad Macbeth", 200, address1);
        Console.WriteLine(lecture.GetStandardDetail());
        Console.WriteLine(lecture.GetFullDetail());
        Console.WriteLine(lecture.SetLecture());
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine("========================");


        Address address2 = new Address("456 Oak St.","Salt Lake City", "Utah", "USA");
        Outdoor outdoor = new Outdoor("Outdoor", "programming workshop", "06/08/2024", "2:00 pm", "contact@event.com",address2);
        Console.WriteLine(outdoor.GetStandardDetail());
        Console.WriteLine(outdoor.GetFullDetail());
        Console.WriteLine(outdoor.SetOutdoor());
        Console.WriteLine(outdoor.GetShortDescription());
        Console.WriteLine("========================");

        Address address3 = new Address("789 Pine St.","Salt Lake City", "Utah", "USA");
        Reception reception = new Reception("Reception", "meet and greet", "06/08/2024", "6:00 pm", "Sunny with a chance of rain",address3);
        Console.WriteLine(reception.GetStandardDetail());
        Console.WriteLine(reception.GetFullDetail());
        Console.WriteLine(reception.SetReception());
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine("========================");


       



        
        

    }
}

        //GetStandardDetail();
        //GetFullDetail();
        //Lecture, Outdor or Reception
        //GetShortDescription