
public class ClassRoom
{
    public string chair;
    public string table;
    public string fan;

    //method:A method defines the behavior of the objects that are created from the class
    //method for set
    public void setInstance(string chair, string table, string fan)
    {
        this.chair = chair;
        this.table = table;
        this.fan = fan;
    }

    // method for get

    public void getInstance()
    {
        Console.WriteLine("Chair name is:"+ this.chair);
        Console.WriteLine("Table name is:"+ this.table);
        Console.WriteLine("Fan name is:"+ this.fan);
        Console.ReadLine();
    }

    //main method
    static void Main(string[] args)
    {
        /// Object is Instance of class and it is real world Entity
        ClassRoom room = new ClassRoom();
        room.setInstance("RFL chair", "4 Holding Table", "CellingFan");//here room is object
        room.getInstance();
    }
}
