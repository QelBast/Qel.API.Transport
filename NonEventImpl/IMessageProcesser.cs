namespace Qel.Api.Transport;

/// <summary>
/// Логика обработки сообщений в модулях, связанных транспортными технологиями
/// </summary>
/// <typeparam name="T">Тип контента в результирующем сообщении</typeparam>
public interface IMessageProcesser<T>
{
    /// <summary>
    /// Обработка полученного сообщения с получением сообщения для последующей отправки / постобработки
    /// </summary>
    /// <param name="message">Обработанное сообщение, готовое к отправке</param>
    /// <returns>Процесс</returns>
    public abstract Task Process(ref BaseMessage<T> message);
}