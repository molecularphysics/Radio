using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace MusicOnStream
{
    class PlayListReader
    {
        // read only m3u playlist file
        public static AudioStreamsHub ReadFile(string file_name)
        {
            AudioStreamsHub output = new AudioStreamsHub();

            using (StreamReader reader = new StreamReader(file_name))
            {
                // first line is #EXTM3U
                string play_list_info = reader.ReadLine();
                // parsing file
                while (!reader.EndOfStream)
                {
                    // two lines is a one audio stream
                    string audio_name = reader.ReadLine();
                    string audio_url = reader.ReadLine();

                    // get only stream name
                    audio_name = audio_name.Substring(audio_name.IndexOf(',') + 1);

                    if (audio_name != "" && audio_url != "")
                    {
                        // check for duplication
                        if (!output.IsContainStream(audio_url))
                        {
                            output.Add(new AudioStream(audio_name, audio_url));
                        }
                    }
                }

                // close the file
                reader.Close();
            }

            return output;
        }

        // read only m3u playlist file
        public static void ReadFile(AudioStreamsHub output, string file_name)
        {
            using (StreamReader reader = new StreamReader(file_name))
            {
                // first line is #EXTM3U
                string play_list_info = reader.ReadLine();
                // parsing file
                while (!reader.EndOfStream)
                {
                    // two lines is a one audio stream
                    string audio_name = reader.ReadLine();
                    string audio_url = reader.ReadLine();

                    // get only stream name
                    audio_name = audio_name.Substring(audio_name.IndexOf(',') + 1);

                    if (audio_name != "" && audio_url != "")
                    {
                        // check for duplication
                        if (!output.IsContainStream(audio_url))
                        {
                            output.Add(new AudioStream(audio_name, audio_url));
                        }
                    }
                }

                // close the file
                reader.Close();
            }
        }
    }
}
