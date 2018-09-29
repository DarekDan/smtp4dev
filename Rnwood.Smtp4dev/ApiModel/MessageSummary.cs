﻿using System;

namespace Rnwood.Smtp4dev.ApiModel
{
    public class MessageSummary
    {
        public MessageSummary(DbModel.Message dbMessage)
        {
            Id = dbMessage.Id;
            From = dbMessage.From;
            To = dbMessage.To;
            ReceivedDate = dbMessage.ReceivedDate;
            Subject = dbMessage.Subject;
        }

        public Guid Id { get; set; }

        public string From { get; set; }
        public string To { get; set; }
        public DateTime ReceivedDate { get; set; }

        public string Subject { get; set; }
    }
}