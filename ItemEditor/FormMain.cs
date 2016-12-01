using System;
using System.Windows.Forms;
using ReadWriteProcessMemory;
using System.Timers;
using System.Net;
using System.IO;

namespace ItemEditor
{
    public partial class FormMain : Form
    {
        int start,y,slot;
        byte buffer, memorize;
        ProcessMemory CubeWorld;
        bool isReady, HL = true;
        System.Timers.Timer hTimer;

        public FormMain()
        {
            InitializeComponent();

            try
            {
                WebRequest request = WebRequest.Create("http://lastexceed.bplaced.net/version");
                WebResponse response = request.GetResponse();
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();
                if (Convert.ToUInt16(responseFromServer) > 10)
                {
                    if(MessageBox.Show("A new version is out! Do want to download it?", "update available", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start("http://cwmods.com/");
                    }
                }
                else
                {
                    MessageBox.Show("You have the latest version.", "UpToDate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                reader.Close();
                response.Close();
            }
            catch (Exception)
            {
                //unable to check for updates
                MessageBox.Show("Unable to check for updates", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            hTimer = new System.Timers.Timer();
            hTimer.Elapsed += new ElapsedEventHandler(hTimerOnTick);
            hTimer.Interval = 250;
            hTimer.Enabled = false;
        }

        //attach
        private void buttonAttach_Click(object sender, EventArgs e)
        {
            try
            {
                CubeWorld = new ProcessMemory("Cube");
            }
            catch (Exception)
            {
                MessageBox.Show("CubeWorld process not found, the program will now exit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            start = CubeWorld.readInt(CubeWorld.readInt(CubeWorld.baseAddress + 0x0036b1c8) + 0x39C) + 0x1E8;
            MessageBox.Show("attached successfully! your client version is 0.?.?", "attached successfully", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            listBoxItem.Enabled = true;
            buttonAttach.Enabled = false;
        }

        private void checkBoxStayOnTop_Click(object sender, EventArgs e)
        {
            TopMost = (checkBoxStayOnTop.Checked == true);
        }

        private void trackBarOpacity_Scroll(object sender, EventArgs e)
        {
            Opacity = (float)trackBarOpacity.Value / 10;
            labelOpacity.Text = "Opacity: " + Opacity*100 + "%";
        }

        //listBoxItem
        private void listBoxItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            isReady = false;
            y = start + listBoxItem.SelectedIndex * 280;
            
            numericUpDownType.Value = CubeWorld.readByte(y + 0); ;
            numericUpDownSubType.Value = CubeWorld.readByte(y + 1);
            numericUpDownModifier.Value = CubeWorld.readInt(y + 4);
            numericUpDownUnknown.Value = CubeWorld.readInt(y + 8);
            numericUpDownRarity.Value = CubeWorld.readByte(y + 12);
            numericUpDownMaterial.Value = CubeWorld.readByte(y + 13);
            numericUpDownLevel.Value = CubeWorld.readUShort(y + 16);
            checkBoxAdapted.Checked = (CubeWorld.readByte(y + 14) == 1); 
            numericUpDownVisible.Value = CubeWorld.readUInt(y + 276);

            tabControl1.Enabled = true;
            listBoxSlots.SelectedIndex = -1;
            isReady = true;
        }

        //numericUpDown
        private void numericUpDownType_ValueChanged(object sender, EventArgs e)
        {
            buffer = (byte)numericUpDownType.Value;
            CubeWorld.writeByte(y + 0, buffer);

            isReady = false;
            if (buffer < 26)
            {
                comboBoxType.SelectedIndex = buffer;
            }
            else
            {
                comboBoxType.SelectedIndex = -1;
            }
            isReady = true;
        }

        private void numericUpDownSubType_ValueChanged(object sender, EventArgs e)
        {
            buffer = (byte)numericUpDownSubType.Value;
            CubeWorld.writeByte(y + 1, buffer);

            isReady = false;
            //if (buffer < ?)
            //{
            //    comboBoxSubType.SelectedIndex = buffer;
            //}
            //else
            //{
            //    comboBoxSubType.SelectedIndex = -1;
            //}
            isReady = true;
        }

        private void numericUpDownModifier_ValueChanged(object sender, EventArgs e)
        {
            CubeWorld.writeInt(y + 4, (int)numericUpDownModifier.Value);
        }

        private void numericUpDownUnknown_ValueChanged(object sender, EventArgs e)
        {
            CubeWorld.writeInt(y + 8, (int)numericUpDownUnknown.Value);
        }

        private void numericUpDownRarity_ValueChanged(object sender, EventArgs e)
        {
            buffer = (byte)numericUpDownRarity.Value;
            CubeWorld.writeByte(y + 12, buffer);

            isReady = false;
            if (buffer < 6)
            {
                comboBoxRarity.SelectedIndex = buffer;
            }
            else
            {
                comboBoxRarity.SelectedIndex = -1;
            }
            isReady = true;
        }

        private void numericUpDownMaterial_ValueChanged(object sender, EventArgs e)
        {
            buffer = (byte)numericUpDownMaterial.Value;
            CubeWorld.writeByte(y + 13, buffer);

            isReady = false;
            if (buffer < 29)
            {
                comboBoxMaterial.SelectedIndex = buffer;
            }
            else if(buffer > 127 && buffer < 132)
            {
                comboBoxMaterial.SelectedIndex = buffer - 99;
            }
            else
            {
                comboBoxMaterial.SelectedIndex = -1;
            }
            isReady = true;
        }

        private void numericUpDownLevel_ValueChanged(object sender, EventArgs e)
        {
            CubeWorld.writeShort(y + 16, (short)numericUpDownLevel.Value);
        }

        //checkbox
        private void checkBoxAdapted_Click(object sender, EventArgs e)
        {
            CubeWorld.writeByte(y + 14, Convert.ToByte(checkBoxAdapted.Checked));
        }

        //combobox
        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isReady)
            {
                buffer = (byte)comboBoxType.SelectedIndex;
                CubeWorld.writeByte(y + 0, buffer);
                numericUpDownType.Value = buffer;
            }
        }

        private void comboBoxSubType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isReady)
            {
                buffer = (byte)comboBoxSubType.SelectedIndex;
                CubeWorld.writeByte(y + 1, buffer);
                numericUpDownSubType.Value = buffer;
            }
        }

        private void comboBoxRarity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isReady)
            {
                buffer = (byte)comboBoxRarity.SelectedIndex;
                CubeWorld.writeByte(y + 12, buffer);
                numericUpDownRarity.Value = buffer;
            }
        }

        private void comboBoxMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isReady)
            {
                buffer = (byte)comboBoxMaterial.SelectedIndex;
                CubeWorld.writeByte(y + 13, buffer);
                numericUpDownMaterial.Value = buffer;
            }
        }


