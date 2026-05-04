namespace MessagingService.Domain.Entities;

public class Message
{
    public string Id { get; set; } = null!;
    public string UserId { get; set; } = null!;
    public string LiveClassId { get; set; } = null!;
    public string Text { get; set; } = null!;
    public bool IsQuestion { get; set; }
    public bool IsAnswered { get; set; }
    public MessageLike[]? Like { get; set; } = null!;
    public string ProfileName { get; set; } = null!;
    public DateTime CreatedAtUtc { get; set; }

}

public class MessageLike
{
    public string UserId { get; set; } = null!;
    public string ProfileName { get; set; } = null!;
}