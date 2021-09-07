using System;
using System.Collections.Generic;
using System.Text;

namespace Messenger.Models
{
    public class Message
    {
        public string Text { get; set; }
        public string Token { get; set; }

        public Message() { }
        public Message(string text, string token)
        {
            Text = text;
            Token = token;
        }
    }
}
