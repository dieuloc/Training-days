<Query Kind="Statements">
  <Connection>
    <ID>5bff0ae1-bdfe-45be-ae66-1beb64ceb5b9</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>.</Server>
    <AllowDateOnlyTimeOnly>true</AllowDateOnlyTimeOnly>
    <DeferDatabasePopulation>true</DeferDatabasePopulation>
    <Database>University</Database>
  </Connection>
</Query>

/*1*/

/*
var resultSet = (from CourseID in Courses select CourseID).Count();
resultSet.Dump();
*/

/*2*/

/*
var resultSet2 = (from ID in Persons select ID).Count();
resultSet2.Dump();
*/

/*3*/

/*
var studentInfo = from p in Persons 
				  join e in Enrollments on 
				  p.ID equals e.StudentID
				  join c in Courses on
				  e.CourseID equals c.CourseID 
				  into studentIn
				  
				  from st in studentIn.DefaultIfEmpty()
				  select new{p.ID, p.FirstName, p.LastName, p.HireDate, p.EnrollmentDate, st.Title};
				  
				  studentInfo.Dump();
*/

/*4*/

/*
var student = Persons.OrderBy(x=>x.FirstName);
student.Dump();
*/

/*5*/

/*
var student = Persons.OrderByDescending(x=>x.LastName);
student.Dump();
*/

var result = Enrollments.Where(x=> x.StudentID == null).Select();
result.Dump();