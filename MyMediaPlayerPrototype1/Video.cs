using System.Diagnostics.CodeAnalysis;

class Video
{
    public required string FilePath { get; set; }
    public required string Name { get; set; }
    public required TimeOnly Duration { get; set; }
    public required bool Repeat { get; set; }

    public Video(string filePath, string name, TimeOnly duration, bool repeat)
    {
        FilePath = filePath;
        Name = name;
        Duration = duration;
        Repeat = repeat;
    }

    public void PlayVideo()
    {
        
    }
}