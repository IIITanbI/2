using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QA.TestLibs.XmlDesiarilization;

namespace TConsole
{
    [XmlType("Hero Carousel")]
    [XmlLocation("heroCarousel")]
    public class HeroCarousel : XmlBaseType
    {
        [XmlProperty("Items of Hero Carousel", IsRequired = false)]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "Items", "items")]
        public List<HeroCarouselItem> Items { get; set; }

        [XmlProperty("Main Theme string of Hero Carousel", IsRequired = false)]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "MainTheme", "mainTheme", "maintheme")]
        public string MainTheme { get; set; }

        [XmlProperty("Transitioin mode of Hero Carousel", IsRequired = false)]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "TransitionMode", "transitionMode", "transitionmode")]
        public HeroCarouselTransitionMode TransitionMode { get; set; } = HeroCarouselTransitionMode.Manual;

        [XmlProperty("Rotation time of Hero Carousel")]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "RotationTime", "RotationTime", "rotationtime")]
        public int RotationTime { get; set; }

        [XmlProperty("Transition time of Hero Carousel")]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "TransitionTime", "transitionTime", "transitiontime")]
        public int TransitionTime { get; set; }
    }

    [XmlType("Hero Carousel Item")]
    [XmlLocation("heroCarouselItem")]
    public class HeroCarouselItem : XmlBaseType
    {
        [XmlProperty("Text of Hero Carousel Item", IsRequired = false)]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "Text", "text")]
        public HeroCarouselItemText Text { get; set; }

        [XmlProperty("Image of Hero Carousel Item", IsRequired = false)]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "Image", "image")]
        public HeroImage Image { get; set; }

        [XmlProperty("Link of Hero Carousel Item", IsRequired = false)]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "Link", "link")]
        public HeroLink Link { get; set; }
    }

    [XmlType("Hero Carousel Item Text")]
    [XmlLocation("heroCarouselItemText")]
    public class HeroCarouselItemText
    {
        [XmlProperty("Headline of Hero Carousel Item Text", IsRequired = false)]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "HeadLine", "headline")]
        public string HeadLine { get; set; }

        [XmlProperty("Paragraph of Hero Carousel Item Text", IsRequired = false)]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "Paragraph", "paragraph")]
        public string Paragraph { get; set; }

        [XmlProperty("Font Color DropDownlist of Hero Carousel Item Text", IsRequired = false)]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "FontColor", "fontcolor", "fontColor")]
        public HeroTextFontColor FontColor { get; set; } = HeroTextFontColor.Black;

        [XmlProperty("Main Theme Color DropDownlist of Hero Carousel Item Text", IsRequired = false)]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "MainThemeColor", "mainThemeColor", "mainthemeColor", "mainthemecolor")]
        public HeroTextMainThemeColor MainThemeColor { get; set; } = HeroTextMainThemeColor.Black;
    }

    [XmlType("Hero Carousel Item Layout")]
    [XmlLocation("heroCarouselItemLayout")]
    public class HeroCarouselItemLayout : XmlBaseType
    {
        [XmlProperty("Overlay checkbox of Hero Carousel Item Layout", IsRequired = false)]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "Overlay", "overlay")]
        public bool Overlay { get; set; }

        [XmlProperty("PlayIcon checkbox of Hero Carousel Item Layout", IsRequired = false)]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "PlayIcon", "playIcon", "playicon")]
        public bool PlayIcon { get; set; }

        [XmlProperty("EmbeddedVideo checkbox of Hero Carousel Item Layout", IsRequired = false)]
        [XmlLocation(XmlLocationType.Attribute | XmlLocationType.Element, "EmbeddedVideo", "embeddedVideo", "embeddedvideo")]
        public bool EmbeddedVideo { get; set; }
    }
}
