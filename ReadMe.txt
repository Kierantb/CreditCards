Right click database project > publish >  Edit > browse > local and select db
Give database a name
Save profile
Publish

Add connection strings to main project web config:

  <connectionStrings>
    <add name="Database" connectionString="Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CreditCardPreQualificationDB;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"/>
  </connectionStrings>