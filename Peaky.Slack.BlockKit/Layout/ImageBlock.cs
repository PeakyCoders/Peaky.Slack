using Newtonsoft.Json;
using Peaky.Slack.BlockKit.Abstractions;
using Peaky.Slack.BlockKit.Composition;

namespace Peaky.Slack.BlockKit.Layout
{
    public class ImageBlock : ILayoutBlock
    {
        /// <summary>
        /// The type of block. For an image block, type is always image.
        /// </summary>
        [JsonProperty("image")]
        public string Type => "image";

        /// <summary>
        /// The URL of the image to be displayed.
        /// Maximum length for this field is 3000 characters.
        /// </summary>
        [JsonProperty("image_url")]
        public string ImageUrl;
        
        /// <summary>
        /// A plain-text summary of the image. This should not contain any markup.
        /// Maximum length for this field is 2000 characters.
        /// </summary>
        [JsonProperty("alt_text")]
        public string AltText;

        /// <summary>
        /// An optional title for the image in the form of a text object that can only be of type: plain_text.
        /// Maximum length for the text in this field is 2000 characters.
        /// </summary>
        [JsonProperty("title")]
        public TextComposition Title;
        
        /// <summary>
        /// A string acting as a unique identifier for a block. You can use this block_id when you receive an
        /// interaction payload to identify the source of the action. If not specified, one will be generated.
        /// Maximum length for this field is 255 characters.
        /// </summary>
        [JsonProperty("block_id")]
        public string BlockId;
    }
}
