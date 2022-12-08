using Microsoft.EntityFrameworkCore;
using Proto.App.Models;

namespace Proto.App.Context
{
    public class ApppppppppppppppppppppContext : DbContext
    {
        public ApppppppppppppppppppppContext() { }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Test;Trusted_Connection=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>((op) =>
            {
                op.HasKey(x => x.Id);
                op.HasData(new List<User>()
                {
                    new(){
                        Id= 1,
                FirstName = "Dill",
                LastName = "Doe"
            },
                    new(){
                        Id= 2,
                FirstName = "Joe",
                LastName = "Chill"
            },
                    new(){
                        Id= 3,
                FirstName = "Working",
                LastName = "Joe"
            },
                });
            });
        }
    }
}
