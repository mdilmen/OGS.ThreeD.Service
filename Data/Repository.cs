
using Microsoft.Extensions.Logging;
using OGS.ThreeD.Service.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGS.ThreeD.Service.Data
{
    public class Repository : IRepository
    {
        private readonly Context _context;
        private readonly ILogger<Repository> _logger;

        public Repository(Context context, ILogger<Repository> logger)
        {
            _context = context;
            _logger = logger;
        }
        public EntegrasyonPoliceLog GetLog(int policeHareketId)
        {
            try
            {
                var hareket = _context.EntegrasyonPoliceHarekets.Where(h => h.EntegrasyonPoliceHareketId == policeHareketId).FirstOrDefault();
                if (hareket != null)
                {
                    var log = _context.EntegrasyonPoliceLogs.Where(l => l.EntegrasyonPoliceLogId == hareket.EntegrasyonPoliceLogId).FirstOrDefault();
                    return log;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                _logger.LogWarning("Could not find any record {msg}", ex.Message);
                return null;
            }   
        }
    }
}
