using RickLocalization.Domain.Notification;
using System;
using System.Collections.Generic;
using System.Text;

namespace RickLocalization.Domain.Interfaces.Notification
{
    public interface INotifiable
    {
        void AddNotification(string name, string message, ETypeNotification typeNotification = ETypeNotification.Error);
        void AddNotification(INotification notification);
        void AddNotifications(IReadOnlyCollection<INotification> notifications);
        void AddNotifications(IList<INotification> notifications);
        void AddNotifications(ICollection<INotification> notifications);
        void AddNotifications(INotifiable item);
        void AddNotifications(params INotifiable[] items);
        IList<INotification> GetNotifications();

        IList<INotification> GetErrors();
        bool Valid();
    }
}
