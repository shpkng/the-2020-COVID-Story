// Author: wuchenyang(shpkng@gmail.com)

public static class DataExtensions
{
    public static Conversation GetConversation(this int id) => ConversationContainer.Get(id);
    public static WorldEvent GetEvent(this int id) => EventContainer.Get(id);
    public static Message GetMessage(this int id) => MessageContainer.Get(id);
    public static Person GetPerson(this int id) => PersonContainer.Get(id);
    public static ReplyMessage GetReplyMessage(this int id) => ReplyMessageContainer.Get(id);
}