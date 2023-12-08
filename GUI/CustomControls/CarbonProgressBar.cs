using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Carbon.Launcher.GUI.CustomControls
{
    public class CarbonProgressBar : ProgressBar
    {
        public CarbonProgressBar()
        {
            this.BackColor = Color.Black;
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rec = e.ClipRectangle;

            rec.Width = (int)(rec.Width * ((double)Value / Maximum)) - 4;
            if (ProgressBarRenderer.IsSupported)
                ProgressBarRenderer.DrawHorizontalBar(e.Graphics, e.ClipRectangle);

            rec.Height = rec.Height - 4;
            e.Graphics.FillRectangle(Brushes.Green, 2, 2, rec.Width, rec.Height);
        }
    }
}
