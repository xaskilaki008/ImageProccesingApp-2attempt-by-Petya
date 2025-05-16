using System.Drawing;

public interface IMyOrangeColorTable
{
    Color MenuBorder { get; }
    Color MenuItemBorder { get; }
    Color MenuItemPressedGradientBegin { get; }
    Color MenuItemPressedGradientEnd { get; }
    Color MenuItemSelected { get; }
    Color MenuItemSelectedGradientBegin { get; }
    Color MenuItemSelectedGradientEnd { get; }
    Color ToolStripDropDownBackground { get; }
}