        //cubes/spirits
        private void listBoxSlots_SelectedIndexChanged(object sender, EventArgs e)
        {
            isReady = false;
            if (hTimer.Enabled)
            {
                CubeWorld.writeByte(slot + 3, memorize);
                slot = y + 20 + 8 * listBoxSlots.SelectedIndex;
                memorize = CubeWorld.readByte(slot + 3);
            }
            else
            {
                slot = y + 20 + 8 * listBoxSlots.SelectedIndex;
            }
            
            numericUpDownX.Value = CubeWorld.readSByte(slot + 0);
            numericUpDownY.Value = CubeWorld.readSByte(slot + 1);
            numericUpDownZ.Value = CubeWorld.readSByte(slot + 2);

            buffer = CubeWorld.readByte(slot + 3);
            numericUpDownTypeC.Value = buffer;
            numericUpDownLevelC.Value= CubeWorld.readShort(slot + 4);

            bool x = (listBoxSlots.SelectedIndex != -1);
            numericUpDownX.Enabled = x;
            numericUpDownY.Enabled = x;
            numericUpDownZ.Enabled = x;
            numericUpDownLevelC.Enabled = x;
            numericUpDownTypeC.Enabled = x;
            comboBoxTypeC.Enabled = x;
            checkBoxHighlight.Enabled = x;

            isReady = true;
        }

        private void numericUpDownX_ValueChanged(object sender, EventArgs e)
        {
            CubeWorld.writeSByte(slot + 0, (sbyte)numericUpDownX.Value);
        }

        private void numericUpDownY_ValueChanged(object sender, EventArgs e)
        {
            CubeWorld.writeSByte(slot + 1, (sbyte)numericUpDownY.Value);
        }

        private void numericUpDownZ_ValueChanged(object sender, EventArgs e)
        {
            CubeWorld.writeSByte(slot + 2, (sbyte)numericUpDownZ.Value);
        }

        private void numericUpDownTypeC_ValueChanged(object sender, EventArgs e)
        {
            buffer = (byte)numericUpDownTypeC.Value;
            CubeWorld.writeByte(slot + 3, buffer);
            isReady = false;
            if (buffer < 29)
            {
                comboBoxTypeC.SelectedIndex = buffer;
            }
            else if (buffer > 127 && buffer < 132)
            {
                comboBoxTypeC.SelectedIndex = buffer - 99;
            }
            else
            {
                comboBoxTypeC.SelectedIndex = -1;
            }
            isReady = true;
        }

        private void comboBoxTypeC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isReady)
            {
                buffer = (byte)comboBoxTypeC.SelectedIndex;
                CubeWorld.writeByte(slot + 3, buffer);
                numericUpDownTypeC.Value = buffer;
            }
        }

        private void numericUpDownLevelC_ValueChanged(object sender, EventArgs e)
        {
            CubeWorld.writeShort(slot + 4, (short)numericUpDownLevelC.Value);
        }

        private void numericUpDownVisible_ValueChanged(object sender, EventArgs e)
        {
            CubeWorld.writeUShort(y + 276, (ushort)numericUpDownVisible.Value);
        }

        private void checkBoxHighlight_Click(object sender, EventArgs e)
        {
            if (checkBoxHighlight.Checked)
            {
                numericUpDownTypeC.Enabled = false;
                comboBoxTypeC.Enabled = false;
                memorize = CubeWorld.readByte(slot + 3);
                hTimer.Enabled = true;
            }
            else
            {
                hTimer.Enabled = false;
                CubeWorld.writeByte(slot + 3, memorize);
                numericUpDownTypeC.Enabled = true;
                comboBoxTypeC.Enabled = true;
                
            }
        }
        private void hTimerOnTick(object source, ElapsedEventArgs e)
        {
            if (HL)
            {
                CubeWorld.writeByte(slot + 3, 5);
                HL = false;
            }
            else
            {
                CubeWorld.writeByte(slot + 3, 131);
                HL = true;
            }
        }
    }
}