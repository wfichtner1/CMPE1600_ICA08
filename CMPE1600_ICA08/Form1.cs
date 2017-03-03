using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CMPE1600_ICA08
{
    public partial class Form1 : Form
    {
        List<Byte> byteList = new List<Byte>();
        int length = 0;
        LongestRunForm longestDialog = new LongestRunForm();
        bool runType = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void UI_LoadButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    FileStream fs = new FileStream(openFileDialog1.SafeFileName, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    for (int i = 0; i < fs.Length; i++)
                    {
                        length++;
                        byteList.Add(br.ReadByte());

                    }
                    br.Close();
                    fs.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ICA_08", "Could not open file", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            UI_FileName.Text = openFileDialog1.SafeFileName.ToUpper();
            UI_FileLength.Text = length.ToString();
            SetCount();
        }

        private void SetCount()
        {
            int setCount = 0;
            foreach (byte b in byteList)
            {
                for (int i = 0; i < 32; i++)
                {
                    if ((b & (1 << i)) > 0)
                        setCount++;
                }
            }
            UI_NumberOnes.Text = setCount.ToString();
        }

        private void UI_LongRunButton_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == longestDialog.ShowDialog())
            {
                runType = longestDialog.RunType;
                if (runType)
                {
                    LongRunCount();
                }
                else if (!runType)
                {
                    LongGapCount();
                }
            }
        }
        private void LongRunCount()
        {
            int state = 0;
            int lengthCount = 0;
            int longestRun = 0;
            foreach (byte b in byteList)
            {
                for (int i = 0; i < 32; i++)
                {
                    if ((b & (1 << i)) == 0)
                    {
                        switch (state)
                        {
                            case 0:
                                state = 0;
                                break;
                            case 1:
                                state = 0;
                                break;
                        }
                    }
                    else if ((b & (1 << i)) > 0)
                    {
                        switch (state)
                        {
                            case 0:
                                state = 1;
                                lengthCount++;
                                break;
                            case 1:
                                state = 1;
                                lengthCount++;
                                break;
                        }

                    }
                }
                if (lengthCount > longestRun)
                {
                    longestRun = lengthCount;
                }
                lengthCount = 0;
            }

            LongestRunLabel.Text = "Longest Run:";
            UI_LongestRuns.Text = longestRun.ToString();
        }
        public void LongGapCount()
        {
            int state = 0;
            int lengthCount = 0;
            int longestGap = 0;
            foreach (byte b in byteList)
            {

                for (int i = 0; i < 8; i++)
                {
                    if ((b & (1 << i)) > 0)
                    {
                        switch (state)
                        {
                            case 0:
                                state = 0;
                                break;
                            case 1:
                                state = 0;
                                break;
                        }
                    }
                    else if ((b & (1 << i)) == 0)
                    {
                        switch (state)
                        {
                            case 0:
                                state = 1;
                                lengthCount++;
                                break;
                            case 1:
                                state = 1;
                                lengthCount++;
                                break;
                        }

                    }
                }
                if (lengthCount > longestGap)
                {
                    longestGap = lengthCount;
                }
                lengthCount = 0;
            }

            LongestRunLabel.Text = "Longest Gap:";
            UI_LongestRuns.Text = longestGap.ToString();

        }


    }
}
