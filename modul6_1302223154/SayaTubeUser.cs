using System;

public class SayaTubeUser
{
    private int id;
    private string Username;
    private List<SayaTubeVideo> uploadedVideos;
    private static Random random = new Random();
    int total = 0;

    public SayaTubeUser(string input)
    {
        if (string.IsNullOrEmpty(input) || input.Length > 100)
        {
            Console.WriteLine("Input not valid");
        } else
        {
            id = random.Next(10000, 99999);
            this.Username = input;
            this.uploadedVideos = new List<SayaTubeVideo>();
        }
    }

    public int GetTotalVideoPlayCount()
    {
        for (int i = 0; i < uploadedVideos.Count; i++) {

        total = total + uploadedVideos[i].getplaycount();
        }

        return total;
    }

    public void AddVideo(SayaTubeVideo video)
    { 
        uploadedVideos.Add(video);
    }

    public void PrintAllVideoPlayCount()
    {
        Console.WriteLine("User: " + Username);
        
        for (int i = 0;i < uploadedVideos.Count;i++)
        {
            Console.WriteLine("Video " + (i + 1) + " judul: " + uploadedVideos[i].gettitle());
        }

        Console.WriteLine("Total Video PlayCount: " + GetTotalVideoPlayCount());
    }
}
