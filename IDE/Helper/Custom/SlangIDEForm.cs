using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace IDE.Helper.Custom
{
    public class SlangIDEForm : Form
    {
        protected Panel TitleBar { get; set; }
        protected Button CloseWindow { get; set; }
        protected Button MinimizeWindow { get; set; }
        protected Button MaximizeWindow { get; set; }
        protected Label TitleLabel { get; set; }


        public SlangIDEForm()
        {
            InitialiseComponents();
            this.FormBorderStyle = FormBorderStyle.None;
            
        }

        private void InitialiseComponents()
        {
            this.BackColor = Color.FromArgb(31,31,31);

            /* Title Bar */
            TitleBar = new Panel();
            TitleBar.Name = "TitleBar";
            TitleBar.Dock = DockStyle.Top;
            TitleBar.Height = 32;
            
            /* Close Button*/
            CloseWindow = new Button();
            CloseWindow.Name = "BtnClose";
            CloseWindow.Dock = DockStyle.Right;
            CloseWindow.Size = new Size(52, 32);
            CloseWindow.Text = CloseWindow.Image is null ? "X" : string.Empty;
            CloseWindow.FlatStyle = FlatStyle.Flat;
            CloseWindow.FlatAppearance.BorderSize = 0;
            CloseWindow.BackColor = Color.WhiteSmoke;
            
            /* Maximize Window */
            MaximizeWindow = new Button();
            MaximizeWindow.Name = "BtnMaximize";
            MaximizeWindow.Dock = DockStyle.Right;
            MaximizeWindow.Size = new Size(52,32);
            MaximizeWindow.Text = MaximizeWindow.Image is null ? "[]" : string.Empty;
            MaximizeWindow.FlatStyle = FlatStyle.Flat;
            MaximizeWindow.FlatAppearance.BorderSize = 0;
            MaximizeWindow.BackColor = Color.WhiteSmoke;

            /* Minimize Window */
            MinimizeWindow = new Button();
            MinimizeWindow.Name = "BtnMinimize";
            MinimizeWindow.Dock = DockStyle.Right;
            MinimizeWindow.Size = new Size(52, 32);
            MinimizeWindow.Text = MinimizeWindow.Image is null ? "-" : string.Empty;
            MinimizeWindow.FlatStyle = FlatStyle.Flat;
            MinimizeWindow.FlatAppearance.BorderSize = 0;
            MinimizeWindow.BackColor = Color.WhiteSmoke;

            /* Title Label */
            TitleLabel = new Label();
            TitleLabel.Name = "LblTitle";
            TitleLabel.Text = this.Text;
            TitleLabel.AutoSize = false;
            TitleLabel.Dock = DockStyle.Left;
            TitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            TitleLabel.BackColor = Color.WhiteSmoke;

            TitleBar.Controls.Add(TitleLabel);
            TitleBar.Controls.Add(MinimizeWindow);
            TitleBar.Controls.Add(MaximizeWindow);
            TitleBar.Controls.Add(CloseWindow);

            this.Controls.Add(TitleBar);
        }
    }
}
