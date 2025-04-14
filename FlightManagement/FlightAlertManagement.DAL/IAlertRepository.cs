namespace FlightAlertManagement.DAL;

public interface IAlertRepository
{
    IEnumerable<Alert> GetAll();
    Alert GetById(Guid id);
    void Add(Alert alert);
    void Update(Alert alert);
    void Delete(Guid id);
}