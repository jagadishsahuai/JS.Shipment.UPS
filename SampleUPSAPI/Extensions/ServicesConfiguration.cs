using Microsoft.Extensions.DependencyInjection;
using JS.Shipment.UPS.Contract.Service;
using JS.Shipment.UPS.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleUPSAPI.Web.Test.Extensions
{
    public static class ServicesConfiguration
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddTransient<ITrackService, TrackService>();
            services.AddTransient<IShipmentService, ShipmentService>();
            services.AddTransient<IVoidShipmentService, VoidShipmentService>();
            services.AddTransient<ILabelRecoveryService, LabelRecoveryService>();
            services.AddTransient<IPickupService, PickupService>();
        }
    }
}
