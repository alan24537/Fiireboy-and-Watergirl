// A static class used to store the player's stats. 
// This includes: the current level, numbers of fire, water and special gems collected, and the number of gems required to complete each level.

public static class PlayerStats {
    public static int level { get; set; } = 0;
    public static int fire_gems { get; set; } = 0;
    public static int water_gems { get; set; } = 0;
    public static int special_gems { get; set; } = 0;

    // The number of gems required to complete each level (indexed at 1)
    public static int[] fire_gems_per_level { get; set; } = {0, 2, 0, 11, 4, 8, 8, 6, 0, 0, 0, 0};
    public static int[] water_gems_per_level { get; set; } = {0, 3, 0, 11, 5, 8, 8, 6, 0, 0, 0, 0};
    public static int[] special_gems_per_level { get; set; } = {0, 0, 1, 0, 0, 0, 0, 0, 1, 1, 0, 0};

    public static void reset_player_stats() { // Resets the player stats to their default values
        fire_gems = 0;
        water_gems = 0;
        special_gems = 0;
    }
}