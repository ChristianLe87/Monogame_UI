using System.Collections.Generic;
using System.IO;
using ChristianTools.Components;
using ChristianTools.Helpers;
using ChristianTools.UI;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Showroom.Scenes
{
    public class Scene_Tiles : IScene
    {
        public List<IEntity> entities { get; set; }
        public List<IUI> UIs { get; set; }
        public Camera camera { get; set; }
        public DxUpdateSystem dxUpdateSystem { get; set; }
        public DxDrawSystem dxDrawSystem { get; set; }

        public void Initialize()
        {
            this.UIs = new List<IUI>()
            {
                // Back to menu
                new Button(rectangle: new Rectangle(10, 400, 100, 50), text: "<-- Back to menu", defaultTexture: null, mouseOverTexture: null, tag: "", OnClickAction: () => Game1.ChangeToScene("Scene_Menu")),
            };
            //string absolutePath = Path.Combine("Content" /*contentManager.RootDirectory*/, $"{tiledMapName}.json");

            Tiled tiled = Tiled.Read_Tiled_JsonSerialization<Tiled>(Path.Combine("MyMap", "MyMap_1"));
            Map map = new Map(tiled);

            this.dxUpdateSystem = (InputState lastInputState, InputState inputState) => ChristianTools.Systems.Update.Scene.UpdateSystem(lastInputState: lastInputState, inputState: inputState);
            this.dxDrawSystem = (SpriteBatch spriteBatch) => ChristianTools.Systems.Draw.Scene.DrawSystem(spriteBatch);
        }
    }
}