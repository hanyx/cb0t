﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace cb0t
{
    class Room
    {
        public ChannelButton Button { get; set; }
        public FavouritesListItem Credentials { get; set; }
        public RoomPanel Panel { get; set; }
        public IPEndPoint EndPoint { get; set; }
    }
}
