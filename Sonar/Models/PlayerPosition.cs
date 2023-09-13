﻿using MessagePack;
using Newtonsoft.Json;
using Sonar.Messages;
using Sonar.Relays;
using System;

namespace Sonar.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    [MessagePackObject]
    [Serializable]
    public sealed class PlayerPosition : GamePosition, ISonarMessage
    {
        public PlayerPosition() { }
        public PlayerPosition(GamePlace p) : base(p) { }
        public PlayerPosition(GamePosition p) : base(p) { }
        public PlayerPosition(PlayerPosition p) : base(p) { }
    }
}
