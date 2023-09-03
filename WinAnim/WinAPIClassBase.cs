using System.Runtime.InteropServices;
using System.Windows.Forms;
using static AnimatedWindow.WinAPIClass;

namespace AnimatedWindow
{
    public class WinAPIClassBase
    {
        /// summary
        /// Анимация окна.
        /// </summary>
        /// <param name=name="hwnd">Окно.</param>
        /// <param name="dwTime">Время.</param>
        /// <param name="dwFlags">Тип анимации. Если в 
        /// неуправляемом коде используется перечисление, то его 
        /// нужно конвертировать в тип данных int.
        /// </param>
        /// <returns></returns>
        [DllImportAttribute("user32.dll", EntryPoint = "AnimateWindow", SetLastError = true)]
        public static extern bool AnimateWindow(Control ctrl, int dwTime, AnimateWindowFlags Flags)
        {
            return AnimateWindow(ctrl.Handle, dwTime, Flags);
        }
    }
}