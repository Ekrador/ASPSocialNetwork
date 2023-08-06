using WebApplication8.Models.Users;

namespace WebApplication8.ViewModels.Account
{
    public class ChatViewModel
    {
        public User You { get; set; }

        public User To { get; set; }

        public List<Message> History { get; set; }

        public MessageViewModel NewMessage { get; set; }

        public ChatViewModel()
        {
            NewMessage = new MessageViewModel();
        }
    }
}
