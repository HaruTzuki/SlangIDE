namespace IDE.Controls
{
    public class UcTabControl : TabControl
    {
        public UcTabControl()
        {
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var backColor = Color.FromArgb(31, 31, 31); // Replace with your desired color
            var selectedBackColor = Color.FromArgb(61, 61, 61); // Replace with your desired color

            using (var brush = new SolidBrush(backColor))
            {
                e.Graphics.FillRectangle(brush, ClientRectangle);
            }

            for (var index = 0; index < TabCount; index++)
            {
                var tabRectangle = GetTabRect(index);
                var isSelected = index == SelectedIndex;

                var tabColor = isSelected ? selectedBackColor : backColor;
                var textColor = isSelected ? Color.White : Color.Gray;

                using (var brush = new SolidBrush(tabColor))
                {
                    e.Graphics.FillRectangle(brush, tabRectangle);
                }

                var headerText = TabPages[index].Text;
                using (var brush = new SolidBrush(textColor))
                {
                    e.Graphics.DrawString(headerText, Font, brush, tabRectangle, StringFormat.GenericDefault);
                }

                // Draw close button
                var closeButtonRect = new Rectangle(tabRectangle.Right - 15, tabRectangle.Top + 4, 10, 10);
                using (var pen = new Pen(Color.Gray))
                {
                    e.Graphics.DrawLine(pen, closeButtonRect.Left, closeButtonRect.Top, closeButtonRect.Right, closeButtonRect.Bottom);
                    e.Graphics.DrawLine(pen, closeButtonRect.Left, closeButtonRect.Bottom, closeButtonRect.Right, closeButtonRect.Top);
                }
                using var borderPen = new Pen(Color.FromArgb(61, 61, 61));
                e.Graphics.DrawRectangle(borderPen, 0, 0, this.Width - 1, this.Height - 1);
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                for (var index = 0; index < TabCount; index++)
                {
                    var tabRectangle = GetTabRect(index);
                    var closeButtonRect = new Rectangle(tabRectangle.Right - 15, tabRectangle.Top + 4, 10, 10);

                    if (closeButtonRect.Contains(e.Location))
                    {
                        TabPages.RemoveAt(index);
                        return;
                    }
                }
            }

            base.OnMouseDown(e);
        }
    }
}
