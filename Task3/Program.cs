class Author{
    public  string Name;
    public int Age;
    public string nationality;
    public Author(){}
    public Author(string name, int age){
        Name = name;
        Age = age;
    }
    public Author(string name, int age, string _nationality){
        Name = name;
        Age = age;
        nationality = _nationality;
    }
    public string GetName(){
        return Name;
    }
    public int GetAge(){
        return Age;
    }
    public string Introduce(){
        return $"My Name is {Name} . I am {Age} years old . I am from {nationality} ";
    }
    public void CelebrateBirthday(){
        return Age + 1;
    }
}