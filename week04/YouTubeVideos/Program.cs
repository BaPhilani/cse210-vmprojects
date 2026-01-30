using System;

class Program

{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("Learning C# Basics", "CodeAcademy", 600);
        video1.AddComment(new Comment("Alice", "Very helpful explanation!"));
        video1.AddComment(new Comment("Brian", "This cleared my confusion."));
        video1.AddComment(new Comment("Chipo", "Great content for beginners."));
        videos.Add(video1);

        // Video 2
        Video video2 = new Video("Understanding Abstraction", "TechWorld", 480);
        video2.AddComment(new Comment("David", "Abstraction finally makes sense."));
        video2.AddComment(new Comment("Emily", "Clear and simple examples."));
        video2.AddComment(new Comment("Farai", "Excellent teaching style."));
        videos.Add(video2);

        // Video 3
        Video video3 = new Video("Object-Oriented Programming Explained", "DevSimplified", 720);
        video3.AddComment(new Comment("Grace", "Best OOP video I've watched."));
        video3.AddComment(new Comment("Henry", "Very informative."));
        video3.AddComment(new Comment("Isaac", "Loved the real-world examples."));
        videos.Add(video3);

        // Display all videos and comments
        foreach (Video video in videos)
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetCommenterName()}: {comment.GetText()}");
            }
        }
    }
}