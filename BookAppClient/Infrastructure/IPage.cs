namespace BookAppSolution.Infrastructure
{
    /// <summary>
    /// Интерфейс для страниц приложения
    /// </summary>
    /// <remarks>
    /// Нужен для добавления новых страниц в приложении
    /// </remarks>
    public interface IPage
    {
        string Name { get; set; }
    }
}
