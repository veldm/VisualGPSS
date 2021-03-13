﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualGPSS
{
    public partial class Main : MaterialSkin.Controls.MaterialForm
    {
        private void UpScale(object sender, EventArgs e)
        {
            double _scale = double.Parse(scaleCB.Text.Substring(0, scaleCB.Text.Length - 1)) + 10;
            scaleCB.Text = $"{_scale}%";
        }

        private void DownScale(object sender, EventArgs e)
        {
            double _scale = double.Parse(scaleCB.Text.Substring(0, scaleCB.Text.Length - 1)) - 10;
            scaleCB.Text = $"{_scale}%";
        }

        private void ScaleChanged(object sender, EventArgs e)
        {
            scale = double.Parse(scaleCB.Text.Substring(0, scaleCB.Text.Length - 1)) / 100;
            graphicsRefresh(sender, e);
        }
    }
}
