using Microsoft.EntityFrameworkCore;
using ProAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProAPI.Data
{
    public class DeviceStoreContext: DbContext
    {
        private List<Device> listOfDevices = new List<Device>();
        public DeviceStoreContext()
         
        {

        }
        public void addDevices(List<Device> devices)
        {
            this.listOfDevices.AddRange(devices);
        }

        public List<Device> getDevices()
        {
            return this.listOfDevices;
        }

        public DeviceStoreContext(DbContextOptions<DeviceStoreContext> options)
            :base(options)
        {

        }
        public DbSet<Device> Devices { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("connection string");
            base.OnConfiguring(optionsBuilder);
        }

    }
}
