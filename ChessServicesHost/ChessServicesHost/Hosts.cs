﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using GamesManagementService;
using AuthenticationService;
using AuthorizationService;
using UserProfileManagementService;
namespace ChessServicesHost
{
    class Hosts
    {
        static void Main(string[] args)
        {
            using (ServiceHost authhost = new ServiceHost(typeof(AuthenticationService.AuthenticationService)))
            {
                authhost.Open();
                Console.WriteLine("Authentication Service Host Started at " + DateTime.Now.ToString());
            }

            using (ServiceHost authorhost = new ServiceHost(typeof(AuthorizationService.AuthorizationService)))
            {
                authorhost.Open();
                Console.WriteLine("Authorization Service Host Started at " + DateTime.Now.ToString());
            }

            using (ServiceHost gmshost = new ServiceHost(typeof(GamesManagementService.GamesManagementService)))
            {
                gmshost.Open();
                Console.WriteLine("Games Management Service Host Started at " + DateTime.Now.ToString());
            }

            using (ServiceHost upmhost = new ServiceHost(typeof(UserProfileManagementService.UserProfileManagementService)))
            {
                upmhost.Open();
                Console.WriteLine("User Profile Management Service Host Started at " + DateTime.Now.ToString());
                Console.ReadLine();
            }
        }
    }
}