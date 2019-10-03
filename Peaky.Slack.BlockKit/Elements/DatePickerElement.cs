using Newtonsoft.Json;
using Peaky.Slack.BlockKit.Abstractions;
using Peaky.Slack.BlockKit.Composition;

namespace Peaky.Slack.BlockKit.Elements
{
    public class DatePickerElement : IBlockElement
    {
        /// <summary>
        /// The type of element. In this case type is always datepicker.
        /// </summary>
        [JsonProperty("type")]
        public string Type => "datepicker";

        /// <summary>
        /// An identifier for the action triggered when a menu option is selected.
        /// You can use this when you receive an interaction payload to identify the source of the action.
        /// Should be unique among all other action_ids used elsewhere by your app.
        /// Maximum length for this field is 255 characters.
        /// </summary>
        [JsonProperty("action_id")]
        public string ActionId;

        /// <summary>
        /// A plain_text only text object that defines the placeholder text shown on the datepicker.
        /// Maximum length for the text in this field is 150 characters.
        /// </summary>
        [JsonProperty("placeholder", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PlainTextComposition Placeholder;

        /// <summary>
        /// The initial date that is selected when the element is loaded.
        /// This should be in the format YYYY-MM-DD.
        /// </summary>
        [JsonProperty("initial_date", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string InitialDate;

        /// <summary>
        /// A confirm object that defines an optional confirmation dialog that appears after a date is selected.
        /// </summary>
        [JsonProperty("confirm", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ConfirmationDialogComposition Confirm;
    }
}
