﻿namespace UglyToad.Pdf.Fonts
{
    using System.Collections.Generic;
    using Geometry;

    class FontMetrics
    {
    }

    internal class FontMetricsBuilder
    {
        public decimal AfmVersion { get; }

        public List<string> Comments { get; }

        public List<IndividualCharacterMetric> CharacterMetrics { get; } = new List<IndividualCharacterMetric>();

        /// <summary>
        /// Name of the font as seen by PostScript.
        /// </summary>
        public string FontName { get; set; }

        /// <summary>
        /// The full text name of the font.
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// The name of the typeface family for the font.
        /// </summary>
        public string FamilyName { get; set; }

        /// <summary>
        /// The weight of the font.
        /// </summary>
        public string Weight { get; set; }

        /// <summary>
        /// Angle in degrees counter-clockwise from vertical of vertical strokes of the font.
        /// </summary>
        public decimal ItalicAngle { get; set; }

        /// <summary>
        /// Whether the font is monospaced or not.
        /// </summary>
        public bool IsFixedPitch { get; set; }

        /// <summary>
        /// The dimensions of the font bounding box.
        /// </summary>
        public PdfRectangle PdfBoundingBox { get; private set; }

        /// <summary>
        /// Distance from the baseline for underlining.
        /// </summary>
        public decimal UnderlinePosition { get; set; }

        /// <summary>
        /// The stroke width for underlining.
        /// </summary>
        public decimal UnderlineThickness { get; set; }

        /// <summary>
        /// Version identifier for the font program.
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Font name trademark or copyright notice.
        /// </summary>
        public string Notice { get; set; }

        public string EncodingScheme { get; set; }

        /// <summary>
        /// Code describing mapping scheme for a non base font.
        /// </summary>
        public int MappingScheme { get; set; }

        /// <summary>
        /// The character set of this font.
        /// </summary>
        public string CharacterSet { get; set; }

        public bool IsBaseFont { get; set; } = true;

        /// <summary>
        /// The y-value of the top of a capital H.
        /// </summary>
        public decimal CapHeight { get; set; }

        /// <summary>
        /// The y-value of the top of lowercase x.
        /// </summary>
        public decimal XHeight { get; set; }

        /// <summary>
        /// Generally the y-value of the top of lowercase d.
        /// </summary>
        public decimal Ascender { get; set; }

        /// <summary>
        /// The y-value of the bottom of lowercase p.
        /// </summary>
        public decimal Descender { get; set; }

        /// <summary>
        /// Width of horizontal stems.
        /// </summary>
        public decimal StdHw { get; set; }

        /// <summary>
        /// Width of vertical stems.
        /// </summary>
        public decimal StdVw { get; set; }

        public CharacterWidth CharacterWidth { get; private set; }

        public FontMetricsBuilder(decimal afmVersion)
        {
            AfmVersion = afmVersion;
            Comments = new List<string>();
        }

        public void SetBoundingBox(decimal x1, decimal y1, decimal x2, decimal y2)
        {
            PdfBoundingBox = new PdfRectangle(x1, y1, x2, y2);
        }

        public void SetCharacterWidth(decimal x, decimal y)
        {
            CharacterWidth = new CharacterWidth(x, y);
        }
    }

    /// <summary>
    /// The x and y components of the width vector of the font's characters.
    /// Presence implies that IsFixedPitch is true.
    /// </summary>
    internal class CharacterWidth
    {
        public decimal X { get; }

        public decimal Y { get; }

        public CharacterWidth(decimal x, decimal y)
        {
            X = x;
            Y = y;
        }
    }

    internal class IndividualCharacterMetric
    {
        public int CharacterCode { get; set; }

        public decimal WidthX { get; set; }
        public decimal WidthY { get; set; }

        public decimal WidthXDirection0 { get; set; }
        public decimal WidthYDirection0 { get; set; }

        public decimal WidthXDirection1 { get; set; }
        public decimal WidthYDirection1 { get; set; }

        public string Name { get; set; }

        public PdfVector VVector { get; set; }

        public PdfRectangle BoundingBox { get; set; }
    }
}
