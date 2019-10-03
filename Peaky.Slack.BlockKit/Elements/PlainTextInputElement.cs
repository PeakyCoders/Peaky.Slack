using Newtonsoft.Json;
using Peaky.Slack.BlockKit.Abstractions;
using Peaky.Slack.BlockKit.Composition;

namespace Peaky.Slack.BlockKit.Elements
{
    public class PlainTextInputElement : IBlockElement
    {
        /// <summary>
        /// The type of element. In this case type is always plain_text_input.
        /// </summary>
        [JsonProperty("type")]
        public string Type => "plain_text_input";
        
        /// <summary>
        /// An identifier for the input value when the parent modal is submitted.
        /// You can use this when you receive a view_submission payload to identify the value of the input element).
        /// Should be unique among all other action_ids used elsewhere by your app.
        /// Maximum length for this field is 255 characters.
        /// </summary>
        [JsonProperty("action_id")]
        public string ActionId;
        
        /// <summary>
        /// A plain_text only text object that defines the placeholder text shown in the plain-text input.
        /// Maximum length for the text in this field is 150 characters.
        /// </summary>
        [JsonProperty("placeholder", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PlainTextComposition Placeholder;

        /// <summary>
        /// The initial value in the plain-text input when it is loaded.
        /// </summary>
        [JsonProperty("initial_value", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string InitialValue;

        /// <summary>
        /// Indicates whether the input will be a single line (false) or a larger textarea (true).
        /// Defaults to false.
        /// </summary>
        [JsonProperty("multiline", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Multiline;

        /// <summary>
        /// The minimum length of input that the user must provide.
        /// If the user provides less, they will receive an error.
        /// Maximum value is 3000.
        /// </summary>
        [JsonProperty("min_length", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int MinLength;

        /// <summary>
        /// The maximum length of input that the user can provide.
        /// If the user provides more, they will receive an error.
        /// </summary>
        [JsonProperty("max_length", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int MaxLength = int.MaxValue;
    }
}
