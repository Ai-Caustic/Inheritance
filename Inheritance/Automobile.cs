﻿public class Automobile
{
    public Automobile(string make, string model, int year)
    {
        if (make == null)
        {
            throw new ArgumentNullException(nameof(make), "The make cannot be null");
        }
        else if (string.IsNullOrEmpty(make))
        {
            throw new ArgumentException("Make cannot be an empty string or have space characters only");
        }
        Make = make;

        if (model == null)
        {
            throw new ArgumentNullException(nameof(model), "The model cannot be null");
        }
        else if (string.IsNullOrEmpty(model))
        {
            throw new ArgumentException("Model cannot be an empty string or have space characters only");
        }
        Model = model;

        if (year < 1857 || year > DateTime.Now.Year + 2)
        {
            throw new ArgumentException("The year is out of range");
        }
        Year = year;

    }

    public string Make { get; }

    public string Model { get; }

    public int Year { get; }

    public override string ToString() => $"{Year} {Make} {Model}";
}