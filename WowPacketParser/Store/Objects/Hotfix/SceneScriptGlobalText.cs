using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [HotfixStructure(DB2Hash.SceneScriptGlobalText, HasIndexInData = false)]
    [DBTableName("CHANGEME")]
    public sealed class SceneScriptGlobalText : IDataModel
    {
        [DBFieldName("CHANGEME")]
        public string Name;
        
        [DBFieldName("CHANGEME")]
        public string Script;
    }
}
