using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

public static class ThemeManager
{
    public enum Mode { Dark, Light }

    public static Mode CurrentMode = Mode.Dark;

    public static Color GetBackgroundColor()
    {
        return CurrentMode == Mode.Dark ? Color.FromArgb(30, 30, 30) : Color.White;
    }

    public static Color GetTextColor()
    {
        return CurrentMode == Mode.Dark ? Color.White : Color.Black;
    }

    public static Color GetButtonColor()
    {
        return CurrentMode == Mode.Dark ? Color.FromArgb(50, 50, 50) : Color.LightGray;
    }

    public static void ApplyTheme(Control root)
    {
        root.BackColor = GetBackgroundColor();
        root.ForeColor = GetTextColor();

        foreach (Control control in root.Controls)
        {
            ApplyTheme(control); // rekursif biar semua control kena
        }
    }
}
