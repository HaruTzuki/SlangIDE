using IDE.Preferences;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDE.Controls
{
    public partial class UcTextEditor : UserControl
    {
        [Category("Appearance")]
        [Description("The Control's text.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string EditorText
        {
            get
            {
                return rtb.Text;
            }
            set
            {
                rtb.Text = value;
                ApplySyntaxHighlighting();
            }
        }
        private Dictionary<string, Color> syntaxHighlightingRules;


        public UcTextEditor()
        {
            InitializeComponent();

            // Initialize the syntax highlighting rules
            InitializeSyntaxHighlightingRules();
        }

        private void InitializeSyntaxHighlightingRules()
        {
            syntaxHighlightingRules = new Dictionary<string, Color>
            {
                // PHP keywords
                { "echo", Color.Blue },
                { "if", Color.Blue },
                // Add more keywords here...

                // PHP built-in functions
                { "strpos", Color.DarkOrange },
                // Add more functions here...
            };
        }

        private void ApplySyntaxHighlighting()
        {
            string code = rtb.Text;

            // Clear any previous formatting
            rtb.SelectionStart = 0;
            rtb.SelectionLength = code.Length;
            rtb.SelectionColor = rtb.ForeColor;

            // Loop through each rule and apply formatting
            foreach (var rule in SystemPreferences.SystemDataTypes)
            {
                string pattern = "\\b" + Regex.Escape(rule.Key) + "\\b"; // Match whole word

                MatchCollection matches = Regex.Matches(code, pattern);
                foreach (Match match in matches)
                {
                    rtb.SelectionStart = match.Index;
                    rtb.SelectionLength = match.Length;
                    rtb.SelectionColor = rule.Value;
                }
            }

            foreach (var rule in SystemPreferences.Keywords)
            {
                string pattern = "\\b" + Regex.Escape(rule.Key) + "\\b"; // Match whole word

                MatchCollection matches = Regex.Matches(code, pattern);
                foreach (Match match in matches)
                {
                    rtb.SelectionStart = match.Index;
                    rtb.SelectionLength = match.Length;
                    rtb.SelectionColor = rule.Value;
                }
            }

            foreach (var rule in SystemPreferences.Directives)
            {
                string pattern = "\\b" + Regex.Escape(rule.Key) + "\\b"; // Match whole word

                MatchCollection matches = Regex.Matches(code, pattern);
                foreach (Match match in matches)
                {
                    rtb.SelectionStart = match.Index;
                    rtb.SelectionLength = match.Length;
                    rtb.SelectionColor = rule.Value;
                }
            }

            // Reset the selection to avoid highlighting the entire text
            rtb.SelectionStart = rtb.Text.Length;
            rtb.SelectionLength = 0;
            rtb.SelectionColor = rtb.ForeColor;
        }

        private void UpdateLineNumbers()
        {
            // create a graphics object to use
            Graphics g = rtb.CreateGraphics();

            // get metrics for the font/character
            float fontHeight = rtb.Font.GetHeight(g);

            // start at line 1
            int lineNumber = 1;

            // create an empty string to build our line numbers
            string lineNumbers = "";

            // iterate over each line
            for (float y = 0; y < rtb.Height; y += fontHeight)
            {
                // get the line index for this y pixel coordinate
                int index = rtb.GetCharIndexFromPosition(new Point(0, (int)y));
                // get the line number for this line index
                int lineForIndex = rtb.GetLineFromCharIndex(index);

                // if this is a different line, add the line number to our string
                if (lineForIndex != lineNumber)
                {
                    lineNumber = lineForIndex;
                    lineNumbers += lineNumber.ToString() + "\n";
                }
            }

            // set the text for our line number label
            lineNumberLabel.Text = lineNumbers;

            // clean up the graphics object
            g.Dispose();
        }

        #region Events
        private void rtb_VScroll(object sender, EventArgs e)
        {
            UpdateLineNumbers();
        }

        private void rtb_FontChanged(object sender, EventArgs e)
        {
            UpdateLineNumbers();
        }

        private void rtb_TextChanged(object sender, EventArgs e)
        {
            //ApplySyntaxHighlighting();
            UpdateLineNumbers();
        }
        #endregion

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            Debug.WriteLine(keyData.ToString());
            if(Preferences.Shortcut.EditorsShortcuts.ContainsKey(keyData))
            {
                Preferences.Shortcut.EditorsShortcuts[keyData].Invoke(this.rtb);
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
