using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace WindowsFormsApp4
{
    public class VideoFile
    {
        public string FilePath { get; set; }
        public Image Thumbnail { get; set; }
    }

    public static class OpenedVideoStorage
    {
        public static List<VideoFile> Videos = new List<VideoFile>();

        public static void Add(string path, Image thumbnail)
        {
            if (!Videos.Any(v => v.FilePath == path))
            {
                Videos.Add(new VideoFile
                {
                    FilePath = path,
                    Thumbnail = thumbnail
                });
            }
        }
    }
}
