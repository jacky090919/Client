﻿using UnityEngine;

namespace EmuLib.Utils.Camera
{
    internal class Free : FreeCamera
    {
        private void FixedUpdate()
        {
            Transform transform1 = transform;
            var o = EmuInstance.Player.gameObject;
            var position = transform1.position;
            o.transform.position = new Vector3(position.x, position.y - 2f, position.z);
            o.transform.rotation = transform1.rotation;
        }
    }
}