﻿namespace CSCodeGen.Ui
{
    class Renderer : ToolStripProfessionalRenderer
    {
        protected override void OnRenderButtonBackground(ToolStripItemRenderEventArgs e)
        {
            if (!e.Item.Selected)
            {
                base.OnRenderButtonBackground(e);
            }
            else
            {
                Rectangle rectangle = new Rectangle(0, 0, e.Item.Size.Width - 1, e.Item.Size.Height - 1);
                e.Graphics.FillRectangle(Brushes.LightSlateGray, rectangle);
                e.Graphics.DrawRectangle(Pens.Gray, rectangle);
            }
        }
    }

}
