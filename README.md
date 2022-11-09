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

Phase(1):
- Create a new project in Visual Studio 2022.
- Right click dependancies and click on nuget manager.
- Download/Add Microsoft.EntityFrameWorkCore package.
- Download/Add Microsoft.EntityFrameWorkCore.SqlServer package.
- Download/Add Microsoft.EntityFrameWorkCore.Tools for migration and database alterations through command line. 

Phase(2):
- Create a new folder under the views folder for your page.
- Right click on views and highligh add and then select folder. Give your folder a name as you like.
- Next create a new view within that new created folder.
- right click the mewly created folder, hightlight add and then select and click view.
- Choose between a created view pre-built by vs studio or create your own. I selected the pre-built view offered by vs studio, 
  give your new view a name. click okay, it will then scafold the new view may take a few seconds. 
- 

Phase(3):
- Cretae a new coller to control the new view you created in the views folder matching the name of the view folder the 
  controller will be controlling.
- On the controllers folder, right click, highligh add, highlioght controller, select controller click.
- Will ask to  create a new empty controller or use a pre-built vs studio template based on your requiremnents trying to acheive. 
- Select empty contoller and give the controller the exact same name as your newly created  folder within the views folder. 
 This has to be exact to have the controller functionality working accordingly to the according folder desired to control. 
- 

Phase(4):
- Update the li tag anchor link in the shared layout-view in the Views folder with the anchor tag link to the page resource. 
- next looking into boot0strap styling of the web content pages using boot-strap 5.1 version located within the wwwroot folder. 
- wwwroot folder/ lib/ bootsrap/ dist/ css/ bootstrap.css to locate and see the version you are using withing the MVC application. 
- visit boot-strap.com to get the specific styling to your leisure usomg the version of boot-strap.
- 

Phase(5):
- Using boot-strap styling the home page. 
- Added dropdown menu desiplaying themulti tab select option using boot-strap. works and responds to the desired controller Anime controller. 
- continue working on stytling. 
- Create a Sql service connection and create a new table, add to databale & insert values.
- Select the folder of your project solution, right click & select Nugetpackage manager. 
- Download the System.Data.SqlClient nuget package from the .NET library. 
- 


Phase(6):
- Create a new model within the models folder. 
- 
