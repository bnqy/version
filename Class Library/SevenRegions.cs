namespace Class_Library_Shared_Enum
{
    [System.Flags]
    public enum SevenRegions : byte
    {
        None        = 0b_0000_0000,
        Chui        = 0b_0000_0001,
        Ysyk_Kol    = 0b_0000_0010,
        Naryn       = 0b_0000_0100,
        Talas       = 0b_0000_1000,
        Jalal_Abad  = 0b_0001_0000,
        Osh         = 0b_0010_0000,
        Batken      = 0b_0100_0000,
    }
}
