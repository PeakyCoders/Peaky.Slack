using System.Collections.Generic;
using Newtonsoft.Json;
using Peaky.Slack.BlockKit.Abstractions;

namespace Peaky.Slack.BlockKit.Composition
{
    public class OptionGroupComposition : ICompositionObject
    {
        /// <summary>
        /// A plain_text only text object that defines the label shown above this group of options.
        /// Maximum length for the text in this field is 75 characters.
        /// </summary>
        [JsonProperty("label")]
        public PlainTextComposition Label;

        /// <summary>
        /// An array of option objects that belong to this specific group.
        /// Maximum of 100 items.
        /// </summary>
        [JsonProperty("options")]
        public List<OptionComposition> Options;
    }
}
