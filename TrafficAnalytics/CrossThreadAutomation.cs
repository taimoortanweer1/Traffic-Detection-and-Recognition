using System;
using System.Windows.Forms;

namespace Helpers
{
    /// <summary>
    /// This class automates cross thread operations.
    /// </summary>
    public static class CrossThreadOperation
    {
        public delegate void Func();
        public delegate TResult Func<TResult>();

        /// <summary>
        /// Invokes a cross-thread operation that doesn’t return a result.
        /// </summary>
        /// <param name="control"></param>
        /// <param name="del"></param>
        public static void Invoke(Control control, Func del)
        {
            if (control == null)
                throw new ArgumentNullException("control");
            if (del == null)
                throw new ArgumentNullException("del");

            // Check if we need to use the controls invoke method to do cross-thread operations.
            if (!control.IsDisposed)
            {
                if (control.InvokeRequired)
                    control.Invoke(del);
                else
                    del();
            }
        }

        public static void BeginInvoke(Control control, Func del)
        {
            if (control == null)
                throw new ArgumentNullException("control");
            if (del == null)
                throw new ArgumentNullException("del");

            // Check if we need to use the controls invoke method to do cross-thread operations.
            if (!control.IsDisposed)
            {
                if (control.InvokeRequired)
                    control.BeginInvoke(del);
                else
                    del();
            }
        }

        /// <summary>
        /// Invokes a cross-thread operation that returns a result.
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="control"></param>
        /// <param name="del"></param>
        /// <returns></returns>
        public static TResult Invoke<TResult>(Control control, Func<TResult> del)
        {
            if (control == null)
                throw new ArgumentNullException("control");
            if (del == null)
                throw new ArgumentNullException("del");

            // Check if we need to use the controls invoke method to do cross-thread operations.
            if (control.InvokeRequired)
                return (TResult)control.Invoke(del);
            return del();
        }
    }

}
