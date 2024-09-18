using System;
using UnityEngine;
using wgewgwegewgwe.UIBuilder.Core;


// using UnityEngine;


namespace wgewgwegewgwe.UIBuilder.Config
{

    [Serializable]
    public class ewrtrnerbrbreb
    {
        public int ewegwegweg = -1;
        public CameraClearFlags ewgwegwegweg = CameraClearFlags.Color;
        public float ewgwegwgwgwg = 10f;
        public bool ewgwegwgweg = true;
        public bool wghwhwegwegwegB = true;


        public void wwfewgwgwegw(Camera camera)
        {
            camera.depth = ewegwegweg;
            camera.clearFlags = ewgwegwegweg;
            camera.orthographic = ewgwegwgweg;
            camera.farClipPlane = ewgwegwgwgwg;
            camera.cullingMask = 1 << qewrfegtrfhng.ewregtrh.Config.wqegrehtrn;
            camera.useOcclusionCulling = wghwhwegwegwegB;
        }
    }
}