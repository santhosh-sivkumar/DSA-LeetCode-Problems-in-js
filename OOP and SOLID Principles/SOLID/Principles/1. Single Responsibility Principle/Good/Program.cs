using Single_Responsiblity_Principle_Good;

// ====================== GOOD (Follows SRP) ======================
// User       → only holds data (Username, Email). One reason to change: data structure.
// UserService → only handles registration logic.  One reason to change: registration rules.
// EmailSender → only handles email sending.       One reason to change: email logic.
// Each class does exactly one thing — and has exactly one reason to change.

var user = new User
{
    Username = "Santhosh S",
    Email = "santhosh.sivkumar@gmail.com"
};

UserService userService = new UserService();
userService.Register(user);
// ^ UserService handles registration, then delegates email to EmailSender.
//   If email logic changes — only EmailSender changes. User and UserService are untouched.
//   If registration logic changes — only UserService changes. Email and User are untouched.