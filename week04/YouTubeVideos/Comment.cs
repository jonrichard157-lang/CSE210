using System;

public class Comment
{
    private string _commentName { get; set; }
    private string _commentText { get; set; }

    public Comment (string commentName, string commentText)
    {
        _commentName = commentName;
        _commentText = commentText;
    }

    public string GetCommentDetails()
    {
        return $"{_commentName}: {_commentText}";
    }
}