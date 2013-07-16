using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MusicOnStream
{
    class RemovedAudioStreamHub
    {
        Stack<AudioStream> streams = new Stack<AudioStream>();

        public void Push(AudioStream audioStream)
        {
            streams.Push(audioStream);
        }

        /// <summary>
        /// Take up item of stack
        /// </summary>
        /// <returns>If stack is void - returns null</returns>
        public AudioStream Take()
        {
            if (streams.Count > 0)
                return streams.Pop();
            else
                return null;
        }
    }
}
