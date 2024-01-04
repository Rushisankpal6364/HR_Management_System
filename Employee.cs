namespace EmpMgmt;

class Employee
{
    public int Id { get; set; }
    public String Name { get; set; }
    public int HrsWorked { get; set; }
    public double BasicSal { get; set; }
    public int tax { get; set; }
    public String Dept { get; set; }



    public Employee(int Id, String Name, int HrsWorked, double BasicSal, int tax, String Dept)
    {

        this.Id = Id;
        this.Name = Name;
        this.HrsWorked = HrsWorked;
        this.BasicSal = BasicSal;
        this.tax = tax;
        this.Dept = Dept;
    }

    public double ComputeSal()
    {
        double finalSal;
        int T = this.tax / 100;
        finalSal = this.BasicSal + (this.HrsWorked) - tax;
        return finalSal;
    }

    public override string ToString()
    {
        return this.Id + " " + this.Name + " " + this.HrsWorked + " " + this.BasicSal + " " + this.tax + " " + this.Dept;

    }

}

