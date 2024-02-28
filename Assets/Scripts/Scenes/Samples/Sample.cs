using UnityEngine;
using UnityEngine.UI;

namespace Scenes.Samples
{
    public class Sample : MonoBehaviour
    {
        [SerializeField] private Button jumpBtn;

        private void Start()
        {
            jumpBtn.onClick.AddListener(() =>
            {
                Debug.Log("Sample Start jumpBtn onClick");
#if UNITY_ANDROID
                Launcher.LaunchBActivity();
#endif
            });
        }
    }
}