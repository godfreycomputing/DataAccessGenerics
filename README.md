# DataAccessGenerics

Steps:

make sure you have SQLite-net-pcl nuget installed.

I would create a separate SQLite data access class (optional)

instantiate the ISQliteDataAcces as a new SQliteDataAccess

4 methods available

GetAllData<T> - This loads all data of a specific type into a List<T> for use with Linq.
SaveData<T> - Saves a single of type T
UpdateData<T> - Updates an existing item of type <T>
DeleteData<T> - Deletes an existing item of type <T>
  
Possible Exceptions:
No Elements Found
Index Out Of Range
Constraint
