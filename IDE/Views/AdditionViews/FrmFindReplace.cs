using System.Diagnostics;
using System.Net.Http;
using System.Runtime.InteropServices;

namespace IDE.Views.AdditionViews
{
    public partial class FrmFindReplace : Form
    {
        RichTextBox _richTextBox;
        string FindText;
        bool IsForReplace;

        private bool isDragging = false;
        private Point dragOffset;

        private bool isResizing = false;
        private int lastMouseX, lastMouseY;
        private const int resizeMargin = 5; // The margin around the form for resizing


        private const int WM_NCHITTEST = 0x0084;
        private const int HTCLIENT = 0x01;
        private const int HTLEFT = 10;
        private const int HTRIGHT = 11;
        private const int HTTOP = 12;
        private const int HTTOPLEFT = 13;
        private const int HTTOPRIGHT = 14;
        private const int HTBOTTOM = 15;
        private const int HTBOTTOMLEFT = 16;
        private const int HTBOTTOMRIGHT = 17;

        private int resizeRegion = 5; // Adjust this value as needed


        public FrmFindReplace(ref RichTextBox rtb, string findText = "", bool isForReplace = false)
        {
            InitializeComponent();
            _richTextBox = rtb;
            FindText = findText;
            IsForReplace = isForReplace;
            LblTitle.Text = IsForReplace ? $"Find & Replace" : "Find";
            TxtFind.Text = findText;
            this.ControlBox = false;
            this.Padding = new Padding(5);

        }

        private void BtnShowReplace_Click(object sender, EventArgs e)
        {
            LblTitle.Text = IsForReplace ? $"Find & Replace" : "Find";
            LblReplace.Visible = IsForReplace;
            TxtReplace.Visible = IsForReplace;
            PnlReplaceButtons.Visible = IsForReplace;
        }

        private void BtnFindNext_Click(object sender, EventArgs e)
        {
            var position = _richTextBox.Find(TxtFind.Text, RichTextBoxFinds.None);
            _richTextBox.Select(position, TxtFind.Text.Length);
            Debug.WriteLine(position.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void BtnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            dragOffset = e.Location;
        }

        private void TitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point newLocation = this.PointToScreen(e.Location);
                newLocation.Offset(-dragOffset.X, -dragOffset.Y);
                this.Location = newLocation;
            }
        }

        private void TitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }



        private const int WM_GETMINMAXINFO = 0x0024;

        [StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
            public int x;
            public int y;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct MINMAXINFO
        {
            public POINT ptReserved;
            public POINT ptMaxSize;
            public POINT ptMaxPosition;
            public POINT ptMinTrackSize;
            public POINT ptMaxTrackSize;
        }

        protected override void WndProc(ref Message m)
        {

            switch(m.Msg)
            {
                case WM_GETMINMAXINFO:
                    MINMAXINFO mmi = (MINMAXINFO)Marshal.PtrToStructure(m.LParam, typeof(MINMAXINFO));

                    // Adjust the maximum size of the window
                    mmi.ptMaxTrackSize.x = Screen.PrimaryScreen.WorkingArea.Width;
                    mmi.ptMaxTrackSize.y = Screen.PrimaryScreen.WorkingArea.Height;

                    Marshal.StructureToPtr(mmi, m.LParam, true);
                    break;
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    if (m.Result.ToInt32() == HTCLIENT)
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32());
                        Point clientPoint = this.PointToClient(screenPoint);

                        if (clientPoint.Y < resizeRegion)
                        {
                            if (clientPoint.X < resizeRegion)
                                m.Result = (IntPtr)HTTOPLEFT;
                            else if (clientPoint.X > this.ClientSize.Width - resizeRegion)
                                m.Result = (IntPtr)HTTOPRIGHT;
                            else
                                m.Result = (IntPtr)HTTOP;
                        }
                        else if (clientPoint.Y > this.ClientSize.Height - resizeRegion)
                        {
                            if (clientPoint.X < resizeRegion)
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X > this.ClientSize.Width - resizeRegion)
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                            else
                                m.Result = (IntPtr)HTBOTTOM;
                        }
                        else if (clientPoint.X < resizeRegion)
                        {
                            m.Result = (IntPtr)HTLEFT;
                        }
                        else if (clientPoint.X > this.ClientSize.Width - resizeRegion)
                        {
                            m.Result = (IntPtr)HTRIGHT;
                        }
                    }
                    return;
            }

            if (m.Msg == WM_GETMINMAXINFO)
            {
                MINMAXINFO mmi = (MINMAXINFO)Marshal.PtrToStructure(m.LParam, typeof(MINMAXINFO));

                // Adjust the maximum size of the window
                mmi.ptMaxTrackSize.x = Screen.PrimaryScreen.WorkingArea.Width;
                mmi.ptMaxTrackSize.y = Screen.PrimaryScreen.WorkingArea.Height;

                Marshal.StructureToPtr(mmi, m.LParam, true);
            }

            base.WndProc(ref m);
        }

        private void FrmFindReplace_Resize(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void FrmFindReplace_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.Black, 0, 0, this.Width - 1, this.Height - 1);
        }

        private void FrmFindReplace_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isResizing = true;
                lastMouseX = e.X;
                lastMouseY = e.Y;
            }
        }

        private void FrmFindReplace_MouseMove(object sender, MouseEventArgs e)
        {
            if (isResizing)
            {
                int deltaX = e.X - lastMouseX;
                int deltaY = e.Y - lastMouseY;
                this.Width += deltaX;
                this.Height += deltaY;
            }
        }

        private void FrmFindReplace_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isResizing = false;
            }
        }
    }
}
