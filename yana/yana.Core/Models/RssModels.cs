/* 
 Licensed under the Apache License, Version 2.0
 
 http://www.apache.org/licenses/LICENSE-2.0
 */
using System;
using System.Xml.Serialization;
using System.Collections.Generic;
namespace yana.Core.Models
{
    [XmlRoot(ElementName="item")]
    public class Item {
        [XmlElement(ElementName="title")]
        public string Title { get; set; }
        [XmlElement(ElementName="link")]
        public string Link { get; set; }
        [XmlElement(ElementName="description")]
        public string Description { get; set; }
    }

    [XmlRoot(ElementName="channel")]
    public class Channel {
        [XmlElement(ElementName="title")]
        public string Title { get; set; }
        [XmlElement(ElementName="link")]
        public string Link { get; set; }
        [XmlElement(ElementName="description")]
        public string Description { get; set; }
        [XmlElement(ElementName="item")]
        public List<Item> Item { get; set; }
    }

    [XmlRoot(ElementName="rss")]
    public class Rss {
        [XmlElement(ElementName="channel")]
        public Channel Channel { get; set; }
        [XmlAttribute(AttributeName="version")]
        public string Version { get; set; }
    }

}
