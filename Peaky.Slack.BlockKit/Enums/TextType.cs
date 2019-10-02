using System.Runtime.Serialization;

namespace Peaky.Slack.BlockKit.Enums
{
    public enum TextType
    {
        [EnumMember(Value = "plain_text")]
        PlainText,

        [EnumMember(Value = "mrkdwn")]
        Markdown
    }
}
