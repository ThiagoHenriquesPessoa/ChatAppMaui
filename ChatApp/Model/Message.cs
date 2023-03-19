using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp.Model
{
    public class Message
    {
        public User Sender { get; set; }
        public string Text { get; set; }
        public string Time { get; set; }
    }
}
