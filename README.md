01. Go to Nuget Package

Install :
1. Entity Framework
2. Relational
3. Design
4. Tools
5. SqlServer

02. Create Domain Class (Example: Model/Customer.cs)

03. Create Application DB Context Class (Example: Model/ApplicationDBContext.cs)

04. Inteherited ApplicationDBContextt class using DBContext Class

05. Override method - OnConfiguration

06. Change the method as below mentioned:
	 protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
 	{
     		optionsBuilder.UseSqlServer("Server=LAPTOP-75O0631G;Database=CodeFirstDB;Integrated Security=true;TrustServerCertificate=true;");
 	}

07. Go to Tools/NuGet Package Manager/Package Manager Console

08. Write Console : add-migration InitialMigrate

09. Write Console : update-database
