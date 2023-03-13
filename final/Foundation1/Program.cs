using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videoList = new List<Video>();
        
        //adding videos and comments
        Video v1 = new Video("Ice Bath Challenge!", "Joe", 10);
        Comment c1 = new Comment("Really cool video man! I like it a lot!", "Timmy");
        Comment c2 = new Comment("Super cool video!", "Andrew");
        Comment c3 = new Comment("Epic vid brooooooo!", "Johnny");
        //assign comments to video
        v1.AddComment(c1); v1.AddComment(c2); v1.AddComment(c3);
        //add video to videoList
        videoList.Add(v1);
        //repeating above steps for 2 more videos
        Video v2 = new Video("Playing games with friends", "MannyPlaysGames", 20);
        Comment c4 = new Comment("Really cool game! I want to play!", "Paul");
        Comment c5 = new Comment ("You are so funny hahahahahahhaha", "LilTimmy");
        Comment c6 = new Comment ("I wish i had freinds )=", "Luke");
        v2.AddComment(c4); v2.AddComment(c5); v2.AddComment(c6);
        videoList.Add(v2);

        Video v3 = new Video("Eating as much beans as i can in one sitting (Gone Wrong!!!!)", "BeansBoi82", 8);
        Comment c7 = new Comment ("Dudeeeee that was a lot of beans!", "User12313131");
        Comment c8 = new Comment ("Wow man! Impressive bean eating", "HotDogDude32");
        Comment c9 = new Comment ("I wish i had that many beans", "Tom");
        v3.AddComment(c7); v3.AddComment(c8); v3.AddComment(c9);
        videoList.Add(v3);

        foreach(Video video in videoList)
        {
            video.Display();
            Console.WriteLine();
        }
    }
}