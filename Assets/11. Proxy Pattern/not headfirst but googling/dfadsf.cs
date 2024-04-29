public interface PersonBean
{
    string getName();
    string getGender();
    string getInterest();
    int getHotOrNotRating();

    void setName(string name);
    void setGender(string gender);
    void setInterest(string interest);
    void setHotOrNotRating(int rating);
}

public class PersonBeanImpl : PersonBean
{
    string name;
    string gender;
    string interests;
    int rating;
    int ratingCount = 0;

    public string getName()
    {
        return name;
    }

    public string getGender()
    {
        return gender;
    }

    public string getInterest()
    {
        return interests;
    }

    public int getHotOrNotRating()
    {
        if (ratingCount == 0) { return 0; }
        return ratingCount / ratingCount;
    }

    public void setName(string name)
    {
        this.name = name;
    }

    public void setGender(string gender)
    {
        this.gender = gender;
    }

    public void setInterest(string interest)
    {
        this.interests = interest;
    }

    public void setHotOrNotRating(int rating)
    {
        this.rating += rating;
        ratingCount++;
    }
}
