using RickLocalization.Domain.Notification;
using System;
using System.Collections.Generic;
using System.Text;

namespace RickLocalization.Domain.Interfaces.Notification
{
    public interface INotification
    {
        string Title { get; }
        string Reason { get; }
        ETypeNotification TypeNotification { get; }
    }
}
