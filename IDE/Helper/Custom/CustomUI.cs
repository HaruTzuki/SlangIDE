using System.Collections;
using System.ComponentModel;
using System.Drawing.Design;
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
            get { return BtnMinimize.Visible; } set {  BtnMinimize.Visible = value; }
        }

        [Browsable(true), Category("SlangCustom")]
        public bool AllowMaximize
        {
            get { return BtnMaximize.Visible; } set { BtnMaximize.Visible = value; }
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
            get { return _formClosingOperation; } set { _formClosingOperation = value; }
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
}
