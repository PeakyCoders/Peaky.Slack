using Newtonsoft.Json;
using Peaky.Slack.BlockKit.Abstractions;

namespace Peaky.Slack.BlockKit.Layout
{
    public class FileBlock : ILayoutBlock
    {
        /// <summary>
        /// The type of block. For a file block, type is always file.
        /// </summary>
        [JsonProperty("type")]
        public string Type => "file";

        /// <summary>
        /// The external unique ID for this file.
        /// </summary>
        [JsonProperty("external_id")]
        public string ExternalId;

        /// <summary>
        /// At the moment, source will always be remote for a remote file.
        /// </summary>
        [JsonProperty("source")]
        public string Source;
        
        /// <summary>
        /// A string acting as a unique identifier for a block. You can use this block_id when you receive an
        /// interaction payload to identify the source of the action. If not specified, one will be generated.
        /// Maximum length for this field is 255 characters.
        /// </summary>
        [JsonProperty("block_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string BlockId;
    }
}
