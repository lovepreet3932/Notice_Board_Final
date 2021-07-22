1. Open the Solution in Visual Studio
2. Build the project 
3. Navigate to tools ans select Nuget Package manager -> Package Manager Console (PMC)
4. On the console execute the following command
Update-Database -Context Student_Notice_Board_IdentityContext 


5. On the console execute the following command

   Update-Database -Context Student_Notice_BoardContext 



6. After migration is successful Run the project 

7 if you login as admin  from the following credentials will be able to see the Notices,  
Students  and Notice Views by students
User : admin@notice.com
Password: Pass@1234

8. Also you can login with the following credentials to visit the site as a Student or register as a student 
 Can View the Notice details

 User : jay@gmail.com
Password: Pass@1234

9. When a student views  the  Notice a record will be written to the notice views indicating this student has viewed the notice

10 if you need to create another  admin login with the admin credentials on step 7 above and
Click in "Register Notice admin" to register a new admin 



Thank you 
Lovepreet Singh
