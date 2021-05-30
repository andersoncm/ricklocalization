using RickLocalization.Domain.Notification;
using RickLocalization.Domain.Interfaces.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace RickLocalization.Service
{
    public abstract class Validatable : Notifiable, IValidatable
    {
        public abstract void Validate();

    }
}
