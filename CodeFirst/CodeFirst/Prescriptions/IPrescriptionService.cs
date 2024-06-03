using CodeFirst.Prescriptions.RequestModels;

namespace CodeFirst.Prescriptions;

public interface IPrescriptionService
{
    Task AddPrescription(Prescription request);
}