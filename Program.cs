using EmpMgmt;

Employee e = new Employee(111, "Rishi", 9, 30000, 10, "HR");
Console.WriteLine(e);

    int Id;
    String Name;
    int HrsWorked;
    double BasicSal;
    int tax;
    String Dept;


int Choice;
List<Employee> emplist = new List<Employee>();
emplist.Add(e);
do
{
    Console.WriteLine("1. Show All Employee List");
    Console.WriteLine("2. Show Employee Details By id");
    Console.WriteLine("3. Add new Employee To The Company");
    Console.WriteLine("4. Remove Employee From the Company by Id");
    Console.WriteLine("5. Calculate Salary for the Given Employee");
    Console.WriteLine("6. Show All Employees With their Name in the List");
    Console.WriteLine("7. Exit");
    Choice = Convert.ToInt32(Console.ReadLine());

    switch(Choice)
    {
        case 1:

            foreach(Employee emp in emplist)
            {
                Console.WriteLine(emp);
            }
            break;

        case 2:
            Console.WriteLine("Enter Employee Id : ");
            Id = Convert.ToInt32(Console.ReadLine());
            bool flag = false;
            foreach(Employee emp in emplist)
            {
                if (emp.Id ==Id)
                {
                    flag = true;
                    Console.WriteLine(emp);
                    break;

                }
            }
            if (!flag)
            {
                Console.WriteLine("Employee With the Given Id is not found...!");
            }
            break;

        case 3:
            Console.WriteLine("Enter Id : ");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name : ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter HrsWorked : ");
            HrsWorked = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter BasicSal : ");
            BasicSal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter tax : ");
            tax = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Dept : ");
            Dept = Console.ReadLine();
            e = new Employee(Id, Name, HrsWorked, BasicSal, tax, Dept);
            emplist.Add(e);
            Console.WriteLine("Employee Added Successfully...!");

            break;

        case 4:
            Console.WriteLine("Enter EmployeeId : ");
            Id = Convert.ToInt32(Console.ReadLine());
            flag = false;
            foreach(Employee emp in emplist)
            {
                if (emp.Id == Id)
                {
                    flag = true;
                    emplist.Remove(emp);
                    break;
                }
            }
            if (!flag)
            {
                Console.WriteLine("Employee With Give Id is Not Found");
            }
            break;

        case 5:
            foreach (Employee emp in emplist)
            {
                Console.WriteLine(emp.ComputeSal());
            }
           
            break;


        case 6:
            foreach(Employee emp in emplist)
            {
             Console.WriteLine("Employee Name :" + emp.Name + "------>" + "sal :" + emp.ComputeSal());
            }
            break;

        case 7:
            Console.WriteLine("You Choose Exit...!");
            break;

    }


} while (Choice != 7);
