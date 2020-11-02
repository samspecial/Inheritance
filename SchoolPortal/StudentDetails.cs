namespace SchoolPortal
{
    public class StudentDetails
    {
      public string StudentName{get;}
      public string StudentRegNum{get;}
      double[] StudentScore = new double [3];

      public StudentDetails(string studentName, string studentRegNum, double[] studentScore)
      {
        StudentName = studentName;
        StudentRegNum = studentRegNum;
        StudentScore = studentScore;
      }

      public double CalculateAvrg()
      {
        double sum = 0;
        foreach (var score in StudentScore)
        {
            sum += score;
        }
        return sum / StudentScore.Length;
      }
    }
}