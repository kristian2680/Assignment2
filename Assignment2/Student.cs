using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Assignment2Test
{
    public enum Status {New, Active, Dropout, Graduated};
    public class student
    {

        int Id {get; init;}
        string GivenName;
        string SurName;
        
        Status status {get; set;}
        DateTime StartDate;
        DateTime EndDate;
        DateTime GraduationDate;


        public Student (int id, string givenName, string surName, DateTime startDate, DateTime endDate, DateTime graduationDate){
            Id = id;
            GivenName = givenName;
            SurName = surName;
            StartDate = startDate;
            EndDate = endDate;
            GraduationDate = graduationDate;

            if(startDate<endDate && startDate<graduationDate && endDate>=graduationDate){
                if(DateTime.Now < startDate){
                    status = Status.New;
                }
                else if(DateTime.Now > startDate){
                    status = Status.Active;
                }
            }
            else if (endDate<graduationDate) {
                status = Status.Dropout;
            }
            else{
                status = Status.Graduated;
            }


        }

        public string toString(){
            var ts = "Name: " + this.GivenName + " Id: " + this.Id + " Status: " + this.status + " Startdate: " + this.StartDate + " Enddate: " + this.EndDate + " Graduationdate: " + this.GraduationDate;
            Console.WriteLine(ts);
            return ts;
        }


        public static void main (string [] args){
            Student student =  new Student(12, 
            "Hej", 
            "med dig", 
            startdate: new DateTime(year: 2021, month: 9, day: 17),
            endDate: new DateTime(year: 2021, month: 10, day: 21),
            graduationDate: new DateTime(year: 2022, month: 1, day: 10));
        }

    }
}