using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pulp_stone_ai_test_gui
{
    public partial class Log : Form
    {
        public Log()
        {
            InitializeComponent();
            lstbox_log.HorizontalScrollbar = true;
        }

        public void SaveLogs(string logFilePath)
        {
            File.WriteAllLines(logFilePath, lstbox_log.Items.Cast<string>());
        }
        public void AppendLog(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(AppendLog), message);
            }
            else
            {
                lstbox_log.Items.Add(message);
                lstbox_log.SelectedIndex = lstbox_log.Items.Count - 1; // Scroll to the bottom
            }
        }
    }
}
