#Review 1
  
//Avoid using bad names

int d; // elapsed time in days

int elapsedTimeIn Days;




#Review 2
var dataFromDb = db.GetFromService().ToList(); // Get List of employees 

//Service need to be created


var employeeService = new EmployeeService(db);
var employees = employeeService.GetEmployeesFromService().ToList();


#Review 3
  int iCounter;
string strFullName;
DateTime dModifiedDate;



int counter;
string fullName;
DateTime modifiedDate;


#Review 4
  public bool IsShopOpen(string pDay, int pAmount)
{
    // some logic
}

//Old hungarian convention is used

  public bool IsShopOpen(string day, int amount)
{
    // some logic
}


#Review 5

  const int DAYS_IN_WEEK = 7;
const int daysInMonth = 30;

var songs = new List<string> { 'Back In Black', 'Stairway to Heaven', 'Hey Jude' };
var Artists = new List<string> { 'ACDC', 'Led Zeppelin', 'The Beatles' };

bool EraseDatabase() {}
bool Restore_database() {}

class animal {}
class Alpaca {}

One Convention need to be followed

const int DaysInWeek = 7;
const int DaysInMonth = 30;

var songs = new List<string> { "Back In Black", "Stairway to Heaven", "Hey Jude" };
var artists = new List<string> { "ACDC", "Led Zeppelin", "The Beatles" };

bool EraseDatabase() {}
bool RestoreDatabase() {}

class Animal {}
class Alpaca {}


#Review 6
  public class Employee
{
    public Datetime sWorkDate { get; set; } // get set Start Working Date
    public Datetime modTime { get; set; } // get set Modification Time
}

Naming Convention

  public class Employee
{
    public Datetime workDate { get; set; } // get set Start Working Date
    public Datetime modifiedTime { get; set; } // get set Modification Time
}

#Review 7
  var employeephone;

public double CalculateSalary(int workingdays, int workinghours)
{
    // some logic
}

Naming Convention

var employeePhone;

public double CalculateSalary(int workingDays, int workingHours)
{
    // some logic
}


  
