using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HttpClientBlazorApp.Models
{
    public class DayForecastModel
    {
        public string Weather_state_name { get; set; }
        public string Applicable_date { get; set; }
        public float Min_temp { get; set; }
        public float Max_temp { get; set; }
    }
}
