﻿using LibDotNetParser.PE;

namespace LibDotNetParser.DotNet.Tabels.Defs;

public class FieldRVA : IMetadataTableRow
{
    public uint RVA { get; private set; }
    public ushort Field { get; private set; }
    public void Read(MetadataReader reader)
    {
        RVA = reader.ReadUInt32();
        Field = reader.ReadUInt16();
    }
}