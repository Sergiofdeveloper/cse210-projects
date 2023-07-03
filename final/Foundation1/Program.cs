using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        
        List<Video> videos = new List<Video>();

        YouTube1.Name = "test1";
        YouTube1.Creator = "JohnDoe1";
        YouTube1.Length = 30;
        YouTube1.Comments = new List<Comment>
        {
            new Comment { CommenterName = "Mike", CommentText = "Great video. I love watching it" },
            new Comment { CommenterName = "Peter", CommentText = "It´s the third time in a row I watch it" },
            new Comment { CommenterName = "Mathias", CommentText = "what a loser" }
            new Comment { CommenterName = "Rachel", CommentText = "I love what you say in the video" }
        };
        videos.Add(YouTube1);

        
        Video YouTube2 = new Video();
        YouTube2.Name = "test2";
        YouTube2.Creator = "JohnDoe2";
        YouTube2.Length = 60;
        YouTube2.Comments = new List<Comment>
        {
            new Comment { CommenterName = "Robin89", CommentText = "I´d like to try it myself" },
            new Comment { CommenterName = "Milkman", CommentText = "Dont watch it, its a waste of time" }
        };
        videos.Add(YouTube2);

        Video YouTube3 = new Video();
        YouTube3.Name = "test3";
        YouTube3.Creator = "JohnDoe3";
        YouTube3.Length = 90;
        YouTube3.Comments = new List<Comment>
        {
            new Comment { CommenterName = "PacMan", CommentText = "I think I´ve seen this before" },
            new Comment { CommenterName = "User81anton", CommentText = "Please share, @user81anton" },
            new Comment { CommenterName = "angelus23", CommentText = "Shut up and take my money!" },
            
        };
        videos.Add(YouTube3);

        foreach (Video video in videos)
        {
            Console.WriteLine("Name: " + video.Name);
            Console.WriteLine("Creator: " + video.Creator);
            Console.WriteLine("Length: " + video.Length + " seconds");
            Console.WriteLine("Comment Count: " + video.CommentNumber());
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine("- " + comment.CommenterName + ": " + comment.CommentText);
            }

            Console.WriteLine();
        }

        Console.ReadLine();
    }
}