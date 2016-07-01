using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VRSSSetter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submitSS_Click(object sender, EventArgs e)
        {
            string multiplier = SSNumber.Value.ToString();
            string configText = "\"renderTargetMultiplier\" : \"" + multiplier + "\"";
            new FileProcessor().WriteSSValueInSteamVRSettings(configText);
        }
    }
}
