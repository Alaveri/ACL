using ACL.Core;
using ACL.Globalization.Development;
using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace ACL.Serialization.Xml
{
    /// <summary>
    /// Provides conversion functions for XML.
    /// </summary>
    public static class XmlConverter
    {
        /// <summary>
        /// Deserializes an XML string into the specified object type.
        /// </summary>
        /// <typeparam name="TObject">The object type to create.</typeparam>
        /// <param name="xml">The xml data.</param>
        /// <param name="extraTypes">Additional types needed for deserialization.  Note that adding extra types</param>
        /// <returns>An object created from the specified XML.</returns>
        /// <exception cref="InvalidOperationException">An error occurred during deserialization. The original exception is available using the InnerException property.</exception>
        public static TObject Deserialize<TObject>(string xml, params Type[] extraTypes)
        {
            var serializer = extraTypes.Length > 0 ?
                new XmlSerializer(typeof(TObject), extraTypes):
                new XmlSerializer(typeof(TObject));
            using (var stream = new MemoryStream(Encoding.Unicode.GetBytes(xml)))
            using (var textReader = new XmlTextReader(stream))
            {
                return (TObject)serializer.Deserialize(textReader);
            }
        }

        /// <summary>
        /// Serializes an object into an XML string.  If obj is null, returns null.
        /// </summary>
        /// <param name="obj">The object to serialize.</param>
        /// <returns>The serialized XML of the object.</returns>
        /// <param name="extraTypes">Additional types needed for deserialization.</param>
        /// <exception cref="InvalidOperationException">An error occurred during serialization. The original exception is available using the InnerException property.</exception>
        public static string Serialize(object obj, params Type[] extraTypes)
        {
            if (obj == null)
                return null;
            var serializer = extraTypes.Length > 0 ?
                new XmlSerializer(obj.GetType(), extraTypes) :
                new XmlSerializer(obj.GetType());
            obj = obj ?? throw ExceptionFactory.CreateArgumentNullException(obj);
            using (var stream = new MemoryStream())
            using (var writer = new XmlTextWriter(stream, Encoding.Unicode))
            {
                serializer.Serialize(writer, obj);
                return Encoding.Unicode.GetString(stream.ToArray());
            }
        }
    }
}
