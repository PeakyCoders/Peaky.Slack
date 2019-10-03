using System.Collections.Generic;
using Newtonsoft.Json;
using Peaky.Slack.BlockKit.Abstractions;

namespace Peaky.Slack.BlockKit.Layout
{
    public class ActionsBlock : ILayoutBlock
    {
        /// <summary>
        /// The type of block. For an actions block, type is always actions.
        /// </summary>
        [JsonProperty("type")]
        public string Type => "actions";

        /// <summary>
        /// An array of interactive element objects - buttons, select menus, overflow menus, or date pickers.
        /// There is a maximum of 5 elements in each action block.
        /// </summary>
        [JsonProperty("elements")]
        public List<IBlockElement> Elements;
        
        /// <summary>
        /// A string acting as a unique identifier for a block. You can use this block_id when you receive an
        /// interaction payload to identify the source of the action. If not specified, one will be generated.
        /// Maximum length for this field is 255 characters.
        /// </summary>
        [JsonProperty("block_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string BlockId;
    }
}
