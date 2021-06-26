using RickLocalization.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RickLocalization.Service.Repository
{
   public interface IRickRepository 
    {
       Task<int> Add(Rick rick);
    }
}
