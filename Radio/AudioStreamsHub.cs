using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MusicOnStream
{
    [Serializable]
    class AudioStreamsHub
    {
        public readonly IList<AudioStream> streams = new List<AudioStream>();

        public AudioStreamsHub()
        {
        }

        public void InitialDefaultAudioStreams()
        {
            streams.Add(new AudioStream("StreamingSoundtracks.com - Scores of Music from Movies, Game", "http://91.121.140.11:8000"));
            streams.Add(new AudioStream("TechnoBase.FM - 24h Techno, Dance, HandsUp & More", "http://37.58.52.44:80"));
            streams.Add(new AudioStream("#MUSIK.DRUMSTEP - WWW.RAUTEMUSIK.FM - 24H NON STOP DRUM AND BASS DUBSTEP AND MORE DNB!", "http://95.141.24.130:80"));
            streams.Add(new AudioStream("My radio - Electro-House", "http://music.myradio.com.ua:8000/Electro-House128.mp3"));
            streams.Add(new AudioStream("BlackBeats.FM - finest in blackbeats - powered by surfmusik.de", "http://91.121.139.196:80"));
            streams.Add(new AudioStream("PulsRadio - www.pulsradio.com - Dance Trance Techno House HandsUp - From France", "http://193.200.42.208:80"));
            streams.Add(new AudioStream("Kazantip radio", "http://music.myradio.com.ua:8000/Kazantip128.mp3"));
            streams.Add(new AudioStream("Ibiza Global Radio", "http://198.50.197.162:8024"));
            streams.Add(new AudioStream("TOP 100 Dubstep by DUBLVOERS.FM - Just the right choice!", "http://85.131.130.211:80/stream/1/"));
            streams.Add(new AudioStream("CINEMIX", "http://192.184.9.79:8006"));
            streams.Add(new AudioStream("StreamingSoundtracks.com - Scores of Music from Movies, Game, TV", "http://91.121.140.11:8000"));
            streams.Add(new AudioStream("Adagio.FM - Timeless Classical Music from Medieval to Modern", "http://91.121.140.11:9000"));
            streams.Add(new AudioStream("Mostly Classical - SKY.FM", "http://stream-204.shoutcast.com:80/classical_skyfm_mp3_96kbps"));
            streams.Add(new AudioStream("Kino", "http://music.myradio.com.ua:8000/kino128.mp3"));
            //musicList.Items.Add("http://audio.rambler.ru/action/play.m3u?id=321&uid=PYb8BYJ/OFFGpwAAAdx4KgB");
            //musicList.Items.Add("http://music.myradio.com.ua:8000/world-hit128.mp3");
            //musicList.Items.Add("http://music.myradio.com.ua:8000/techno128.mp3");
            //musicList.Items.Add("http://music.myradio.com.ua:8000/dubstep128.mp3");
            //musicList.Items.Add("http://music.myradio.com.ua:8000/Electro-House128.mp3");
            //musicList.Items.Add("http://music.myradio.com.ua:8000/soundtrack128.mp3");
            //musicList.Items.Add("http://music.myradio.com.ua:8000/Classica128.mp3");
            //musicList.Items.Add("http://music.myradio.com.ua:8000/Kazantip128.mp3");
            //musicList.Items.Add("http://music.myradio.com.ua:8000/kino128.mp3");
            //musicList.Items.Add("http://music.myradio.com.ua:8000/onlyukraine128.mp3");
            //musicList.Items.Add("http://music.myradio.com.ua:8000/UkrPophit128.mp3");
            //musicList.Items.Add("http://music.myradio.com.ua:8000/RnB128.mp3");

            // we are now change the list, so remember this
            value.IsMusicListChanged = true;
        }

        public bool IsContainStream(string URL)
        {
            foreach (var stream in streams)
            {
                if (URL == stream.URL)
                    return true;
            }

            return false;
        }

        public void Add(AudioStream audioStream)
        {
            streams.Add(audioStream);
        }

        public void Remove(int index_pos)
        {
            streams.RemoveAt(index_pos);
        }
    }
}
