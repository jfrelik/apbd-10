namespace CodeFirst.Prescriptions.ResponseModels;

public class PatientData
{
    public Patient patient { get; set; }
    public List<Medicament> medicaments { get; set; }
    public DateTime Date { get; set; }
    public DateTime DueDate { get; set; }
}