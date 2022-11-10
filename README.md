# AnimeMangaMVCApp

PURPOSE: 
Create a MVC application using ASP.NET Core MVC model approach.
Create CRUD operations within the MVC application. 
Create Controllers.
Create SQL Server Database connection for table creation and migratiion. 
Create/ Work-on UI.
--------------------------------------------------------------------------------
ADDING VIEWS/CONTROLLERS TO MVC/.NET APPLICATION:
=================================================

Step(1):
- Create a new project in Visual Studio 2022.
- Right click dependancies and click on nuget manager.
- Download/Add Microsoft.EntityFrameWorkCore package.
- Download/Add Microsoft.EntityFrameWorkCore.SqlServer package.
- Download/Add Microsoft.EntityFrameWorkCore.Tools for migration and database alterations through command line. 

Step(2):
- Create a new folder under the views folder for your page.
- Right click on views and highligh add and then select folder. Give your folder a name as you like.
- Next create a new view within that new created folder.
- right click the mewly created folder, hightlight add and then select and click view.
- Choose between a created view pre-built by vs studio or create your own. I selected the pre-built view offered by vs studio, 
  give your new view a name. click okay, it will then scafold the new view may take a few seconds. 
- 

Step(3):
- Cretae a new coller to control the new view you created in the views folder matching the name of the view folder the 
  controller will be controlling.
- On the controllers folder, right click, highligh add, highlioght controller, select controller click.
- Will ask to  create a new empty controller or use a pre-built vs studio template based on your requiremnents trying to acheive. 
- Select empty contoller and give the controller the exact same name as your newly created  folder within the views folder. 
 This has to be exact to have the controller functionality working accordingly to the according folder desired to control. 
- 

Step(4):
- Update the li tag anchor link in the shared layout-view in the Views folder with the anchor tag link to the page resource. 
- next looking into boot0strap styling of the web content pages using boot-strap 5.1 version located within the wwwroot folder. 
- wwwroot folder/ lib/ bootsrap/ dist/ css/ bootstrap.css to locate and see the version you are using withing the MVC application. 
- visit boot-strap.com to get the specific styling to your leisure usomg the version of boot-strap.
- 

Step(5):
- Using boot-strap styling the home page. 
- Added dropdown menu desiplaying themulti tab select option using boot-strap. works and responds to the desired controller Anime controller. 
- continue working on stytling. 
- Create a Sql service connection and create a new table, add to databale & insert values.
- Select the folder of your project solution, right click & select Nugetpackage manager. 
- Download the System.Data.SqlClient nuget package from the .NET library. 
- 


Step(6):
- Create a new folder within the project solution folder, name it what you would like (I chose Data). 
- Download from tools select NugetManager packages into the project Microsoft.EntityFrameworkCore, Microsoft.EntityFrameworkCore.SqlServer, Microsoft.EntityFrameworkCore.Tool.
- Create a new class within the newly created folder naming MVCDemoDbContext.
- In the class constructor make it an instance of the DbContext class.
- Click on the DbContext and them press conbination of CTRL + . & intellisence will open select the package you added EntityFrameworkCore.
- Click on the MVCDemoDbContext & CTRL + . & select the intellisence constructor method with options which will be automatically generated and this helps us pass the options back to the base parent class. 
- Next create a properties are used to access the tables that EntityCore Framework will create within your DataBase Sql Server.
- Within the public slass parent on a new line type prop and press tab button 2x(twice), this will get intellisence to auto generate the public method.
- Then change the Int to DbSet<{which is the model that you create to perform crud operations on}> & the reason is to perform crud operation on a DbData.  


Step(7):
- Create a new folder within the Models folder within your project solution file. Name it what you would like.
- Next create anew class a model in C# is a class. Rigth click the newly created folder select add, select class & give it a namwe doe the model you want to perform crud operations on.
- Back to Models folder AnimeList or what you named it, The Model you created and named select it & create getters and setters for the Table database you will be creating with the table fields.
- Next back to the MVCDemoDbCOntext and add the table name from the Model that your created to the DbSet<your table name here> followed by the table that will be created in the database.
- Next inject the MVCDemoDbContect into the program.cs file or the application will have no idea about the DbContext and what propertyies it takes. 
- Add builder.Services.AddDbContext<MVCDemoDbContext>(options => options.UseSqlServer("this is your connection string to your mssql server"));
- In appsettings.jsopn you can store your connection string and call it into the program.cs file and use it within the builder service previously created. 
- 

