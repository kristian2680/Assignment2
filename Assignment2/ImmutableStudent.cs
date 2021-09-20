using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Assignment2{
    
    public record ImmutableStudent{
        int Id {get; init;}
        string GivenName {get; init;}
        string SurName {get; init;}
        Status status {get => calculateStatus();}

        DateTime StartDate {get; init;}
        DateTime EndDate {get; init;}
        DateTime GraduationDate {get; init;}
        
        public Status calculateStatus() => 
            Student.calculateStatus(DateTime.Now, 
            new Student{GivenName=GivenName, 
            SurName=SurName, 
            Id=Id, 
            StartDate=StartDate, 
            EndDate=EndDate, 
            GraduationDate=GraduationDate });

        public string toString(){
        var ts = "Name: " + this.GivenName + ". Surname: " + this.SurName + ". Id: " + this.Id + ". Status: " + this.status + ". Startdate: " + this.StartDate + ". Enddate: " + this.EndDate + ". Graduationdate: " + this.GraduationDate;
        return ts;
        }
    }

}