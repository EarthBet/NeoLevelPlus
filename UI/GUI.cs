﻿using LevelPlus.Utility;
using Microsoft.Xna.Framework;
using Terraria.UI;

namespace LevelPlus.UI {
    internal class GUI : UIState {
        public static bool visible;
        private XPBar XPBar;
        private Vector2 placement;

        public override void OnInitialize() {
            base.OnInitialize();
            placement = new Vector2(ClientConfig.Instance.xpBarLeft, ClientConfig.Instance.xpBarTop);

            XPBar = new XPBar(120, 26);

            XPBar.Left.Set(placement.X, 0f);
            XPBar.Top.Set(placement.Y, 0f);
            XPBar.SetSnapPoint("origin", 0, placement);

            base.Append(XPBar);
            visible = true;
        }

        public override void OnDeactivate() {
            base.OnDeactivate();
            XPBar = null;
        }
    }
}

