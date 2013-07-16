namespace MusicOnStream
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonPlayPause = new System.Windows.Forms.Button();
            this.musicList = new System.Windows.Forms.ListBox();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.musicInfo = new System.Windows.Forms.Label();
            this.trackVolume = new System.Windows.Forms.TrackBar();
            this.buttonOpenPL = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonUndo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPlayPause
            // 
            this.buttonPlayPause.BackColor = System.Drawing.Color.White;
            this.buttonPlayPause.BackgroundImage = global::MusicOnStream.Properties.Resources.PlayButton;
            this.buttonPlayPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPlayPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlayPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlayPause.Location = new System.Drawing.Point(384, 12);
            this.buttonPlayPause.Name = "buttonPlayPause";
            this.buttonPlayPause.Size = new System.Drawing.Size(48, 48);
            this.buttonPlayPause.TabIndex = 0;
            this.buttonPlayPause.UseVisualStyleBackColor = false;
            this.buttonPlayPause.Click += new System.EventHandler(this.button1_Click);
            // 
            // musicList
            // 
            this.musicList.BackColor = System.Drawing.Color.White;
            this.musicList.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musicList.ForeColor = System.Drawing.SystemColors.WindowText;
            this.musicList.FormattingEnabled = true;
            this.musicList.ItemHeight = 21;
            this.musicList.Location = new System.Drawing.Point(12, 12);
            this.musicList.Name = "musicList";
            this.musicList.Size = new System.Drawing.Size(312, 172);
            this.musicList.TabIndex = 1;
            this.musicList.SelectedValueChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // buttonPrev
            // 
            this.buttonPrev.BackColor = System.Drawing.Color.White;
            this.buttonPrev.BackgroundImage = global::MusicOnStream.Properties.Resources.PrevButton;
            this.buttonPrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPrev.Location = new System.Drawing.Point(330, 12);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(48, 48);
            this.buttonPrev.TabIndex = 2;
            this.buttonPrev.UseVisualStyleBackColor = false;
            this.buttonPrev.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.Color.White;
            this.buttonNext.BackgroundImage = global::MusicOnStream.Properties.Resources.NextButton;
            this.buttonNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNext.Location = new System.Drawing.Point(438, 12);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(48, 48);
            this.buttonNext.TabIndex = 3;
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.button3_Click);
            // 
            // musicInfo
            // 
            this.musicInfo.BackColor = System.Drawing.Color.White;
            this.musicInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.musicInfo.Location = new System.Drawing.Point(8, 196);
            this.musicInfo.Name = "musicInfo";
            this.musicInfo.Size = new System.Drawing.Size(478, 20);
            this.musicInfo.TabIndex = 4;
            // 
            // trackVolume
            // 
            this.trackVolume.BackColor = System.Drawing.Color.White;
            this.trackVolume.Location = new System.Drawing.Point(447, 66);
            this.trackVolume.Maximum = 100;
            this.trackVolume.Name = "trackVolume";
            this.trackVolume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackVolume.Size = new System.Drawing.Size(45, 104);
            this.trackVolume.TabIndex = 5;
            this.trackVolume.TickFrequency = 5;
            this.trackVolume.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackVolume.Value = 100;
            this.trackVolume.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // buttonOpenPL
            // 
            this.buttonOpenPL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenPL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenPL.Location = new System.Drawing.Point(330, 148);
            this.buttonOpenPL.Name = "buttonOpenPL";
            this.buttonOpenPL.Size = new System.Drawing.Size(111, 35);
            this.buttonOpenPL.TabIndex = 6;
            this.buttonOpenPL.Text = "Open PlayList";
            this.buttonOpenPL.UseVisualStyleBackColor = true;
            this.buttonOpenPL.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(444, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Volume";
            // 
            // buttonRemove
            // 
            this.buttonRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRemove.Location = new System.Drawing.Point(330, 66);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(111, 35);
            this.buttonRemove.TabIndex = 8;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonUndo
            // 
            this.buttonUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUndo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUndo.Location = new System.Drawing.Point(330, 107);
            this.buttonUndo.Name = "buttonUndo";
            this.buttonUndo.Size = new System.Drawing.Size(111, 35);
            this.buttonUndo.TabIndex = 9;
            this.buttonUndo.Text = "Undo";
            this.buttonUndo.UseVisualStyleBackColor = true;
            this.buttonUndo.Click += new System.EventHandler(this.button6_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(498, 229);
            this.Controls.Add(this.buttonUndo);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonOpenPL);
            this.Controls.Add(this.trackVolume);
            this.Controls.Add(this.musicInfo);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.musicList);
            this.Controls.Add(this.buttonPlayPause);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MusicOnStream";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Destructor);
            ((System.ComponentModel.ISupportInitialize)(this.trackVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPlayPause;
        private System.Windows.Forms.ListBox musicList;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Label musicInfo;
        private System.Windows.Forms.TrackBar trackVolume;
        private System.Windows.Forms.Button buttonOpenPL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonUndo;
    }
}

