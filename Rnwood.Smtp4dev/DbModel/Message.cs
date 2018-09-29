﻿using System;

namespace Rnwood.Smtp4dev.DbModel
{
    public class Message
    {
        public Guid Id { get; set; }

        public string From { get; set; }
        public string To { get; set; }
        public DateTime ReceivedDate { get; set; }

        public string Subject { get; set; }

        public byte[] Data { get; set; }

        public string MimeParseError { get; set; }
    }
}