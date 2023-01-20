public static class PlayerStats
{
    public static int level { get; set; } = 0;
    public static int fire_gems { get; set; } = 0;
    public static int water_gems { get; set; } = 0;
    public static int[] fire_gems_per_level { get; set; } = {0, 2, 11, 4, 8, 8, 6, 0, 0, 0};
    public static int[] water_gems_per_level { get; set; } = {0, 3, 11, 5, 8, 8, 6, 0, 0, 0};

    public static void reset_player_stats() {
        fire_gems = 0;
        water_gems = 0;
    }

}