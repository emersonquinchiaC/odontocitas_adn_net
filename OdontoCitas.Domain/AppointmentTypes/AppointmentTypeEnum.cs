using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdontoCitas.Domain.AppointmentTypes
{
    public class AppointmentTypeEnum
    {

        public string AppointmentType { get; }

        public double Price { get; }

        public int Duration { get; }

        public AppointmentTypeEnum(string appointmentType)
        {
            if (appointmentType.ToLower().Equals("urgencias")){

                AppointmentType = "urgencias";
                Price = 30000;
                Duration = 60;
            }            
            else if(appointmentType.ToLower().Equals("control")){
                AppointmentType = "control";
                Price = 15000;
                Duration = 30;
            };
        }
    }
}
