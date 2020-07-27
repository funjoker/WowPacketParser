using WowPacketParser.SQL;
using WowPacketParser.Misc;

namespace WowPacketParser.Store.Objects
{
    [DBTableName("creature_trainer")]
    public class CreatureDefaultTrainer : IDataModel
    {
        [DBFieldName("CreatureId", true)]
        public uint? CreatureId;

        [DBFieldName("MenuID", true)]
        public uint? MenuID;

        [DBFieldName("OptionIndex", true)]
        public uint? OptionIndex;

        [DBFieldName("TrainerId")]
        public uint? TrainerId;

        [DBFieldName("VerifiedBuild")]
        public int? VerifiedBuild = ClientVersion.BuildInt;
    }
}
