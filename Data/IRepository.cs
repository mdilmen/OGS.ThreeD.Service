using OGS.ThreeD.Service.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGS.ThreeD.Service.Data
{
    public interface IRepository
    {
        EntegrasyonPoliceLog GetLog(int policeHareketId);
    }
}
