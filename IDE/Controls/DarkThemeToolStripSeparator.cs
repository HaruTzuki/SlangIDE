using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDE.Controls
{
    public class DarkThemeToolStripSeparator : ToolStripSeparator
    {
        public DarkThemeToolStripSeparator()
        {
            this.Paint += OnPaint;
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            // Get the separator's width and height.
            ToolStripSeparator toolStripSeparator = (ToolStripSeparator)sender;
            int width = toolStripSeparator.Width + 1;
            int height = toolStripSeparator.Height + 1;

            // Choose the colors for drawing.
            // I've used Color.White as the foreColor.
            Color foreColor = Color.FromArgb(61,61,61);
            // Color.Teal as the backColor.
            Color backColor = Color.FromArgb(31, 31, 31);

            // Fill the background.
            e.Graphics.FillRectangle(new SolidBrush(backColor), 0, 0, width, height);

            // Draw the line.
            e.Graphics.DrawLine(new Pen(foreColor), 4, height / 2, width - 4, height / 2);
        }
    }
}
