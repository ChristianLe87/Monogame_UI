namespace Showroom
{
    public class WK : IDefault
    {
        public int TileSize { get; } = 16;
        public double FPS { get; } = 60;
        public int CanvasWidth { get; } = (int)AspectRatio_16_9.Width*2;
        public int CanvasHeight { get; } = (int)AspectRatio_16_9.Height*2;
        public string Atlas_Tileset { get; } = "AtlasTileset_PNG";
        public string Atlas_Entities { get; } = "AtlasEntities_PNG";
        public string WindowTitle { get; } = "Showroom";
        public string FontFileName { get; } = "MyFont_130x28_PNG";
        public bool IsFullScreen { get; } = false;
        public bool AllowUserResizing { get; } = false;
        public bool IsMouseVisible { get; } = true;
        public Dictionary<string, string> Maps { get; } = new Dictionary<string, string>()
        {
            { "Zeldamon_1", "MyMap/Zeldamon_1" },
            { "Platformer_1", "MyMap/Platformer_1" },
        };

        public Dictionary<string, IScene> Scenes { get; set; } = new Dictionary<string, IScene>()
        {
            { "Scene_Test", new Scene_Test() },
            { "Scene_Menu", new Scene_Menu() },
            { "Scene_UI", new Scene_UI() },
            { "Scene_Camera", new Scene_Camera() },
            { "Scene_Entities", new Scene_Entities() },
            { "Scene_Tiles", new Scene_Tiles() },
            { "Scene_Zeldamon", new Scene_Zeldamon() },
            { "Scene_Platformer", new Scene_Platformer() },
            
        };
        
        public static class AtlasEntitiesReferences
        {
            public static Rectangle Idle_Up { get; } = new Rectangle(0 * 16, 0 * 16, 16, 16);
            public static Rectangle Idel_Down { get; } = new Rectangle(0 * 16, 1 * 16, 16, 16);
            public static Rectangle Idl_Right { get; } = new Rectangle(0 * 16, 2 * 16, 16, 16);

            public static Rectangle Idle_Left { get; } = new Rectangle(0 * 16, 3 * 16, 16, 16);
            //     public static Rectangle _5 { get; } = new Rectangle(1 * 16, 1 * 16, 16, 16);
            //     public static Rectangle _6 { get; } = new Rectangle(1 * 16, 1 * 16, 16, 16);
            //
            //     public static Rectangle _7 { get; } = new Rectangle(1 * 16, 1 * 16, 16, 16);
            //     public static Rectangle _8 { get; } = new Rectangle(1 * 16, 1 * 16, 16, 16);
            //     public static Rectangle _9 { get; } = new Rectangle(1 * 16, 1 * 16, 16, 16);
        }


    }
}