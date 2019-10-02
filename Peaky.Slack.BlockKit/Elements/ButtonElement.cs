using Newtonsoft.Json;
using Peaky.Slack.BlockKit.Abstractions;
using Peaky.Slack.BlockKit.Composition;

namespace Peaky.Slack.BlockKit.Elements
{
    public class ButtonElement : IBlockElement
    {
        /// <summary>
        /// The type of element. In this case type is always button.
        /// </summary>
        [JsonProperty("button")]
        public string Type => "button";

        /// <summary>
        /// A text object that defines the button's text.
        /// Can only be of type: plain_text.
        /// Maximum length for the text in this field is 75 characters.
        /// </summary>
        [JsonProperty("text")]
        public TextComposition Text;

        /// <summary>
        /// An identifier for this action.
        /// You can use this when you receive an interaction payload to identify the source of the action.
        /// Should be unique among all other action_ids used elsewhere by your app.
        /// Maximum length for this field is 255 characters.
        /// </summary>
        [JsonProperty("action_id")]
        public string ActionId;

        /// <summary>
        /// A URL to load in the user's browser when the button is clicked.
        /// Maximum length for this field is 3000 characters.
        /// If you're using url, you'll still receive an interaction payload
        /// and will need to send an acknowledgement response.
        /// </summary>
        [JsonProperty("url")]
        public string Url;

        /// <summary>
        /// The value to send along with the interaction payload.
        /// Maximum length for this field is 2000 characters.
        /// </summary>
        [JsonProperty("value")]
        public string Value;

        /// <summary>
        /// Decorates buttons with alternative visual color schemes. Use this option with restraint.
        ///
        /// primary gives buttons a green outline and text, ideal for affirmation or confirmation actions.
        /// primary should only be used for one button within a set.
        ///
        /// danger gives buttons a red outline and text, and should be used when the action is destructive.
        /// Use danger even more sparingly than primary.
        ///
        /// If you don't include this field, the default button style will be used.
        /// </summary>
        [JsonProperty("style")]
        public string Style;

        /// <summary>
        /// A confirm object that defines an optional confirmation dialog after the button is clicked.
        /// </summary>
        [JsonProperty("confirm")]
        public ConfirmationDialogComposition Confirm;
    }
}
