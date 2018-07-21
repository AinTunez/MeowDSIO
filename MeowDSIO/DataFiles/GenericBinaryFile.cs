﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeowDSIO.DataFiles
{
    public class GenericBinaryFile : DataFile
    {
        public byte[] Data { get; set; } = null;

        protected override void Read(DSBinaryReader bin, IProgress<(int, int)> prog)
        {
            Data = bin.ReadAllBytes();
        }

        protected override void Write(DSBinaryWriter bin, IProgress<(int, int)> prog)
        {
            if (Data != null)
            {
                bin.Write(Data);
            }
        }

        public static explicit operator GenericBinaryFile(byte[] data)
        {
            return new GenericBinaryFile() { Data = data };
        }

        public static implicit operator byte[](GenericBinaryFile b)
        {
            return b.Data;
        }
    }
}
