using Newtonsoft.Json;
using Peaky.Slack.BlockKit.Abstractions;

namespace Peaky.Slack.BlockKit.Composition
{
    public class ConfirmationDialogComposition : ICompositionObject
    {
        /// <summary>
        /// A plain_text-only text object that defines the dialog's title.
        /// Maximum length for this field is 100 characters.
        /// </summary>
        [JsonProperty("title")]
        public PlainTextComposition Title;

        /// <summary>
        /// A text object that defines the explanatory text that appears in the confirm dialog.
        /// Maximum length for the text in this field is 300 characters.
        /// </summary>
        [JsonProperty("text")]
        public TextComposition Text;

        /// <summary>
        /// A plain_text-only text object to define the text of the button that confirms the action.
        /// Maximum length for the text in this field is 30 characters.
        /// </summary>
        [JsonProperty("confirm")]
        public PlainTextComposition Confirm;

        /// <summary>
        /// A plain_text-only text object to define the text of the button that cancels the action.
        /// Maximum length for the text in this field is 30 characters.
        /// </summary>
        [JsonProperty("deny")]
        public PlainTextComposition Deny;
    }
}
