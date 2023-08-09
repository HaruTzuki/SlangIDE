using IDE.Abstraction;
using IDE.Helper;

namespace IDE.Views.ToolWindows
{
    public partial class ToolWindowBreakpoints : ToolWindow
    {
        public ToolWindowBreakpoints()
        {
            InitializeComponent();

        }

        public void AddBreakpointToList(string breakpointName, string fileLocation, string lineNumber)
        {
            var ListViewItem = new ListViewItem(breakpointName);
            ListViewItem.SubItems.Add(fileLocation);
            ListViewItem.SubItems.Add(lineNumber);

            BreakpointListView.Items.Add(ListViewItem);
        }

        public void ClearBreakpointList()
        {
            BreakpointListView.Items.Clear();
        }

        private void ToolWindowBreakpoints_Load(object sender, EventArgs e)
        {
            foreach (var breakpoint in Sessions.Breakpoints)
            {
                AddBreakpointToList(breakpoint.Name, breakpoint.FilePath, breakpoint.Line.ToString());
            }
        }

    }
}
