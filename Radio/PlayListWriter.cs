using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace MusicOnStream
{
    class PlayListWriter
    {
        // write only m3u playlist file
        public static void WriteToFile(AudioStreamsHub astreams_data, string file_name)
        {
            IList<AudioStream> input = astreams_data.streams;

            using (StreamWriter writer = new StreamWriter(file_name))
            {
                // first line is #EXTM3U
                writer.WriteLine("#EXTM3U");
                // write audio streams data to file
                foreach (var astream in input)
                {
                    // two lines is a one audio stream
                    writer.WriteLine("#EXTINF:-1," + astream.Name);
                    writer.WriteLine(astream.URL);
                }

                writer.Close();
            }
        }
    }
}
