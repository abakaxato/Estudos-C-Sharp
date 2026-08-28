using System;
using System.Collections.Generic;
using System.Text;

namespace OlaMundo.Exercicios.Aula105.Models
{
    internal class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public int likes { get; set; } = 0;
        private List<Comment> Comments { get; set; } = new List<Comment>() { };
        public List<Comment> AddComment(Comment comment) {
            Comments.Add(comment);
            return Comments;
        }
        public List<Comment> RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
            return Comments;
        }
        public override string ToString()
        {
            if (Comments.Count == 0)
            {
                return $"Moment = {Moment}\nTitle = {Title}\nContent = {Content}\nLikes = {likes}\nNo Comments...";
            }
            else 
            {
                string sumComment = string.Empty;

                foreach (Comment comment in Comments)
                {
                    sumComment = $"{sumComment}\n{comment.ToString()}";
                }
                return $"Moment = {Moment}\nTitle = {Title}\nContent = {Content}\nLikes = {likes}\nComments : {sumComment}";
            }
        }
    }
}
