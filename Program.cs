#region interface
using System.Collections;

public class Student : IHuman, IPlayer // implemantion of multiple interfaces has A ihuman and A iplayer
{

    public string GetClub(string club) => $"Club: {club}";
    public string GetCountry(string country) => $"Country: {country}";
    public string GetJerseyNumber(string jerseyNumber) => $"Jersey Number: {jerseyNumber}";
    public string GetPosition(string position) => $"Position: {position}";
    public string GetTeam(string team) => $"Team: {team}";

    public void Position()
    {
        Console.WriteLine("New Position!");
    }

    double IHuman.GetAge(int age) => age;
    float IHuman.GetHeight(float h) => h;
    string IHuman.GetName(string name) => name;
    float IHuman.GetWeight(float w) => w;
    float IHuman.GetWidth(float width) => width;

    void IHuman.Position()
    {
        Console.WriteLine("Student Position (IHuman)");
    }

    public Student()
    {
    }
}

public interface IHuman
{
    void Position() // can be implemented method in interface class
    {
        Console.WriteLine(" Position Of Good : ");
    }
    double GetAge(int age);
    float GetHeight(float h);
    string GetName(string name);
    float GetWeight(float w);
    float GetWidth(float width);
}

public interface IPlayer
{
    void Position();
    string GetTeam(string team);
    string GetPosition(string position);
    string GetCountry(string country);
    string GetClub(string club);
    string GetJerseyNumber(string jerseyNumber);
}
public class Employee : ICloneable, IComparable
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Position { get; set; }
    public gender gender1 { get; set; }
    public Employee(int id, string name, string address, string phone, string email, string position,
        gender gender1 = gender.female)
    {
        Id = id;
        Name = name;
        Address = address;
        Phone = phone;
        Email = email;
        Position = position;
        this.gender1 = gender1;
    }

    public Employee()
    {
        Id = 0;
        Name = "Unknown";
        Address = "Unknown";
        Phone = "Unknown";
        Email = "Unknown";
        Position = "Unknown";
    }

    public object Clone(object obj)
    {
        Employee emp = new Employee();
        emp.Id = this.Id;
        emp.Name = this.Name;
        emp.Address = this.Address;
        emp.Phone = this.Phone;
        emp.Email = this.Email;
        emp.Position = this.Position;
        emp.gender1 = this.gender1;
        return emp;

    }

    public int CompareTo(object? obj)
    {
        Employee emp = (Employee)obj;
        return this.Id.CompareTo(emp.Id);


    }

    public object Clone()
    {
        throw new NotImplementedException();
    }
    public override string ToString()
        => $"Id: {Id}, Name: {Name}, Address: {Address}, Phone: {Phone}, Email: {Email}, Position : {Position} , gender :{gender1}";

}
#endregion

#region  dictionary_implementation
class question
{
    public int id { get; set; }
    public String body { get; set; }
    public int mark { get; set; }
    public question(int id, string body, int mark = 10)
    {
        this.id = id;
        this.body = body;
        this.mark = mark;

    }
    public override string ToString() => $"Id : {id}, Body : {body}, Mark : {mark}";
}
public class Answer
{
    public int Id { get; set; }
    public string Txt { get; set; }
    public bool Status { get; set; }
    public Answer(int id, string txt, bool status)
    {
        Id = id;
        Txt = txt;
        Status = status;
    }
    public override string ToString() => $"Id : {Id}, Txt : {Txt}, Status : {Status}";
}
#endregion

#region Enum
[Flags]
// for multiple selection of enum value (Search about Big Endian and Little Endian) 
// for multiple selection of enum value (Search about Big Endian and Little Endian)
public enum Days
{
    Saturday,
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday
}
public enum gender
{
    male,
    female
}
public enum previlage // size of enum int is 4 byte
{
    admin = 3,
    user,
    guest
}
#endregion

#region  partial class
partial class dt
{
    // search about partial class
    // import partioal class from another file
    // partial class can be used for multiple inheritance
    // partial class can be used for multiple overloading

    public dt()
    {
        
    }
}
#endregion

