namespace FlightAlertManagement.Services;

public interface IAlertService
{
    IEnumerable<Alert> GetAllAlerts();
    Alert GetAlertById(Guid id);
    Alert CreateAlert(Alert alert);
    Alert UpdateAlert(Guid id, Alert alert);
    void DeleteAlert(Guid id);
}