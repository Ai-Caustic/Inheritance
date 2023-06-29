using System;

public class Example
{
    public static void Main()
    {
        // var Bentley = new Automobile("Slime", "Intercontinental", 2022);
        // Console.WriteLine(Bentley);

        var book = new Book("The Tempest", "0912557348", "Shakespeare, William", "Public Domain Press");
        ShowPublicationInfo(book);
        book.Publish(new DateTime(2016, 8, 18));
        ShowPublicationInfo(book);

  

    }

    public static void ShowPublicationInfo(Publication pub)
    {
        string pubDate = pub.GetPublicationDate();
        Console.WriteLine($"{pub.Title}, " + $"{(pubDate == "NYP" ? "Not Yet Published" : "Published on " + pubDate):d} by {pub.Publisher}");
    }
}