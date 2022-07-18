using RentalService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalService.UseCases.Rents
{
    public class GetRentsResponse
    {
        public List<Rent> Rents { get; set; }
    }
}
