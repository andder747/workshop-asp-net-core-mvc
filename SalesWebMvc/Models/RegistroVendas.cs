using SalesWebMvc.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models
{
    public class RegistroVendas
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public double montante { get; set; }
        public VendaStatus status { get; set; }
        public Vendedor Vendedor { get; set; }


        public RegistroVendas()
        {
        }

        public RegistroVendas(int id, DateTime data, double montante, VendaStatus status, Vendedor vendedor)
        {
            Id = id;
            Data = data;
            this.montante = montante;
            this.status = status;
            Vendedor = vendedor;
        }
    }
}
