using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

using System.Xml;
using System.Xml.Serialization;

namespace Syspro
{
    public class CustomConfigLoader : IConfigurationSectionHandler
    {
        public object Create(object parent, object configContext, XmlNode section)
        {
            if (section == null)
            {
                throw new ArgumentNullException($"XMLNode passed in is null.");
            }

            var type = AppDomain.CurrentDomain.GetAssemblies()
            .SelectMany(a => a.GetTypes())
            .FirstOrDefault(t => t.Name == section.Name);

            if (type == null)
            {
                throw new ArgumentException($"Type with name {section.Name} couldn't be found.");
            }

            var serializer = new XmlSerializer(type, new XmlRootAttribute(section.Name));

            using (XmlReader reader = new XmlNodeReader(section))
            {
                return serializer.Deserialize(reader);
            }
        }
    }
}
