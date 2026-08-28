using System;
using System.Collections.Generic;
using System.Text;

namespace OlaMundo.Exercicios.Aula105.Models
{
    internal class Comment(string text)
    {
        private string Text { get; init; } = text;
        private DateTime CommentTime { get; init; } = DateTime.Now;

        public override string ToString()
        {
            return $"\n{Text}\n{CommentTime}";
        }
    }
}
