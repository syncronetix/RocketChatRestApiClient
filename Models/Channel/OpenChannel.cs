﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Rocker.Chat.RestApiClient.Models.Channel
{
    public partial class OpenChannelParam
    {
        [JsonProperty("roomId")]
        public string RoomId { get; set; }
    }

    public partial class OpenChannelResult
    {
        [JsonProperty("success")]
        public bool Success { get; set; }
    }
}