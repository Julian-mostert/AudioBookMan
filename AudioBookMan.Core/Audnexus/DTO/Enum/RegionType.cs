using System.Runtime.Serialization;

namespace AudioBookMan.Core.Audnexus.DTO.Enum;

public enum RegionType
{
    [EnumMember(Value = @"au")]
    Au = 0,

    [EnumMember(Value = @"ca")]
    Ca = 1,

    [EnumMember(Value = @"de")]
    De = 2,

    [EnumMember(Value = @"es")]
    Es = 3,

    [EnumMember(Value = @"fr")]
    Fr = 4,

    [EnumMember(Value = @"in")]
    In = 5,

    [EnumMember(Value = @"it")]
    It = 6,

    [EnumMember(Value = @"jp")]
    Jp = 7,

    [EnumMember(Value = @"us")]
    Us = 8,

    [EnumMember(Value = @"uk")]
    Uk = 9
}

