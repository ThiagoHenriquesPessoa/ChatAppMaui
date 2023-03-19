using ChatApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp.Services
{
    public class MessageService
    {
        static MessageService _instance;

        public static MessageService Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MessageService();
                }
                return _instance;
            }
        }

        readonly User user1 = new User
        {
            Name = "Alaya Cordova",
            Image = "emojil.png",
            Color = Color.FromArgb("#FFE0EC")
        };
    }
}
