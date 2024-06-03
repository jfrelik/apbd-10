using CodeFirst.Prescriptions.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst.Prescriptions.Context;

public class PrescriptionsContext: DbContext
{
    public PrescriptionContext(DbContextOptions<PrescriptionContext> options) : base(options) { }

    public DbSet<Patient> Patients { get; set; }
    public DbSet<Prescription> Prescriptions { get; set; }
    public DbSet<Medicament> Medicaments { get; set; }
    public DbSet<Doctor> Doctors { get; set; }
}