using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MusicOnStream
{
    [Serializable]
    class AudioStream
    {
        public readonly string Name;
        public readonly string URL;
        public readonly int Index;

        public AudioStream(string Name, string URL)
        {
            this.Name = Name;
            this.URL = URL;
        }
    }
}
