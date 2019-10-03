using Newtonsoft.Json;

namespace Peaky.Slack.BlockKit.Composition
{
    public class MarkdownTextComposition : TextComposition
    {
        /// <summary>
        /// The formatting to use for this text object. Forced to mrkdwn.
        /// </summary>
        [JsonProperty("type")]
        public override string Type => "mrkdwn";

        /// <summary>
        /// When set to false (as is default) URLs will be auto-converted into links, conversation names
        /// will be link-ified, and certain mentions will be automatically parsed. 
        /// Using a value of true will skip any preprocessing of this nature, although you can still
        /// include manual parsing strings. This field is only usable when type is mrkdwn.
        /// </summary>
        [JsonProperty("verbatim", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Verbatim;
    }
}
