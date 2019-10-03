using System.Collections.Generic;
using Newtonsoft.Json;
using Peaky.Slack.BlockKit.Abstractions;

namespace Peaky.Slack.BlockKit.Entities
{
    public class BlockMessage
    {
        [JsonProperty("blocks")]
        public List<ILayoutBlock> Blocks;
    }
}
