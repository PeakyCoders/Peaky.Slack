using System.Collections.Generic;
using Newtonsoft.Json;
using Peaky.Slack.BlockKit.Abstractions;

namespace Peaky.Slack.BlockKit.Layout
{
    public class ContextBlock : ILayoutBlock
    {
        /// <summary>
        /// The type of block. For a context block, type is always context.
        /// </summary>
        [JsonProperty("type")]
        public string Type => "context";

        /// <summary>
        /// An array of image elements and text objects.
        /// Maximum number of items is 10.
        /// </summary>
        [JsonProperty("elements")]
        public List<IContextElement> Elements;
        
        /// <summary>
        /// A string acting as a unique identifier for a block. You can use this block_id when you receive an
        /// interaction payload to identify the source of the action. If not specified, one will be generated.
        /// Maximum length for this field is 255 characters.
        /// </summary>
        [JsonProperty("block_id")]
        public string BlockId;
    }
}
