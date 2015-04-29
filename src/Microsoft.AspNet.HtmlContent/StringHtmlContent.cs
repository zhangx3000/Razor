
using System.IO;
using Microsoft.Framework.WebEncoders;

namespace Microsoft.AspNet.HtmlContent
{
    public class StringHtmlContent : IHtmlContent
    {
        public static readonly StringHtmlContent Empty = new StringHtmlContent(string.Empty, encodeOnWrite: true);

        private bool _encodeOnWrite;
        private string _text;

        public static StringHtmlContent FromEncodedText(string text)
        {
            return new StringHtmlContent(text, encodeOnWrite: true);
        }

        public StringHtmlContent(string text)
            : this(text, encodeOnWrite: false)
        {
        }

        protected StringHtmlContent(string text, bool encodeOnWrite)
        {
            _text = text;
            _encodeOnWrite = encodeOnWrite;
        }

        public void WriteTo(TextWriter writer, IHtmlEncoder encoder)
        {
            if (_encodeOnWrite)
            {
                encoder.HtmlEncode(_text, writer);
            }
            else
            {
                writer.Write(_text);
            }
        }

        public override string ToString()
        {
            using (var writer = new StringWriter())
            {
                WriteTo(writer, new HtmlEncoder());
                return writer.ToString();
            }
        }
    }
}