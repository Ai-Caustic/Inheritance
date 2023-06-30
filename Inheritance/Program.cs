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
        GetPublicationType(book);
        var mag = new Magazine("The Liar", "Action", "Slimeto", "Bison Press");
        ShowPublicationInfo(mag);
        GetPublicationType(mag);

  

    }

    public static void ShowPublicationInfo(Publication pub)
    {
        string pubDate = pub.GetPublicationDate();
        Console.WriteLine($"{pub.Title}, " + $"{(pubDate == "NYP" ? "Not Yet Published" : "Published on " + pubDate):d} by {pub.Publisher}");

        
    }
    public static string GetPublicationType(Publication pub)
    {
        //PublicationType book = PublicationType.Book;
        //PublicationType misc = PublicationType.Misc;
        //PublicationType article = PublicationType.Article;
        //PublicationType mag = PublicationType.Magazine;

        if (pub.Type == PublicationType.Book)
        {
            Console.WriteLine("Book");
        }
        else if (pub.Type == PublicationType.Magazine)
        {
            Console.WriteLine("Magazine");
        }
        else if (pub.Type == PublicationType.Article)
        {
            Console.WriteLine("Article");
        }
        else if (pub.Type == PublicationType.Misc)
        {
            Console.WriteLine("Misc");
        }
        else
            throw new ArgumentNullException("Publication type not found for" + nameof(pub));

        return pub.Type.ToString();
    }
}