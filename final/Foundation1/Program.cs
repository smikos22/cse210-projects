using System;

class Program
{
    static void Main(string[] args)
    {
        Comment v1 = new Comment();
        v1._name = "Sarah Mikos";
        v1._comment="Loved the video";

        Comment v1c2 = new Comment();
        v1c2._name = "Gage Mikos";
        v1c2._comment ="Very educational";

        Comment v1c3 = new Comment();
        v1c3._name = "Shasta Vega";
        v1c3._comment = "Amazing";

        Video video1 = new Video();
        video1._title = "How to learn to program with c#";
        video1._author = "Shane Master";
        video1._length = 1000;
        video1._comments.Add(v1);
        video1._comments.Add(v1c2);
        video1._comments.Add(v1c3);
        video1.DisplayVideo();
        Console.WriteLine();

        Comment v2 = new Comment();
        v2._name = "Chris Lane";
        v2._comment="Best video I've watched";

        Comment v2c2 = new Comment();
        v2c2._name = "Zach Murphy";
        v2c2._comment ="Please make more videos";

        Comment v2c3 = new Comment();
        v2c3._name = "Herman Body";
        v2c3._comment = "Thank you for your help";

        Video video2 = new Video();
        video2._title = "Python for Beginners";
        video2._author = "Monty Python";
        video2._length = 5000;
        video2._comments.Add(v2);
        video2._comments.Add(v2c2);
        video2._comments.Add(v2c3);
        video2.DisplayVideo();
        Console.WriteLine();

        Comment v3 = new Comment();
        v3._name = "Sam Chewy";
        v3._comment="Bravo";

        Comment v3c2 = new Comment();
        v3c2._name = "Brock Lee";
        v3c2._comment ="Keep making more!";

        Comment v3c3 = new Comment();
        v1c3._name = "Mckaela Night";
        v1c3._comment = "This is wonderful";

        Video video3 = new Video();
        video3._title = "HTML for beginners";
        video3._author = "Mandy Green";
        video3._length = 2000;
        video3._comments.Add(v1);
        video3._comments.Add(v1c2);
        video3._comments.Add(v1c3);
        video3.DisplayVideo();
        Console.WriteLine();


    }
}