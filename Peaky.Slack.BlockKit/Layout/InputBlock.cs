using Newtonsoft.Json;
using Peaky.Slack.BlockKit.Abstractions;
using Peaky.Slack.BlockKit.Composition;

namespace Peaky.Slack.BlockKit.Layout
{
    public class InputBlock : ILayoutBlock
    {
        /// <summary>
        /// The type of block. For an input block, type is always input.
        /// </summary>
        [JsonProperty("type")]
        public string Type => "input";

        /// <summary>
        /// A label that appears above an input element in the form of a text object that must have type of plain_text.
        /// Maximum length for the text in this field is 2000 characters.
        /// </summary>
        [JsonProperty("label")]
        public TextComposition Label;

        /// <summary>
        /// An plain-text input element, a select menu element, or a multi-select menu element.
        /// </summary>
        [JsonProperty("element")]
        public IBlockElement Element;

        /// <summary>
        /// An optional hint that appears below an input element in a lighter grey.
        /// It must be a a text object with a type of plain_text.
        /// Maximum length for the text in this field is 2000 characters.
        /// </summary>
        [JsonProperty("hint", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public TextComposition Hint;

        /// <summary>
        /// A boolean that indicates whether the input element may be empty when a user submits the modal.
        /// Defaults to false.
        /// </summary>
        [JsonProperty("optional", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Optional;
    }
}
