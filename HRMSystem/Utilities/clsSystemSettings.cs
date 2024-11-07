using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMSystem.Utilities
{
    public static class clsSystemSettings
    {
        public static string TARGET_PROJECT = "SystemManagement";
        public static string TargetForder = Application.StartupPath + "Images";

        public static Font TitlePageFont = new Font("Tahoma", 20);
        public static Font TitleDetailFormFont = new Font("Tahoma", 14);

        public static Font CaptionGroupControlFont = new Font("Tahoma", 14);
        public static Font CaptionColumnHeaderFont = new Font("Tahoma", 10);
        public static Size ButtonInBarWidth = new Size(35,0);

        //public static string LangCode = "en";

        //public static ResourceManager ResourceManager = new ResourceManager("CommonControls.Languages.Language", typeof(ucCommonSettings).Assembly);
        //public static ResourceManager ResourceSpecial = new ResourceManager($"{TARGET_PROJECT}.Languages.Language", typeof(ucCommonSettings).Assembly);

        //public static List<SlideBarModel> SliderBars = new List<SlideBarModel>();
    }
}
