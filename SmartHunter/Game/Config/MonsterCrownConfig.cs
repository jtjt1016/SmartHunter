﻿using SmartHunter.Core;

namespace SmartHunter.Game.Config
{
    public enum CrownPreset
    {
        Standard,
        Alternate
    }

    public class MonsterCrownConfig
    {
        public float Mini = 0.9f;
        public float Silver = 1.15f;
        public float Gold = 1.23f;

        public MonsterCrownConfig()
        {
        }

        public MonsterCrownConfig(CrownPreset crownPreset)
        {
            if (crownPreset == CrownPreset.Standard)
            {
                Mini = 0.9f;
                Silver = 1.15f;
                Gold = 1.23f;
            }
            else if (crownPreset == CrownPreset.Alternate)
            {
                Mini = 0.9f;
                Silver = 1.1f;
                Gold = 1.2f;
            }
            else
            {
                Log.WriteLine($"MonsterCrownConfig: Unhandled CrownPreset {crownPreset.ToString()}");
            }
        }

        public MonsterCrownConfig(float mini, float silver, float gold)
        {
            Mini = mini;
            Silver = silver;
            Gold = gold;
        }
    }
}
