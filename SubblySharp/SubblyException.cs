﻿using Newtonsoft.Json;
using System;

namespace SubblySharp
{
    public class SubblyException
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("errors")]
        public Errors Errors { get; set; }

        public static explicit operator SystemException(SubblyException v)
        {
            throw new NotImplementedException();
        }
    }

    public class Errors
    {
        [JsonProperty("status")]
        public string[] Status { get; set; }
    }
}
