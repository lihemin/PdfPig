﻿namespace UglyToad.PdfPig.DocumentLayoutAnalysis.Export.PAGE
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    public partial class PageXmlDocument
    {
        /// <summary>
        /// Border of the actual page (if the scanned image
        /// contains parts not belonging to the page).
        /// </summary>
        [EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCode("xsd", "4.6.1055.0")]
        [Serializable()]
        [DebuggerStepThrough()]
        [DesignerCategory("code")]
        [XmlType(Namespace = "http://schema.primaresearch.org/PAGE/gts/pagecontent/2019-07-15")]
        public class PageXmlBorder
        {

            private PageXmlCoords coordsField;

            /// <remarks/>
            public PageXmlCoords Coords
            {
                get
                {
                    return this.coordsField;
                }
                set
                {
                    this.coordsField = value;
                }
            }
        }
    }
}
