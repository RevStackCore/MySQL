# RevStackCore.MySQL




# Usage

```cs
var dbContext = new MySQLDbContext(connectionString);
var repository = new MySQLRepository<Continent, int>(dbContext);

var item = new Continent();
item.Code = "NA";
item.ContinentId = 1;
item.CultureId = 7;
item.Name = "North America";

//add
repository.Add(item);

//get all
var all = repository.Get();

//find
var many = repository.Find(c => c.Id != 1);
```
