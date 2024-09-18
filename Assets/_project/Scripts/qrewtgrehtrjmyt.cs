using System;
using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using wgewgwegewgwe.UIBuilder.AddOns.Button;

namespace _project.Scripts
{
    public sealed class qrewtgrehtrjmyt : rewgrehtrn
    {
        [SerializeField] private Image circle;
        [SerializeField] private Transform pos0;
        [SerializeField] private Transform pos1;
        [SerializeField] private Color disabledColor;
        [SerializeField] private Color enabledColor;

        public bool IsActive { get; set; } = true;

        public event Action<bool> OnUpdate; 

        protected override void Start()
        {
            base.Start();
            wgwegwegweg += () =>
            {
                IsActive = !IsActive;
                qewghretr();
                OnUpdate?.Invoke(IsActive);
            };
        }

        public void qrewtgrehtrn()
        {
            circle.transform.position = IsActive ? pos1.position : pos0.position;
        }
        
        public void qewghretr()
        {
            if (IsActive) qwegrhetn();
            else rnehsgv();
        }

        private void rnehsgv() => wterhetrn(pos0.position, disabledColor, 0.2f);
        private void qwegrhetn() => wterhetrn(pos1.position, enabledColor, 0.2f);

        private async UniTask wterhetrn(Vector3 ewgwegwegew, Color nernenwegw, float wwgewgewgwe)
        {
            float egweg = 0f;
            Vector3 qweghre = circle.transform.position;
            Color hersg = circle.color;

            while (egweg < wwgewgewgwe)
            {
                egweg += Time.deltaTime;
                float t = Mathf.Clamp01(egweg / wwgewgewgwe);

                circle.transform.position = Vector3.Lerp(qweghre, ewgwegwegew, Mathf.SmoothStep(0, 1, t));
                circle.color = Color.Lerp(hersg, nernenwegw, Mathf.SmoothStep(0, 1, t));

                await UniTask.Yield();
            }

            circle.transform.position = ewgwegwegew;
            circle.color = nernenwegw;
        }
    }
}