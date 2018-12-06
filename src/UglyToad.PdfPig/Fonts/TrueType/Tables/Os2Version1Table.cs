﻿namespace UglyToad.PdfPig.Fonts.TrueType.Tables
{
    using System.Collections.Generic;

    /// <summary>
    /// Version 1 was defined in TrueType revision 1.66. Version 1 has two additional fields beyond those in version 0. 
    /// </summary>
    internal class Os2Version1Table : Os2RevisedVersion0Table
    {
        /// <summary>
        /// This field is used to specify the code pages encompassed by the font file in the 'cmap' subtable for the Microsoft platform(3), Unicode BMP encoding (1). 
        /// </summary>
        public byte CodePage1 { get; }

        /// <summary>
        /// This field is the second byte used to specify the code pages encompassed by the font file in the 'cmap' subtable for the Microsoft platform(3), Unicode BMP encoding (1). 
        /// </summary>
        public byte CodePage2 { get; }

        public Os2Version1Table(TrueTypeHeaderTable directoryTable, ushort version, short xAverageCharacterWidth, ushort weightClass, ushort widthClass, 
            ushort typeFlags, 
            short ySubscriptXSize, 
            short ySubscriptYSize, 
            short ySubscriptXOffset,
            short ySubscriptYOffset,
            short ySuperscriptXSize, 
            short ySuperscriptYSize,
            short ySuperscriptXOffset,
            short ySuperscriptYOffset, 
            short yStrikeoutSize,
            short yStrikeoutPosition, 
            short familyClass, 
            IReadOnlyList<byte> panose,
            IReadOnlyList<uint> unicodeRanges, 
            string vendorId, 
            ushort fontSelectionFlags, 
            ushort firstCharacterIndex,
            ushort lastCharacterIndex, 
            short typographicAscender,
            short typographicDescender, 
            short typographicLineGap, 
            ushort windowsAscent, 
            ushort windowsDescent,
            byte codePage1, 
            byte codePage2) : base(directoryTable, version, xAverageCharacterWidth, weightClass, widthClass, 
            typeFlags, ySubscriptXSize, ySubscriptYSize, ySubscriptXOffset, ySubscriptYOffset, ySuperscriptXSize, 
            ySuperscriptYSize, ySuperscriptXOffset, ySuperscriptYOffset, yStrikeoutSize, yStrikeoutPosition, 
            familyClass, panose, unicodeRanges, vendorId, fontSelectionFlags, firstCharacterIndex, lastCharacterIndex,
            typographicAscender, typographicDescender, typographicLineGap, windowsAscent, windowsDescent)
        {
            CodePage1 = codePage1;
            CodePage2 = codePage2;
        }
    }
}