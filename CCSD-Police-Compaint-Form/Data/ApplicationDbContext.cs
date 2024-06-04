using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CCSD_Police_Compaint_Form.Models;

namespace CCSD_Police_Compaint_Form.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<CCSD_Police_Compaint_Form.Models.Form> Form { get; set; } = default!;
    }
}
