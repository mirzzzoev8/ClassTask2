class User
{
    public string FirstName;
    public string LastName;
    public string UserName;
    public string PassWord;
    public bool IsLoggedIn;

    public void Login(string userName, string passWord)
    {
        this.UserName = userName;
        this.PassWord = passWord;
        if (userName == passWord)
        System.Console.WriteLine("User logged in successfully");
        else
        {
         System.Console.WriteLine("Your password or username is incorrect.");
        }
    }
    public void Logout(){
        IsLoggedIn = false;
    }
    public string GetFullInfo(){
        return $"{FirstName} {LastName} - {IsLoggedIn = true}";
    }

}