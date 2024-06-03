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
        
        app.MapGet("api/prescriptions/patient/{id:int}", async (IPrescriptionService service, int id) =>
        {
            try
            {
                var result = await service.GetPatientPrescriptions(id);
                return Results.Ok(result);
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