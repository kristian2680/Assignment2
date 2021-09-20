using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Assignment2
{
    public enum Status {New, Active, Dropout, Graduated};
    public class Student
    {

        public int Id {get; init;}
        public string GivenName {get; set;}
        public string SurName {get; set;}        
        public Status status {get => calculateStatus(DateTime.Now, this);}
        public DateTime StartDate {get; set;}
        public DateTime EndDate {get; set;}
        public DateTime GraduationDate {get; set;}

        public static Status calculateStatus(DateTime now, Student s){
            if(s.StartDate<s.EndDate && s.StartDate<s.GraduationDate && s.EndDate>=s.GraduationDate){
                if(now < s.StartDate){
                    return Status.New;
                }
                else if(now > s.StartDate){
                    return Status.Active;
                }
            }
            else if (s.EndDate<s.GraduationDate) {
                return Status.Dropout;
            }
            else{
                return Status.Graduated;
            }
            throw new Exception();
        }

        public string toString(){
            var ts = "Name: " + this.GivenName + ". Surname: " + this.SurName + ". Id: " + this.Id + ". Status: " + this.status + ". Startdate: " + this.StartDate + ". Enddate: " + this.EndDate + ". Graduationdate: " + this.GraduationDate;
            return ts;
        }
    }
}