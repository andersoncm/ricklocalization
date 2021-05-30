
using RickLocalization.Domain.Interfaces.Notification;
using RickLocalization.Domain.Notification;
using System;
using System.Collections.Generic;
using System.Text;

namespace RickLocalization.Service.GenericResponse
{
    public class Response : Notifiable, IResponse
    {
        public bool Success => Valid();
        public string Title { get; set; }
        public int Status { get; set; }
        public object Data { get; set; }
        public IList<INotification> Notifications => GetNotifications();

      
    }
}
