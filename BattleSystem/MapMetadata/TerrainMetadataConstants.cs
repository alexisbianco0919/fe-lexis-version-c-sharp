readonly ref struct TerrainGrasslands()
{
    public static string TerrainType { get; } = "Grasslands";
    public static bool CanBeTraversedInfantry { get; } = true;
    public static bool CanBeTraversedArmor { get; } = true;
    public static bool CanBeTraversedHorse { get; } = true;
    public static bool CanBeTraversedFlyer { get; } = true;
    public static int MvGrantedInfantry { get; } = -1;
    public static int MvGrantedArmor { get; } = -1; 
    public static int MvGrantedHorse { get; } = -1;
    public static int MvGrantedFlyer { get; } = -1;
    public static int HpEffectsInfantry { get; } = 0;
    public static int HpEffectsArmor { get; } = 0;
    public static int HpEffectsHorse { get; } = 0;
    public static int HpEffectsFlyer { get; } = 0; 
}