using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using wgewgwegewgwe.UIBuilder.Core.UIElements;

namespace _project.Scripts
{
    public sealed class ujynhtbgrvrfdcsexa : thygtfrdsd
    {
        [SerializeField] private Image img;


        public async UniTask uyhtgrf(float nhgbfvdcs)
        {
            img.fillAmount = 0;
            float junhbgfvfdcsx = 0f;

            while (junhbgfvfdcsx < nhgbfvdcs)
            {
                junhbgfvfdcsx += Time.deltaTime;
                img.fillAmount = Mathf.Clamp01(junhbgfvfdcsx / nhgbfvdcs);
                await UniTask.Yield();
            }

            img.fillAmount = 1f;
        }
    }
}
