using MaterialSkin;
using MaterialSkin.Controls;
using Sanford.Multimedia.Midi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidiPilot
{
    public partial class MainWindow : MaterialForm
    {
        private int MidiDeviceIndex = 0;
        private InputDevice inDevice;
        private List<int> midiChannels = new List<int>();
        private bool isConnected = false;

        public MainWindow()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepOrange300, Primary.DeepOrange800, Primary.DeepOrange500, Accent.DeepOrange400, TextShade.WHITE);

            DeviceTypeMenu.SelectedIndex = 0;

            // Select all midi channels by default
            EventMidiChannelSelector.Items.Clear();
            for (int i = 0; i < MidiChannelSelector.Items.Count; i++)
            {
                MidiChannelSelector.SetItemChecked(i, true);
                midiChannels.Add(i + 1);

                // populate the midi channel dropdown with the midi channels
                EventMidiChannelSelector.Items.Add("Ch" + (i + 1));
            }

            for (int i = 0; i < InputDevice.DeviceCount; i++)
            {
                // loop through availible midi devices and push their names to the menu
                MidiDeviceSelector.Items.Add(InputDevice.GetDeviceCapabilities(i).name);

                TrayMenuConnect.DropDownItems.Add(InputDevice.GetDeviceCapabilities(i).name);

            }

            TrayMenuConnect.DropDownItemClicked += new ToolStripItemClickedEventHandler(TrayConnect_Click);

        }

        private void ConnectDevice()
        {
            if (isConnected == false)
            {
                isConnected = true;

                // Connect to input midi device based on index
                inDevice = new InputDevice(MidiDeviceIndex);
                ChannelStopper stopper = new ChannelStopper();

                MidiLogBox.Items.Add("Connected to MIDI input device " + InputDevice.GetDeviceCapabilities(MidiDeviceIndex).name);
                MidiLogBox.Items.Add("Driver Version: " + InputDevice.GetDeviceCapabilities(MidiDeviceIndex).driverVersion);
                MidiLogBox.Items.Add("Manufacturer ID: " + InputDevice.GetDeviceCapabilities(MidiDeviceIndex).mid);

                inDevice.ChannelMessageReceived += delegate (object midiSender, ChannelMessageEventArgs eMidi)
                {
                    if (midiChannels.Contains(eMidi.Message.MidiChannel + 1))
                    {
                        // log midi messages
                        stopper.Process(eMidi.Message);
                        MidiLogBox.Items.Add("Ch:" + (eMidi.Message.MidiChannel + 1) + " Cmd:" + eMidi.Message.Command + " D1:" + eMidi.Message.Data1 + " D2:" + eMidi.Message.Data2);
                        MidiLogBox.SelectedIndex = MidiLogBox.Items.Count - 1;
                        MidiLogBox.SelectedIndex = -1;

                    }
                };

                // Show that we're connected now!
                inDevice.StartRecording();
                MidiConnectBtn.Text = "Disconnect";

            }
            else
            {
                isConnected = false;

                // Switch the button back to "Connect" and close our previous midi connection
                MidiConnectBtn.Text = "Connect";
                inDevice.Close();
            }
        }
        private void MidiConnectBtn_Click(object sender, EventArgs e)
        {
            ConnectDevice();
        }

        private void MidiDeviceSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            // when device is changed, update the index
            if (inDevice != null)
            {
                if (MidiDeviceSelector.SelectedIndex == inDevice.DeviceID)
                {
                    // Don't connect to the new device
                }
                else
                {
                    MidiDeviceIndex = MidiDeviceSelector.SelectedIndex;
                    ConnectDevice();
                }
            }
        }

        private void MidiChannelSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Parse the checkbox items
            List<String> selectedItems = MidiChannelSelector.CheckedItems.OfType<String>().ToList();
            for (int i = 0; i < selectedItems.Count; i++)
            {
                selectedItems[i] = selectedItems[i].Substring(2);
            }
            
            // Update the list with the new channels
            midiChannels = selectedItems.Select(int.Parse).ToList();

            // Update the channel selector in the events pane
            EventMidiChannelSelector.Items.Clear();

            for (int i = 0; i < selectedItems.Count; i++)
            {
                EventMidiChannelSelector.Items.Add("Ch" + selectedItems[i]);
            }
        }

        void TrayConnect_Click(Object sender, ToolStripItemClickedEventArgs e)
        {
            // Connect
            ToolStripItem clickedItem = e.ClickedItem;
            MidiDeviceIndex = TrayMenuConnect.DropDownItems.IndexOf(clickedItem);
            MidiDeviceSelector.SelectedIndex = MidiDeviceIndex;
            ConnectDevice();
        }

        private void ClearConsole_Click(object sender, EventArgs e)
        {
            MidiLogBox.Items.Clear();
        }

        private void SelectAll_Click(object sender, EventArgs e)
        {
            EventMidiChannelSelector.Items.Clear();
            for (int i = 0; i < MidiChannelSelector.Items.Count; i++)
            {
                MidiChannelSelector.SetItemChecked(i, true);
                midiChannels.Add(i + 1);

                // populate the midi channel dropdown with the midi channels
                EventMidiChannelSelector.Items.Add("Ch" + (i + 1));
            }
        }

        private void SelectNone_Click(object sender, EventArgs e)
        {
            EventMidiChannelSelector.Items.Clear();
            for (int i = 0; i < MidiChannelSelector.Items.Count; i++)
            {
                MidiChannelSelector.SetItemChecked(i, false);
                midiChannels.Clear();
            }
        }
    }
}
