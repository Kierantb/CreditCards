To set up the data base:

Right click database project > publish >  Edit > browse > local and select db
Give it a name
click Save profile
click Publish

Add connection strings to database in main project web config like so:

  <connectionStrings>
    <add name="Database" connectionString="Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CreditCardPreQualificationDB;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"/>
  </connectionStrings>

Now run the application (CTRL F5) and go to the 'Apply' page
Fill in the details and click submit

Please note:
As the Id of the customer is hard coded the record will need to be deleted to complete more than one set of results