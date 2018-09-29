﻿using System;

namespace Rnwood.Smtp4dev.DbModel
{
    public class Session
    {
        public Guid Id { get; set; }

        public string Log { get; set; }
        public int NumberOfMessages { get; internal set; }
        public string ClientAddress { get; internal set; }
        public string ClientName { get; internal set; }
        public DateTime EndDate { get; internal set; }
    }
}