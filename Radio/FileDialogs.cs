using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MusicOnStream
{
    class FileDialogs
    {
        /// <summary>
        /// Open file dialog
        /// </summary>
        /// <param name="formats">Write formats in string, for example: "*.jpg *.txt *.*" etc.</param>
        /// <returns>Opened File name</returns>
        public static string OpenFile(string formats)
        {
            OpenFileDialog file_open = new OpenFileDialog();
            // V_CONTINUE FORMATS
            file_open.Filter = formats; //"Jpg picture (*.jpg)|*.jpg|All files (*.*)|*.*";
            file_open.RestoreDirectory = true;

            if (file_open.ShowDialog() == DialogResult.OK)
            {
                return file_open.FileName;
            }
            else
            {
                throw new Exception("Error on open file dialog result");
            }
        }

        public static string SaveFile()
        {
            // V_CONTINUE
            throw new Exception("Error on save file dialog result");
        }
    }
}
