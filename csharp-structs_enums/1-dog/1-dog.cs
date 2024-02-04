using System;

// Define the Rating enum
public enum Rating
{
    Good,
    Great,
    Excellent
}

// Define the Dog struct with the specified members
public struct Dog
{
    public string name;
    public float age;
    public string owner;
    public Rating rating;
}