class Program
{
    #region Interface
    static void Display(IHuman ihuman)
    {
        Console.WriteLine(ihuman.GetAge(20));
        Console.WriteLine(ihuman.GetHeight(5.5f));
        Console.WriteLine(ihuman.GetName("Rahim"));
        Console.WriteLine(ihuman.GetWeight(60.5f));
        Console.WriteLine(ihuman.GetWidth(5.5f));
        ihuman.Position();
    }
    static void Display(IPlayer iplayer)
    {
        Console.WriteLine(iplayer.GetTeam("Bangladesh"));
        Console.WriteLine(iplayer.GetPosition("Midfielder"));
        Console.WriteLine(iplayer.GetCountry("Bangladesh"));
        Console.WriteLine(iplayer.GetClub("Abahani"));
        Console.WriteLine(iplayer.GetJerseyNumber("10"));
        iplayer.Position();
    }
    #endregion
    static void Main(string[] args)
    {
        #region Interface
        Student student = new Student();
        // notes : 
        // interFace method call => processing for Multiple inheritance
        // Generic method call => processing for Multiple overloading
        // Display(student); // Error => cannot convert from 'Student' to 'IHuman'
        Display((IHuman)student);
        Display((IPlayer)student);
        Display(student as IHuman);
        #endregion

        #region Enum
        Employee employee = new Employee();
        Console.WriteLine(employee.ToString());
        gender gender = new gender();
        Console.WriteLine(gender);

        Days day = Days.Sunday;
        Console.WriteLine(day);
        Console.WriteLine((int)day);
        Console.WriteLine(day);

        previlage p = (previlage)4;
        Console.WriteLine(p.ToString());
        Console.WriteLine((int)p);
        #endregion

        #region forEach
        Console.Clear();
        int[] nummbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        foreach (var item in nummbers)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();

        #endregion

        #region Collection

        #region ArrayList
        // 01 : arraylist
        ArrayList arrayList = new ArrayList();
        arrayList.Add(15);
        arrayList.Add("Rahim");
        arrayList.Add(5.5f);
        arrayList.Add('A');
        arrayList.Add(true);
        arrayList.Add(new Employee(1, "Rahim", "Dhaka", "017", "", "Manager"));
        Console.Clear();
        foreach (var item in arrayList)
        {
            Console.Write(" " + item);
        }
        Console.Clear();
        #endregion

        #region hashset
        // hashset
        HashSet<int> hashSet = new HashSet<int>();
        hashSet.Add(10);
        hashSet.Add(20);
        hashSet.Add(30);
        hashSet.Add(40);
        hashSet.Add(50);
        hashSet.Add(60);
        hashSet.Add(70);
        foreach (var item in hashSet)
        {
            Console.WriteLine(item);
        }
        Console.Clear();
        #endregion

        #region queue
        // queue
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);
        queue.Enqueue(40);
        queue.Enqueue(50);
        queue.Enqueue(60);
        queue.Enqueue(70);
        foreach (var item in queue)
        {
            Console.WriteLine(item);
        }
        Console.Clear();
        #endregion

