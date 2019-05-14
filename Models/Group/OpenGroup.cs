﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Rocker.Chat.RestApiClient.Models.Group
{
    public partial class OpenGroupParam
    {
        [JsonProperty("roomId")]
        public string RoomId { get; set; }
    }

    public partial class OpenGroupResult
    {
        [JsonProperty("success")]
        public bool Success { get; set; }
    }
}