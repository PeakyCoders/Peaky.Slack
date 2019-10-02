using Newtonsoft.Json;
using Peaky.Slack.BlockKit.Abstractions;

namespace Peaky.Slack.BlockKit.Elements
{
    public class ImageElement : IBlockElement, IContextElement
    {
        /// <summary>
        /// The type of element. In this case type is always image.
        /// </summary>
        [JsonProperty("type")]
        public string Type => "image";

        /// <summary>
        /// The URL of the image to be displayed.
        /// </summary>
        [JsonProperty("image_url")]
        public string ImageUrl;
        
        /// <summary>
        /// A plain-text summary of the image. This should not contain any markup.
        /// </summary>
        [JsonProperty("alt_text")]
        public string AltText;
    }
}
