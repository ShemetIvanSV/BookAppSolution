using System.Windows;

namespace BookAppSolution.Infrastructure
{
    public interface IErrorMessageBoxService
    {
        /// <summary>
        /// Открыть messagebox
        /// </summary>
        void OpenMessageBox(string message, string caption);
    }

    public class MessageBoxService : IErrorMessageBoxService
    {
        public void OpenMessageBox(string message, string caption)
        {
            MessageBox.Show(message, caption, MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
