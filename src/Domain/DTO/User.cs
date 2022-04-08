namespace Domain.DTO
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public User()
        {
            
        }
        public User(Model.User user)
        {
            Id = user.Id;
            Name = user.Name;
            Email = user.Email;
            Phone = user.Phone;

        }

        public bool IsValid()
        {
            return !string.IsNullOrEmpty(Name);
        }
    }

}
