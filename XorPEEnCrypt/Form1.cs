using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace XorPEEnCrypt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fileStream = new FileStream("TEST.exe", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            byte[] TempByte = new byte[fileStream.Length];
            fileStream.Read(TempByte, 0, TempByte.Length);
            for (int i = 0; i < TempByte.Length; i++) TempByte[i] ^= 0x0a;
            fileStream.Seek(0,0);
            fileStream.Write(TempByte, 0, TempByte.Length);
            fileStream.Close();
        }
    }
}
