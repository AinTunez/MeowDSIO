﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeowDSIO.DataTypes.TAE.Events
{
    public class Tae000 : TimeActEventBase
    {
        public override IList<object> Parameters
        {
            get => new List<object>
            {
                AnimCancelType,
                UNK1,
                UNK2,
            };
            set
            {
                AnimCancelType = (int)value[0];
                UNK1 = (float)value[1];
                UNK2 = (int)value[2];
            }
        }

        public int AnimCancelType { get; set; } = 0;
        public float UNK1 { get; set; } = 0;
        public int UNK2 { get; set; } = 0;

        public override void ReadParameters(DSBinaryReader bin)
        {
            AnimCancelType = bin.ReadInt32();
            UNK1 = bin.ReadSingle();
            UNK2 = bin.ReadInt32();
        }

        public override void WriteParameters(DSBinaryWriter bin)
        {
            bin.Write(AnimCancelType);
            bin.Write(UNK1);
            bin.Write(UNK2);
        }

        protected override TimeActEventType GetEventType()
        {
            return TimeActEventType.Type0;
        }
    }
}
