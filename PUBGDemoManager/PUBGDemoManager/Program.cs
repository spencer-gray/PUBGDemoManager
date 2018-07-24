using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PUBGDemoManager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    class Replay
    {
        public string dir { get; set; }

        public TimeSpan length { get; set; }
        public int lengthMIN { get; set; }
        public DateTimeOffset timestamp { get; set; }
        public string mode { get; set; }
        public string map { get; set; }
        public bool fpp { get; set; }

        public Replay()
        {
            
        }
        // scans directory for info
        public Replay(string directory)
        {
            dir = directory.Split('\\').Last();
            var infoFile = File.ReadAllText(directory + @"\\PUBG.replayinfo", System.Text.Encoding.UTF8);
            length = TimeSpan.FromMilliseconds(double.Parse(infoFile.Split(new[] { "\"LengthInMS\":" }, StringSplitOptions.None)[1].Split(',')[0]));
            lengthMIN = length.Minutes;
            timestamp = DateTimeOffset.FromUnixTimeMilliseconds(long.Parse(infoFile.Split(new[] { "\"Timestamp\":" }, StringSplitOptions.None)[1].Split(',')[0]));
            var _mode = infoFile.Split(new[] { "\"Mode\": " }, StringSplitOptions.None)[1].Split('"')[1];
            fpp = _mode.Contains('-');
            mode = fpp? _mode.Split('-')[0] : _mode;
            mode = char.ToUpper(mode[0]) + mode.Substring(1);

            map = infoFile.Split(new[] { "\"MapName\": " }, StringSplitOptions.None)[1].Split('"')[1];
            if (map == "Desert_Main") { map = "Miramer"; }
            else if (map == "Savage_Main") { map = "Sanhok"; }
            else { map = "Miramar"; }
        }
    }
}
