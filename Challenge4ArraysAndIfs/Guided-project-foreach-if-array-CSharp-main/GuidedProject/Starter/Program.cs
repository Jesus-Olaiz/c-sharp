using System;

// student names
string[] studentNames = ["sophia", "andrew", "emma", "logan",];

// student scores
int[] sophiaScores =  [90, 86, 87, 98, 100];
int[] andrewScores =  [92, 89, 81, 96, 90];
int[] emmaScores =  [90, 85, 87, 98, 68];
int[] loganScores =  [90, 95, 87, 88, 96];

// initialize variables - graded assignments 
int currentAssignments = 5;

int sophiaSum = 0;
int andrewSum = 0;
int emmaSum = 0;
int loganSum = 0;

decimal sophiaScore = 0M;
string sophiaLetterScore = "";

decimal andrewScore = 0M;
string andrewLetterScore = "";

decimal emmaScore = 0M;
string emmaLetterScore = "";

decimal loganScore = 0M;
string loganLetterScore = "";

foreach (string name in studentNames){
    if(name == "sophia")
    {
        foreach(int grade in sophiaScores){
            sophiaSum += grade;
        }
        
        if(sophiaScores.Length > currentAssignments){
            sophiaSum += (sophiaScores.Length - currentAssignments) * 10;
        }

        sophiaScore = (decimal)sophiaSum/currentAssignments;

        Console.WriteLine(sophiaScore);

        if(sophiaScore >= 83){
            sophiaLetterScore = "B";
        }
        else if(sophiaScore >= 87){
            sophiaLetterScore = "B+";
        }
        else if(sophiaScore >= 90){
            sophiaLetterScore = "A-";
        }
        else if(sophiaScore >= 93){
            sophiaLetterScore = "A";
        }
        else if(sophiaScore >= 97){
            sophiaLetterScore = "A+";
        }
        
    }
    else if(name == "andrew")
    {
        foreach(int grade in andrewScores){
            andrewSum += grade;
        }

        if(andrewScores.Length > currentAssignments){
            andrewSum += (andrewScores.Length - currentAssignments) * 10;
        }

        andrewScore = (decimal)andrewSum/currentAssignments;

        if(andrewScore >= 83){
            andrewLetterScore = "B";
        }
        else if(andrewScore >= 87){
            andrewLetterScore = "B+";
        }
        else if(andrewScore >= 90){
            andrewLetterScore = "A-";
        }
        else if(andrewScore >= 93){
            andrewLetterScore = "A";
        }
        else if(andrewScore >= 97){
            andrewLetterScore = "A+";
        }
    }
    else if(name == "emma")
    {
        foreach(int grade in emmaScores){
            emmaSum += grade;
        }

        if(emmaScores.Length > currentAssignments){
            emmaSum += (emmaScores.Length - currentAssignments) * 10;
        }

        emmaScore = (decimal)emmaSum/currentAssignments;

        if(emmaScore >= 83){
            emmaLetterScore = "B";
        }
        else if(emmaScore >= 87){
            emmaLetterScore = "B+";
        }
        else if(emmaScore >= 90){
            emmaLetterScore = "A-";
        }
        else if(emmaScore >= 93){
            emmaLetterScore = "A";
        }
        else if(emmaScore >= 97){
            emmaLetterScore = "A+";
        }
    }
    else if(name == "logan")
    {
        foreach(int grade in loganScores){
            loganSum += grade;
        }

        if(loganScores.Length > currentAssignments){
            loganSum += (loganScores.Length - currentAssignments) * 10;
        }

        loganScore = (decimal)loganSum/currentAssignments;

        if(loganScore >= 83){
            loganLetterScore = "B";
        }
        else if(loganScore >= 87){
            loganLetterScore = "B+";
        }
        else if(loganScore >= 90){
            loganLetterScore = "A-";
        }
        else if(loganScore >= 93){
            loganLetterScore = "A";
        }
        else if(loganScore >= 97){
            loganLetterScore = "A+";
        }
    }
    
}





Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine("Sophia:\t\t" + sophiaScore + $"\t{sophiaLetterScore}");
Console.WriteLine("Andrew:\t\t" + andrewScore + $"\t{andrewLetterScore}");
Console.WriteLine("Emma:\t\t" + emmaScore + $"\t{emmaLetterScore}");
Console.WriteLine("Logan:\t\t" + loganScore + $"\t{loganLetterScore}");

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
