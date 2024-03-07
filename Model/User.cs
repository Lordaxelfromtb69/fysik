using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Model
// Definerer User-klassen, som repræsenterer en bruger i systemet
{
    public class User
{

        // Constructor for at oprette en ny bruger med de angivne egenskaber
        public User(int UserID, String Username, String Email, String Address)
    {
        this.UserID = UserID;
        this.Username = Username;
        this.Email = Email;
        this.Address = Address;

    }
    public int UserID { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
}
}