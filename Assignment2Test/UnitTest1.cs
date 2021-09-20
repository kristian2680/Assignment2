using System;
using Xunit;
using Assignment2;

namespace Assignment2Test
{
    public class UnitTest1
    {
        [Fact]
        public void testing_toString_method_Student()
        {

            Student student=new Student{GivenName="Hej", 
            SurName="med dig", 
            Id=12, 
            StartDate=new DateTime(year: 2021, month: 9, day: 17, hour: 12, minute: 00, second: 00), 
            EndDate=new DateTime(year: 2022, month: 1, day: 9, hour: 12, minute: 00, second: 00), 
            GraduationDate=new DateTime(year: 2022, month: 1, day: 10, hour: 12, minute: 00, second: 00)};

            var expected = "Name: Hej. Surname: med dig. Id: 12. Status: Dropout. Startdate: 17.09.2021 12.00.00. Enddate: 09.01.2022 12.00.00. Graduationdate: 10.01.2022 12.00.00";
            var actual = student.toString();

            Assert.Equal(expected, actual);
        }

    

        [Fact]
        public void calculateStatus_check_status_DropOut(){
            Student student=new Student{GivenName="Hej", 
            SurName="med dig", 
            Id=12, 
            StartDate=new DateTime(year: 2021, month: 9, day: 17, hour: 12, minute: 00, second: 00), 
            EndDate=new DateTime(year: 2022, month: 1, day: 9, hour: 12, minute: 00, second: 00), 
            GraduationDate=new DateTime(year: 2022, month: 1, day: 10, hour: 12, minute: 00, second: 00)};


            var actual = student.status;
            var expected = Status.Dropout;

            Assert.Equal(expected, actual);
        }

         [Fact]
        public void calculateStatus_check_status_Active(){
            Student student=new Student{GivenName="Hej", 
            SurName="med dig", 
            Id=21, 
            StartDate=new DateTime(year: 2021, month: 9, day: 17, hour: 12, minute: 00, second: 00), 
            EndDate=new DateTime(year: 2023, month: 1, day: 9, hour: 12, minute: 00, second: 00), 
            GraduationDate=new DateTime(year: 2022, month: 1, day: 10, hour: 12, minute: 00, second: 00)};


            var actual = student.status;
            var expected = Status.Active;

            Assert.Equal(expected, actual);
        }

        


    }
}
