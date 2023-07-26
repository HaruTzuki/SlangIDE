using System.Collections;
using System.ComponentModel;
using System.Drawing.Design;
using System.Reflection;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace IDE.Helper.Custom
{
    [Designer(typeof(CustomUIDesigner))]
    public partial class CustomUI : UserControl
    {

        #region Moving
        private bool isDragging = false;
        private Point dragOffset;
        #endregion


        [Browsable(true), Category("SlangCustom")]
        public bool AllowMinimize
        {
            get { return BtnMinimize.Visible; }
            set { BtnMinimize.Visible = value; }
        }

        [Browsable(true), Category("SlangCustom")]
        public bool AllowMaximize
        {
            get { return BtnMaximize.Visible; }
            set { BtnMaximize.Visible = value; }
        }

        [Browsable(true), Category("SlangCustom")]
        public string Title
        {
            get { return HeaderTitle.Text; }
            set { HeaderTitle.Text = value; }
        }

        private FormClosingOperations _formClosingOperation = FormClosingOperations.CloseWindow;
        [Browsable(true), Category("SlangCustom")]
        public FormClosingOperations FormClosingOperation
        {
            get { return _formClosingOperation; }
            set { _formClosingOperation = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public Panel ContentsPanel
        {
            get { return Body; }
        }

        public CustomUI()
        {
            InitializeComponent();
            TypeDescriptor.AddAttributes(this.Body,
            new DesignerAttribute(typeof(MyPanelDesigner)));
            MainMenu.Renderer = new DarkThemeRenderer();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            if (_formClosingOperation == FormClosingOperations.CloseWindow)
                this.ParentForm.Close();
            else
                Application.Exit();
        }

        private void BtnMaximize_Click(object sender, EventArgs e)
        {
            if (this.ParentForm.WindowState == FormWindowState.Maximized)
                this.ParentForm.WindowState = FormWindowState.Normal;
            else
                this.ParentForm.WindowState = FormWindowState.Maximized;
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.ParentForm.WindowState = FormWindowState.Minimized;
        }

        private void MainMenu_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void MainMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                //if (this.ParentForm.WindowState == FormWindowState.Maximized) this.ParentForm.WindowState = FormWindowState.Normal;
                Point newLocation = this.ParentForm.PointToScreen(e.Location);
                newLocation.Offset(-dragOffset.X, -dragOffset.Y);
                this.ParentForm.Location = newLocation;
            }
        }

        private void MainMenu_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            dragOffset = e.Location;
        }

        private void MainMenu_DoubleClick(object sender, EventArgs e)
        {
            Maximise();
        }

        private void Maximise()
        {
            if (this.ParentForm.WindowState == FormWindowState.Maximized)
                this.ParentForm.WindowState = FormWindowState.Normal;
            else
                this.ParentForm.WindowState = FormWindowState.Maximized;
        }
    }

    public class CustomUIDesigner : ParentControlDesigner
    {
        public override void Initialize(IComponent component)
        {
            base.Initialize(component);
            var contentsPanel = ((CustomUI)this.Control).ContentsPanel;
            this.EnableDesignMode(contentsPanel, "ContentsPanel");
        }
        public override bool CanParent(Control control)
        {
            return false;
        }
        protected override void OnDragOver(DragEventArgs de)
        {
            de.Effect = DragDropEffects.None;
        }
        protected override IComponent[] CreateToolCore(ToolboxItem tool,
            int x, int y, int width, int height, bool hasLocation, bool hasSize)
        {
            return null;
        }
    }

    public class MyPanelDesigner : ParentControlDesigner
    {
        public override SelectionRules SelectionRules
        {
            get
            {
                SelectionRules selectionRules = base.SelectionRules;
                selectionRules &= ~SelectionRules.AllSizeable;
                return selectionRules;
            }
        }
        protected override void PostFilterAttributes(IDictionary attributes)
        {
            base.PostFilterAttributes(attributes);
            attributes[typeof(DockingAttribute)] = new DockingAttribute(DockingBehavior.Never);
        }
        protected override void PostFilterProperties(IDictionary properties)
        {
            base.PostFilterProperties(properties);
            var propertiesToRemove = new string[] {
            "Dock", "Anchor",
            "Size", "Location", "Width", "Height",
            "MinimumSize", "MaximumSize",
            "AutoSize", "AutoSizeMode",
            "Visible", "Enabled",
        };
            foreach (var item in propertiesToRemove)
            {
                if (properties.Contains(item))
                    properties[item] = TypeDescriptor.CreateProperty(this.Component.GetType(),
                        (PropertyDescriptor)properties[item],
                        new BrowsableAttribute(false));
            }
        }
    }

    public class DarkThemeRenderer : ToolStripProfessionalRenderer
    {

        public DarkThemeRenderer() : base(new MyColor())
        {

        }

        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            Rectangle rc = new Rectangle(Point.Empty, e.Item.Size);
            Color c = e.Item.Selected ? Color.FromArgb(61, 61, 61) : Color.FromArgb(31, 31, 31);
            using (SolidBrush brush = new SolidBrush(c))
                e.Graphics.FillRectangle(brush, rc);
        }

        protected override void OnRenderSeparator(ToolStripSeparatorRenderEventArgs e)
        {
            if (!e.Vertical || (e.Item as ToolStripSeparator) == null)
                base.OnRenderSeparator(e);
            else
            {
                Rectangle bounds = new Rectangle(Point.Empty, e.Item.Size);
                bounds.Y += 3;
                bounds.Height = Math.Max(0, bounds.Height - 6);
                if (bounds.Height >= 4) bounds.Inflate(0, -2);
                Pen pen = new Pen(Color.FromArgb(31, 31, 31));
                int x = bounds.Width / 2;
                e.Graphics.DrawLine(pen, x, bounds.Top, x, bounds.Bottom - 1);
                pen.Dispose();
                pen = new Pen(Color.FromArgb(61, 61, 61));
                e.Graphics.DrawLine(pen, x + 1, bounds.Top + 1, x + 1, bounds.Bottom);
                pen.Dispose();
            }
        }

        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
        {
            // Keep all borders but remove the left border for ToolStripMenuItems
            Rectangle borderRect = new Rectangle(Point.Empty, e.ToolStrip.Size);

            // Draw the top border
            using (Pen pen = new Pen(Color.FromArgb(31, 31, 31)))
            {
                e.Graphics.DrawLine(pen, borderRect.Left, borderRect.Top, borderRect.Right - 1, borderRect.Top);
            }

            // Draw the bottom border
            using (Pen pen = new Pen(Color.FromArgb(31, 31, 31)))
            {
                e.Graphics.DrawLine(pen, borderRect.Left, borderRect.Bottom - 1, borderRect.Right - 1, borderRect.Bottom - 1);
            }

            // Draw the right border
            using (Pen pen = new Pen(Color.FromArgb(31, 31, 31)))
            {
                e.Graphics.DrawLine(pen, borderRect.Right - 1, borderRect.Top, borderRect.Right - 1, borderRect.Bottom - 1);
            }
        }
    }

    public class MyColor : ProfessionalColorTable
    {
        public override Color MenuBorder => Color.FromArgb(31, 31, 31);
        public override Color MenuItemBorder => Color.FromArgb(31,31,31);
    }
}

