using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.SceneScript, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class SceneScript : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public ushort? FirstSceneScriptID;
        
        [DBFieldName("CHANGEME")]
        public ushort? NextSceneScriptID;
    }
}
