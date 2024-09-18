using System;
using UnityEngine;
using wgewgwegewgwe.UIBuilder.AddOns.Button;
using wgewgwegewgwe.UIBuilder.Core;
using wgewgwegewgwe.UIBuilder.Core.UIElements;

namespace _project.Scripts
{
    public sealed class ewgewgwegweg : thygtfrdsd
    {
        [SerializeField] private rewgrehtrn policyButton;
        [SerializeField] private rewgrehtrn playButton;
        [SerializeField] private rewgrehtrn optionsButton;
        [SerializeField] private rewgrehtrn exitButton;
        
        public event Action ewgewgwegew
        {
            add => playButton.wgwegwegweg += value;
            remove => playButton.wgwegwegweg += value;
        }
        
        public event Action egwegwegw
        {
            add => optionsButton.wgwegwegweg += value;
            remove => optionsButton.wgwegwegweg += value;
        }
        
        public event Action ewgwegwegew
        {
            add => exitButton.wgwegwegweg += value;
            remove => exitButton.wgwegwegweg += value;
        }
        
        public event Action OnPolicyButtonEvent
        {
            add => policyButton.wgwegwegweg += value;
            remove => policyButton.wgwegwegweg += value;
        }


        protected override void ewregtrhnht() => qewrfegtrfhng.ewregtrh.ewregthrnhg<BackgroundScreen>().ShowBlur();
    }
}