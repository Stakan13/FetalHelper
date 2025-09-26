using FetalHelper.Core.Enums.AnnotationEnums;

namespace FetalHelper.Core.Entities;

public class Annotation
{
    public Guid Id { get; set; }
    public Guid SessionId { get; set; }
    public AnnotationType Type { get; set; }
    public DateTime Time { get; set; }
    public string? Text { get; set; }
    public AnnotationAuthor Author { get; set; }
    
    public Annotation() { }

    private Annotation(Guid id, Guid sessionId, AnnotationType type, DateTime time, string? text,
        AnnotationAuthor author)
    {
        Id = id;
        SessionId = sessionId;
        Type = type;
        Time = time;
        Text = text;
        Author = author;
    }

    public static Annotation Create(Guid sessionId, AnnotationType type, DateTime time, string? text,
        AnnotationAuthor author)
    {
        return new Annotation(Guid.NewGuid(), sessionId, type, time, text, author);
    }
}