using UnityEngine;

namespace Totobono4.NetworkSceneLoader {
    public class NetworkSceneLoaderCallback : MonoBehaviour {
        private bool isFisrtUpdate = true;

        private void Update() {
            if (!isFisrtUpdate) return;

            isFisrtUpdate = false;
            NetworkSceneLoaderCore.LoaderCallback();
        }
    }
}