using System.ComponentModel;
using System.Runtime.InteropServices;

namespace IDE.Helper.Custom
{
    [TypeConverter(typeof(EditorFormConverter))]
    public class SlangIDEForm : Form
    {
        #region Customisations for Form Maximize, Resize, Painting
        private bool isDragging = false;
        private Point dragOffset;
        private bool isResizing = false;
        private int lastMouseX, lastMouseY;


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
        private const int WM_GETMINMAXINFO = 0x0024;
        #endregion


        protected Panel TitleBar { get; set; }
        protected Panel Body { get; set; }
        protected Button CloseWindow { get; set; }
        protected Button MinimizeWindow { get; set; }
        protected Button MaximizeWindow { get; set; }
        protected Label TitleLabel { get; set; }


        private Color _borderColour = Color.DarkOrange;
        [Browsable(true), Category("Slang IDE Customs"), Description("You can change the border's colour.")]
        public Color BorderColour
        {
            get { return _borderColour; }
            set { _borderColour = value; }
        }

        [Browsable(true), Category("Slang IDE Customs")]
        public string FormTitle
        {
            get
            {
                return TitleLabel.Text;
            }
            set
            {
                TitleLabel.Text = value;
            }
        }

        [Browsable(true), Category("Slang IDE Customs")]
        public bool AllowMaximize
        {
            get
            {
                return MaximizeWindow.Visible;
            }
            set
            {
                MaximizeWindow.Visible = value;
            }
        }

        [Browsable(true), Category("Slang IDE Customs")]
        public bool AllowMinimize
        {
            get => MinimizeWindow.Visible;
            set
            {
                MinimizeWindow.Visible = value;
            }
        }
        private bool _allowResizing = true;
        [Browsable(true), Category("Slang IDE Customs")]
        public bool AllowResizing
        {
            get
            {
                return _allowResizing;
            }
            set
            {
                _allowResizing = value;
            }
        }

        private FormClosingOperations _formClosingOperations;
        [Browsable(true), Category("Slang IDE Customs")]
        public FormClosingOperations FormClosingOperations
        {
            get
            {
                return _formClosingOperations;
            }
            set
            {
                _formClosingOperations = value;
            }
        }

        

        public SlangIDEForm()
        {
            InitialiseComponents();
            this.FormBorderStyle = FormBorderStyle.None;

        }

        private void InitialiseComponents()
        {
            this.BackColor = Color.FromArgb(31, 31, 31);

            /* Title Bar */
            TitleBar = new Panel();
            TitleBar.Name = "TitleBar";
            TitleBar.Dock = DockStyle.Top;
            TitleBar.Height = 32;
            TitleBar.MouseDown += TitleBar_MouseDown;
            TitleBar.MouseMove += TitleBar_MouseMove;
            TitleBar.MouseUp += TitleBar_MouseUp;

            /* Close Button*/
            CloseWindow = new Button();
            CloseWindow.Name = "BtnClose";
            CloseWindow.Dock = DockStyle.Right;
            CloseWindow.Size = new Size(52, 32);
            CloseWindow.Text = CloseWindow.Image is null ? "X" : string.Empty;
            CloseWindow.FlatStyle = FlatStyle.Flat;
            CloseWindow.FlatAppearance.BorderSize = 0;
            CloseWindow.ForeColor = Color.WhiteSmoke;
            CloseWindow.Click += CloseWindow_Click;

            /* Maximize Window */
            MaximizeWindow = new Button();
            MaximizeWindow.Name = "BtnMaximize";
            MaximizeWindow.Dock = DockStyle.Right;
            MaximizeWindow.Size = new Size(52, 32);
            MaximizeWindow.Text = MaximizeWindow.Image is null ? "[]" : string.Empty;
            MaximizeWindow.FlatStyle = FlatStyle.Flat;
            MaximizeWindow.FlatAppearance.BorderSize = 0;
            MaximizeWindow.ForeColor = Color.WhiteSmoke;
            MaximizeWindow.Click += MaximizeWindow_Click;

            /* Minimize Window */
            MinimizeWindow = new Button();
            MinimizeWindow.Name = "BtnMinimize";
            MinimizeWindow.Dock = DockStyle.Right;
            MinimizeWindow.Size = new Size(52, 32);
            MinimizeWindow.Text = MinimizeWindow.Image is null ? "-" : string.Empty;
            MinimizeWindow.FlatStyle = FlatStyle.Flat;
            MinimizeWindow.FlatAppearance.BorderSize = 0;
            MinimizeWindow.ForeColor = Color.WhiteSmoke;
            MinimizeWindow.Click += MinimizeWindow_Click;

            /* Title Label */
            TitleLabel = new Label();
            TitleLabel.Name = "LblTitle";
            TitleLabel.Text = this.Text;
            TitleLabel.AutoSize = false;
            TitleLabel.Dock = DockStyle.Fill;
            TitleLabel.TextAlign = ContentAlignment.MiddleLeft;
            TitleLabel.ForeColor = Color.WhiteSmoke;

            TitleBar.Controls.Add(TitleLabel);
            TitleBar.Controls.Add(MinimizeWindow);
            TitleBar.Controls.Add(MaximizeWindow);
            TitleBar.Controls.Add(CloseWindow);

            this.Controls.Add(TitleBar);

            /* Panel Body */
            //Body = new Panel();
            //TitleBar.Name = "Body";
            //TitleBar.Dock = DockStyle.Fill;

            //Controls.Add(Body);
            Controls.Add(TitleBar);

            this.Padding = new Padding(1);
            this.Paint += SlangIDEForm_Paint;
            this.Resize += SlangIDEForm_Resize;
            this.MouseDown += SlangIDEForm_MouseDown;
            this.MouseMove += SlangIDEForm_MouseMove;
            this.MouseUp += SlangIDEForm_MouseUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #region Form Resizing Events
        private void SlangIDEForm_MouseUp(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isResizing = false;
            }
        }

