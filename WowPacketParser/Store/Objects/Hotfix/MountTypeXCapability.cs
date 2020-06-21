using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.MountTypeXCapability, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class MountTypeXCapability : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public ushort? MountTypeID;
        
        [DBFieldName("CHANGEME")]
        public ushort? MountCapabilityID;
        
        [DBFieldName("CHANGEME")]
        public byte? OrderIndex;
    }
}
