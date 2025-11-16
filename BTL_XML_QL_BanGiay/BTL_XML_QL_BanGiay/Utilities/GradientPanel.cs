using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_XML_QL_BanGiay.Utilities
{
    class GradientPanel:Panel
    {
        public Color ColorTop { get; set; } = Color.FromArgb(118, 240, 210);
        public Color ColorBottom { get; set; } = Color.FromArgb(0, 200, 180);

        protected override void OnPaint(PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(
                this.ClientRectangle,
                ColorTop,
                ColorBottom,
                90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
            base.OnPaint(e);
        }
    }
}
