namespace Otvetmailru.Entities.Models;

public class AnswerHasAttachment : BaseEntity
{
    public Guid QuestionId  { get; set; }
    public virtual Question Question { get; set; }
    
    public Guid AnswerId  { get; set; }
    public virtual Answer Answer { get; set; }
    
    public Guid UserId  { get; set; }
    public virtual User User { get; set; } 
    
    public Guid AttachmentsId  { get; set; }
    public virtual Attachments Attachments { get; set; } 
}