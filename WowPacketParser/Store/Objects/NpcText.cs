using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [DBTableName("npc_text")]
    public class NpcText : IDataModel
    {
        public float?[] Probabilities;

        public string[] Texts1;

        public string[] Texts2;

        public Language?[] Languages;

        public uint?[][] EmoteDelays;

        public EmoteType?[][] EmoteIds;

        public void ConvertToDBStruct()
        {
            // Seriously...

            Prob0 = Probabilities[0];
            Prob1 = Probabilities[1];
            Prob2 = Probabilities[2];
            Prob3 = Probabilities[3];
            Prob4 = Probabilities[4];
            Prob5 = Probabilities[5];
            Prob6 = Probabilities[6];
            Prob7 = Probabilities[7];

            Lang0 = Languages[0];
            Lang1 = Languages[1];
            Lang2 = Languages[2];
            Lang3 = Languages[3];
            Lang4 = Languages[4];
            Lang5 = Languages[5];
            Lang6 = Languages[6];
            Lang7 = Languages[7];

            Text00 = Texts1[0];
            Text10 = Texts1[1];
            Text20 = Texts1[2];
            Text30 = Texts1[3];
            Text40 = Texts1[4];
            Text50 = Texts1[5];
            Text60 = Texts1[6];
            Text70 = Texts1[7];

            Text01 = Texts2[0];
            Text11 = Texts2[1];
            Text21 = Texts2[2];
            Text31 = Texts2[3];
            Text41 = Texts2[4];
            Text51 = Texts2[5];
            Text61 = Texts2[6];
            Text71 = Texts2[7];

            //Emote0X = new uint?[3];
            //Emote1X = new uint?[3];
            //Emote2X = new uint?[3];
            //Emote3X = new uint?[3];
            //Emote4X = new uint?[3];
            //Emote5X = new uint?[3];
            //Emote6X = new uint?[3];
            //Emote7X = new uint?[3];
            //
            //EmoteDelay0X = new uint?[3];
            //EmoteDelay1X = new uint?[3];
            //EmoteDelay2X = new uint?[3];
            //EmoteDelay3X = new uint?[3];
            //EmoteDelay4X = new uint?[3];
            //EmoteDelay5X = new uint?[3];
            //EmoteDelay6X = new uint?[3];
            //EmoteDelay7X = new uint?[3];

            Emote00 = (uint) EmoteIds[0][0];
            Emote01 = (uint) EmoteIds[0][1];
            Emote02 = (uint) EmoteIds[0][2];
            EmoteDelay00 =     EmoteDelays[0][0];
            EmoteDelay01 =     EmoteDelays[0][1];
            EmoteDelay02 =     EmoteDelays[0][2];
            Emote10 = (uint) EmoteIds[1][0];
            Emote11 = (uint) EmoteIds[1][1];
            Emote12 = (uint) EmoteIds[1][2];
            EmoteDelay10 =     EmoteDelays[1][0];
            EmoteDelay11 =     EmoteDelays[1][1];
            EmoteDelay12 =     EmoteDelays[1][2];
            Emote20 = (uint) EmoteIds[2][0];
            Emote21 = (uint) EmoteIds[2][1];
            Emote22 = (uint) EmoteIds[2][2];
            EmoteDelay20 =     EmoteDelays[2][0];
            EmoteDelay21 =     EmoteDelays[2][1];
            EmoteDelay22 =     EmoteDelays[2][2];
            Emote30 = (uint) EmoteIds[3][0];
            Emote31 = (uint) EmoteIds[3][1];
            Emote32 = (uint) EmoteIds[3][2];
            EmoteDelay30 =     EmoteDelays[3][0];
            EmoteDelay31 =     EmoteDelays[3][1];
            EmoteDelay32 =     EmoteDelays[3][2];
            Emote40 = (uint) EmoteIds[4][0];
            Emote41 = (uint) EmoteIds[4][1];
            Emote42 = (uint) EmoteIds[4][2];
            EmoteDelay40 =     EmoteDelays[4][0];
            EmoteDelay41 =     EmoteDelays[4][1];
            EmoteDelay42 =     EmoteDelays[4][2];
            Emote50 = (uint) EmoteIds[5][0];
            Emote51 = (uint) EmoteIds[5][1];
            Emote52 = (uint) EmoteIds[5][2];
            EmoteDelay50 =     EmoteDelays[5][0];
            EmoteDelay51 =     EmoteDelays[5][1];
            EmoteDelay52 =     EmoteDelays[5][2];
            Emote60 = (uint) EmoteIds[6][0];
            Emote61 = (uint) EmoteIds[6][1];
            Emote62 = (uint) EmoteIds[6][2];
            EmoteDelay60 =     EmoteDelays[6][0];
            EmoteDelay61 =     EmoteDelays[6][1];
            EmoteDelay62 =     EmoteDelays[6][2];
            Emote70 = (uint) EmoteIds[7][0];
            Emote71 = (uint) EmoteIds[7][1];
            Emote72 = (uint) EmoteIds[7][2];
            EmoteDelay70 =     EmoteDelays[7][0];
            EmoteDelay71 =     EmoteDelays[7][1];
            EmoteDelay72 =     EmoteDelays[7][2];
        }

        [DBFieldName("ID", true)]
        public uint? ID;

        [DBFieldName("text0_0")]
        public string Text00;

        [DBFieldName("text0_1")]
        public string Text01;

        [DBFieldName("BroadcastTextID0", false, true)]
        public object BroadcastTextID0;

        [DBFieldName("lang0")]
        public Language? Lang0;

        [DBFieldName("Probability0")]
        public float? Prob0;

        [DBFieldName("EmoteDelay0_0")]
        public uint? EmoteDelay00;

        [DBFieldName("EmoteDelay0_1")]
        public uint? EmoteDelay01;

        [DBFieldName("EmoteDelay0_2")]
        public uint? EmoteDelay02;

        [DBFieldName("Emote0_0")]
        public uint? Emote00;

        [DBFieldName("Emote0_1")]
        public uint? Emote01;

        [DBFieldName("Emote0_2")]
        public uint? Emote02;

        [DBFieldName("text1_0")]
        public string Text10;

        [DBFieldName("text1_1")]
        public string Text11;

        [DBFieldName("BroadcastTextID1", false, true)]
        public object BroadcastTextID1;

        [DBFieldName("lang1")]
        public Language? Lang1;

        [DBFieldName("Probability1")]
        public float? Prob1;

        [DBFieldName("EmoteDelay1_0")]
        public uint? EmoteDelay10;

        [DBFieldName("EmoteDelay1_1")]
        public uint? EmoteDelay11;

        [DBFieldName("EmoteDelay1_2")]
        public uint? EmoteDelay12;

        [DBFieldName("Emote1_0")]
        public uint? Emote10;

        [DBFieldName("Emote1_1")]
        public uint? Emote11;

        [DBFieldName("Emote1_2")]
        public uint? Emote12;

        [DBFieldName("text2_0")]
        public string Text20;

        [DBFieldName("text2_1")]
        public string Text21;

        [DBFieldName("BroadcastTextID2", false, true)]
        public object BroadcastTextID2;

        [DBFieldName("lang2")]
        public Language? Lang2;

        [DBFieldName("Probability2")]
        public float? Prob2;

        [DBFieldName("EmoteDelay2_0")]
        public uint? EmoteDelay20;

        [DBFieldName("EmoteDelay2_1")]
        public uint? EmoteDelay21;

        [DBFieldName("EmoteDelay2_2")]
        public uint? EmoteDelay22;

        [DBFieldName("Emote2_0")]
        public uint? Emote20;

        [DBFieldName("Emote2_1")]
        public uint? Emote21;

        [DBFieldName("Emote2_2")]
        public uint? Emote22;

        [DBFieldName("text3_0")]
        public string Text30;

        [DBFieldName("text3_1")]
        public string Text31;

        [DBFieldName("BroadcastTextID3", false, true)]
        public object BroadcastTextID3;

        [DBFieldName("lang3")]
        public Language? Lang3;

        [DBFieldName("Probability3")]
        public float? Prob3;

        [DBFieldName("EmoteDelay3_0")]
        public uint? EmoteDelay30;

        [DBFieldName("EmoteDelay3_1")]
        public uint? EmoteDelay31;

        [DBFieldName("EmoteDelay3_2")]
        public uint? EmoteDelay32;

        [DBFieldName("Emote3_0")]
        public uint? Emote30;

        [DBFieldName("Emote3_1")]
        public uint? Emote31;

        [DBFieldName("Emote3_2")]
        public uint? Emote32;

        [DBFieldName("text4_0")]
        public string Text40;

        [DBFieldName("text4_1")]
        public string Text41;

        [DBFieldName("BroadcastTextID4", false, true)]
        public object BroadcastTextID4;

        [DBFieldName("lang4")]
        public Language? Lang4;

        [DBFieldName("Probability4")]
        public float? Prob4;

        [DBFieldName("EmoteDelay4_0")]
        public uint? EmoteDelay40;

        [DBFieldName("EmoteDelay4_1")]
        public uint? EmoteDelay41;

        [DBFieldName("EmoteDelay4_2")]
        public uint? EmoteDelay42;

        [DBFieldName("Emote4_0")]
        public uint? Emote40;

        [DBFieldName("Emote4_1")]
        public uint? Emote41;

        [DBFieldName("Emote4_2")]
        public uint? Emote42;

        [DBFieldName("text5_0")]
        public string Text50;

        [DBFieldName("text5_1")]
        public string Text51;

        [DBFieldName("BroadcastTextID5", false, true)]
        public object BroadcastTextID5;

        [DBFieldName("lang5")]
        public Language? Lang5;

        [DBFieldName("Probability5")]
        public float? Prob5;

        [DBFieldName("EmoteDelay5_0")]
        public uint? EmoteDelay50;

        [DBFieldName("EmoteDelay5_1")]
        public uint? EmoteDelay51;

        [DBFieldName("EmoteDelay5_2")]
        public uint? EmoteDelay52;

        [DBFieldName("Emote5_0")]
        public uint? Emote50;

        [DBFieldName("Emote5_1")]
        public uint? Emote51;

        [DBFieldName("Emote5_2")]
        public uint? Emote52;

        [DBFieldName("text6_0")]
        public string Text60;

        [DBFieldName("text6_1")]
        public string Text61;

        [DBFieldName("BroadcastTextID6", false, true)]
        public object BroadcastTextID6;

        [DBFieldName("lang6")]
        public Language? Lang6;

        [DBFieldName("Probability6")]
        public float? Prob6;

        [DBFieldName("EmoteDelay6_0")]
        public uint? EmoteDelay60;

        [DBFieldName("EmoteDelay6_1")]
        public uint? EmoteDelay61;

        [DBFieldName("EmoteDelay6_2")]
        public uint? EmoteDelay62;

        [DBFieldName("Emote6_0")]
        public uint? Emote60;

        [DBFieldName("Emote6_1")]
        public uint? Emote61;

        [DBFieldName("Emote6_2")]
        public uint? Emote62;

        [DBFieldName("text7_0")]
        public string Text70;

        [DBFieldName("text7_1")]
        public string Text71;

        [DBFieldName("BroadcastTextID7", false, true)]
        public object BroadcastTextID7;

        [DBFieldName("lang7")]
        public Language? Lang7;

        [DBFieldName("Probability7")]
        public float? Prob7;

        [DBFieldName("EmoteDelay7_0")]
        public uint? EmoteDelay70;

        [DBFieldName("EmoteDelay7_1")]
        public uint? EmoteDelay71;

        [DBFieldName("EmoteDelay7_2")]
        public uint? EmoteDelay72;

        [DBFieldName("Emote7_0")]
        public uint? Emote70;

        [DBFieldName("Emote7_1")]
        public uint? Emote71;

        [DBFieldName("Emote7_2")]
        public uint? Emote72;

        [DBFieldName("VerifiedBuild")]
        public int? VerifiedBuild = ClientVersion.BuildInt;
    }

    [DBTableName("npc_text")]
    public class NpcTextMop : IDataModel
    {
        public float[] Probabilities;

        public uint[] BroadcastTextId;

        public void ConvertToDBStruct()
        {
            // Seriously...

            Prob0 = Probabilities[0];
            Prob1 = Probabilities[1];
            Prob2 = Probabilities[2];
            Prob3 = Probabilities[3];
            Prob4 = Probabilities[4];
            Prob5 = Probabilities[5];
            Prob6 = Probabilities[6];
            Prob7 = Probabilities[7];

            BroadcastTextId0 = BroadcastTextId[0];
            BroadcastTextId1 = BroadcastTextId[1];
            BroadcastTextId2 = BroadcastTextId[2];
            BroadcastTextId3 = BroadcastTextId[3];
            BroadcastTextId4 = BroadcastTextId[4];
            BroadcastTextId5 = BroadcastTextId[5];
            BroadcastTextId6 = BroadcastTextId[6];
            BroadcastTextId7 = BroadcastTextId[7];
        }

        [DBFieldName("ID", true)]
        public uint? ID;

        [DBFieldName("Probability0")]
        public float? Prob0;

        [DBFieldName("Probability1")]
        public float? Prob1;

        [DBFieldName("Probability2")]
        public float? Prob2;

        [DBFieldName("Probability3")]
        public float? Prob3;

        [DBFieldName("Probability4")]
        public float? Prob4;

        [DBFieldName("Probability5")]
        public float? Prob5;

        [DBFieldName("Probability6")]
        public float? Prob6;

        [DBFieldName("Probability7")]
        public float? Prob7;

        [DBFieldName("BroadcastTextId0")]
        public uint? BroadcastTextId0;

        [DBFieldName("BroadcastTextId1")]
        public uint? BroadcastTextId1;

        [DBFieldName("BroadcastTextId2")]
        public uint? BroadcastTextId2;

        [DBFieldName("BroadcastTextId3")]
        public uint? BroadcastTextId3;

        [DBFieldName("BroadcastTextId4")]
        public uint? BroadcastTextId4;

        [DBFieldName("BroadcastTextId5")]
        public uint? BroadcastTextId5;

        [DBFieldName("BroadcastTextId6")]
        public uint? BroadcastTextId6;

        [DBFieldName("BroadcastTextId7")]
        public uint? BroadcastTextId7;

        [DBFieldName("VerifiedBuild")]
        public int? VerifiedBuild = ClientVersion.BuildInt;
    }
}
