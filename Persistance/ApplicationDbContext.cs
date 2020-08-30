using System;
using System.Collections.Generic;
using System.Text;
using Domain.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Persistance
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Establishment> Establishments { get; set; }
        public DbSet<Employee> Employees { get; set; } 
        public DbSet<UserCompany> UserCompanies { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<Form> Forms { get; set; }
        public DbSet<FormField> FormFields { get; set; }
        public DbSet<FieldType> FieldTypes { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<DynamicFormsData> DynamicFormsData { get; set; }
        public DbSet<registreRhHistory> registreRhHistories { get; set; }
        public DbSet<registreRhSetting> registreRhSettings { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Risk> Risks { get; set; }
        public DbSet<WorkUnit> WorkUnits { get; set; }
        public DbSet<WorkUnitMember> WorkUnitMembers { get; set; }
        public DbSet<UniqueDocument> UniqueDocuments { get; set; }
        public DbSet<registreRhColumnSetting> registreRhColumnSettings { get; set; }
        public DbSet<EmployeeDocument> EmployeeDocuments { get; set; }
        public DbSet<Events> Events { get; set; }
        public DbSet<SingleDocument> SingleDocuments { get; set; }
        public DbSet<Subscription> Subscription { get; set; }
        public DbSet<ActionPlan> ActionPlans { get; set; }
        public DbSet<Recommendation> Recommendations { get; set; }
        public DbSet<ExistingMean> ExistingMeans { get; set; }
    }
}
