using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;

namespace cj_project
{
    static class Program
    {
        public static Button[] buttons = new Button[10];
        public static ToolTip toolTip;
        public static List<KeyandValue> resData;
        public static IEnumerable<KeyandValue> nowData;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        public static void LoadResXFile()
        {
            string resxFile = @".\\info.resx";
            using (ResXResourceReader resxReader = new(resxFile))
            {
                resData = resxReader
                    .Cast<DictionaryEntry>()
                    .Select(e => new KeyandValue(e.Key.ToString(), e.Value.ToString()))
                    .ToList();
            }
        }
        public static void ReflectButtonText(string searchData)
        {
            int i = 0;
            nowData = resData.Where(e => e.key.Contains(searchData)).OrderBy(e => e.key.IndexOf(searchData)).Take(10);
            foreach (var x in nowData)
            {
                buttons[i].Text = x.value;
                toolTip.SetToolTip(buttons[i], x.key);
                i++;
            }
            for (; i < 10; i++)
            {
                buttons[i].Text = "";
                toolTip.SetToolTip(buttons[i], "");
            }
        }
        public static void SetKey(int value)
        {
            var v = nowData.Skip(value).FirstOrDefault();

            if (v is not null)
            {
                Clipboard.SetText(v.value);
            }
        }
    }
    public class KeyandValue
    {
        public string key;
        public string value;
        public KeyandValue(string  k, string v)
        {
            key = k;
            value = v;
        }
    }
}
