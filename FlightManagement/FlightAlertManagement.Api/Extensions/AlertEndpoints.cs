using FlightAlertManagement.Services;

namespace FlightAlertManagement.Api.Extensions;

public static class AlertEndpoints
{
    public static void MapAlertEndpoints(this WebApplication app)
    {
        // GET all alerts
        app.MapGet("/alerts", (IAlertService service) =>
        {
            var alerts = service.GetAllAlerts();
            return Results.Ok(alerts);
        });

        // GET a single alert by id
        app.MapGet("/alerts/{id:guid}", (Guid id, IAlertService service) =>
        {
            var alert = service.GetAlertById(id);
            return alert != null ? Results.Ok(alert) : Results.NotFound();
        });

        // POST a new alert
        app.MapPost("/alerts", (Alert alert, IAlertService service) =>
        {
            var createdAlert = service.CreateAlert(alert);
            return Results.Created($"/alerts/{createdAlert.AlertId}", createdAlert);
        });

        // PUT update an existing alert
        app.MapPut("/alerts/{id:guid}", (Guid id, Alert alert, IAlertService service) =>
        {
            var updatedAlert = service.UpdateAlert(id, alert);
            return updatedAlert != null ? Results.Ok(updatedAlert) : Results.NotFound();
        });

        // DELETE an alert
        app.MapDelete("/alerts/{id:guid}", (Guid id, IAlertService service) =>
        {
            service.DeleteAlert(id);
            return Results.NoContent();
        });
    }
}