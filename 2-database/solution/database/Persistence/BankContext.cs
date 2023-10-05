#nullable disable

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Persistence
{
    public class BankContext : DbContext
    {

        public DbSet<Account> Customers { get;set; }


    }

    public class Account
    {
        public int Id { get; set; }
        public int CustId { get; set; }
        public double Balance { get; set; } = 0;
    }

}
