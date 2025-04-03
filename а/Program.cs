namespace Task_20_05
{
    internal class Program
    {
        /*
     * Напишите программу, имитирующую систему авторизации с использованием перечисления AccessLevel:
        • Guest (только чтение)
        • User (чтение + комментарии)
        • Moderator (удаление контента)
        • Admin (полный доступ)
        Создайте метод, который проверяет, может ли пользователь выполнить действие (например, удалитьпост).На основе уровня доступа выводите сообщение (например,
        "Ошибка: Недостаточно прав!").
     */
        static void Main(string[] args)
        {
            Client guest = new Client(AccessLevel.Guest);
            guest.Read();
            guest.DeleteContent();

            Client user = new Client(AccessLevel.User);
            user.CreateContent();
            user.Read();

            Client moderator = new Client(AccessLevel.Moderator);
            moderator.CreateContent();
            moderator.DeleteContent();

            Client admin = new Client(AccessLevel.Admin);
            admin.Read();
            admin.DeleteContent();
        }
    }
}