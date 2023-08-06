﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WebApplication8.Data.Context;
using WebApplication8.Models.Users;

namespace WebApplication8.Data.Repository
{
    public class MessageRepository : Repository<Message>
    {
        public MessageRepository(ApplicationDbContext db) : base(db)
        {
        }

        public List<Message> GetMessages(User sender, User recipient)
        {
            Set.Include(x => x.Recipient);
            Set.Include(x => x.Sender);

            var from = Set.AsEnumerable().Where(x => x.SenderId == sender.Id && x.RecipientId == recipient.Id).ToList();
            var to = Set.AsEnumerable().Where(x => x.SenderId == recipient.Id && x.RecipientId == sender.Id).ToList();

            var result = new List<Message>();
            result.AddRange(from);
            result.AddRange(to);
            result.OrderBy(x => x.Id);
            return result;
        }

    }
}