        #region stack
        // stack
        Stack<int> stack = new Stack<int>();
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);
        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }
        Console.Clear();
        stack.Pop();
        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }
        Console.Clear();

        #endregion

        #endregion

        #region Collection_Generic

        #region List
        // List
        List<int> list = new List<int>();
        list.Add(10);
        list.Add(20);
        list.Add(30);
        list.Add(40);
        list.Add(50);
        list.Add(60);
        list.Add(70);
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
        Console.Clear();
        list.Reverse();
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
        Console.Clear();
        list.AddRange(new int[] { 80, 90, 100 });
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
        Console.Clear();
        list.Remove(100);
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
        Console.Clear();
        list.RemoveAt(0);
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
        Console.Clear();
        list.Sort();
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
        Console.Clear();
        list.Remove(100);
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
        Console.Clear();
        List<Employee> employees = new List<Employee>()
        {
        new Employee(1, "Rahim", "Dhaka", "017", "", "Manager"),
        new Employee(2, "Karim", "Dhaka", "017", "", "Manager"),
        new Employee(3, "Rahim", "Dhaka", "017", "", "Manager"),
        new Employee(4, "Karim", "Dhaka", "017", "", "Manager"),
        new Employee (5, "Rahim", "Dhaka", "017", "", "Manager")
        };
        employees.Add(new Employee(1, "Rahim", "Dhaka", "017", "", "Manager"));
        employees.Add(new Employee(2, "Karim", "Dhaka", "017", "", "Manager"));
        employees.Add(new Employee(3, "Rahim", "Dhaka", "017", "", "Manager"));
        employees.Add(new Employee(4, "Karim", "Dhaka", "017", "", "Manager"));
        employees.Add(new Employee(5, "Rahim", "Dhaka", "017", "", "Manager"));
        employees.Add(new Employee(6, "Karim", "Dhaka", "017", "", "Manager"));
        employees.Add(new Employee(7, "Rahim", "Dhaka", "017", "", "Manager"));
        employees.Add(new Employee(8, "Karim", "Dhaka", "017", "", "Manager"));
        employees.Add(new Employee(9, "Rahim", "Dhaka", "017", "", "Manager"));
        foreach (var item in employees)
        {
            Console.WriteLine(item);
        }
        Console.Clear();
        for (int i = 0; i < employees.Count; i++)
        {
            Console.WriteLine(employees[i]);
        }
        Console.Clear();
        //int x = 5;
        //while (employees.Count > 0)
        //{
        //    Console.WriteLine(employees[x]);
        //    employees.RemoveAt(x);
        //    x--;

        //}
        //do
        //{
        //    Console.WriteLine(employees[x]);
        //    employees.RemoveAt(x);
        //} while (employees.Count > x);
        Console.Clear();
        #endregion

        #region Dictionary
        // Dictionary
        #region normal or const Dictionary
        Dictionary<int, string> dictionary = new Dictionary<int, string>();
        dictionary.Add(1, "Rahim");
        dictionary.Add(2, "Karim");
        dictionary.Add(3, "Rahim");
        dictionary.Add(4, "Karim");
        dictionary.Add(5, "Rahim");
        dictionary.Add(6, "Karim");
        dictionary.Add(7, "Rahim");
        dictionary.Add(8, "Karim");
        dictionary[dictionary.Count + 1] = "Ali";
        foreach (var item in dictionary)
        {
            Console.WriteLine($" key : {item.Key}-- " +
                $" Value : {item.Value}");
        }
        Console.Clear();
        // dictionary[" 1 Ali "]="1"   -- indxer property " nessarcy"
        Dictionary<int, Employee> employees1 = new Dictionary<int, Employee>();
        employees1.Add(1, new Employee(1, "Rahim", "Dhaka", "017", "", "Manager"));
        employees1.Add(2, new Employee(2, "Karim", "Dhaka", "017", "", "Manager"));
        employees1.Add(3, new Employee(3, "Ali", "Dhaka", "017", "", "Manager", gender.female));
        foreach (var item in employees1)
        {
            Console.WriteLine($" key : {item.Key}-- " +
                $" Value : {item.Value}");
        }
        Console.Clear();
        #endregion

        #region implentation of dictionary
        List<Answer> answers = new List<Answer>()
        {
            new Answer(1, "A", true),
            new Answer(2, "B", false),
            new Answer(3, "C", false),
            new Answer(4, "D", false),
            new Answer(5, "E", false),
            new Answer(6, "F", false),
        };
        Dictionary<question, List<Answer>> exam = new Dictionary<question, List<Answer>>();
        exam.Add(new question(1, "What is your name?"), answers);
        exam.Add(new question(2, "What is your age?"), answers);
        exam.Add(new question(3, "What is your address?"), answers);
        exam.Add(new question(4, "What is your phone?"), answers);
        exam.Add(new question(5, "What is your email?"), answers);
        exam.Add(new question(6, "What is your position?"), answers);
        exam.Add(new question(8, "What is your position?"), new List<Answer>
        {
            new Answer(1, "A", true),

        });
        foreach (var item in exam)
        {
            Console.WriteLine(item.Key);
            foreach (var item1 in item.Value)
            {
                Console.WriteLine(item1);
            }
        }
        Console.Clear();
        exam[new question(5, "ok", 10)] = new List<Answer>
        {
            new Answer(1, "A", true),
            new Answer(2, "B", false),
            new Answer(3, "C", false),
            new Answer(4, "D", false),
            new Answer(5, "E", false),
            new Answer(6, "F", false),
        };
       // -- Implent ?  exam.Sort();
        foreach (var item in exam)
        {
            Console.WriteLine(item.Key);
            foreach (var item1 in item.Value)
            {
                Console.WriteLine(item1);
            }
            Console.WriteLine("------------\n");
        }
        #endregion

        #endregion


        #endregion
    }
}
