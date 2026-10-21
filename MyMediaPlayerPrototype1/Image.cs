class Image
{
    public required string FilePath { get; set; }
    public required string Name { get; set; }
    public required string Dimensions { get; set; }

    public Image(string filePath, string name, string dimensions)
    {
        FilePath = filePath;
        Name = name;
        Dimensions = dimensions;
    }

    public void Viewimage()
    {

    }
}