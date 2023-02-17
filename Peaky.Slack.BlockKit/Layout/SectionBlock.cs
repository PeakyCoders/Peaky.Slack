using System.Collections.Generic;
using Newtonsoft.Json;
using Peaky.Slack.BlockKit.Abstractions;
using Peaky.Slack.BlockKit.Composition;

namespace Peaky.Slack.BlockKit.Layout
{
    public class SectionBlock : ILayoutBlock
    {
        /// <summary>
        /// The type of block. For a section block, type will always be section.
        /// </summary>
        [JsonProperty("type")]
        public string Type => "section";

        /// <summary>
        /// The text for the block, in the form of a text object.
        /// Maximum length for the text in this field is 3000 characters.
        /// </summary>
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public TextComposition Text;

        /// <summary>
        /// A string acting as a unique identifier for a block.
        /// You can use this block_id when you receive an interaction payload to identify the source of the action.
        /// If not specified, one will be generated.
        /// Maximum length for this field is 255 characters.
        /// block_id should be unique for each message and each iteration of a message.
        /// If a message is updated, use a new block_id.
        /// </summary>
        [JsonProperty("block_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string BlockId;

        /// <summary>
        /// An array of text objects.
        /// Any text objects included with fields will be rendered in a compact
        /// format that allows for 2 columns of side-by-side text.
        /// Maximum number of items is 10.
        /// Maximum length for the text in each item is 2000 characters.
        /// </summary>
        [JsonProperty("fields", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<TextComposition> Fields;

        /// <summary>
        /// One of the available element objects.
        /// </summary>
        [JsonProperty("accessory", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IBlockElement Accessory;
    }
}
