using Modelos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IService
    {

        Task Insert(Media media);
        Task<List<Media>> GetAll();
        Task Update(Media media);
        Task Delete(int id);
    }
}
