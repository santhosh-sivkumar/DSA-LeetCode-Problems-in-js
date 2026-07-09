using Single_Reponsibility_Principle_Bad;

// ====================== BAD (Violates SRP) ======================
// User.Register() does TWO things: registers the user AND sends a welcome email.
// If email logic changes, you are forced to edit the User class — which has nothing to do with email.
// A class should have only ONE reason to change.

var user = new User
{
    Username = "Santhosh S",
    Email = "santhosh.sivkumar@gmail.com"
};

user.Register();
// ^ This one call does registration AND email sending — two responsibilities in one method.
//   User class now has TWO reasons to change: registration rules OR email logic.