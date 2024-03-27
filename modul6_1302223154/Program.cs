// See https://aka.ms/new-console-template for more information
class main
{
    static void Main(string[] args)
    {
        SayaTubeUser user = new SayaTubeUser("Darryl Rambi");

        SayaTubeVideo video = new SayaTubeVideo("Sing");
        video.IncreasePlayCount(2);
        //video.PrintVideoDetails();
        SayaTubeVideo video1 = new SayaTubeVideo("Sing 2");
        video1.IncreasePlayCount(2);
        //video1.PrintVideoDetails();
        SayaTubeVideo video2 = new SayaTubeVideo("Catch Me If You Can");
        video2.IncreasePlayCount(2);
        //video2.PrintVideoDetails();
        SayaTubeVideo video3 = new SayaTubeVideo("Now You See Me");
        video3.IncreasePlayCount(2);
        //video3.PrintVideoDetails();
        SayaTubeVideo video4 = new SayaTubeVideo("Now You See Me 2");
        video4.IncreasePlayCount(2);
        //video4.PrintVideoDetails();
        SayaTubeVideo video5 = new SayaTubeVideo("Infinity Wars");
        video5.IncreasePlayCount(2);
        //video5.PrintVideoDetails();
        SayaTubeVideo video6 = new SayaTubeVideo("Mr & Mrs Smith");
        video6.IncreasePlayCount(2);
        //video6.PrintVideoDetails();
        SayaTubeVideo video7 = new SayaTubeVideo("Grown Ups");
        video7.IncreasePlayCount(2);
        //video7.PrintVideoDetails();
        SayaTubeVideo video8 = new SayaTubeVideo("Grown Ups 2");
        video8.IncreasePlayCount(2);
        //video8.PrintVideoDetails();
        SayaTubeVideo video9 = new SayaTubeVideo("IT");
        video9.IncreasePlayCount(2);
        //video9.PrintVideoDetails();

        user.AddVideo(video);
        user.AddVideo(video1);
        user.AddVideo(video2);
        user.AddVideo(video3);
        user.AddVideo(video4);
        user.AddVideo(video5);
        user.AddVideo(video6);
        user.AddVideo(video7);
        user.AddVideo(video8);
        user.AddVideo(video9);

        user.PrintAllVideoPlayCount();
    }
}