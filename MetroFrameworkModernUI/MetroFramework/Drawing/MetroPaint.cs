﻿/**
 * MetroFramework - Modern UI for WinForms
 * 
 * The MIT License (MIT)
 * Copyright (c) 2011 Sven Walter, http://github.com/viperneo
 * Copyright (c) 2016 Angelo Cresta, http://quarztech.com
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy of 
 * this software and associated documentation files (the "Software"), to deal in the 
 * Software without restriction, including without limitation the rights to use, copy, 
 * modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, 
 * and to permit persons to whom the Software is furnished to do so, subject to the 
 * following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in 
 * all copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, 
 * INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A 
 * PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT 
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF 
 * CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE 
 * OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

namespace MetroFramework.Drawing
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public class MetroPaintEventArgs : EventArgs
    {
        public Color BackColor { get; private set; }
        public Color ForeColor { get; private set; }
        public Graphics Graphics { get; private set; }

        public MetroPaintEventArgs(Color backColor, Color foreColor, Graphics g)
        {
            BackColor = backColor;
            ForeColor = foreColor;
            Graphics = g;
        }
    }

    public sealed class MetroPaint
    {
        #region ... Border Colors ...
        public sealed class BorderColor
        {
            public static Color Form(MetroThemeStyle theme)
            {
                if (theme == MetroThemeStyle.Dark)
                    return Color.FromArgb(68, 68, 68);

                return Color.FromArgb(204, 204, 204);
            }

            public static class ScrollBar
            {
                public static Color Normal(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(17, 17, 17);

                    return Color.FromArgb(155, 155, 155);
                }
            }


            public static class Panel
            {
                public static Color Normal(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(68, 68, 68);

                    return Color.FromArgb(204, 204, 204);
                }

                public static Color Disabled(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(109, 109, 109);

                    return Color.FromArgb(155, 155, 155);
                }
            }

            public static class DataGrid
            {
                public static Color GridColor(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(68, 68, 68);

                    return Color.FromArgb(204, 204, 204);
                }
            }

            public static class KnobControl
            {
                public static Color Normal(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(68, 68, 68);

                    return Color.FromArgb(204, 204, 204);
                }
            }

            public static class NumericUpDown
            {
                public static Color Normal(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(68, 68, 68);

                    return Color.FromArgb(204, 204, 204);
                }
                public static Color Hot(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.Black;

                    return Color.White;
                }
            }

            public static class GroupBox
            {
                public static Color Normal(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(68, 68, 68);

                    return Color.FromArgb(204, 204, 204);
                }

                public static Color Shadow(MetroThemeStyle theme)
                {
                    return ControlPaint.Light(Normal(theme));
                }

                public static Color Disabled(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(109, 109, 109);

                    return Color.FromArgb(155, 155, 155);
                }
            }

            public static class SplitContainer
            {
                public static Color Normal(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(68, 68, 68);

                    return Color.FromArgb(204, 204, 204);
                }

                public static Color Disabled(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(109, 109, 109);

                    return Color.FromArgb(155, 155, 155);
                }
            }

            public static class PropertyGrid
            {
                public static Color Normal(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(68, 68, 68);

                    return Color.FromArgb(204, 204, 204);
                }

                public static Color Disabled(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(109, 109, 109);

                    return Color.FromArgb(155, 155, 155);
                }
            }
            public static class Button
            {
                public static Color Normal(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(68, 68, 68);

                    return Color.FromArgb(204, 204, 204);
                }

                public static Color Hover(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(170, 170, 170);

                    return Color.FromArgb(102, 102, 102);
                }

                public static Color Press(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(238, 238, 238);

                    return Color.FromArgb(51, 51, 51);
                }

                public static Color Disabled(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(109, 109, 109);

                    return Color.FromArgb(155, 155, 155);
                }
            }

            public static class CheckBox
            {
                public static Color Normal(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(153, 153, 153);

                    return Color.FromArgb(153, 153, 153);
                }

                public static Color Hover(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(204, 204, 204);

                    return Color.FromArgb(51, 51, 51);
                }

                public static Color Press(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(153, 153, 153);

                    return Color.FromArgb(153, 153, 153);
                }

                public static Color Disabled(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(85, 85, 85);

                    return Color.FromArgb(204, 204, 204);
                }
            }

            public static class ComboBox
            {
                public static Color Normal(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(153, 153, 153);

                    return Color.FromArgb(153, 153, 153);
                }

                public static Color Hover(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(204, 204, 204);

                    return Color.FromArgb(51, 51, 51);
                }

                public static Color Press(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(153, 153, 153);

                    return Color.FromArgb(153, 153, 153);
                }

                public static Color Disabled(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(85, 85, 85);

                    return Color.FromArgb(204, 204, 204);
                }
            }

            public static class ProgressBar
            {
                public static Color Normal(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(68, 68, 68);

                    return Color.FromArgb(204, 204, 204);
                }

                public static Color Hover(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(68, 68, 68);

                    return Color.FromArgb(204, 204, 204);
                }

                public static Color Press(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(68, 68, 68);

                    return Color.FromArgb(204, 204, 204);
                }

                public static Color Disabled(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(109, 109, 109);

                    return Color.FromArgb(155, 155, 155);
                }
            }

            public static class TabControl
            {
                public static Color Normal(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(68, 68, 68);

                    return Color.FromArgb(204, 204, 204);
                }

                public static Color Hover(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(68, 68, 68);

                    return Color.FromArgb(204, 204, 204);
                }

                public static Color Press(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(68, 68, 68);

                    return Color.FromArgb(204, 204, 204);
                }

                public static Color Disabled(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(109, 109, 109);

                    return Color.FromArgb(155, 155, 155);
                }
            }
        }
        #endregion

        #region ... Back Colors ...
        public sealed class BackColor
        {
            public static Color Form(MetroThemeStyle theme)
            {
                if (theme == MetroThemeStyle.Dark)
                    return Color.FromArgb(17, 17, 17);

                return Color.FromArgb(255, 255, 255);
            }

            public static class Panel
            {
                public static Color Normal(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(17, 17, 17);

                    return Color.FromArgb(255, 255, 255);
                }
            }

            public static class DataGrid
            {
                public static Color Normal(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(17, 17, 17);

                    return Color.FromArgb(255, 255, 255);
                }
                public static Color Background(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(17, 17, 17);

                    return Color.FromArgb(255, 255, 255);
                }
                public static Color DefaultCellStyle(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(17, 17, 17);

                    return Color.FromArgb(255, 255, 255);
                }
                public static Color ColumnHeadersDefaultCellStyle(MetroThemeStyle theme, MetroColorStyle style)
                {
                    return MetroPaint.GetStyleColor(style);
                }

                public static Color RowHeadersDefaultCellStyle(MetroThemeStyle theme, MetroColorStyle style)
                {
                    return MetroPaint.GetStyleColor(style);
                }

                public static Color DefaultCellStyleSelectionBackColor(MetroThemeStyle theme, MetroColorStyle style)
                {
                    return MetroPaint.GetStyleColor(style);
                }

                public static Color RowHeadersDefaultCellStyleSelectionBackColor(MetroThemeStyle theme, MetroColorStyle style)
                {
                    return MetroPaint.GetStyleColor(style);
                }
                public static Color ColumnHeadersDefaultCellStyleSelectionBackColor(MetroThemeStyle theme, MetroColorStyle style)
                {
                    return MetroPaint.GetStyleColor(style);
                }
            }

            public static class KnobControl
            {
                public static Color Normal(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(17, 17, 17);

                    return Color.FromArgb(255, 255, 255);
                }
            }
            public static class NumericUpDown
            {
                public static Color Normal(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(34, 34, 34);

                    return Color.FromArgb(238, 238, 238);
                }
                public static Color Alternate(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(17, 17, 17);

                    return Color.FromArgb(255, 255, 255);
                }
            }

            public static class GroupBox
            {
                public static Color Normal(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(17, 17, 17);

                    return Color.FromArgb(255, 255, 255);
                }

                public static Color Disabled(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(109, 109, 109);

                    return Color.FromArgb(155, 155, 155);
                }
            }

            public static class SplitContainer
            {
                public static Color Normal(MetroThemeStyle theme)
                {
                    return BorderColor.SplitContainer.Normal(theme);
                }

                public static Color Disabled(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(109, 109, 109);

                    return Color.FromArgb(155, 155, 155);
                }
            }
            public sealed class PropertyGrid
            {
                public static Color Normal(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(34, 34, 34);

                    return Color.FromArgb(238, 238, 238);
                }

                public static Color Disabled(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(80, 80, 80);

                    return Color.FromArgb(204, 204, 204);
                }
            }

            public sealed class Button
            {
                public static Color Normal(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(34, 34, 34);

                    return Color.FromArgb(238, 238, 238);
                }

                public static Color Normal2(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(68, 68, 68);

                    return Color.FromArgb(208, 208, 208);
                }

                public static Color Hover(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(170, 170, 170);

                    return Color.FromArgb(102, 102, 102);
                }

                public static Color Hover2(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(190, 190, 190);

                    return Color.FromArgb(82, 82, 82);
                }

                public static Color Press(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(238, 238, 238);

                    return Color.FromArgb(51, 51, 51);
                }

                public static Color Press2(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(248, 248, 248);

                    return Color.FromArgb(31, 31, 31);
                }

                public static Color Disabled(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(80, 80, 80);

                    return Color.FromArgb(204, 204, 204);
                }
            }

            public sealed class TrackBar
            {
                public sealed class Thumb
                {
                    public static Color Normal(MetroThemeStyle theme)
                    {
                        if (theme == MetroThemeStyle.Dark)
                            return Color.FromArgb(153, 153, 153);

                        return Color.FromArgb(102, 102, 102);
                    }

                    public static Color Hover(MetroThemeStyle theme)
                    {
                        if (theme == MetroThemeStyle.Dark)
                            return Color.FromArgb(204, 204, 204);

                        return Color.FromArgb(17, 17, 17);
                    }

                    public static Color Press(MetroThemeStyle theme)
                    {
                        if (theme == MetroThemeStyle.Dark)
                            return Color.FromArgb(204, 204, 204);

                        return Color.FromArgb(17, 17, 17);
                    }

                    public static Color Disabled(MetroThemeStyle theme)
                    {
                        if (theme == MetroThemeStyle.Dark)
                            return Color.FromArgb(85, 85, 85);

                        return Color.FromArgb(179, 179, 179);
                    }
                }

                public sealed class Bar
                {
                    public static Color Normal(MetroThemeStyle theme)
                    {
                        if (theme == MetroThemeStyle.Dark)
                            return Color.FromArgb(51, 51, 51);

                        return Color.FromArgb(204, 204, 204);
                    }

                    public static Color Hover(MetroThemeStyle theme)
                    {
                        if (theme == MetroThemeStyle.Dark)
                            return Color.FromArgb(51, 51, 51);

                        return Color.FromArgb(204, 204, 204);
                    }

                    public static Color Press(MetroThemeStyle theme)
                    {
                        if (theme == MetroThemeStyle.Dark)
                            return Color.FromArgb(51, 51, 51);

                        return Color.FromArgb(204, 204, 204);
                    }

                    public static Color Disabled(MetroThemeStyle theme)
                    {
                        if (theme == MetroThemeStyle.Dark)
                            return Color.FromArgb(34, 34, 34);

                        return Color.FromArgb(230, 230, 230);
                    }
                }
            }

            public sealed class ScrollBar
            {
                public sealed class Thumb
                {
                    public static Color Normal(MetroThemeStyle theme)
                    {
                        if (theme == MetroThemeStyle.Dark)
                            return Color.FromArgb(51, 51, 51);

                        return Color.FromArgb(221, 221, 221);
                    }

                    public static Color Hover(MetroThemeStyle theme)
                    {
                        if (theme == MetroThemeStyle.Dark)
                            return Color.FromArgb(204, 204, 204);

                        return Color.FromArgb(17, 17, 17);
                    }

                    public static Color Press(MetroThemeStyle theme)
                    {
                        if (theme == MetroThemeStyle.Dark)
                            return Color.FromArgb(204, 204, 204);

                        return Color.FromArgb(17, 17, 17);
                    }

                    public static Color Disabled(MetroThemeStyle theme)
                    {
                        if (theme == MetroThemeStyle.Dark)
                            return Color.FromArgb(51, 51, 51);

                        return Color.FromArgb(221, 221, 221);
                    }
                }

                public sealed class Bar
                {
                    public static Color Normal(MetroThemeStyle theme)
                    {
                        if (theme == MetroThemeStyle.Dark)
                            return Color.FromArgb(38, 38, 38);

                        return Color.FromArgb(234, 234, 234);
                    }

                    public static Color Hover(MetroThemeStyle theme)
                    {
                        if (theme == MetroThemeStyle.Dark)
                            return Color.FromArgb(38, 38, 38);

                        return Color.FromArgb(234, 234, 234);
                    }

                    public static Color Press(MetroThemeStyle theme)
                    {
                        if (theme == MetroThemeStyle.Dark)
                            return Color.FromArgb(38, 38, 38);

                        return Color.FromArgb(234, 234, 234);
                    }

                    public static Color Disabled(MetroThemeStyle theme)
                    {
                        if (theme == MetroThemeStyle.Dark)
                            return Color.FromArgb(38, 38, 38);

                        return Color.FromArgb(234, 234, 234);
                    }
                }
            }

            public sealed class ProgressBar
            {
                public sealed class Bar
                {
                    public static Color Normal(MetroThemeStyle theme)
                    {
                        if (theme == MetroThemeStyle.Dark)
                            return Color.FromArgb(38, 38, 38);

                        return Color.FromArgb(234, 234, 234);
                    }

                    public static Color Hover(MetroThemeStyle theme)
                    {
                        if (theme == MetroThemeStyle.Dark)
                            return Color.FromArgb(38, 38, 38);

                        return Color.FromArgb(234, 234, 234);
                    }

                    public static Color Press(MetroThemeStyle theme)
                    {
                        if (theme == MetroThemeStyle.Dark)
                            return Color.FromArgb(38, 38, 38);

                        return Color.FromArgb(234, 234, 234);
                    }

                    public static Color Disabled(MetroThemeStyle theme)
                    {
                        if (theme == MetroThemeStyle.Dark)
                            return Color.FromArgb(51, 51, 51);

                        return Color.FromArgb(221, 221, 221);
                    }
                }
            }
        }
        #endregion

        #region ... Fore Colors ...
        public sealed class ForeColor
        {
            public static Color FormGrip(MetroThemeStyle theme)
            {
                if (theme == MetroThemeStyle.Dark)
                    return Color.FromArgb(109, 109, 109);

                return Color.FromArgb(136, 136, 136);
            }

            public static class ListView
            {
                public static Color Normal(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(109, 109, 109);

                    return Color.FromArgb(136, 136, 136);
                }
                public static Color Selected(MetroThemeStyle theme, MetroColorStyle style)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(17, 17, 17);

                    return Color.FromArgb(255, 255, 255);
                }
            }

            public static class DataGrid
            {
                public static Color Normal(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(109, 109, 109);

                    return Color.FromArgb(136, 136, 136);
                }

                public static Color ColumnHeadersDefaultCellStyle(MetroThemeStyle theme, MetroColorStyle style)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(17, 17, 17);

                    return Color.FromArgb(255, 255, 255);
                }

                public static Color RowHeadersDefaultCellStyle(MetroThemeStyle theme, MetroColorStyle style)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(17, 17, 17);

                    return Color.FromArgb(255, 255, 255);
                }

                public static Color DefaultCellStyleSelectionForeColor(MetroThemeStyle theme, MetroColorStyle style)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(17, 17, 17);

                    return Color.FromArgb(255, 255, 255);
                }

                public static Color RowHeadersDefaultCellStyleSelectionForeColor(MetroThemeStyle theme, MetroColorStyle style)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(17, 17, 17);

                    return Color.FromArgb(255, 255, 255);
                }

                public static Color ColumnHeadersDefaultCellStyleSelectionForeColor(MetroThemeStyle theme, MetroColorStyle style)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(17, 17, 17);

                    return Color.FromArgb(255, 255, 255);
                }
            }

            public static class KnobControl
            {
                public static Color Normal(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(170, 170, 170);

                    return Color.FromArgb(0, 0, 0);
                }
            }

            public static class NumericUpDown
            {
                public static Color Normal(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(204, 204, 204);

                    return Color.FromArgb(0, 0, 0);
                }

                public static Color Disabled(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(109, 109, 109);

                    return Color.FromArgb(155, 155, 155);
                }
            }

            public static class GroupBox
            {
                public static Color Normal(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(255, 255, 255);

                    return Color.FromArgb(0, 0, 0);
                }

                public static Color Disabled(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(109, 109, 109);

                    return Color.FromArgb(155, 155, 155);
                }
            }
            public sealed class PropertyGrid
            {
                public static Color Normal(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(204, 204, 204);

                    return Color.FromArgb(0, 0, 0);
                }

                public static Color Disabled(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(109, 109, 109);

                    return Color.FromArgb(136, 136, 136);
                }
            }
            public sealed class MenuItem
            {
                public static Color Normal(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(204, 204, 204);

                    return Color.FromArgb(0, 0, 0);
                }

                public static Color Hover(MetroThemeStyle theme, MetroColorStyle style)
                {
                    if (theme == MetroThemeStyle.Dark)
                    {
                        if (style == MetroColorStyle.White)
                            return Color.FromArgb(200, 200, 200);
                        else
                            return Color.FromArgb(255, 255, 255);
                    }

                    if (style == MetroColorStyle.White)
                        return Color.FromArgb(200, 200, 200);
                    else
                        return Color.FromArgb(255, 255, 255); 
                }

                public static Color Press(MetroThemeStyle theme, MetroColorStyle style)
                {
                    if (theme == MetroThemeStyle.Dark)
                    {
                        if (style == MetroColorStyle.White)
                            return Color.FromArgb(200, 200, 200);
                        else
                            return Color.FromArgb(255, 255, 255);
                    }

                    if (style == MetroColorStyle.White)
                        return Color.FromArgb(200, 200, 200);
                    else
                        return Color.FromArgb(255, 255, 255); 
                }

                public static Color Disabled(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(51, 51, 51);

                    return Color.FromArgb(209, 209, 209);
                }
            }
            public sealed class Button
            {
                public static Color Normal(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(204, 204, 204);

                    return Color.FromArgb(0, 0, 0);
                }

                public static Color Hover(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(17, 17, 17);

                    return Color.FromArgb(255, 255, 255);
                }

                public static Color Press(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(17, 17, 17);

                    return Color.FromArgb(255, 255, 255);
                }

                public static Color Disabled(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(109, 109, 109);

                    return Color.FromArgb(136, 136, 136);
                }
            }

            public static Color Title(MetroThemeStyle theme)
            {
                if (theme == MetroThemeStyle.Dark)
                    return Color.FromArgb(255, 255, 255);

                return Color.FromArgb(0, 0, 0);
            }

            public sealed class Tile
            {
                public static Color Normal(MetroThemeStyle theme, MetroColorStyle style)
                {
                    if (theme == MetroThemeStyle.Dark)
                    {
                        if (style == MetroColorStyle.White)                       
                            return Color.FromArgb(200, 200, 200);                  
                        else                       
                            return Color.FromArgb(255, 255, 255);                    
                    }

                    if (style == MetroColorStyle.White)
                        return Color.FromArgb(200, 200, 200);
                    else
                        return Color.FromArgb(255, 255, 255); 
                }

                public static Color Hover(MetroThemeStyle theme, MetroColorStyle style)
                {
                    if (theme == MetroThemeStyle.Dark)
                    {
                        if (style == MetroColorStyle.White)
                            return Color.FromArgb(200, 200, 200);
                        else
                            return Color.FromArgb(255, 255, 255);
                    }

                    if (style == MetroColorStyle.White)
                        return Color.FromArgb(200, 200, 200);
                    else
                        return Color.FromArgb(255, 255, 255); 
                }

                public static Color Press(MetroThemeStyle theme, MetroColorStyle style)
                {
                    if (theme == MetroThemeStyle.Dark)
                    {
                        if (style == MetroColorStyle.White)
                            return Color.FromArgb(200, 200, 200);
                        else
                            return Color.FromArgb(255, 255, 255);
                    }

                    if (style == MetroColorStyle.White)
                        return Color.FromArgb(200, 200, 200);
                    else
                        return Color.FromArgb(255, 255, 255); 
                }

                public static Color Disabled(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(209, 209, 209);

                    return Color.FromArgb(209, 209, 209);
                }
            }

            public sealed class Link
            {
                public static Color Normal(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(170, 170, 170);

                    return Color.FromArgb(0, 0, 0);
                }

                public static Color Hover(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(93, 93, 93);

                    return Color.FromArgb(128, 128, 128);
                }

                public static Color Press(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(93, 93, 93);

                    return Color.FromArgb(128, 128, 128);
                }

                public static Color Disabled(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(51, 51, 51);

                    return Color.FromArgb(209, 209, 209);
                }
            }

            public sealed class Label
            {
                public static Color Normal(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(170, 170, 170);

                    return Color.FromArgb(0, 0, 0);
                }

                public static Color Disabled(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(51, 51, 51);

                    return Color.FromArgb(209, 209, 209);
                }
            }

            public sealed class CheckBox
            {
                public static Color Normal(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(170, 170, 170);

                    return Color.FromArgb(17, 17, 17);
                }

                public static Color Hover(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(153, 153, 153);

                    return Color.FromArgb(153, 153, 153);
                }

                public static Color Press(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(153, 153, 153);

                    return Color.FromArgb(153, 153, 153);
                }

                public static Color Disabled(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(93, 93, 93);

                    return Color.FromArgb(136, 136, 136);
                }
            }

            public sealed class ComboBox
            {
                public static Color Normal(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(153, 153, 153);

                    return Color.FromArgb(153, 153, 153);
                }

                public static Color Hover(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(170, 170, 170);

                    return Color.FromArgb(17, 17, 17);
                }

                public static Color Press(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(153, 153, 153);

                    return Color.FromArgb(153, 153, 153);
                }

                public static Color Disabled(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(93, 93, 93);

                    return Color.FromArgb(136, 136, 136);
                }
            }

            public sealed class ProgressBar
            {
                public static Color Normal(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(170, 170, 170);

                    return Color.FromArgb(0, 0, 0);
                }

                public static Color Disabled(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(51, 51, 51);

                    return Color.FromArgb(209, 209, 209);
                }
            }

            public sealed class TabControl
            {
                public static Color Normal(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(170, 170, 170);

                    return Color.FromArgb(0, 0, 0);
                }

                public static Color Disabled(MetroThemeStyle theme)
                {
                    if (theme == MetroThemeStyle.Dark)
                        return Color.FromArgb(51, 51, 51);

                    return Color.FromArgb(209, 209, 209);
                }
            }
        }
        #endregion

        #region ... Menus ColorTable Colors ...
        public sealed class ColorTable
        {
            public sealed class Grip
            {
                public static Color Dark(MetroThemeStyle theme, MetroColorStyle style)
                {
                    return BackColor.Form(theme);
                }

                public static Color Light(MetroThemeStyle theme, MetroColorStyle style)
                {
                    return ControlPaint.Light(MetroPaint.BackColor.Form(theme));
                }
            }

            public sealed class Separator
            {
                public static Color Dark(MetroThemeStyle theme, MetroColorStyle style)
                {
                    return MetroPaint.BackColor.Form(theme);
                }

                public static Color Light(MetroThemeStyle theme, MetroColorStyle style)
                {
                    return ControlPaint.Light(MetroPaint.BackColor.Form(theme));
                }
            }

            public sealed class Button
            {
                public static Color ButtonSelectedBorder(MetroThemeStyle theme, MetroColorStyle style)
                {
                    return MetroPaint.GetStyleColor(style);
                }

                public static Color ButtonSelectedGradientBegin(MetroThemeStyle theme, MetroColorStyle style)
                {
                    return MetroPaint.GetStyleColor(style);
                }

                public static Color ButtonSelectedGradientMiddle(MetroThemeStyle theme, MetroColorStyle style)
                {
                    return MetroPaint.GetStyleColor(style);
                }

                public static Color ButtonSelectedGradientEnd(MetroThemeStyle theme, MetroColorStyle style)
                {
                    return MetroPaint.GetStyleColor(style);
                }

                public static Color ButtonPressedGradientBegin(MetroThemeStyle theme, MetroColorStyle style)
                {
                    return MetroPaint.GetStyleColor(style);
                }

                public static Color ButtonPressedGradientMiddle(MetroThemeStyle theme, MetroColorStyle style)
                {
                    return MetroPaint.GetStyleColor(style);
                }

                public static Color ButtonPressedGradientEnd(MetroThemeStyle theme, MetroColorStyle style)
                {
                    return MetroPaint.GetStyleColor(style);
                }

                public static Color ButtonCheckedGradientBegin(MetroThemeStyle theme, MetroColorStyle style)
                {
                    return Color.Transparent;
                }

                public static Color ButtonCheckedGradientMiddle(MetroThemeStyle theme, MetroColorStyle style)
                {
                    return Color.Transparent;
                }

                public static Color ButtonCheckedGradientEnd(MetroThemeStyle theme, MetroColorStyle style)
                {
                    return Color.Transparent;
                }

                public static Color OverflowButtonGradientBegin(MetroThemeStyle theme, MetroColorStyle style)
                {
                    return ControlPaint.Light(MetroPaint.BackColor.Form(theme));
                }

                public static Color OverflowButtonGradientMiddle(MetroThemeStyle theme, MetroColorStyle style)
                {
                    return ControlPaint.Light(MetroPaint.BackColor.Form(theme));
                }

                public static Color OverflowButtonGradientEnd(MetroThemeStyle theme, MetroColorStyle style)
                {
                    return ControlPaint.Light(MetroPaint.BackColor.Form(theme));
                }
            }

            public sealed class MenuStrip
            {
                public static Color MenuStripGradientBegin(MetroThemeStyle theme, MetroColorStyle style)
                {
                    return MetroPaint.BackColor.Button.Normal(theme); //return ControlPaint.Light(MetroPaint.BackColor.Form(theme));
                }

                public static Color MenuStripGradientEnd(MetroThemeStyle theme, MetroColorStyle style)
                {
                    return MetroPaint.BackColor.Button.Normal(theme); //return ControlPaint.Light(MetroPaint.BackColor.Form(theme));
                }

                public static Color MenuItemSelectedGradientBegin(MetroThemeStyle theme, MetroColorStyle style)
                {
                    return MetroPaint.GetStyleColor(style);
                }

                public static Color MenuItemSelectedGradientEnd(MetroThemeStyle theme, MetroColorStyle style)
                {
                    return MetroPaint.GetStyleColor(style);
                }

                public static Color MenuItemPressedGradientBegin(MetroThemeStyle theme, MetroColorStyle style)
                {
                    return MetroPaint.GetStyleColor(style);
                }

                public static Color MenuItemPressedGradientEnd(MetroThemeStyle theme, MetroColorStyle style)
                {
                    return MetroPaint.GetStyleColor(style);
                }

                public static Color MenuItemSelected(MetroThemeStyle theme, MetroColorStyle style)
                {
                    return MetroPaint.GetStyleColor(style);
                }

                public static Color MenuBorder(MetroThemeStyle theme, MetroColorStyle style)
                {
                    return MetroPaint.GetStyleColor(style); //return MetroPaint.BorderColor.Button.Normal(theme);
                }

                public static Color MenuItemBorder(MetroThemeStyle theme, MetroColorStyle style)
                {
                    return MetroPaint.GetStyleColor(style);
                }

            }

            public sealed class ToolStrip
            {
                public static Color ToolStripDropDownBackground(MetroThemeStyle theme, MetroColorStyle style)
                {
                    return ControlPaint.Light(MetroPaint.BackColor.Form(theme));
                }

                public static Color ToolStripGradientBegin(MetroThemeStyle theme, MetroColorStyle style)
                {
                    return MetroPaint.BackColor.Button.Normal(theme); //return ControlPaint.Light(MetroPaint.BackColor.Form(theme));
                }

                public static Color ToolStripGradientMiddle(MetroThemeStyle theme, MetroColorStyle style)
                {
                    return MetroPaint.BackColor.Button.Normal(theme); //return ControlPaint.Light(MetroPaint.BackColor.Form(theme));
                }

                public static Color ToolStripGradientEnd(MetroThemeStyle theme, MetroColorStyle style)
                {
                    return MetroPaint.BackColor.Button.Normal(theme); //return ControlPaint.Light(MetroPaint.BackColor.Form(theme));
                }

                public static Color ToolStripPanelGradientBegin(MetroThemeStyle theme, MetroColorStyle style)
                {
                    return ControlPaint.Light(MetroPaint.BackColor.Form(theme));
                }

                public static Color ToolStripPanelGradientEnd(MetroThemeStyle theme, MetroColorStyle style)
                {
                    return ControlPaint.Light(MetroPaint.BackColor.Form(theme));
                }

                public static Color ToolStripBorder(MetroThemeStyle theme, MetroColorStyle style)
                {
                    return ControlPaint.Light(MetroPaint.BackColor.Form(theme));
                }
            }

            public sealed class Image
            {
                public static Color ImageMarginGradientBegin(MetroThemeStyle theme, MetroColorStyle style)
                {
                    return ControlPaint.Light(MetroPaint.BackColor.Form(theme));
                }

                public static Color ImageMarginGradientMiddle(MetroThemeStyle theme, MetroColorStyle style)
                {
                    return ControlPaint.Light(MetroPaint.BackColor.Form(theme));
                }

                public static Color ImageMarginGradientEnd(MetroThemeStyle theme, MetroColorStyle style)
                {
                    return ControlPaint.Light(MetroPaint.BackColor.Form(theme));
                }
            }

            public sealed class StatusStrip
            {
                public static Color StatusStripGradientBegin(MetroThemeStyle theme, MetroColorStyle style)
                {
                    return MetroPaint.BackColor.Button.Normal(theme);
                }

                public static Color StatusStripGradientEnd(MetroThemeStyle theme, MetroColorStyle style)
                {
                    return MetroPaint.BackColor.Button.Normal(theme);
                }
            }

        }
        #endregion

        #region ... Helper Methods ...

        public static Color GetStyleColor(MetroColorStyle style)
        {
            switch (style)
            {
                case MetroColorStyle.Black:
                    return MetroColors.Black;

                case MetroColorStyle.White:
                    return MetroColors.White;

                case MetroColorStyle.Silver:
                    return MetroColors.Silver;

                case MetroColorStyle.Blue:
                    return MetroColors.Blue;

                case MetroColorStyle.Green:
                    return MetroColors.Green;

                case MetroColorStyle.Lime:
                    return MetroColors.Lime;

                case MetroColorStyle.Teal:
                    return MetroColors.Teal;

                case MetroColorStyle.Orange:
                    return MetroColors.Orange;

                case MetroColorStyle.Brown:
                    return MetroColors.Brown;

                case MetroColorStyle.Pink:
                    return MetroColors.Pink;

                case MetroColorStyle.Magenta:
                    return MetroColors.Magenta;

                case MetroColorStyle.Purple:
                    return MetroColors.Purple;

                case MetroColorStyle.Red:
                    return MetroColors.Red;

                case MetroColorStyle.Yellow:
                    return MetroColors.Yellow;

                case MetroColorStyle.DarkSalmon:
                    return MetroColors.DarkSalmon;

                default:
                    return MetroColors.Blue;
            }
        }

        public static SolidBrush GetStyleBrush(MetroColorStyle style)
        {
            switch (style)
            {
                case MetroColorStyle.Black:
                    return MetroBrushes.Black;

                case MetroColorStyle.White:
                    return MetroBrushes.White;

                case MetroColorStyle.Silver:
                    return MetroBrushes.Silver;

                case MetroColorStyle.Blue:
                    return MetroBrushes.Blue;

                case MetroColorStyle.Green:
                    return MetroBrushes.Green;

                case MetroColorStyle.Lime:
                    return MetroBrushes.Lime;

                case MetroColorStyle.Teal:
                    return MetroBrushes.Teal;

                case MetroColorStyle.Orange:
                    return MetroBrushes.Orange;

                case MetroColorStyle.Brown:
                    return MetroBrushes.Brown;

                case MetroColorStyle.Pink:
                    return MetroBrushes.Pink;

                case MetroColorStyle.Magenta:
                    return MetroBrushes.Magenta;

                case MetroColorStyle.Purple:
                    return MetroBrushes.Purple;

                case MetroColorStyle.Red:
                    return MetroBrushes.Red;

                case MetroColorStyle.Yellow:
                    return MetroBrushes.Yellow;

                case MetroColorStyle.DarkSalmon:
                    return MetroBrushes.DarkSalmon;

                default:
                    return MetroBrushes.Blue;
            }
        }

        public static Pen GetStylePen(MetroColorStyle style)
        {
            switch (style)
            {
                case MetroColorStyle.Black:
                    return MetroPens.Black;

                case MetroColorStyle.White:
                    return MetroPens.White;

                case MetroColorStyle.Silver:
                    return MetroPens.Silver;

                case MetroColorStyle.Blue:
                    return MetroPens.Blue;

                case MetroColorStyle.Green:
                    return MetroPens.Green;

                case MetroColorStyle.Lime:
                    return MetroPens.Lime;

                case MetroColorStyle.Teal:
                    return MetroPens.Teal;

                case MetroColorStyle.Orange:
                    return MetroPens.Orange;

                case MetroColorStyle.Brown:
                    return MetroPens.Brown;

                case MetroColorStyle.Pink:
                    return MetroPens.Pink;

                case MetroColorStyle.Magenta:
                    return MetroPens.Magenta;

                case MetroColorStyle.Purple:
                    return MetroPens.Purple;

                case MetroColorStyle.Red:
                    return MetroPens.Red;

                case MetroColorStyle.Yellow:
                    return MetroPens.Yellow;

                case MetroColorStyle.DarkSalmon:
                    return MetroPens.DarkSalmon;

                default:
                    return MetroPens.Blue;
            }
        }

        public static StringFormat GetStringFormat(ContentAlignment textAlign)
        {
            StringFormat stringFormat = new StringFormat();
            stringFormat.Trimming = StringTrimming.EllipsisCharacter;

            switch (textAlign)
            {
                case ContentAlignment.TopLeft:
                    stringFormat.Alignment = StringAlignment.Near;
                    stringFormat.LineAlignment = StringAlignment.Near;
                    break;
                case ContentAlignment.TopCenter:
                    stringFormat.Alignment = StringAlignment.Center;
                    stringFormat.LineAlignment = StringAlignment.Near;
                    break;
                case ContentAlignment.TopRight:
                    stringFormat.Alignment = StringAlignment.Far;
                    stringFormat.LineAlignment = StringAlignment.Near;
                    break;

                case ContentAlignment.MiddleLeft:
                    stringFormat.Alignment = StringAlignment.Center;
                    stringFormat.LineAlignment = StringAlignment.Near;
                    break;
                case ContentAlignment.MiddleCenter:
                    stringFormat.Alignment = StringAlignment.Center;
                    stringFormat.LineAlignment = StringAlignment.Center;
                    break;
                case ContentAlignment.MiddleRight:
                    stringFormat.Alignment = StringAlignment.Center;
                    stringFormat.LineAlignment = StringAlignment.Far;
                    break;

                case ContentAlignment.BottomLeft:
                    stringFormat.Alignment = StringAlignment.Far;
                    stringFormat.LineAlignment = StringAlignment.Near;
                    break;
                case ContentAlignment.BottomCenter:
                    stringFormat.Alignment = StringAlignment.Far;
                    stringFormat.LineAlignment = StringAlignment.Center;
                    break;
                case ContentAlignment.BottomRight:
                    stringFormat.Alignment = StringAlignment.Far;
                    stringFormat.LineAlignment = StringAlignment.Far;
                    break;
            }

            return stringFormat;
        }

        public static TextFormatFlags GetTextFormatFlags(ContentAlignment textAlign)
        {
            return GetTextFormatFlags(textAlign, false);
        }

        public static TextFormatFlags GetTextFormatFlags(ContentAlignment textAlign, bool WrapToLine)
        {
            TextFormatFlags controlFlags = TextFormatFlags.Default;

            switch (WrapToLine)
            {
                case true:
                    controlFlags = TextFormatFlags.WordBreak;
                    break;
                case false:
                    controlFlags = TextFormatFlags.EndEllipsis;
                    break;
            }
            switch (textAlign)
            {
                case ContentAlignment.TopLeft:
                    controlFlags |= TextFormatFlags.Top | TextFormatFlags.Left;
                    break;
                case ContentAlignment.TopCenter:
                    controlFlags |= TextFormatFlags.Top | TextFormatFlags.HorizontalCenter;
                    break;
                case ContentAlignment.TopRight:
                    controlFlags |= TextFormatFlags.Top | TextFormatFlags.Right;
                    break;

                case ContentAlignment.MiddleLeft:
                    controlFlags |= TextFormatFlags.VerticalCenter | TextFormatFlags.Left;
                    break;
                case ContentAlignment.MiddleCenter:
                    controlFlags |= TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter;
                    break;
                case ContentAlignment.MiddleRight:
                    controlFlags |= TextFormatFlags.VerticalCenter | TextFormatFlags.Right;
                    break;

                case ContentAlignment.BottomLeft:
                    controlFlags |= TextFormatFlags.Bottom | TextFormatFlags.Left;
                    break;
                case ContentAlignment.BottomCenter:
                    controlFlags |= TextFormatFlags.Bottom | TextFormatFlags.HorizontalCenter;
                    break;
                case ContentAlignment.BottomRight:
                    controlFlags |= TextFormatFlags.Bottom | TextFormatFlags.Right;
                    break;
            }

            return controlFlags;
        }

        #endregion
    }
}


