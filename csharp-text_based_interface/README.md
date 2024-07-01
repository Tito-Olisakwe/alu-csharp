# TEXT BASE INTERFACE

---

Code Allows the Serialization and Deserialization of Verious objects providing a commandline option for creating objects as well. Included is a test solution 
to assess the various edge cases.
---

## WORKING WITH COMMAND LINE
Description of various commands for interfacing with the various objects 

| Commands                  | Description |
|---------------------------|-------------|
| ClassNames                | Print all class names of objects loaded in JSONStorage|
| All                       | Print all objects |
| All \<ClassName>          | Print all objects of the given ClassName|
| Create \<ClassName>       | Create and save a new object of ClassName |
| Show \<ClassName> \<id>   | Print the string representation of the requested object |
| Update \<ClassName> \<id> | Update the properties of the given object |
| Delete \<ClassName> \<id> | Delete the given object from the JSONStorage |
| Exit | Quit the application |



### RUNNING
#### STEPS
- [x] Navigate to InventoryManager
- [x] Run ***dotnet run***


---
## MAJOR CLASSES 

| Class Names  |  Description |
|--------------|--------------|
| BaseClass.cs | The parent class from which Item, Inventory and User class inherit from |
| Item.cs      | Provides the blueprint for Creating Items with Name, Price , Description |
| Inventory.cs | Blueprint for creating an inventory taking item id , User id and Quantity |
| User.cs      | Blueprint for creatign a new User with major argument of name|
| JSONStorage.cs | A singleton class which serializes and deserializes various objects |
| Inventory.cs | Controls Access of various objects through the command line |


---

### TEST
#### STEPS 
- [x] Navigate to InventoryManagement.Test
- [x] Run ***dotnet test***


## Authors

 Nwalahnjie Akumawah ([@ante](https://github.com/Ante-237)) - a.nwalahnjie@alustudent.com
  