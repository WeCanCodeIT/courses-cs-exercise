# courses-cs-exercise

The Courses project consists of a SQL database of courses and instructor tables with a one-to-many relationship.  It utilizes C#/ASP.NET Core and Entity Framework.  Various CRUD views have been added on the front end.  This project and its branches demonstrate the MVC pattern, repository pattern, EF, forms, and tag helpers.  The initial skeleton project can be found in the master branch.  All subsequent branches add one feature and build off of each other.  The order of branches is listed below, followed by an explanation of the workshops.

## Branch Order
1. master
2. add-model-test
3. repository-pattern
4. add-EF (or 5. add-course-details-view)
5. add-course-details-view (or 4. add-EF)
6. add-instructor-model
7. create-course (or 8. add-instructor-controller)
8. add-instructor-controller (or 7. create-course)
9. course-delete
10. controller-tests
11. add-students
12. add-student-to-course

NOT USED- add-dbContext

## Add Model Test Branch
1. Add Index_Passes_Course_Model_To_View to CourseControllerTests
   * Make pass by adding Course Model and updating CourseController
   * Course model can be empty
   * Reference Courses.Models in CourseController and CourseControllerTests with using statement 
2. Add new CourseTests class
3. Add Course_Constructor_Sets_Name_On_Course_Model
   * Add Name property and constructor to Course model
   * Add parameterless default Course() constructor to satisfy CourseController needs
   * Make pass by setting Name property in constructor
4. Add Course_Constructor_Sets_Id_On_Course_Model
   * Add Id property to Course model constructor
   * Update previous test with Id parameter
   * Make pass by setting Id property in constructor
5. Add Course_Constructor_Sets_Description_On_Course_Model
    * Add Description property to Course model constructor
    * Update previous tests with Description parameter
    * Make pass by setting Description property in constructor
6. Refactor CourseTests and CourseControllerTests
7. Set up Course Index view to use model object and test that it runs

## Repository Pattern Branch

* Repositories are a place to hold your domain ("models") in memory.  
* They provide one place for common retrieval actions, such as GetAll() and GetById()
* IIS -> Controller -> (Repository added here breaks dependency between Controller and EF) -> EF (queries on your tables) -> dB (your tables)

### Repository Workshop Instructions
 1. Add CourseRepository with seed data and list of courses
     * CourseList is a public property of CourseRepository
     * Add 3 Courses to the list in CourseRepository constructor
 2. Modify CourseController to use CourseRepository
     * For now, set model to equal one of the items from the list
 3. Add a generic IRepository with GetAll() and GetById() methods
 4. CourseRepository implements IRepository
     * Add code for GetAll() and GetById() methods
 5. Modify CourseController and Index View to get all courses and show them in the View
 
 ## Add Entity Framework Branch
 1. Add EF Packages through Nuget Package Manager
    * Microsoft.EntityFrameworkCore
    * Microsoft.EntityFrameworkCore.Proxies
    * Microsoft.EntityFrameworkCore.SqlServer
    * Microsoft.EntityFrameworkCore.Tools
 2. Add a UniversityContext which inherits from DbContext
    * add a DbSet for Courses
    * define the connection string in OnConfiguring() method
    * add Seed Data in the OnModelCreating() method
 3. Add service to Startup by using the AddDbContext<>() method for UniversityContext
 4. Add a Migration
 5. In CourseRepo, replace the courseList with UniversityContext
    * inject the db into the CourseRepo constructor
    * change all references in methods from courseList with db
 6. If not already done, inject the CourseRepo into the CourseController and add scoping services
 
 ## Add Course Details View Branch
 1. Add GetById method to CourseController; 
    * (courseRepo will have a red squiggle in new method; add reference from GetAll method into GetById method body tpo show it makes red squiggle go away, than refactor with just using a constructor in the public class;
    * Add controller constructor (references "courseRepo") to make red squiggle go away 
 2. Add Details view inside Views/Course folder; (choose "view", then the template that's not empty, rename to "Details";
    * add top line @model projectnameinlowercase.Models.Course to let our view know to use course model in our Models folder). 
 3. Comment out failing CourseControllerTests;
 4. Implement IRepository by adding : IRepository<yourmodelnameinuppercase>
 5. Change razor syntax in Index and Details views;
 6. Add scoping for DI in Startup file. 
 
 ## Add Instructor Model Branch
 1. Add Instructor model with navigation properties creating 1:many relationshiop to Courses
 2. Add corresponding navigation properties in Course model
 3. Add DbSet to UniversityContext for Instructor model
 4. Add Instructor seed data to both the Instructor DbSet and the Course DbSet (reference to foreign key)
 5. Add a new migration and update database
 6. Add the instructor name to the Course Details view
 
 NOTE: This workshop can be continued by adding a CourseLocation model with a one:one relationship to Course and a Student model with a many:many relationship to Course.
 
 ## Create Course Branch
 
 ## Add Instructor Controller Branch
 
 ## Course Delete Branch
 ## Controller Test Branch
 1. Add NSubtitute dependency and a using statement to the test project
 2. In test constructor, use NSubstitute as a Substitute.For the repository
 3. For tests that use the repository, call the method followed by the NSubstitute Returns() method to return the expected value
 
 ## Add Students Branch
 1. Add Student model
 2. Add StudentCourse model
 3. Add navigation properties to Student, Course, and StudentCourse to establish many to many relationship
 4. Add Student and StudentCourse seed data
 5. Add appropriate migrations and update database
 6. Add unordered list of students to Courses details view
 
 ## Add Students to Course Branch
 1. Add link from Course Details page to add a student for the given course
 2. Add StudentCourseRepository
 3. Add StudentCourseController with dependency injection
 4. Add scoping for dependency injection
 5. Add CreateByCourseId action and views for the StudentCourse model
 6. Add Create HttpPost action for the StudentCourse model
 7. Check if student is already enrolled in course before adding
 
