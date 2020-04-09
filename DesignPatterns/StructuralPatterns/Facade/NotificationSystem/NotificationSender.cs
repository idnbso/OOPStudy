namespace DesignPatterns.StructuralPatterns.Facade.NotificationSystem
{
    public class NotificationSender
    {
        public static void Run()
        {
            var notificationService = new NotificationService();
            notificationService.Send(message: "Hello World!", target: "PC-D23JHF24");
        }
    }
}
