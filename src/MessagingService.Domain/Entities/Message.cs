namespace MessagingService.Domain.Entities;

public class Message
{
    public Guid Id { get; private set; }
    public Guid? StudentId { get; private set; }
    public string LiveClassId { get; private set; } = null!;
    public Guid? InstructorId { get; private set; }
    public string Text { get; set; } = null!;
    public bool IsQuestion { get; set; }
    public bool IsAnswered { get; set; }
    public List<Like> Likes { get; private set; } = [];
    public string ProfileName { get; private set; } = null!;
    public DateTime CreatedAtUtc { get; private set; } = DateTime.UtcNow;


    private Message() { }

    public static Message Create(Guid senderId, string liveClassId, string text, string profileName, bool isQuestion, bool isInstructor)
    {
        Message message = new()
        {
            Id = Guid.NewGuid(),
            LiveClassId = liveClassId,
            Text = text,
            IsQuestion = !isInstructor && isQuestion,
            ProfileName = profileName,
        };

        if (isInstructor)
        {
            message.InstructorId = senderId;
        } else
        {
            message.StudentId = senderId;
        }

        return message;
    }

}
