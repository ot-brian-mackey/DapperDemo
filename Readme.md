#About

- Run the myproc.sql against your DB
- Modify the TestClass.cs with your correct connection string.

- Demo uses Dapper v1.38 added as DLL reference.
I don't know what version of Dapper is running in the production code that we are seeing this problem in.  The reference comes from an internal nuget server where Dapper is a dependency of our internal framework and specified to be >= v1.38.  Looking at the packages folder of the caller Dapper is v1.38.  The framework has package v1.42. 