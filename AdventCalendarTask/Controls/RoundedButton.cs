using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Runtime.InteropServices;
using static AdventForm.RoundedPanel;

namespace AdventForm
{
    public partial class RoundedButton : Button
    {
        [Description("Changes the color of the panel."), Category("Appearance")]
        public Color PanelColor { get; set; }

        [Description("Toggles a glassy effect on the panel."), Category("Appearance")]
        public bool Glass { get; set; }

        [Description("Changes the radius of the panel's corners."), Category("Appearance")]
        public int Radius
        {
            get
            {
                return this.borderRadius;
            }
            set
            {
                if (value < 180)
                {
                    borderRadius = value;
                }
            }
        }

        [Description("Changes the size of the panel's border."), Category("Appearance")]
        public int BorderSize
        {
            get
            {
                return this.borderSize;
            }
            set
            {
                borderSize = value;

            }
        }
        
        [Description("Changes the color of the panel's border."), Category("Appearance")]
        public Color BorderColor
        {
            get
            {
                return this.borderColor;
            }
            set
            {
                borderColor = value;
            }
        }

        private int borderSize = 0;
        private int borderRadius = 50;
        private Color borderColor = Color.Transparent;

        public RoundedButton()
        {
            this.DoubleBuffered = true;
            this.FlatStyle = FlatStyle.Flat;
            this.Size = new(150, 40);
            this.BackColor = Color.Gainsboro;
            this.ForeColor = Color.White;
        }

        private void RoundedPanel_Load(object sender, EventArgs e)
        {
        }

        private GraphicsPath GetPath(RectangleF rect, float radius)
        {
            GraphicsPath path = new();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (Glass)
            {
                int r = this.BackColor.R;
                int g = this.BackColor.G;
                int b = this.BackColor.B;

                this.BackColor = Color.FromArgb(125, r, g, b);

                var hr = CreateEllipticRgn(0, 0, Width, Height);
                var dbb = new DwmBlurBehind { FEnable = true, DwFlags = 1, HRgnBlur = hr, FTransitionOnMaximized = false };
                DwmEnableBlurBehindWindow(Handle, ref dbb);
            }

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectSurface = new(0, 0, this.Width, this.Height);
            RectangleF rectBorder = new(1, 1, this.Width - 0.8f, this.Height - 1);

            if (borderRadius > 2)
            {
                using (GraphicsPath surfacePath = GetPath(rectSurface, borderRadius))
                using (GraphicsPath borderPath = GetPath(rectBorder, borderRadius - 1f))
                using (Pen surfacePen = new(this.Parent.BackColor, 2))
                using (Pen borderPen = new(borderColor, borderSize))
                {
                    borderPen.Alignment = PenAlignment.Inset;
                    this.Region = new(surfacePath);

                    e.Graphics.DrawPath(surfacePen, surfacePath);

                    if (borderSize >= 1)
                    {
                        e.Graphics.DrawPath(borderPen, borderPath);
                    }
                }
            }
            else
            {
                this.Region = new(rectSurface);

                if (borderSize >= 1)
                {
                    using (Pen borderPen = new(borderColor, borderSize))
                    {
                        borderPen.Alignment = PenAlignment.Inset;
                        e.Graphics.DrawRectangle(borderPen, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }

        [DllImport("gdi32")]
        private static extern IntPtr CreateEllipticRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect);

        [DllImport("dwmapi")]
        private static extern int DwmEnableBlurBehindWindow(IntPtr hWnd, ref DwmBlurBehind pBlurBehind);

        public struct DwmBlurBehind
        {
            public int DwFlags;
            public bool FEnable;
            public IntPtr HRgnBlur;
            public bool FTransitionOnMaximized;
        }
    }
}

