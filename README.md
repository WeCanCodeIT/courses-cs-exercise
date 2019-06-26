# courses-cs-exercise

The Courses project consists of a SQL database of courses and instructor tables with a one-to-many relationship.  It utilizes C#/ASP.NET Core and Entity Framework.  Various CRUD views have been added on the front end.  This project and its branches demonstrate the MVC pattern, repository pattern, EF, forms, and tag helpers.  The initial skeleton project can be found in the master branch.  All subsequent branches add one feature and build off of each other.  The order of branches is listed below, followed by an explanation of the workshops.

## Branch Order
1. master
2. add-model-test
3. repository-pattern
4. add-EF
5. add-course-details-view
6. add-instructor-model
7. create-course
8. add-instructor-controller
9. course-delete
10. controller-tests

NOT USED- add-dbContext

## Add Model Test Branch

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
 
 ## Add Course Details View Branch
 
 ## Add Instructor Model Branch
 
 ## Create Course Branch
 
 ## Add Instructor Controller Branch
 
 ## Course Delete Branch
 ## Controller Test Branch
 1. Add NSubtitute dependency and a using statement to the test project
 2. In test constructor, use NSubstitute as a Substitute.For the repository
 3. For tests that use the repository, call the method followed by the NSubstitute Returns() method to return the expected value
 
