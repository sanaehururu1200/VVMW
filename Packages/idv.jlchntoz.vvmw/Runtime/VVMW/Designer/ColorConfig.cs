﻿using UnityEngine;

namespace JLChnToZ.VRC.VVMW.Designer {
    [EditorOnly]
    [ExecuteInEditMode]
    public class ColorConfig : MonoBehaviour {
        public Color[] colors;

        public void ConfigurateColors() {
            var autoConfigurators = GetComponentsInChildren<AbstractAutoConfigurator>(true);
            foreach (var autoConfigurator in autoConfigurators)
                autoConfigurator.ConfigurateColor();
        }
    }
}