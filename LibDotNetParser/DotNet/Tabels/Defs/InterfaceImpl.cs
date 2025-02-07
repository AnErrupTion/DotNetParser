﻿using LibDotNetParser.PE;

namespace LibDotNetParser.DotNet.Tabels.Defs;

public class InterfaceImpl : IMetadataTableRow
{
    public uint Class { get; private set; }
    public uint Interface { get; private set; }

    public void Read(MetadataReader reader)
    {
        Class = reader.ReadUInt16();
        Interface = reader.ReadUInt16();
    }
}