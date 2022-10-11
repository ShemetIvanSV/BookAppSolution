using System.ComponentModel;

namespace BookAppSolution.ViewModels
{
    /// <summary>
    /// Базовый класс реализующий INotifyPropertyChanged
    /// </summary>
    /// <remarks>
    /// Может расширяться общей функциональностью всех VM
    /// </remarks>
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
