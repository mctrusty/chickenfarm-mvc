using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChickenFarmMVC.Models
{
    public class FarmersViewModel
    {
        IEnumerable<Farmer> Farmers { get; set; }
    }
}