        private void SlangIDEForm_MouseMove(object? sender, MouseEventArgs e)
        {
            if (isResizing)
            {
                int deltaX = e.X - lastMouseX;
                int deltaY = e.Y - lastMouseY;
                this.Width += deltaX;
                this.Height += deltaY;
            }
        }

        private void SlangIDEForm_MouseDown(object? sender, MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Left && _allowResizing)
            //{
            //    isResizing = true;
            //    lastMouseX = e.X;
            //    lastMouseY = e.Y;
            //}
        }

        private void SlangIDEForm_Resize(object? sender, EventArgs e)
        {
            this.Invalidate();
        }

        protected override void WndProc(ref Message m)
        {

            switch (m.Msg)
            {
                case WM_GETMINMAXINFO when _allowResizing:
                    MINMAXINFO mmi = (MINMAXINFO)Marshal.PtrToStructure(m.LParam, typeof(MINMAXINFO));

                    // Adjust the maximum size of the window
                    mmi.ptMaxTrackSize.x = Screen.PrimaryScreen.WorkingArea.Width;
                    mmi.ptMaxTrackSize.y = Screen.PrimaryScreen.WorkingArea.Height;

                    Marshal.StructureToPtr(mmi, m.LParam, true);
                    break;
                case WM_NCHITTEST when _allowResizing:
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
        #endregion

        #region Form's Moving Events
        private void TitleBar_MouseUp(object? sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void TitleBar_MouseMove(object? sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point newLocation = this.PointToScreen(e.Location);
                newLocation.Offset(-dragOffset.X, -dragOffset.Y);
                this.Location = newLocation;
            }
        }

        private void TitleBar_MouseDown(object? sender, MouseEventArgs e)
        {
            isDragging = true;
            dragOffset = e.Location;
        }
        #endregion

        #region Buttons Functionalities
        private void MinimizeWindow_Click(object? sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MaximizeWindow_Click(object? sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void CloseWindow_Click(object? sender, EventArgs e)
        {
            if (_formClosingOperations == FormClosingOperations.CloseWindow)
                this.Close();
            else
                Application.Exit();
        }
        #endregion

        #region Border Color
        private void SlangIDEForm_Paint(object? sender, PaintEventArgs e)
        {
            Pen actualBorderColour = new Pen(_borderColour);
            e.Graphics.DrawRectangle(actualBorderColour, 0, 0, this.Width - 1, this.Height - 1);
        }
        #endregion
    }

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
}
