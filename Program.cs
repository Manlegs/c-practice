// initialize variables - graded assignments 
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

int currentAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };    

string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

int[] studentScore = new int [10];
string currentStudentLetterGrade = "";

Console.WriteLine("Student\tExam Score\tOverall\tGrade\tExtra Credit \n");
foreach(string name in studentNames)
{   
    if(name == studentNames[0]) 
        studentScore = sophiaScores;   
    else if(name == "Andrew")
        studentScore = andrewScores;  
    else if(name == "Emma")
        studentScore = emmaScores; 
    else if(name == "Logan")
        studentScore = loganScores;
    else if (name == "Becky")
        studentScore= beckyScores;
    else if (name == "Chris")
        studentScore= chrisScores;
    else if (name == "Eric")
        studentScore= ericScores;
    else if (name == "Gregor")
        studentScore= gregorScores;
      
    int count = 0;
    decimal extraCreditPts = 0;
    decimal extraCreditScore = 0;        
    decimal examScores = 0;
    int gradedAssignments = 0;
    decimal sum = 0;
    foreach(int score in studentScore)
    {  
        gradedAssignments ++;
        if(gradedAssignments <= currentAssignments)
        {
            sum += score;
            examScores = sum;
        }
        else
        {   
            count ++;      //counts number of time this happens for # of extra credit asignments
            sum += score/10;
            extraCreditScore += score;
        }
    }
       
    decimal avgExtraCreditScore = extraCreditScore/count; 
    decimal currentStudentGrade = sum/currentAssignments;
    extraCreditPts = (examScores/currentAssignments)-currentStudentGrade;  

    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";

    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";

    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-";

    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";

    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";

    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";

    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";

    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";

    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";

    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";

    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";

    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";
        
    else
        currentStudentLetterGrade = "F";

    Console.WriteLine($"{name}:\t{examScores/currentAssignments}\t\t " + currentStudentGrade + $"\t{currentStudentLetterGrade}\t{extraCreditScore/count} ({extraCreditPts} pts)");
}  