using System.Windows.Forms;

namespace BookAppSolution.Infrastructure
{
    public interface IDialogService
    {
        /// <summary>
        /// Открыть диалоговое окно 
        /// </summary>
        /// <returns>Путь к файлу</returns>
        string OpenFileDialog();
    }

    public class DialogService : IDialogService
    {
        public string OpenFileDialog()
        {
            var openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "C:\\";
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png";
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog.FileName;
            }
            
            return string.Empty;
        }
    }
}
