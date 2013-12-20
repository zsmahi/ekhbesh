using System;

public class Profil
{
    public String login { get; set; }
    public String password { get; set; }
    public Filiere filiere { get; set; }
    public DateTime dateNaissance { get; set; }
    private Programme programme { get; set; }


	public Profil()
	{
        
	}
    
}
