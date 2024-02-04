using Project2.Server.Models;
using Project2.Shared.Domain;
using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Project2.Server.Configurations.Entities;

namespace Project2.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<Cart> Carts { get; set; }
        public DbSet<UserPurchaseHistory> UserPurchaseHistories { get; set; }
    }
}