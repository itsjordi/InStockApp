using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InStockApp
{
    public interface ICars
    {
        string Kenteken { get; set; }
        int CarID { get; set; }
        int KMStand { get; set; }
    }
}
