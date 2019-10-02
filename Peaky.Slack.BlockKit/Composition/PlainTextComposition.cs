using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Peaky.Slack.BlockKit.Enums;

namespace Peaky.Slack.BlockKit.Composition
{
    public class PlainTextComposition : TextComposition
    {
        /// <summary>
        /// The formatting to use for this text object. Forced to plain_text.
        /// </summary>
        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public override TextType Type => TextType.PlainText;
    }
}
