using System;
using System.Collections.Generic;
public class Video
{
    public string Name;
    public string Creator;
    public int Length;
    public List<Comment> Comments;

    public int CommentNumber()
    {
        return Comments.Count;
    }
}