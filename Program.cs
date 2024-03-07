using Model;

using (var db = new UserContext())
{
  Console.WriteLine($"Database path: {db.DbPath}.");

    // Create
    Console.WriteLine("Indsæt en ny bruger");

    User user1 = new User(10, "Bruno Bruhn", "Bruno@mail.com", "Viby Torb");
    db.Add(user1);
    db.SaveChanges();
    Console.WriteLine($"User '{user1.Username}' blev oprettet.");

    // Read
    Console.WriteLine("Find den sidste bruger");
    // Opret en ny bruger og tilføj den til databasen
    var lastUser = db.Users
        .OrderByDescending(b => b.UserID)
        .FirstOrDefault();
    Console.WriteLine($"Username: {lastUser?.Username}");
 
    /*
   // Search by UserID
    Console.WriteLine("Søger efter bruger via UserID:");

    // Find en bruger med det angivne UserID
    var userByID = db.Users.FirstOrDefault(u => u.UserID == 3);
    if (userByID != null)
    {
        Console.WriteLine($"User found by UserID: {userByID.Username}");
    }
    else
    {
        Console.WriteLine("User not found by UserID.");
    }
 
    // Search by Username starting with 'A'
    Console.WriteLine("Søger efter brugere, hvis brugernavne starter med 'A':");

    // Find og udskriv alle brugere, hvis brugernavne starter med bogstavet 'A'
    var usersStartingWithA = db.Users.Where(u => u.Username.StartsWith("A")).ToList();
    foreach (var user in usersStartingWithA)
    {
        Console.WriteLine($"User found with username starting with 'A': {user.Username}");
    }
    */
}


// For at søge på bruger via Forbogstav A skal man først udkommentere der andre funktioner, det samme gælder med ID funktionen hvoraf man kun kan bruge en af dem ad gangen.