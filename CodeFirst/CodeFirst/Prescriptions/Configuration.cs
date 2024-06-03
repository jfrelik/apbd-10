using System.Data;
using CodeFirst.Prescriptions.RequestModels;

namespace CodeFirst.Prescriptions;

public static class Configuration
{
    public static void RegisterEndpointsForPrescriptions(this IEndpointRouteBuilder app)
    {
        app.MapPost("api/prescriptions", async (IPrescriptionService service, Prescription request) =>
        {
            try
            {
                await service.AddPrescription(request);
                return Results.Created();
            }
            catch (DataException e)
            {
                return Results.NotFound(e.Message);
            }
            catch (Exception e)
            {
                return Results.Problem(e.Message);
            }
        });
    }

}