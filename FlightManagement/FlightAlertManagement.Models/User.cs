using System.ComponentModel.DataAnnotations;

public class User
{
    [Key]
    public Guid UserId { get; set; } = Guid.NewGuid();
        
    [Required]
    [EmailAddress]
    public string Email { get; set; }
        
    [Required]
    public string Name { get; set; }
        
    [Required]
    public string PasswordHash { get; set; }
        
    public string PhoneNumber { get; set; }
        
    public List<DeviceToken> DeviceTokens { get; set; } = new List<DeviceToken>();
        
    public UserPreferences Preferences { get; set; } = new UserPreferences();
        
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
}

public class DeviceToken
{
    [Key]
    public Guid DeviceTokenId { get; set; } = Guid.NewGuid();
        
    [Required]
    public string DeviceId { get; set; }
        
    [Required]
    public string Platform { get; set; }
        
    [Required]
    public string Token { get; set; }
        
    public DateTime LastActive { get; set; } = DateTime.UtcNow;
}

public class UserPreferences
{
    [Key]
    public Guid UserPreferencesId { get; set; } = Guid.NewGuid();
        
    public string NotificationFrequency { get; set; } = "immediately";
        
    public bool EmailNotifications { get; set; } = true;
        
    public bool PushNotifications { get; set; } = true;
}