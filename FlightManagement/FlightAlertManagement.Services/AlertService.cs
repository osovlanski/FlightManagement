using FlightAlertManagement.DAL;

namespace FlightAlertManagement.Services;

public class AlertService : IAlertService
{
    private readonly IAlertRepository _alertRepository;

    public AlertService(IAlertRepository alertRepository)
    {
        _alertRepository = alertRepository;
    }

    public IEnumerable<Alert> GetAllAlerts() => _alertRepository.GetAll();

    public Alert GetAlertById(Guid id) => _alertRepository.GetById(id);

    public Alert CreateAlert(Alert alert)
    {
        alert.AlertId = Guid.NewGuid();
        alert.CreatedAt = DateTime.UtcNow;
        alert.UpdatedAt = DateTime.UtcNow;
        _alertRepository.Add(alert);
        return alert;
    }

    public Alert UpdateAlert(Guid id, Alert alert)
    {
        var existing = _alertRepository.GetById(id);
        if (existing == null)
        {
            return null;
        }

        // Update only the necessary fields. This is a simplified example.
        alert.AlertId = id;
        alert.UpdatedAt = DateTime.UtcNow;
        _alertRepository.Update(alert);
        return alert;
    }

    public void DeleteAlert(Guid id)
    {
        _alertRepository.Delete(id);
    }
}