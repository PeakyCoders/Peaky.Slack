using Newtonsoft.Json;
using Peaky.Slack.BlockKit.Abstractions;

namespace Peaky.Slack.BlockKit.Layout
{
    public class DividerBlock : ILayoutBlock
    {
        /// <summary>
        /// The type of block. For a divider block, type is always divider.
        /// </summary>
        [JsonProperty("type")]
        public string Type => "divider";

        /// <summary>
        /// A string acting as a unique identifier for a block. You can use this block_id when you receive an
        /// interaction payload to identify the source of the action. If not specified, one will be generated.
        /// Maximum length for this field is 255 characters.
        /// </summary>
        [JsonProperty("block_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string BlockId;
    }
}
