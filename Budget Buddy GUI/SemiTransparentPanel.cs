using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget_Buddy_GUI
{
    public class SemiTransparentPanel : Panel
    {
        private const int WS_EX_TRANSPARENT = 0x20;
        public SemiTransparentPanel()
        {
            SetStyle(ControlStyles.Opaque, true);
        }

        private int opacity = 50;
        [DefaultValue(50)]
        public int Opacity
        {
            get
            {
                return this.opacity;
            }
            set
            {
                try
                {
                    if (value < 0 || value > 100)
                        throw new ArgumentException("value must be between 0 and 100");
                    this.opacity = value;
                }
                catch(Exception ex)
                {
                    Console.WriteLine("An exception occurred: " + ex.Message);
                }
            }
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle = cp.ExStyle | WS_EX_TRANSPARENT;
                return cp;
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            using (var brush = new SolidBrush(Color.FromArgb(this.opacity * 255 / 100, this.BackColor)))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
            base.OnPaint(e);
        }
    }
}
