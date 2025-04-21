using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public static class AppTheme
    {
        public static bool IsDarkMode = false;

        private static readonly Color DarkBackColor = Color.FromArgb(45, 45, 48);
        private static readonly Color DarkForeColor = Color.White;
        private static readonly Color LightBackColor = SystemColors.Control;
        private static readonly Color LightForeColor = SystemColors.ControlText;

        public static void ToggleTheme()
        {
            IsDarkMode = !IsDarkMode;
        }

        public static void SetTheme(bool darkMode)
        {
            IsDarkMode = darkMode;
        }

        public static void ApplyTheme(Control control)
        {
            if (control == null) return;

            if (IsDarkMode)
            {
                control.BackColor = DarkBackColor;
                control.ForeColor = DarkForeColor;
            }
            else
            {
                control.BackColor = LightBackColor;
                control.ForeColor = LightForeColor;
            }

            // Recursive ke semua kontrol anak
            foreach (Control child in control.Controls)
            {
                ApplyTheme(child);
            }
        }
    }
}
