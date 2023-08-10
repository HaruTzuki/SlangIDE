using System.ComponentModel;
using System.Runtime.InteropServices;

namespace IDE.Helper.Custom
{
    [TypeConverter(typeof(EditorFormConverter))]
    //[Designer(typeof(SlangIDEFormDesigner))]
    public class SlangIDEForm : Form
    {
        #region Customisations for Form Maximize, Resize, Painting
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

        private bool _allowResizing;
        [Browsable(true), Category("SlangCustom")]
        public bool AllowResizing
        {
            get { return _allowResizing; }
            set { _allowResizing = value; }
        }


        private Color _borderColour = Color.DarkOrange;
        [Browsable(true), Category("SlangCustom"), Description("You can change the border's colour.")]
        public Color BorderColour
        {
            get { return _borderColour; }
            set { _borderColour = value; }
        }

        public SlangIDEForm()
        {
            InitialiseComponents();
            this.FormBorderStyle = FormBorderStyle.None;

        }

        private void InitialiseComponents()
        {
            this.BackColor = Color.FromArgb(31, 31, 31);
            this.Padding = new Padding(1);
            this.Paint += SlangIDEForm_Paint;
            this.Resize += SlangIDEForm_Resize;
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


        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // SlangIDEForm
            // 
            this.ClientSize = new System.Drawing.Size(695, 412);
            this.Name = "SlangIDEForm";
            this.ResumeLayout(false);

        }

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

    //public class SlangIDEFormDesigner : ParentControlDesigner
    //{
    //    IDesignerHost designerHost;
    //    public override void Initialize(IComponent component)
    //    {
    //        base.Initialize(component);
    //        base.AutoResizeHandles = true;
    //        base.EnableDesignMode(((SlangIDEForm)component).Body, "Body");
    //        designerHost = (IDesignerHost)component.Site.GetService(typeof(IDesignerHost));
    //    }

    //    public override bool CanParent(Control control)
    //    {
    //        return false;
    //    }

    //    public override System.Collections.ICollection AssociatedComponents
    //    {
    //        get
    //        {
    //            List<Control> list = new List<Control>();
    //            foreach (Control control in ((SlangIDEForm)Control).Body.Controls)
    //            {
    //                list.Add(control);
    //            }
    //            return list;
    //        }
    //    }

    //    protected override Control GetParentForComponent(IComponent component)
    //    {
    //        return ((SlangIDEForm)Control).Body;
    //    }

    //    public override int NumberOfInternalControlDesigners()
    //    {
    //        return 1;
    //    }

    //    public override ControlDesigner InternalControlDesigner(int internalControlIndex)
    //    {
    //        Control panel = ((SlangIDEForm)Control).Body;
    //        switch (internalControlIndex)
    //        {
    //            case 0:
    //                return this.designerHost.GetDesigner(panel) as ControlDesigner;
    //            default:
    //                return null;
    //        }
    //    }

    //    protected override IComponent[] CreateToolCore(ToolboxItem tool, int x, int y, int width, int height, bool hasLocation, bool hasSize)
    //    {
    //        ParentControlDesigner panelDesigner = this.designerHost.GetDesigner(((SlangIDEForm)Control).Body) as ParentControlDesigner;
    //        InvokeCreateTool(panelDesigner, tool);
    //        return null;
    //    }
    //}
}
