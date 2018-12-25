﻿using Ninject.Modules;
using DAL.Interfaces;
using DAL.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Infrastructure
{
    public class ServiceModule : NinjectModule
    {
        private string connectionString;
        public ServiceModule(string connection)
        {
            connectionString = connection;
        }
        public override void Load()
        {
            Bind<IDbRepos>().To<DBReposSQL>().InSingletonScope().WithConstructorArgument(connectionString);
        }
    }
}
