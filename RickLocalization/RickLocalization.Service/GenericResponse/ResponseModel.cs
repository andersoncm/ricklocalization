using RickLocalization.Domain.Interfaces.Notification;
using RickLocalization.Domain.Notification;
using System;
using System.Collections.Generic;
using System.Text;

namespace RickLocalization.Service.GenericResponse
{
    public class ResponseModel<T> : Notifiable, IResponse where T : Notifiable, new()
    {
        public ResponseModel()
        {
            Data = new T();
        }
        public bool Success => Valid();
        public string Title { get; set; }
        public int Status { get; set; }
        public T Data { get; set; }
        public IList<INotification> Notifications => GetNotifications();

       
    }
}
