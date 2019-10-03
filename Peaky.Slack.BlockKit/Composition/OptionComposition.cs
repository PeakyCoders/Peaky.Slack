using Newtonsoft.Json;
using Peaky.Slack.BlockKit.Abstractions;

namespace Peaky.Slack.BlockKit.Composition
{
    public class OptionComposition : ICompositionObject
    {
        /// <summary>
        /// A plain_text only text object that defines the text shown in the option on the menu.
        /// Maximum length for the text in this field is 75 characters.
        /// </summary>
        [JsonProperty("text")]
        public PlainTextComposition Text;

        /// <summary>
        /// The string value that will be passed to your app when this option is chosen.
        /// Maximum length for this field is 75 characters.
        /// </summary>
        [JsonProperty("value")]
        public string Value;

        /// <summary>
        /// A URL to load in the user's browser when the option is clicked.
        /// The url attribute is only available in overflow menus.
        /// Maximum length for this field is 3000 characters.
        /// If you're using url, you'll still receive an interaction payload
        /// and will need to send an acknowledgement response.
        /// </summary>
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Url;
    }
}
