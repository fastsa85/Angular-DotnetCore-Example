﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeOrganizerWebApi.Installers
{
    public interface IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration);
    }
}
