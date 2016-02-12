using QA.TestLibs.XmlDesiarilization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TConsole
{
    [XmlType("Hero Link")]
    public class HeroLink : XmlBaseType
    {
        [XmlProperty("Link Name of HeroCentered link", IsRequired = false)]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "LinkName", "linkName", "linkname")]
        public string LinkName { get; set; }

        [XmlProperty("Path of HeroCentered link")]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "Path", "path")]
        public string Path { get; set; }

        [XmlProperty("Target enum of HeroCentered link", IsRequired = false)]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "Target", "target")]
        public HeroLinkTargetWindow Target { get; set; } = HeroLinkTargetWindow.New;

        [XmlProperty("Displaymode enum of HeroCentered link", IsRequired = false)]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "DisplayMode", "displayMode", "displaymode")]
        public HeroLinkDisplayMode DisplayMode { get; set; } = HeroLinkDisplayMode.Link;

        [XmlProperty("Tooltip of HeroCentered link", IsRequired = false)]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "Tooltip", "tooltip")]
        public string Tooltip { get; set; }
    }

    [XmlType("Hero Text")]
    public class HeroText : XmlBaseType
    {
        [XmlProperty("Text headline of hero-element", IsRequired = false)]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "Headline", "headline", "HeadLine", "headLine")]
        public string Headline { get; set; }

        [XmlProperty("Paragraph of hero-element", IsRequired = false)]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "Paragraph", "paragraph")]
        public string Paragraph { get; set; }

        [XmlProperty("Text font Color of hero-element", IsRequired = false)]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "FontColor", "fontColor")]
        public HeroTextFontColor FontColor { get; set; }
    }

    [XmlType("Hero Image")]
    public class HeroImage
    {
        [XmlProperty("Alt Text for image", IsRequired = false)]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "ImageAltText", "imageAltText", "imagealttext")]
        public string ImageAltText { get; set; }

        [XmlProperty("Image Direction", IsRequired = false)]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "ImageDirection", "imageDirection", "imagedirection")]
        public HeroImageDirection ImageDirection { get; set; }
    }
}
