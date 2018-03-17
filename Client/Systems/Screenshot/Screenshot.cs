﻿using UnityEngine;

namespace LunaClient.Systems.Screenshot
{
    public class Screenshot
    {
        public int Width;
        public int Height;
        public byte[] Data = new byte[0];

        private Texture2D _texture;

        public Texture2D Texture
        {
            get
            {
                if (_texture == null)
                {
                    _texture = new Texture2D(Width, Height);
                    _texture.LoadImage(Data);
                }
                return _texture;
            }
        }
    }
}
