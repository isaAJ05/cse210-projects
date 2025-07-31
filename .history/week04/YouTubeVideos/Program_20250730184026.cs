using System;

class Program
{
    static void Main(string[] args)
    {
    List<Video> _videos = new List<Video>();
    Video video1 = new Video("How to code in Python", "Paula Nuñez", 1800);
    video1.AddComment("Juan Carlos", "Excellent video Pau!");
    video1.AddComment("Kottay", "So Cool");
    video1.AddComment("Luis", "Great!");
        video1.AddComment("Charlie", "I learned a lot");
    Video video2 = new Video("How to code in Java", "Natalia Carpintero", 1000);
    video1.AddComment("Juan Carlos", "Excellent video Pau!");
        video1.AddComment("Kottay", "So Cool");
        video1.AddComment("Luis", "Great!");
        video1.AddComment("Charlie", "I learned a lot");
        Video video3 = new Video("How to code in C#", "Luis Robles", 1200);
    video1.AddComment("Juan Carlos", "Excellent video Pau!");
        video1.AddComment("Kottay", "So Cool");
        video1.AddComment("Luis", "Great!");
        video1.AddComment("Charlie", "I learned a lot");
        Video video4 = new Video("How to code in JavaScript", "Sebastian Brito", 1100);
        video1.AddComment("Juan Carlos", "Excellent video Pau!");
        video1.AddComment("Kottay", "So Cool");
        video1.AddComment("Luis", "Great!");
        video1.AddComment("Charlie", "I learned a lot");

    }
}