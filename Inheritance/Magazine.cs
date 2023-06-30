using System;

public sealed class Magazine : Publication
{
    public Magazine(string title, string author, string publisher) : this(title, string.Empty, author, publisher)
    { }

    public Magazine(string title, string genre, string author, string publisher) : base(title, publisher, PublicationType.Magazine)
    {
        Author = author;
        Genre = genre;
    }

    public string Genre { get; }

    public string Author { get; }



}
