using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.SpellItemEnchantmentCondition, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class SpellItemEnchantmentCondition : IDataModel
    {
        [HotfixArray(5)]
        public byte?[] LtOperandType;
        
        [HotfixArray(5)]
        public uint?[] LtOperand;
        
        [HotfixArray(5)]
        public byte?[] Operator;
        
        [HotfixArray(5)]
        public byte?[] RtOperandType;
        
        [HotfixArray(5)]
        public byte?[] RtOperand;
        
        [HotfixArray(5)]
        public byte?[] Logic;
    }
}
