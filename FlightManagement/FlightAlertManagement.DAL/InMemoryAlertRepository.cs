namespace FlightAlertManagement.DAL;

public class InMemoryAlertRepository : IAlertRepository
{
    private readonly List<Alert> _alerts = [];

    public IEnumerable<Alert> GetAll() => _alerts;

    public Alert GetById(Guid id) => _alerts.FirstOrDefault(a => a.AlertId == id);

    public void Add(Alert alert) => _alerts.Add(alert);

    public void Update(Alert alert)
    {
        var existing = _alerts.FirstOrDefault(a => a.AlertId == alert.AlertId);
        if (existing != null)
        {
            _alerts.Remove(existing);
            _alerts.Add(alert);
        }
    }

    public void Delete(Guid id)
    {
        var alert = _alerts.FirstOrDefault(a => a.AlertId == id);
        if (alert != null)
        {
            _alerts.Remove(alert);
        }
    }
}