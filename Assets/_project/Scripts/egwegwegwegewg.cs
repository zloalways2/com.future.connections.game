using UnityEngine;
using UnityEngine.EventSystems;

namespace _project.Scripts
{
    public sealed class egwegwegwegewg : MonoBehaviour, IPointerDownHandler, IPointerEnterHandler, IPointerUpHandler
    {
        private int ewgwegwegw;
        private int egwgewgweg;
        private rewgrethrytm egwewgwgweg;

        public void rnerere(int x, int y, rewgrethrytm screen)
        {
            this.egwewgwgweg = screen;
            this.egwgewgweg = y;
            this.ewgwegwegw = x;
        }
        
        public void OnPointerDown(PointerEventData eventData)
        {
            egwewgwgweg.egewgewgewgewg(ewgwegwegw, egwgewgweg);
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            egwewgwgweg.egwegwegwegweg();
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            egwewgwgweg.gwgewgwegwegew(ewgwegwegw, egwgewgweg);
        }
    }
}