using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WMPLib;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace MusicOnStream
{
    public partial class Main : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        AudioStreamsHub streams = new AudioStreamsHub();
        RemovedAudioStreamHub removed_streams = new RemovedAudioStreamHub();

        public enum WMPState
        {
            Playing,
            Pause
        }
        
        WMPState player_state = WMPState.Pause;

        // the current stateof media player
        WMPState PlayerState
        {
            get
            {
                return player_state;
            }
            set
            {
                if (player_state != value)
                {
                    if (value == WMPState.Playing)
                    {
                        // start play first audio, if not selected
                        if (musicList.SelectedItem == null)
                        {
                            musicList.SelectedIndex = 0;
                        }

                        // play music
                        player.controls.play();
                        // set pause image
                        buttonPlayPause.BackgroundImage = Properties.Resources.PauseButton;
                    }
                    else if (value == WMPState.Pause)
                    {
                        // pause music
                        player.controls.pause();
                        // set play image
                        buttonPlayPause.BackgroundImage = Properties.Resources.PlayButton;
                    }

                    // save state
                    player_state = value;
                }
            }
        }

        public Main()
        {
            InitializeComponent();
            LoadMusicList();
            InitialMusicList();
            LoadSettings();
            DebugSettings();
        }

        private void DebugSettings()
        {
#if DEBUG
#else
#endif
        }

        private void LoadMusicList()
        {
            try
            {
                using (FileStream file = new FileStream(value.NameMusicStreamsFile, FileMode.OpenOrCreate))
                {
                    // load only if file not empty
                    if (file.Length > 0)
                    {
                        BinaryFormatter de_serializer = new BinaryFormatter();
                        streams = (AudioStreamsHub)de_serializer.Deserialize(file);
                    }
                    else
                    {
                        // else initialize default streams
                        streams.InitialDefaultAudioStreams();
                    }

                    file.Close();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void InitialMusicList()
        {
            // remove items
            musicList.Items.Clear();

            // and add all items again
            for (int n_stream = 0; n_stream < streams.streams.Count; n_stream++)
            {
                musicList.Items.Add(streams.streams[n_stream].Name);
            }
        }

        private void LoadSettings()
        {
            try
            {
                using (FileStream file = new FileStream(value.NameSettingsFile, FileMode.OpenOrCreate))
                {
                    // load only if file not empty
                    if (file.Length > 0)
                    {
                        BinaryReader reader = new BinaryReader(file);
                        // load user settings
                        musicList.SelectedIndex = reader.ReadInt32();
                        trackVolume.Value = reader.ReadInt32();
                        Left = reader.ReadInt32();
                        Top = reader.ReadInt32();

                        // update playewr and stop the music
                        Update();
                        PlayerState = WMPState.Pause;
                    }
                    
                    file.Close();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public void Destructor(object sender, FormClosingEventArgs e)
        {
            SaveMusicList();
            SaveSettings();
        }

        private void SaveMusicList()
        {
            if (value.IsMusicListChanged)
            {
                using (FileStream file = new FileStream(value.NameMusicStreamsFile, FileMode.Create))
                {
                    BinaryFormatter serializer = new BinaryFormatter();
                    serializer.Serialize(file, streams);
                    file.Close();
                }
            }
        }

        private void SaveSettings()
        {
            using (FileStream file = new FileStream(value.NameSettingsFile, FileMode.Create))
            {
                BinaryWriter writer = new BinaryWriter(file);

                writer.Write(musicList.SelectedIndex); // current music stream - int
                writer.Write(trackVolume.Value); // volume - int
                writer.Write(Left); // window x position - int
                writer.Write(Top); // window y position - int

                file.Close();
            }
        }

        // The base update operation
        private new void Update()
        {
            try
            {
                // additional check if item not select
                if (musicList.SelectedItem != null)
                {
                    // read audio stream
                    int stream_index = musicList.SelectedIndex;
                    string stream_name = streams.streams[stream_index].Name;
                    string stream_url = streams.streams[stream_index].URL;

                    if (stream_url != player.URL)
                    {
                        player.URL = stream_url;
                        musicInfo.Text = stream_name;
                    }

                    PlayerState = WMPState.Playing;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Update();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PlayerState == WMPState.Playing)
            {
                PlayerState = WMPState.Pause;
            }
            else if (PlayerState == WMPState.Pause)
            {
                PlayerState = WMPState.Playing;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index_pos = musicList.SelectedIndex;

            if (index_pos > 0)
            {
                musicList.SelectedIndex--;
            }
            else
            {
                musicList.SelectedIndex = musicList.Items.Count - 1;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index_pos = musicList.SelectedIndex;

            if (index_pos < musicList.Items.Count - 1)
            {
                musicList.SelectedIndex++;
            }
            else
            {
                musicList.SelectedIndex = 0;
            }
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            player.settings.volume = trackVolume.Value;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string file_name = FileDialogs.OpenFile("All files (*.*)|*.*");
                PlayListReader.ReadFile(streams, file_name);
                InitialMusicList();

                // we are now change the list, so remember this
                value.IsMusicListChanged = true;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int stream_index = musicList.SelectedIndex;

            // save this stream to trash bin
            removed_streams.Push(streams.streams[stream_index]);

            // remove from hub
            streams.Remove(stream_index);

            // select previous index, for avoid a problem
            musicList.SelectedIndex--;

            // and remove from mus list
            musicList.Items.RemoveAt(stream_index);

            // remember this, we change the list
            value.IsMusicListChanged = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // get removed stream and add to streams and mus list
            AudioStream removed_str = removed_streams.Take();

            if (removed_str != null)
            {
                streams.Add(removed_str);
                musicList.Items.Add(removed_str.Name);

                // set the removed stream index in mus list
                musicList.SelectedIndex = musicList.Items.Count - 1;
            }
        }
    }
}
