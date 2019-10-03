using Newtonsoft.Json;
using Peaky.Slack.BlockKit.Abstractions;

namespace Peaky.Slack.BlockKit.Composition
{
    public abstract class TextComposition : ICompositionObject, IContextElement
    {
        /// <summary>
        /// The formatting to use for this text object. Can be one of plain_text or mrkdwn.
        /// </summary>
        [JsonProperty("type")]
        public abstract string Type { get; }
        
        /// <summary>
        /// The text for the block. This field accepts any of the standard text formatting markup when type is mrkdwn.
        /// </summary>
        [JsonProperty("text")]
        public string Text;
    }
}
