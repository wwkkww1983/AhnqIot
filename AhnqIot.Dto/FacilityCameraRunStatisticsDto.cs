﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;using ProtoBuf;
using ProtoBuf;
namespace AhnqIot.Dto
{
    [ProtoContract]
   public class FacilityCameraRunStatisticsDto:BaseDto
    {
        [ProtoMember(1)]
        public int AllCount { get; set; }
        [ProtoMember(2)]
        public int Day { get; set; }
        [ProtoMember(3)]
        public string FacilityCameraSerialnum { get; set; }
        [ProtoMember(4)]
        public int Month { get; set; }
        [ProtoMember(5)]
        public int OnlineCount { get; set; }
        [ProtoMember(6)]
        public decimal OnlinePercent { get; set; }
        [ProtoMember(7)]
        public int Year { get; set; }
    }
}
