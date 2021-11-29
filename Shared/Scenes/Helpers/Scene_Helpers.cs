﻿using System;
using System.Collections.Generic;
using ChristianTools.Components;
using ChristianTools.Helpers;
using ChristianTools.UI;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;

namespace Shared
{
    public class Scene_Helpers : IScene
    {
        public GameState gameState { get; private set; }
        public List<IEntity> entities { get; set; }
        public List<IUI> UIs { get; set; }
        public List<SoundEffect> soundEffects { get; }
        public Camera camera { get; private set; }
        public Map map { get; }

        public Scene_Helpers()
        {
            Initialize();
        }
        public void Initialize()
        {
            this.camera = new Camera(Game1.spriteBatch.GraphicsDevice.Viewport);

            this.UIs = new List<IUI>()
            {
                new Button(
                    rectangle: new Rectangle (10, 10, 230, 30),
                    text: "Helpers_InputState",
                    defaultTexture: WK.Texture.Red,
                    mouseOverTexture: WK.Texture.Gray,
                    spriteFont: WK.Font.font_14,
                    tag: "goToHelpers_InputState",
                    OnClickAction: () => Game1.ChangeToScene(WK.Scene.Helpers_InputState),
                    camera
                ),
                new Button(
                    rectangle: new Rectangle (10, 50, 230, 30),
                    text: "Helpers_JsonSerialization",
                    defaultTexture: WK.Texture.Red,
                    mouseOverTexture: WK.Texture.Gray,
                    spriteFont: WK.Font.font_14,
                    tag: "goToHelpers_JsonSerialization",
                    OnClickAction: () => Game1.ChangeToScene(WK.Scene.Helpers_JsonSerialization),
                    camera
                ),
                new Button(
                    rectangle: new Rectangle (0, 470, 230, 30),
                    text: "<- Menu",
                    defaultTexture: WK.Texture.LightGray,
                    mouseOverTexture: WK.Texture.Gray,
                    spriteFont: WK.Font.font_14,
                    tag: "goToMenu",
                    OnClickAction: () => Game1.ChangeToScene(WK.Scene.Menu),
                    camera: camera
                ),
            };
        }

        public void Update(InputState lastInputState, InputState inputState)
        {
            foreach (var ui in UIs)
                ui.Update(lastInputState, inputState);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            foreach (var ui in UIs)
                ui.Draw(spriteBatch);
        }
    }
}