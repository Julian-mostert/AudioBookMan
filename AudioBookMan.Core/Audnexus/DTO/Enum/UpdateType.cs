using System.Runtime.Serialization;

namespace AudioBookMan.Core.Audnexus.DTO.Enum;

public enum UpdateType
{
    [EnumMember(Value = @"Update")]
    Update = 0,

    [EnumMember(Value = @"DontUpdate")]
    DontUpdate = 1
}

public enum SeedAuthorsType
{
    [EnumMember(Value = @"Yes")]
    Yes = 0,

    [EnumMember(Value = @"No")]
    No = 1
}


