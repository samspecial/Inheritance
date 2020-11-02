namespace SchoolPortal
{
    public class ScienceStudent: StudentDetails
    {
      string Department{get;}
      private double computerNetwork;

      public double ComputerNetwork
      {
        set{

        if(value > 0.0)
        {
          ComputerNetwork = value;
        }
      }
      get{return ComputerNetwork}
      }


      public ScienceStudent(string department, string name, string regNum): base(name, regNum)
      {
        Department = department;
        StudentName = name;
        StudentRegNum = regNum;
      }
    }
}