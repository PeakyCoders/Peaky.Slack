using System.Collections.Generic;
using Newtonsoft.Json;
using Peaky.Slack.BlockKit.Abstractions;
using Peaky.Slack.BlockKit.Composition;

namespace Peaky.Slack.BlockKit.Elements
{
    public class OverflowMenuElement : IBlockElement
    {
        /// <summary>
        /// The type of element. In this case type is always overflow.
        /// </summary>
        [JsonProperty("type")]
        public string Type => "overflow";

        /// <summary>
        /// An identifier for the action triggered when a menu option is selected.
        /// You can use this when you receive an interaction payload to identify the source of the action.
        /// Should be unique among all other action_ids used elsewhere by your app.
        /// Maximum length for this field is 255 characters.
        /// </summary>
        [JsonProperty("action_id")]
        public string ActionId;

        /// <summary>
        /// An array of option objects to display in the menu.
        /// Maximum number of options is 5, minimum is 2.
        /// </summary>
        [JsonProperty("options")]
        public List<OptionComposition> Options;

        /// <summary>
        /// A confirm object that defines an optional confirmation dialog that appears after a menu item is selected.
        /// </summary>
        [JsonProperty("confirm", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ConfirmationDialogComposition Confirm;
    }
}
