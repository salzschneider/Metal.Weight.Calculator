﻿// Copyright (c) 2021 Salzschneider and others
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

namespace MetalWeightCalculator.Shapes.Angle.Arguments
{
    internal class IShapedAngleArgument
    {
        public double Height { get; set; }

        public double TopFlangeWidth { get; set; }

        public double TopFlangeThickness { get; set; }

        public double BottomFlangeWidth { get; set; }

        public double BottomFlangeThickness { get; set; }

        public double StemThickness { get; set; }

        public double Weight { get; set; }

        public double Length { get; set; }

        public double Density { get; set; }

        public IShapedAngleArgument(
            double height,
            double topFlangeWidth,
            double topFlangeThickness,
            double bottomFlangeWidth,
            double bottomFlangeThickness,
            double stemThickness,
            double weight,
            double length,
            double density)
        {
            Height = height;
            TopFlangeWidth = topFlangeWidth;
            TopFlangeThickness = topFlangeThickness;
            BottomFlangeWidth = bottomFlangeWidth;
            BottomFlangeThickness = bottomFlangeThickness;
            StemThickness = stemThickness;
            Weight = weight;
            Length = length;
            Density = density;
        }
    }
}
