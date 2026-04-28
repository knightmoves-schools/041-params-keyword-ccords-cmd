namespace knightmoves;

public class Person{
   public string FirstName;
   public string LastName;
   public string[] Hobbies;

   public Person(string firstName, string lastName){
      FirstName = firstName;
      LastName = lastName;

      Hobbies = new string[0];
   }

   public void AddHobbies(params string[] hobbies){
      string[] newHobbies = new string[Hobbies.Length + hobbies.Length];
      Hobbies.CopyTo(newHobbies, 0);
      hobbies.CopyTo(newHobbies, Hobbies.Length);
      Hobbies = newHobbies;
   }
}
