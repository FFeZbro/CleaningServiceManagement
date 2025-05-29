using System.Drawing;
using System.Windows.Forms;

namespace CleaningServiceManagement.Forms.Common
{
    public partial class ProfileCircle : UserControl
    {
        public ProfileCircle()
        {
            InitializeComponent();
            this.Paint += (s, e) => DrawCircle(e.Graphics);
        }

        private void DrawCircle(Graphics g)
        {
            using (var brush = new SolidBrush(Color.SteelBlue))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.FillEllipse(brush, 0, 0, this.Width - 1, this.Height - 1);
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Invalidate();
        }
    }
}
