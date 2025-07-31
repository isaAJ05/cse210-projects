using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videos = new List<Video>();
        Video video1 = new Video("How to code in Python", "Paula Nuñez", 1800);
        Comment comment1 = new Comment("Juan Carlos", "Excellent video Pau!");
        video1.AddComment(comment1);
        Comment comment2 = new Comment("Kottay", "So Cool");
        video1.AddComment(comment2);
        Comment comment3 = new Comment("Luis", "Great!");
        video1.AddComment(comment3);

        Video video2 = new Video("How to code in Java", "Natalia Carpintero", 1000);
        Comment comment21 = new Comment("Marquez", "Excellent video Nat!");
        video2.AddComment(comment21);
        Comment comment22 = new Comment("Andres", "So Cool");
        video2.AddComment(comment22);
        Comment comment23 = new Comment("Hitsam", "Great!");
        video2.AddComment(comment23);

        Video video3 = new Video("How to code in C#", "Luis Robles", 1200);
        Comment comment31 = new Comment("Will", "Excellent video Luis!");
        video3.AddComment(comment31);
        Comment comment32 = new Comment("Luz", "So Cool");
        video3.AddComment(comment32);
        Comment comment33 = new Comment("Michell", "Great!");
        video3.AddComment(comment33);

        Video video4 = new Video("How to code in JavaScript", "Sebastian Brito", 1100);
        Comment comment41 = new Comment("Elias", "Excellent video Sebas!");
        video4.AddComment(comment41);
        Comment comment42 = new Comment("Matt", "hey follow this channel");
        video4.AddComment(comment42);
        Comment comment43 = new Comment("James", "Awesome");
        video4.AddComment(comment43);

        _videos.Add(video1);
        _videos.Add(video2);
        _videos.Add(video3);
        _videos.Add(video4);

        foreach (Video v in _videos)
        {
            v.DisplayVideo();
            Console.Write($"{v.NumberOfComments()}");

            Console.WriteLine(v.DisplayComments())
        }

    }
}