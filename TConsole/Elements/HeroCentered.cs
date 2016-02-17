using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QA.TestLibs.XmlDesiarilization;

namespace TConsole
{
    [XmlType("Hero Centered")]
    [XmlLocation("heroCentered")]
    public class HeroCentered : XmlBaseType
    {
        [XmlProperty("Text of Hero Centered", IsRequired = false)]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "Text", "text")]
        public HeroCenteredText Text { get; set; }

        [XmlProperty("Links of Hero Centered", IsRequired = false)]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "Links", "links")]
        public List<HeroLink> Links { get; set; }

        [XmlProperty("Image of Hero Centered", IsRequired = false)]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "Image", "image")]
        [XmlConstraint("Layout.Style", HeroCenteredLayoutStyle.PromoFullWidth, IsPositive = false)]
        public HeroImage Image { get; set; }

        [XmlProperty("Layout of Hero Centered", IsRequired = false)]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "Layout", "layout")]
        public HeroCenteredLayout Layout { get; set; }


        [XmlProperty("Video path of Hero Centered", IsRequired = false)]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "VideoPath", "videoPath")]
        [XmlConstraint("Layout.Style", HeroCenteredLayoutStyle.PromoFullWidth)]
        public string VideoPath { get; set; }

        [XmlProperty("Video Poster of Hero Centered", IsRequired = false)]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "VideoPoster", "videoPoster", "videoposter")]
        [XmlConstraint("Layout.Style", HeroCenteredLayoutStyle.PromoFullWidth)]
        public HeroImage VideoPoster { get; set; }
    }

    [XmlType("Hero Centered Text")]
    [XmlLocation("heroCenteredText")]
    public class HeroCenteredText : XmlBaseType
    {
        [XmlProperty("Headline of Hero Centered Text", IsRequired = false)]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "HeadLine", "headline")]
        public string HeadLine { get; set; }

        [XmlProperty("SubHeadline of Hero Centered Text", IsRequired = false)]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "SubHeadLine", "subheadline", "subHeadline")]
        public string SubHeadLine { get; set; }

        [XmlProperty("Paragraph of Hero Centered Text", IsRequired = false)]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "Paragraph", "paragraph")]
        public string Paragraph { get; set; }

        [XmlProperty("Footnote of Hero Centered Text", IsRequired = false)]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "FootNote", "footnote", "footNote")]
        public string FootNote { get; set; }

        [XmlProperty("FontColor DropDownList of Hero Centered Text", IsRequired = false)]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "FontColor", "fontcolor", "fontColor")]
        public HeroTextFontColor FontColor { get; set; } = HeroTextFontColor.Black;
    }

    
    [XmlType("Hero Centered Layout")]
    [XmlLocation("heroCenteredLayout")]
    public class HeroCenteredLayout : XmlBaseType
    {
        [XmlProperty("Style enum of Hero Centered Layout", IsRequired = false)]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "Style", "style")]
        public HeroCenteredLayoutStyle Style { get; set; } = HeroCenteredLayoutStyle.Promo;

        [XmlProperty("Breadcrumbs of Hero Centered Layout", IsRequired = false)]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "Breadcrumbs", "breadcrumbs")]
        public bool Breadcrumbs { get; set; }
    }
}
