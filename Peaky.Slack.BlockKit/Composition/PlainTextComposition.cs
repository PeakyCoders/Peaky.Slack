using Newtonsoft.Json;

namespace Peaky.Slack.BlockKit.Composition
{
    public class PlainTextComposition : TextComposition
    {
        /// <summary>
        /// The formatting to use for this text object. Forced to plain_text.
        /// </summary>
        [JsonProperty("type")]
        public override string Type => "plain_text";
        
        /// <summary>
        /// Indicates whether emojis in a text field should be escaped into the colon emoji format.
        /// This field is only usable when type is plain_text.
        /// </summary>
        [JsonProperty("emoji", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Emoji;
    }
}
