using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Peaky.Slack.BlockKit.Abstractions;
using Peaky.Slack.BlockKit.Enums;

namespace Peaky.Slack.BlockKit.Composition
{
    public class TextComposition : ICompositionObject, IContextElement
    {
        /// <summary>
        /// The formatting to use for this text object. Can be one of plain_text or mrkdwn.
        /// </summary>
        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public virtual TextType Type { get; set; }
        
        /// <summary>
        /// The text for the block. This field accepts any of the standard text formatting markup when type is mrkdwn.
        /// </summary>
        [JsonProperty("text")]
        public string Text;

        /// <summary>
        /// Indicates whether emojis in a text field should be escaped into the colon emoji format.
        /// This field is only usable when type is plain_text.
        /// </summary>
        [JsonProperty("emoji")]
        public bool Emoji;

        /// <summary>
        /// When set to false (as is default) URLs will be auto-converted into links, conversation names
        /// will be link-ified, and certain mentions will be automatically parsed. 
        /// Using a value of true will skip any preprocessing of this nature, although you can still
        /// include manual parsing strings. This field is only usable when type is mrkdwn.
        /// </summary>
        [JsonProperty("verbatim")]
        public bool Verbatim;
    }
}
