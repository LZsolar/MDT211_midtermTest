class Admin{
    private string email;
    private string password;

    public Admin(string email,string pass){
        this.email = email;
        this.password=pass;
    }
    public string getEmail(){
        return this.email;
    }
    public string getPass(){
        return this.password;
    }
}