using Newtonsoft.Json;
using System;

namespace CountryAPI.Models
{
    public class CountryDetails : BaseModel
    {
        public long Population { get; set; }
        public string Capital { get; set; }

    }
}
